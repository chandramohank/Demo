using PostSharp.Aspects;
using System.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularDemo.Shared
{
    [Serializable]
    [AttributeUsage(AttributeTargets.Method)]
    public class MethodAspect : OnMethodBoundaryAspect
    {
        public override void CompileTimeInitialize(MethodBase method, AspectInfo aspectInfo)
        {
            base.CompileTimeInitialize(method, aspectInfo);
        }
        public override void RuntimeInitialize(MethodBase method)
        {
            base.RuntimeInitialize(method);
        }

        public override void OnEntry(MethodExecutionArgs args)
        {
            base.OnEntry(args);
        }

        public override void OnSuccess(MethodExecutionArgs args)
        {
            base.OnSuccess(args);
        }

        public override void OnExit(MethodExecutionArgs args)
        {
            base.OnExit(args);
        }

        public override bool Match(object obj)
        {
            return base.Match(obj);
        }

        public override void OnException(MethodExecutionArgs args)
        {
            base.OnException(args);
        }
    }
}
