﻿using System;
using SpiceSharp.Components.NoiseSources;
using SpiceSharp.Simulations;
using SpiceSharp.Behaviors;

namespace SpiceSharp.Components.MosfetBehaviors.Level1
{
    /// <summary>
    /// Noise behavior for a <see cref="MOS1"/>
    /// </summary>
    public class NoiseBehavior : Behaviors.NoiseBehavior, IConnectedBehavior
    {
        /// <summary>
        /// Necessary behaviors
        /// </summary>
        BaseParameters bp;
        ModelBaseParameters mbp;
        TemperatureBehavior temp;
        LoadBehavior load;
        ModelTemperatureBehavior modeltemp;
        ModelNoiseParameters mnp;

        /// <summary>
        /// Nodes
        /// </summary>
        int dNode, gNode, sNode, bNode, sNodePrime, dNodePrime;

        /// <summary>
        /// Noise generators
        /// </summary>
        public ComponentNoise MOS1Noise { get; } = new ComponentNoise(
            new NoiseThermal("rd", 0, 4),
            new NoiseThermal("rs", 2, 5),
            new NoiseThermal("id", 4, 5),
            new NoiseGain("1overf", 4, 5)
            );
        const int RdNoise = 0;
        const int RsNoise = 1;
        const int IdNoise = 2;
        const int FlickerNoise = 3;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">Name</param>
        public NoiseBehavior(Identifier name) : base(name) { }

        /// <summary>
        /// Setup behavior
        /// </summary>
        /// <param name="provider">Data provider</param>
        public override void Setup(SetupDataProvider provider)
        {
            if (provider == null)
                throw new ArgumentNullException(nameof(provider));

            // Get parameters
            bp = provider.GetParameterSet<BaseParameters>(0);
            mbp = provider.GetParameterSet<ModelBaseParameters>(1);
            mnp = provider.GetParameterSet<ModelNoiseParameters>(1);

            // Get behaviors
            temp = provider.GetBehavior<TemperatureBehavior>(0);
            load = provider.GetBehavior<LoadBehavior>(0);
            modeltemp = provider.GetBehavior<ModelTemperatureBehavior>(1);
        }

        /// <summary>
        /// Connect
        /// </summary>
        /// <param name="pins">Pins</param>
        public void Connect(params int[] pins)
        {
            if (pins == null)
                throw new ArgumentNullException(nameof(pins));
            if (pins.Length != 4)
                throw new Diagnostics.CircuitException($"Pin count mismatch: 4 pins expected, {pins.Length} given");
            dNode = pins[0];
            gNode = pins[1];
            sNode = pins[2];
            bNode = pins[3];
        }

        /// <summary>
        /// Connect the noise sources
        /// </summary>
        public override void ConnectNoise()
        {
            // Get extra equations
            dNodePrime = load.DrainNodePrime;
            sNodePrime = load.SourceNodePrime;

            // Connect noise
            MOS1Noise.Setup(dNode, gNode, sNode, bNode,
                dNodePrime, sNodePrime);
        }

        /// <summary>
        /// Noise calculations
        /// </summary>
        /// <param name="simulation">Noise simulation</param>
        public override void Noise(Noise simulation)
        {
            if (simulation == null)
                throw new ArgumentNullException(nameof(simulation));

            var state = simulation.State;
            var noise = simulation.NoiseState;

            double coxSquared;
            if (modeltemp.OxideCapFactor > 0.0)
                coxSquared = modeltemp.OxideCapFactor;
            else
                coxSquared = 3.9 * 8.854214871e-12 / 1e-7;
            coxSquared *= coxSquared;

            // Set noise parameters
            MOS1Noise.Generators[RdNoise].SetCoefficients(temp.DrainConductance);
            MOS1Noise.Generators[RsNoise].SetCoefficients(temp.SourceConductance);
            MOS1Noise.Generators[IdNoise].SetCoefficients(2.0 / 3.0 * Math.Abs(load.Gm));
            MOS1Noise.Generators[FlickerNoise].SetCoefficients(mnp.FlickerNoiseCoefficient * Math.Exp(mnp.FlickerNoiseExponent * Math.Log(Math.Max(Math.Abs(load.Cd), 1e-38))) 
                / (bp.Width * (bp.Length - 2 * mbp.LatDiff) * coxSquared) / noise.Freq);

            // Evaluate noise sources
            MOS1Noise.Evaluate(simulation);
        }
    }
}
