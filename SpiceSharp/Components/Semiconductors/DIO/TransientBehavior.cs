﻿using System;
using SpiceSharp.Attributes;
using SpiceSharp.Behaviors;
using SpiceSharp.Simulations;
using SpiceSharp.Sparse;
using SpiceSharp.IntegrationMethods;

namespace SpiceSharp.Components.DiodeBehaviors
{
    /// <summary>
    /// Transient behavior for a <see cref="Diode"/>
    /// </summary>
    public class TransientBehavior : Behaviors.TransientBehavior, IConnectedBehavior
    {
        /// <summary>
        /// Necessary behaviors and parameters
        /// </summary>
        LoadBehavior load;
        TemperatureBehavior temp;
        ModelTemperatureBehavior modeltemp;
        BaseParameters bp;
        ModelBaseParameters mbp;

        /// <summary>
        /// Diode capacitance
        /// </summary>
        [PropertyName("cd"), PropertyInfo("Diode capacitance")]
        public double Cap { get; protected set; }
        public double Current { get; protected set; }
        public double Conduct { get; protected set; }

        /// <summary>
        /// The charge on the junction capacitance
        /// </summary>
        public StateDerivative CapCharge { get; private set; }

        /// <summary>
        /// Nodes
        /// </summary>
        int posNode, negNode, posPrimeNode;
        protected MatrixElement PosPosPrimePtr { get; private set; }
        protected MatrixElement NegPosPrimePtr { get; private set; }
        protected MatrixElement PosPrimePosPtr { get; private set; }
        protected MatrixElement PosPrimeNegPtr { get; private set; }
        protected MatrixElement PosPosPtr { get; private set; }
        protected MatrixElement NegNegPtr { get; private set; }
        protected MatrixElement PosPrimePosPrimePtr { get; private set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">Name</param>
        public TransientBehavior(Identifier name) : base(name) { }

        /// <summary>
        /// Setup the behavior
        /// </summary>
        /// <param name="provider">Data provider</param>
        public override void Setup(SetupDataProvider provider)
        {
            if (provider == null)
                throw new ArgumentNullException(nameof(provider));

            // Get parameters
            bp = provider.GetParameterSet<BaseParameters>(0);
            mbp = provider.GetParameterSet<ModelBaseParameters>(1);

            // Get behaviors
            load = provider.GetBehavior<LoadBehavior>(0);
            temp = provider.GetBehavior<TemperatureBehavior>(0);
            modeltemp = provider.GetBehavior<ModelTemperatureBehavior>(1);
        }
        
        /// <summary>
        /// Unsetup the device
        /// </summary>
        public override void Unsetup()
        {
            PosPosPrimePtr = null;
            NegPosPrimePtr = null;
            PosPrimePosPtr = null;
            PosPrimeNegPtr = null;
            PosPosPtr = null;
            NegNegPtr = null;
            PosPrimePosPrimePtr = null;
        }

        /// <summary>
        /// Connect
        /// </summary>
        /// <param name="pins">Pins</param>
        public void Connect(params int[] pins)
        {
            if (pins == null)
                throw new ArgumentNullException(nameof(pins));
            if (pins.Length != 2)
                throw new Diagnostics.CircuitException($"Pin count mismatch: 2 pins expected, {pins.Length} given");
            posNode = pins[0];
            negNode = pins[1];
        }

        /// <summary>
        /// Get matrix pointers
        /// </summary>
        /// <param name="matrix"></param>
        public override void GetMatrixPointers(Matrix matrix)
        {
			if (matrix == null)
				throw new ArgumentNullException(nameof(matrix));

            // Get extra nodes
            posPrimeNode = load.PosPrimeNode;

            // Get matrix pointers
            PosPosPrimePtr = matrix.GetElement(posNode, posPrimeNode);
            NegPosPrimePtr = matrix.GetElement(negNode, posPrimeNode);
            PosPrimePosPtr = matrix.GetElement(posPrimeNode, posNode);
            PosPrimeNegPtr = matrix.GetElement(posPrimeNode, negNode);
            PosPosPtr = matrix.GetElement(posNode, posNode);
            NegNegPtr = matrix.GetElement(negNode, negNode);
            PosPrimePosPrimePtr = matrix.GetElement(posPrimeNode, posPrimeNode);
        }

        /// <summary>
        /// Create states
        /// </summary>
        /// <param name="states">States</param>
        public override void CreateStates(StatePool states)
        {
			if (states == null)
				throw new ArgumentNullException(nameof(states));

            CapCharge = states.Create();
        }

        /// <summary>
        /// Calculate the state values
        /// </summary>
        /// <param name="simulation">Simulation</param>
        public override void GetDCstate(TimeSimulation simulation)
        {
			if (simulation == null)
				throw new ArgumentNullException(nameof(simulation));

            var state = simulation.State;
            double arg, sarg, capd;
            double vd = state.Solution[posPrimeNode] - state.Solution[negNode];

            // charge storage elements
            double czero = temp.TJctCap * bp.Area;
            if (vd < temp.TDepCap)
            {
                arg = 1 - vd / mbp.JunctionPotential;
                sarg = Math.Exp(-mbp.GradingCoefficient * Math.Log(arg));
                CapCharge.Value = mbp.TransitTime * load.Current + mbp.JunctionPotential * czero * (1 - arg * sarg) / (1 -
                        mbp.GradingCoefficient);
                capd = mbp.TransitTime * load.Conduct + czero * sarg;
            }
            else
            {
                double czof2 = czero / modeltemp.F2;
                CapCharge.Value = mbp.TransitTime * load.Current + czero * temp.TF1 + czof2 * (modeltemp.F3 * (vd -
                    temp.TDepCap) + (mbp.GradingCoefficient / (mbp.JunctionPotential + mbp.JunctionPotential)) * (vd * vd - temp.TDepCap * temp.TDepCap));
                capd = mbp.TransitTime * load.Conduct + czof2 * (modeltemp.F3 + mbp.GradingCoefficient * vd / mbp.JunctionPotential);
            }
            Cap = capd;
        }

        /// <summary>
        /// Transient behavior
        /// </summary>
        /// <param name="simulation">Time-based simulation</param>
        public override void Transient(TimeSimulation simulation)
        {
			if (simulation == null)
				throw new ArgumentNullException(nameof(simulation));

            var state = simulation.State;
            double vd = state.Solution[posPrimeNode] - state.Solution[negNode];

            // This is the same calculation
            GetDCstate(simulation);

            // Integrate
            CapCharge.Integrate();
            double geq = CapCharge.Jacobian(Cap);
            double ceq = CapCharge.Current(geq, vd);

            // Load Rhs vector
            state.Rhs[negNode] += ceq;
            state.Rhs[posPrimeNode] -= ceq;

            // Load Y-matrix
            NegNegPtr.Add(geq);
            PosPrimePosPrimePtr.Add(geq);
            NegPosPrimePtr.Sub(geq);
            PosPrimeNegPtr.Sub(geq);
        }

        /// <summary>
        /// Use local truncation error to cut timestep
        /// </summary>
        /// <param name="timestep">Timestep</param>
        public override void Truncate(ref double timestep)
        {
            CapCharge.LocalTruncationError(ref timestep);
        }
    }
}
