//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FptFramework.OutHouse.Security {
    
    
    #region Component Designer generated code 
    public partial class LibEncryption_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::FptFramework.OutHouse.Security.@__LibEncryption.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::FptFramework.OutHouse.Security.LibEncryption), typeof(global::FptFramework.OutHouse.Security.LibEncryption_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::FptFramework.OutHouse.Security.LibEncryption), typeof(global::FptFramework.OutHouse.Security.LibEncryption_))]
    internal sealed partial class @__LibEncryption : global::java.lang.Object {
        
        internal new static global::java.lang.Class staticClass;
        
        private @__LibEncryption(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::FptFramework.OutHouse.Security.@__LibEncryption.staticClass = @__class;
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__LibEncryption);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "Encrypt_Password", "Encrypt_Password0", "(Ljava/lang/String;)Ljava/lang/String;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "__ctorLibEncryption0", "__ctorLibEncryption0", "(Lnet/sf/jni4net/inj/IClrProxy;)V"));
            return methods;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle Encrypt_Password0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle PasswordData) {
            // (Ljava/lang/String;)Ljava/lang/String;
            // (LSystem/String;)LSystem/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            @__return = global::net.sf.jni4net.utils.Convertor.StrongC2JString(@__env, global::FptFramework.OutHouse.Security.LibEncryption.Encrypt_Password(global::net.sf.jni4net.utils.Convertor.StrongJ2CString(@__env, PasswordData)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static void @__ctorLibEncryption0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::FptFramework.OutHouse.Security.LibEncryption @__real = new global::FptFramework.OutHouse.Security.LibEncryption();
            global::net.sf.jni4net.utils.Convertor.InitProxy(@__env, @__obj, @__real);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::FptFramework.OutHouse.Security.@__LibEncryption(@__env);
            }
        }
    }
    #endregion
}
