﻿using SpiceSharp.Attributes;
using SpiceSharp.Components.InductorBehaviors;

namespace SpiceSharp.Components
{
    /// <summary>
    /// An inductor
    /// </summary>
    [Pin(0, "L+"), Pin(1, "L-")]
    public class Inductor : Component
    {
        /// <summary>
        /// Nodes
        /// </summary>
        public int PosourceNode { get; internal set; }
        public int NegateNode { get; internal set; }

        /// <summary>
        /// Constants
        /// </summary>
        public const int InductorPinCount = 2;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">The name of the inductor</param>
        public Inductor(Identifier name)
            : base(name, InductorPinCount)
        {
            // Add parameters
            Parameters.Add(new BaseParameters());

            // Add factories
            AddFactory(typeof(LoadBehavior), () => new LoadBehavior(Name));
            AddFactory(typeof(FrequencyBehavior), () => new FrequencyBehavior(Name));
            AddFactory(typeof(TransientBehavior), () => new TransientBehavior(Name));
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">The name of the inductor</param>
        /// <param name="pos">The positive node</param>
        /// <param name="neg">The negative node</param>
        /// <param name="inductance">The inductance</param>
        public Inductor(Identifier name, Identifier pos, Identifier neg, double inductance) 
            : base(name, InductorPinCount)
        {
            // Add parameters
            Parameters.Add(new BaseParameters(inductance));

            // Add factories
            AddFactory(typeof(LoadBehavior), () => new LoadBehavior(Name));
            AddFactory(typeof(FrequencyBehavior), () => new FrequencyBehavior(Name));
            AddFactory(typeof(TransientBehavior), () => new TransientBehavior(Name));

            // Connect
            Connect(pos, neg);
        }

        /// <summary>
        /// Setup the inductor
        /// </summary>
        /// <param name="circuit">The circuit</param>
        public override void Setup(Circuit circuit)
        {
            var nodes = BindNodes(circuit);
            PosourceNode = nodes[0].Index;
            NegateNode = nodes[1].Index;
        }
    }
}
