﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MySql.Data.EntityFramework.Properties {
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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MySql.Data.EntityFramework.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to The connection parameter must reference an object of type MySql.Data.MySqlConnection.
        /// </summary>
        internal static string ConnectionMustBeOfTypeMySqlConnection {
            get {
                return ResourceManager.GetString("ConnectionMustBeOfTypeMySqlConnection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There is no store type corresponding to the EDM type &apos;{0}&apos; of primitive type &apos;{1}&apos;..
        /// </summary>
        internal static string NoStoreTypeForEdmType {
            get {
                return ResourceManager.GetString("NoStoreTypeForEdmType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The underlying provider does not support the type &apos;{0}&apos;..
        /// </summary>
        internal static string TypeNotSupported {
            get {
                return ResourceManager.GetString("TypeNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Result type of a function is expected to be a collection of RowType or PrimitiveType.
        /// </summary>
        internal static string WrongFunctionResultType {
            get {
                return ResourceManager.GetString("WrongFunctionResultType", resourceCulture);
            }
        }
    }
}
