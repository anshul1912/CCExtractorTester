﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CCExtractorTester.DiffTool {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class DiffResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal DiffResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CCExtractorTester.DiffTool.DiffResources", typeof(DiffResources).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
       
        /// <summary>
        ///   Looks up a localized string similar to #diffBar
        ///{
        ///	width: 3%;
        ///	height: 100%;
        ///	float: left;
        ///	position:relative;
        ///	background: #DDDDDD;
        ///}
        ///
        ///.diffBarLineLeft, .diffBarLineRight
        ///{
        ///	width: 50%;
        ///	float:left;
        ///	height:0px;
        ///	cursor:pointer;
        ///}
        ///
        ///.inView
        ///{
        ///	background-image: url(&quot;../Content/InView.png&quot;);
        ///	background-repeat: repeat;
        ///}
        ///
        ///#activeBar
        ///{
        ///	position:absolute;
        ///	top:0px;
        ///	background-color:#6699FF;
        ///	opacity:0.5;
        ///	filter:alpha(opacity=&apos;50&apos;);
        ///}
        ///
        ///
        ///#diffBox
        ///{
        ///	margin-left: auto;
        ///	margin-right: auto;
        ///	border: solid 2px #00 [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Diff1 {
            get {
                return ResourceManager.GetString("Diff1", resourceCulture);
            }
        }
    }
}