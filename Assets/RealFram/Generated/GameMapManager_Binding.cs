using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

using ILRuntime.CLR.TypeSystem;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.Runtime.Stack;
using ILRuntime.Reflection;
using ILRuntime.CLR.Utils;

namespace ILRuntime.Runtime.Generated
{
    unsafe class GameMapManager_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(global::GameMapManager);

            field = type.GetField("LoadSceneOverCallBack", flag);
            app.RegisterCLRFieldGetter(field, get_LoadSceneOverCallBack_0);
            app.RegisterCLRFieldSetter(field, set_LoadSceneOverCallBack_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_LoadSceneOverCallBack_0, AssignFromStack_LoadSceneOverCallBack_0);
            field = type.GetField("LoadingProgress", flag);
            app.RegisterCLRFieldGetter(field, get_LoadingProgress_1);
            app.RegisterCLRFieldSetter(field, set_LoadingProgress_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_LoadingProgress_1, AssignFromStack_LoadingProgress_1);


        }



        static object get_LoadSceneOverCallBack_0(ref object o)
        {
            return ((global::GameMapManager)o).LoadSceneOverCallBack;
        }

        static StackObject* CopyToStack_LoadSceneOverCallBack_0(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((global::GameMapManager)o).LoadSceneOverCallBack;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_LoadSceneOverCallBack_0(ref object o, object v)
        {
            ((global::GameMapManager)o).LoadSceneOverCallBack = (System.Action)v;
        }

        static StackObject* AssignFromStack_LoadSceneOverCallBack_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Action @LoadSceneOverCallBack = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((global::GameMapManager)o).LoadSceneOverCallBack = @LoadSceneOverCallBack;
            return ptr_of_this_method;
        }

        static object get_LoadingProgress_1(ref object o)
        {
            return global::GameMapManager.LoadingProgress;
        }

        static StackObject* CopyToStack_LoadingProgress_1(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = global::GameMapManager.LoadingProgress;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_LoadingProgress_1(ref object o, object v)
        {
            global::GameMapManager.LoadingProgress = (System.Int32)v;
        }

        static StackObject* AssignFromStack_LoadingProgress_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @LoadingProgress = ptr_of_this_method->Value;
            global::GameMapManager.LoadingProgress = @LoadingProgress;
            return ptr_of_this_method;
        }



    }
}
