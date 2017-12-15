﻿namespace SpiceSharp.Behaviors
{
    /// <summary>
    /// Behavior for setting initial conditions
    /// </summary>
    public abstract class CircuitObjectBehaviorIc : Behavior
    {
        /// <summary>
        /// Set the initial conditions
        /// </summary>
        /// <param name="ckt">Circuit</param>
        public abstract void SetIc(Circuit ckt);
    }
}
