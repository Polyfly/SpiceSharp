﻿using SpiceSharp.Attributes;
using SpiceSharp.Behaviors;
using SpiceSharp.Components.MosfetBehaviors.Level2;

namespace SpiceSharp.Components
{
    /// <summary>
    /// A MOS2 Mosfet.
    /// Level 2, A. Vladimirescu and S. Liu, The Simulation of MOS Integrated Circuits Using SPICE2, ERL Memo No. M80/7, Electronics Research Laboratory University of California, Berkeley, October 1980.
    /// </summary>
    [Pin(0, "Drain"), Pin(1, "Gate"), Pin(2, "Source"), Pin(3, "Bulk"), Connected(0, 2), Connected(0, 3)]
    public class Mosfet2 : Component
    {
        static Mosfet2()
        {
            RegisterBehaviorFactory(typeof(Mosfet2), new BehaviorFactoryDictionary
            {
                {typeof(TemperatureBehavior), name => new TemperatureBehavior(name)},
                {typeof(BiasingBehavior), name => new BiasingBehavior(name)},
                {typeof(FrequencyBehavior), name => new FrequencyBehavior(name)},
                {typeof(TransientBehavior), name => new TransientBehavior(name)},
                {typeof(NoiseBehavior), name => new NoiseBehavior(name)}
            });
        }

        /// <summary>
        /// Set the model for the MOS2 Mosfet.
        /// </summary>
        public void SetModel(Model model) => Model = model;

        /// <summary>
        /// Constants
        /// </summary>
        [ParameterName("pincount"), ParameterInfo("Number of pins")]
		public const int Mosfet2PinCount = 4;
        
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">The name of the device</param>
        public Mosfet2(string name) : base(name, Mosfet2PinCount)
        {
            // Add parameters
            ParameterSets.Add(new BaseParameters());
        }
    }
}
