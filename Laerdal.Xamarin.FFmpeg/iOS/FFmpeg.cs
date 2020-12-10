using System;
using System.Collections.Generic;
using System.Linq;

namespace Laerdal.Xamarin.FFmpeg
{
    public partial class FFmpegImplementation : BaseFFmpegImplementation
    {
        public override string Version => iOS.Constants.MOBILE_FFMPEG_VERSION.ToString();
        
        public override int Execute(string arguments)
        {
            return iOS.MobileFFmpeg.Execute(arguments);
        }
        
        public override int Execute(string[] arguments)
        {
            return iOS.MobileFFmpeg.ExecuteWithArguments(arguments.Select(s => new Foundation.NSString(s)).ToArray());
        }

        public override void Cancel(long executionId)
        {
            iOS.MobileFFmpeg.Cancel(new nint(executionId));
        }

        public override IEnumerable<FFmpegExecution> ListExecutions()
        {
            var executions = iOS.MobileFFmpeg.ListExecutions;
            return executions.Select(e => new FFmpegExecution((iOS.FFmpegExecution)e));
        }
    }
}