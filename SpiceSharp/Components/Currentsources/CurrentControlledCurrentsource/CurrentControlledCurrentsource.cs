﻿using SpiceSharp.Circuits;
using SpiceSharp.Parameters;
using SpiceSharp.Diagnostics;

namespace SpiceSharp.Components
{
    /// <summary>
    /// A current-controlled current source
    /// </summary>
    [SpicePins("F+", "F-"), ConnectedPins()]
    public class CurrentControlledCurrentsource : CircuitComponent<CurrentControlledCurrentsource>
    {
        /// <summary>
        /// Register default behaviours
        /// </summary>
        static CurrentControlledCurrentsource()
        {
            Behaviours.Behaviours.RegisterBehaviour(typeof(CurrentControlledCurrentsource), typeof(ComponentBehaviours.CurrentControlledCurrentsourceLoadBehaviour));
            Behaviours.Behaviours.RegisterBehaviour(typeof(CurrentControlledCurrentsource), typeof(ComponentBehaviours.CurrentControlledCurrentsourceAcBehaviour));
        }

        /// <summary>
        /// Parameters
        /// </summary>
        [SpiceName("gain"), SpiceInfo("Gain of the source")]
        public Parameter CCCScoeff { get; } = new Parameter();
        [SpiceName("control"), SpiceInfo("Name of the controlling source")]
        public CircuitIdentifier CCCScontName { get; set; }
        [SpiceName("i"), SpiceInfo("CCCS output current")]
        public double GetCurrent(Circuit ckt) => ckt.State.Real.Solution[CCCScontBranch] * CCCScoeff;
        [SpiceName("v"), SpiceInfo("CCCS voltage at output")]
        public double GetVoltage(Circuit ckt) => ckt.State.Real.Solution[CCCSposNode] - ckt.State.Real.Solution[CCCSnegNode];
        [SpiceName("p"), SpiceInfo("CCCS power")]
        public double GetPower(Circuit ckt) => ckt.State.Real.Solution[CCCScontBranch] * CCCScoeff *
            (ckt.State.Real.Solution[CCCSposNode] - ckt.State.Real.Solution[CCCSnegNode]);

        /// <summary>
        /// Nodes
        /// </summary>
        [SpiceName("pos_node"), SpiceInfo("Positive node of the source")]
        public int CCCSposNode { get; private set; }
        [SpiceName("neg_node"), SpiceInfo("Negative node of the source")]
        public int CCCSnegNode { get; private set; }
        public int CCCScontBranch { get; private set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">The name of the current controlled current source</param>
        public CurrentControlledCurrentsource(CircuitIdentifier name) : base(name)
        {
            // Make sure the current controlled current source happens after voltage sources
            Priority = -1;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">The name of the current controlled current source</param>
        /// <param name="pos">The positive node</param>
        /// <param name="neg">The negative node</param>
        /// <param name="vsource">The name of the voltage source</param>
        /// <param name="gain">The current gain</param>
        public CurrentControlledCurrentsource(CircuitIdentifier name, CircuitIdentifier pos, CircuitIdentifier neg, CircuitIdentifier vsource, double gain) : base(name)
        {
            Priority = -1;
            Connect(pos, neg);
            CCCScoeff.Set(gain);
            CCCScontName = vsource;
        }

        /// <summary>
        /// Setup the current controlled current source
        /// </summary>
        /// <param name="ckt">The circuit</param>
        public override void Setup(Circuit ckt)
        {
            var nodes = BindNodes(ckt);
            CCCSposNode = nodes[0].Index;
            CCCSnegNode = nodes[1].Index;

            // Find the voltage source for which the current is being measured
            if (ckt.Objects[CCCScontName] is Voltagesource vsrc)
                CCCScontBranch = vsrc.VSRCbranch;
            else
                throw new CircuitException($"{Name}: Could not find voltage source '{CCCScontName}'");
        }
    }
}
