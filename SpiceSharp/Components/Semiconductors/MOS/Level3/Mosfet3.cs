﻿using SpiceSharp.Attributes;
using SpiceSharp.Behaviors;
using SpiceSharp.Components.MosfetBehaviors.Level3;

namespace SpiceSharp.Components
{
    /// <summary>
    /// A MOS3 Mosfet
    /// Level 3, a semi-empirical model(see reference for level 3).
    /// </summary>
    [Pin(0, "Drain"), Pin(1, "Gate"), Pin(2, "Source"), Pin(3, "Bulk"), Connected(0, 2), Connected(0, 3)]
    public class Mosfet3 : Component
    {
        static Mosfet3()
        {
            RegisterBehaviorFactory(typeof(Mosfet3), new BehaviorFactoryDictionary
            {
                {typeof(TemperatureBehavior), name => new TemperatureBehavior(name)},
                {typeof(BiasingBehavior), name => new BiasingBehavior(name)},
                {typeof(FrequencyBehavior), name => new FrequencyBehavior(name)},
                {typeof(TransientBehavior), name => new TransientBehavior(name)},
                {typeof(NoiseBehavior), name => new NoiseBehavior(name)}
            });
        }

        /// <summary>
        /// Set the model for the MOS3 model
        /// </summary>
        public void SetModel(Mosfet3Model model) => Model = model;

        /// <summary>
        /// Constants
        /// </summary>
        [ParameterName("pincount"), ParameterInfo("Number of pins")]
		public const int Mosfet3PinCount = 4;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">The name of the device</param>
        public Mosfet3(string name) : base(name, Mosfet3PinCount)
        {
            // Add parameters
            ParameterSets.Add(new BaseParameters());
        }
    }
}
