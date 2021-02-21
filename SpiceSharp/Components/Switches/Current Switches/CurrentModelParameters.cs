﻿using SpiceSharp.ParameterSets;
using SpiceSharp.Attributes;

namespace SpiceSharp.Components.Switches
{
    /// <summary>
    /// Model parameters for a <see cref="CurrentSwitchModel" />.
    /// </summary>
    /// <seealso cref="ModelParameters" />
    [GeneratedParameters]
    public partial class CurrentModelParameters : ModelParameters
    {
        /// <summary>
        /// Gets the threshold current.
        /// </summary>
        [ParameterName("it"), ParameterInfo("Threshold current")]
        public override double Threshold { get; set; }

        /// <summary>
        /// Gets the hysteresis current.
        /// </summary>
        [ParameterName("ih"), ParameterInfo("Hysteresis current")]
        public override double Hysteresis { get; set; }
    }
}
