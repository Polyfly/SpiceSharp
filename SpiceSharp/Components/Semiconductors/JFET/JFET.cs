﻿using SpiceSharp.Attributes;
using SpiceSharp.Behaviors;
using SpiceSharp.Components.JFETBehaviors;

namespace SpiceSharp.Components
{
    /// <summary>
    /// A junction field-effect transistor.
    /// </summary>
    /// <seealso cref="SpiceSharp.Components.Component" />
    [Pin(0, "drain"), Pin(1, "gate"), Pin(2, "source")]
    public class JFET : Component
    {
        static JFET()
        {
            RegisterBehaviorFactory(typeof(JFET), new BehaviorFactoryDictionary
            {
                // Add behavior factories
                {typeof(TemperatureBehavior), name => new TemperatureBehavior(name)},
                {typeof(BiasingBehavior), name => new BiasingBehavior(name)},
                {typeof(FrequencyBehavior), name => new FrequencyBehavior(name)},
                {typeof(TransientBehavior), name => new TransientBehavior(name)}
            });
        }

        /// <summary>
        /// Sets the model.
        /// </summary>
        /// <param name="model">The model.</param>
        public void SetModel(JFETModel model) => Model = model;

        /// <summary>
        /// The number of pins on a JFET.
        /// </summary>
        public const int JFETPincount = 3;

        /// <summary>
        /// Initializes a new instance of the <see cref="JFET"/> class.
        /// </summary>
        /// <param name="name">The string of the entity.</param>
        public JFET(string name)
            : base(name, JFETPincount)
        {
            // Add parameters
            ParameterSets.Add(new BaseParameters());
        }
    }
}
