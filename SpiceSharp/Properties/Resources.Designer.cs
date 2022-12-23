﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SpiceSharp.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SpiceSharp.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The solver was forced to choose a pivot that did not meet tolerance levels at matrix element ({0}, {1})..
        /// </summary>
        public static string Algebra_BadlyConditioned {
            get {
                return ResourceManager.GetString("Algebra.BadlyConditioned", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The pivot for elimination step {0} is zero..
        /// </summary>
        public static string Algebra_InvalidPivot {
            get {
                return ResourceManager.GetString("Algebra.InvalidPivot", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The matrix is singular..
        /// </summary>
        public static string Algebra_SingularMatrix {
            get {
                return ResourceManager.GetString("Algebra.SingularMatrix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The matrix was found to be singular when eliminating row {0}..
        /// </summary>
        public static string Algebra_SingularMatrixIndexed {
            get {
                return ResourceManager.GetString("Algebra.SingularMatrixIndexed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The solver is not factored yet..
        /// </summary>
        public static string Algebra_SolverNotFactored {
            get {
                return ResourceManager.GetString("Algebra.SolverNotFactored", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The vector has {0} elements, but {1} were expected..
        /// </summary>
        public static string Algebra_VectorLengthMismatch {
            get {
                return ResourceManager.GetString("Algebra.VectorLengthMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There are already behaviors for &apos;{0}&apos;..
        /// </summary>
        public static string Behaviors_BehaviorsAlreadyExist {
            get {
                return ResourceManager.GetString("Behaviors.BehaviorsAlreadyExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not find behaviors for &apos;{0}&apos;..
        /// </summary>
        public static string Behaviors_NoBehaviorFor {
            get {
                return ResourceManager.GetString("Behaviors.NoBehaviorFor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Node mismatch: {0} nodes expected, but {1} were given..
        /// </summary>
        public static string Components_NodeMismatch {
            get {
                return ResourceManager.GetString("Components.NodeMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Node mismatch for &apos;{0}&apos;: {1} nodes expected, but {1} were given..
        /// </summary>
        public static string Components_NodeMismatchNamed {
            get {
                return ResourceManager.GetString("Components.NodeMismatchNamed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No model was specified for component &apos;{0}&apos; of type {1}..
        /// </summary>
        public static string Components_NoModel {
            get {
                return ResourceManager.GetString("Components.NoModel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Non-causal delay detected. Delays should be greater than 0..
        /// </summary>
        public static string Delays_NonCausalDelay {
            get {
                return ResourceManager.GetString("Delays.NonCausalDelay", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Time points are not monotonically increasing. Time goes from {0:e3} to {1:e3}..
        /// </summary>
        public static string Delays_NonIncreasingTime {
            get {
                return ResourceManager.GetString("Delays.NonIncreasingTime", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot resolve constructor for &apos;{0}&apos;..
        /// </summary>
        public static string DI_CannotResolveConstructor {
            get {
                return ResourceManager.GetString("DI.CannotResolveConstructor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot resolve a parameter of type &apos;{0}&apos; for the constructor of &apos;{1}&apos;..
        /// </summary>
        public static string DI_InvalidConstructorParameter {
            get {
                return ResourceManager.GetString("DI.InvalidConstructorParameter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: breakdown current increased to {1:g5} to resolve incompatibility with specified saturation current..
        /// </summary>
        public static string Diodes_BreakdownCurrentIncreased {
            get {
                return ResourceManager.GetString("Diodes.BreakdownCurrentIncreased", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: unable to match forward and reverse diode region. Bv = {1:g}, ibv = {2:g}..
        /// </summary>
        public static string Diodes_ImpossibleFwdRevMatch {
            get {
                return ResourceManager.GetString("Diodes.ImpossibleFwdRevMatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The default method could not be created for this target framework. Please specify Element&lt;T&gt;.Addition and Element&lt;T&gt;.Subtraction manually..
        /// </summary>
        public static string Element_DefaultMethodNotCreated {
            get {
                return ResourceManager.GetString("Element.DefaultMethodNotCreated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An entity with the name &quot;{0}&quot; already exists..
        /// </summary>
        public static string EntityCollection_KeyExists {
            get {
                return ResourceManager.GetString("EntityCollection.KeyExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} has no DC value, 0 assumed..
        /// </summary>
        public static string IndependentSources_NoDc {
            get {
                return ResourceManager.GetString("IndependentSources.NoDc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} has no DC value, waveform value at time 0 used..
        /// </summary>
        public static string IndependentSources_NoDcUseWaveform {
            get {
                return ResourceManager.GetString("IndependentSources.NoDcUseWaveform", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: effective channel length less than zero..
        /// </summary>
        public static string Mosfets_EffectiveChannelTooSmall {
            get {
                return ResourceManager.GetString("Mosfets.EffectiveChannelTooSmall", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Node {1} of component {0} was &apos;null&apos;, and was connected to ground..
        /// </summary>
        public static string Nodes_NullToGround {
            get {
                return ResourceManager.GetString("Nodes.NullToGround", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No enough elements..
        /// </summary>
        public static string NotEnoughElements {
            get {
                return ResourceManager.GetString("NotEnoughElements", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parallel access to {0} is not supported..
        /// </summary>
        public static string Parallel_AccessNotSupported {
            get {
                return ResourceManager.GetString("Parallel.AccessNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expected {2} arguments for {0}, but {1} were passed..
        /// </summary>
        public static string Parameters_ArgumentCountMismatch {
            get {
                return ResourceManager.GetString("Parameters.ArgumentCountMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The parameter value should be finite..
        /// </summary>
        public static string Parameters_Finite {
            get {
                return ResourceManager.GetString("Parameters.Finite", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The parameter value should be a number but was NaN..
        /// </summary>
        public static string Parameters_IsNaN {
            get {
                return ResourceManager.GetString("Parameters.IsNaN", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The parameter cannot be zero..
        /// </summary>
        public static string Parameters_IsZero {
            get {
                return ResourceManager.GetString("Parameters.IsZero", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The parameter value of {0} was too small, and was raised from {1} to {2}..
        /// </summary>
        public static string Parameters_LowerLimitReached {
            get {
                return ResourceManager.GetString("Parameters.LowerLimitReached", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not find parameter &apos;{0}&apos; of type &apos;{1}&apos; on {2}..
        /// </summary>
        public static string Parameters_NotFoundNamed {
            get {
                return ResourceManager.GetString("Parameters.NotFoundNamed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not find a parameter with type &apos;{0}&apos;..
        /// </summary>
        public static string Parameters_NotFoundTyped {
            get {
                return ResourceManager.GetString("Parameters.NotFoundTyped", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The parameter value should be greater than {0}..
        /// </summary>
        public static string Parameters_NotGreater {
            get {
                return ResourceManager.GetString("Parameters.NotGreater", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The parameter value should be at least {0}..
        /// </summary>
        public static string Parameters_NotGreaterOrEqual {
            get {
                return ResourceManager.GetString("Parameters.NotGreaterOrEqual", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The parameter value should be less than {0}..
        /// </summary>
        public static string Parameters_NotLess {
            get {
                return ResourceManager.GetString("Parameters.NotLess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The parameter value should be at most {0}..
        /// </summary>
        public static string Parameters_NotLessOrEqual {
            get {
                return ResourceManager.GetString("Parameters.NotLessOrEqual", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The parameter value is outside the allowed range {0}-{1}..
        /// </summary>
        public static string Parameters_NotWithinRange {
            get {
                return ResourceManager.GetString("Parameters.NotWithinRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A parameter set of type &apos;{0}&apos; could not be found..
        /// </summary>
        public static string Parameters_ParameterSetNotFound {
            get {
                return ResourceManager.GetString("Parameters.ParameterSetNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The parameter value of {0} was too large, and was reduced from {1} to {2}..
        /// </summary>
        public static string Parameters_UpperLimitReached {
            get {
                return ResourceManager.GetString("Parameters.UpperLimitReached", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The parameter set of type &apos;{0}&apos; is not defined..
        /// </summary>
        public static string ParameterSets_NotDefined {
            get {
                return ResourceManager.GetString("ParameterSets.NotDefined", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The destination type does not match the source..
        /// </summary>
        public static string Reflection_NotMatchingType {
            get {
                return ResourceManager.GetString("Reflection.NotMatchingType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The parameter or property &apos;{0}&apos; points to both {1} and {2}..
        /// </summary>
        public static string Reflection_SameName {
            get {
                return ResourceManager.GetString("Reflection.SameName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: Model describes short-circuit, 1kOhm used..
        /// </summary>
        public static string Resistors_ZeroResistance {
            get {
                return ResourceManager.GetString("Resistors.ZeroResistance", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The simulation {0} does not export simulation data..
        /// </summary>
        public static string Sampler_NoExportEvent {
            get {
                return ResourceManager.GetString("Sampler.NoExportEvent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Gmin step failed..
        /// </summary>
        public static string Simulation_Biasing_GminSteppingFailed {
            get {
                return ResourceManager.GetString("Simulation.Biasing.GminSteppingFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The solution of variable &apos;{0}&apos; is not a number for the current iteration..
        /// </summary>
        public static string Simulation_VariableNotANumber {
            get {
                return ResourceManager.GetString("Simulation.VariableNotANumber", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not determine the operating point..
        /// </summary>
        public static string Simulations_Biasing_NoOp {
            get {
                return ResourceManager.GetString("Simulations.Biasing.NoOp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Source stepping failed..
        /// </summary>
        public static string Simulations_Biasing_SourceSteppingFailed {
            get {
                return ResourceManager.GetString("Simulations.Biasing.SourceSteppingFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Starting diagonal Gmin stepping..
        /// </summary>
        public static string Simulations_Biasing_StartDiagonalGminStepping {
            get {
                return ResourceManager.GetString("Simulations.Biasing.StartDiagonalGminStepping", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Starting Gmin stepping..
        /// </summary>
        public static string Simulations_Biasing_StartGminStepping {
            get {
                return ResourceManager.GetString("Simulations.Biasing.StartGminStepping", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Starting source stepping..
        /// </summary>
        public static string Simulations_Biasing_StartSourceStepping {
            get {
                return ResourceManager.GetString("Simulations.Biasing.StartSourceStepping", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not set convergence aid: variable &apos;{0}&apos; could not be found..
        /// </summary>
        public static string Simulations_ConvergenceAidVariableNotFound {
            get {
                return ResourceManager.GetString("Simulations.ConvergenceAidVariableNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The sweep &apos;{0}&apos; does not contain any points to simulate..
        /// </summary>
        public static string Simulations_DC_NoSweepPoints {
            get {
                return ResourceManager.GetString("Simulations.DC.NoSweepPoints", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Histories cannot track less than one point..
        /// </summary>
        public static string Simulations_History_InvalidLength {
            get {
                return ResourceManager.GetString("Simulations.History.InvalidLength", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid initialization mode..
        /// </summary>
        public static string Simulations_InvalidInitializationMode {
            get {
                return ResourceManager.GetString("Simulations.InvalidInitializationMode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: there are no entities..
        /// </summary>
        public static string Simulations_NoEntities {
            get {
                return ResourceManager.GetString("Simulations.NoEntities", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The expansion factor should be greater or equal than 1..
        /// </summary>
        public static string Simulations_Time_MaximumExpansionTooSmall {
            get {
                return ResourceManager.GetString("Simulations.Time.MaximumExpansionTooSmall", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: transient simulation was terminated..
        /// </summary>
        public static string Simulations_Time_Terminated {
            get {
                return ResourceManager.GetString("Simulations.Time.Terminated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The timestep is invalid..
        /// </summary>
        public static string Simulations_Time_TimestepInvalid {
            get {
                return ResourceManager.GetString("Simulations.Time.TimestepInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The timestep {0:e5}s is too small at t={1:e5}s..
        /// </summary>
        public static string Simulations_Time_TimestepTooSmall {
            get {
                return ResourceManager.GetString("Simulations.Time.TimestepTooSmall", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The simulation &apos;{0}&apos; has {1} rule violations..
        /// </summary>
        public static string Simulations_ValidationFailed {
            get {
                return ResourceManager.GetString("Simulations.ValidationFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A simulation state of type &apos;{0}&apos; is not defined..
        /// </summary>
        public static string Stateful_NotDefined {
            get {
                return ResourceManager.GetString("Stateful.NotDefined", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot compute an equivalent solution for subcircuit &apos;{0}&apos;..
        /// </summary>
        public static string Subcircuits_NoEquivalent {
            get {
                return ResourceManager.GetString("Subcircuits.NoEquivalent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The number of points should be greater than 0..
        /// </summary>
        public static string Sweeps_PointsTooSmall {
            get {
                return ResourceManager.GetString("Sweeps.PointsTooSmall", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot reach the end {0} with the current sweep settings..
        /// </summary>
        public static string Sweeps_Unreachable {
            get {
                return ResourceManager.GetString("Sweeps.Unreachable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A logarithmic sweep cannot start or stop at a value of 0..
        /// </summary>
        public static string Sweeps_ZeroTarget {
            get {
                return ResourceManager.GetString("Sweeps.ZeroTarget", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A value of type {0} already exists..
        /// </summary>
        public static string TypeAlreadyExists {
            get {
                return ResourceManager.GetString("TypeAlreadyExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type &apos;{0}&apos; resolved to multiple instances..
        /// </summary>
        public static string TypeDictionary_AmbiguousType {
            get {
                return ResourceManager.GetString("TypeDictionary.AmbiguousType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A value of the type &apos;{0}&apos; could not be found..
        /// </summary>
        public static string TypeDictionary_TypeNotFound {
            get {
                return ResourceManager.GetString("TypeDictionary.TypeNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid exponent. Cannot represent the exponent {0}/{1}..
        /// </summary>
        public static string Units_InvalidExponent {
            get {
                return ResourceManager.GetString("Units.InvalidExponent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A variable with id &apos;{0}&apos; already exists..
        /// </summary>
        public static string VariableDictionary_KeyExists {
            get {
                return ResourceManager.GetString("VariableDictionary.KeyExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The variable &apos;{0}&apos; is already mapped..
        /// </summary>
        public static string VariableMap_KeyExists {
            get {
                return ResourceManager.GetString("VariableMap.KeyExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A variable by the name of &apos;{0}&apos; could not be found..
        /// </summary>
        public static string VariableNotFound {
            get {
                return ResourceManager.GetString("VariableNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No points are specified..
        /// </summary>
        public static string Waveforms_Pwl_Empty {
            get {
                return ResourceManager.GetString("Waveforms.Pwl.Empty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The time values are not monotonically increasing..
        /// </summary>
        public static string Waveforms_Pwl_NoIncreasingTimeValues {
            get {
                return ResourceManager.GetString("Waveforms.Pwl.NoIncreasingTimeValues", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The piece-wise linear function requires the same amount of time and value points..
        /// </summary>
        public static string Waveforms_Pwl_TimeValueLength {
            get {
                return ResourceManager.GetString("Waveforms.Pwl.TimeValueLength", resourceCulture);
            }
        }
    }
}
