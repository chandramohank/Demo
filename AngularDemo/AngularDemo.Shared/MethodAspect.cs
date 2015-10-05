using PostSharp.Aspects;
using System.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using System.Diagnostics;

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
            args.MethodExecutionTag = Stopwatch.StartNew();
            //private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
            Logging.Info("Called Entry " + args.Method.Name);
            base.OnEntry(args);
        }

        public override void OnSuccess(MethodExecutionArgs args)
        {
            Logging.Info("Called sucess " + args.Method.Name);
            base.OnSuccess(args);
        }

        public override void OnExit(MethodExecutionArgs args)
        {
            Stopwatch sw = (Stopwatch)args.MethodExecutionTag;
            sw.Stop();
            base.OnExit(args);
            string output = string.Format("{0} Executed in {1} milli seconds",
                               args.Method.Name, sw.ElapsedMilliseconds );
            Logging.Info(output);
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
