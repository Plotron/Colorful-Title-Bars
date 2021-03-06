﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ColorfulTitleBars {
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
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ColorfulTitleBars.Strings", typeof(Strings).Assembly);
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
        ///   Looks up a localized string similar to Colorful title bars are currently disabled. Do you want to enable colorful title bars so you can see the changes you make?
        ///You can always disable them in Windows personalization settings..
        /// </summary>
        internal static string ColorDisabledWarningMessage {
            get {
                return ResourceManager.GetString("ColorDisabledWarningMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enable colorful title bars?.
        /// </summary>
        internal static string ColorDisabledWarningTitle {
            get {
                return ResourceManager.GetString("ColorDisabledWarningTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your system is incompatible with this application. This application will close down..
        /// </summary>
        internal static string IncompatibleSystemErrorMessage {
            get {
                return ResourceManager.GetString("IncompatibleSystemErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This application works on Windows 10 only!.
        /// </summary>
        internal static string IncompatibleSystemErrorTitle {
            get {
                return ResourceManager.GetString("IncompatibleSystemErrorTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Inactive accent color value couldn&apos;t be found in the file. Make sure the file contains valid registry data..
        /// </summary>
        internal static string RegFileParsingFailedMessage {
            get {
                return ResourceManager.GetString("RegFileParsingFailedMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Inactive accent color value not found.
        /// </summary>
        internal static string RegFileParsingFailedTitle {
            get {
                return ResourceManager.GetString("RegFileParsingFailedTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to apply changes.  The registry key is inaccessible!.
        /// </summary>
        internal static string RegistryInaccessibleErrorMessage {
            get {
                return ResourceManager.GetString("RegistryInaccessibleErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error! Failed to apply changes!.
        /// </summary>
        internal static string RegistryUpdateErrorTitle {
            get {
                return ResourceManager.GetString("RegistryUpdateErrorTitle", resourceCulture);
            }
        }
    }
}
