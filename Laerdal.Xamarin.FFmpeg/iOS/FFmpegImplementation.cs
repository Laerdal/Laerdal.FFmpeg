using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;

namespace Laerdal.Xamarin.FFmpeg
{
	[Preserve (AllMembers = true)]
    internal partial class FFmpegImplementation
    {
        public override string Version => iOS.MobileFFmpegConfig.FFmpegVersion;

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
            iOS.MobileFFmpeg.Cancel(executionId);
        }

        public override IEnumerable<FFmpegExecution> ListExecutions()
        {
            var executions = iOS.MobileFFmpeg.ListExecutions;
            return executions.Select(e => new FFmpegExecution((iOS.FFmpegExecution)e));
        }
    }
}