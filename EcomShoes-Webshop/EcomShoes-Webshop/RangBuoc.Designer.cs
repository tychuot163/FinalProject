﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EcomShoes_Webshop {
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
    public class RangBuoc {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal RangBuoc() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("EcomShoes_Webshop.RangBuoc", typeof(RangBuoc).Assembly);
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
        ///   Looks up a localized string similar to Số lượng sản phẩm phải lớn hơn 0, vui lòng chọn lại.
        /// </summary>
        public static string active_Product {
            get {
                return ResourceManager.GetString("active_Product", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Đã tồn tại mã sản phẩm này.
        /// </summary>
        public static string codeProduct_Exist {
            get {
                return ResourceManager.GetString("codeProduct_Exist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Số lượng sản phẩm bằng 0, vui lòng chọn lại.
        /// </summary>
        public static string deactive_Product {
            get {
                return ResourceManager.GetString("deactive_Product", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Giá của sản phẩm phải lớn hơn 0.
        /// </summary>
        public static string price_Less_0 {
            get {
                return ResourceManager.GetString("price_Less_0", resourceCulture);
            }
        }
    }
}
