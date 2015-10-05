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
    public class ExceptionAspect : OnExceptionAspect
    {
        public override void OnException(MethodExecutionArgs args)
        {
            base.OnException(args);
        }

        public override void CompileTimeInitialize(MethodBase method, AspectInfo aspectInfo)
        {
            base.CompileTimeInitialize(method, aspectInfo);
        }

        public override void RuntimeInitialize(MethodBase method)
        {
            base.RuntimeInitialize(method);
        }
    }
}
