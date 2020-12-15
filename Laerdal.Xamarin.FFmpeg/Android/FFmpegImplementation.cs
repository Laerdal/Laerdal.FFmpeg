using System.Collections.Generic;
using System.Linq;

namespace Laerdal.Xamarin.FFmpeg
{
    internal partial class FFmpegImplementation
    {
        public override string Version => Android.Config.Version;
        
        public override int Execute(string arguments)
        {
            return Android.FFmpeg.Execute(arguments);
        }

        public override int Execute(string[] arguments)
        {
            return Android.FFmpeg.Execute(arguments);
        }
        
        public override void Cancel(long executionId)
        {
            Android.FFmpeg.Cancel(executionId);
        }

        public override IEnumerable<FFmpegExecution> ListExecutions()
        {
            var executions = Android.FFmpeg.ListExecutions();
            return executions.Select(e => new FFmpegExecution(e));
        }
    }
}