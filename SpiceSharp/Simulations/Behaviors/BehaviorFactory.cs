﻿namespace SpiceSharp.Behaviors
{
    /// <inheritdoc />
    /// <summary>
    /// Factory for behaviors
    /// </summary>
    public class BehaviorFactoryDictionary : TypeDictionary<BehaviorFactoryMethod>
    {
        /// <inheritdoc />
        /// <summary>
        /// Constructor
        /// </summary>
        public BehaviorFactoryDictionary()
            : base(typeof(Behavior))
        {
        }
    }

    /// <summary>
    /// Delegate
    /// </summary>
    public delegate Behavior BehaviorFactoryMethod();
}
