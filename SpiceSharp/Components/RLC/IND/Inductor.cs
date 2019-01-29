﻿using SpiceSharp.Attributes;
using SpiceSharp.Behaviors;
using SpiceSharp.Components.InductorBehaviors;

namespace SpiceSharp.Components
{
    /// <summary>
    /// An inductor
    /// </summary>
    [Pin(0, "L+"), Pin(1, "L-")]
    public class Inductor : Component
    {
        static Inductor()
        {
            RegisterBehaviorFactory(typeof(Inductor), new BehaviorFactoryDictionary
            {
                {typeof(BiasingBehavior), name => new BiasingBehavior(name)},
                {typeof(TransientBehavior), name => new TransientBehavior(name)},
                {typeof(FrequencyBehavior), name => new FrequencyBehavior(name)}
            });
        }

        /// <summary>
        /// Constants
        /// </summary>
        [ParameterName("pincount"), ParameterInfo("Number of pins")]
		public const int InductorPinCount = 2;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">The name of the inductor</param>
        public Inductor(string name)
            : base(name, InductorPinCount)
        {
            // Add parameters
            ParameterSets.Add(new BaseParameters());
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">The name of the inductor</param>
        /// <param name="pos">The positive node</param>
        /// <param name="neg">The negative node</param>
        /// <param name="inductance">The inductance</param>
        public Inductor(string name, string pos, string neg, double inductance) 
            : base(name, InductorPinCount)
        {
            // Add parameters
            ParameterSets.Add(new BaseParameters(inductance));

            // Connect
            Connect(pos, neg);
        }
    }
}
