using System.Collections.Generic;

namespace Laerdal.Xamarin.FFmpeg
{
    public partial class FFmpegImplementation : BaseFFmpegImplementation
    {
        public override string Version => throw new System.Exception(
            $"No FFmpeg assembly for shared .NET, Did you forget to add a reference in your native project too ?");

        public override int Execute(string arguments) => throw new System.Exception(
            $"No FFmpeg assembly for shared .NET, Did you forget to add a reference in your native project too ?");

        public override int Execute(string[] arguments) => throw new System.Exception(
            $"No FFmpeg assembly for shared .NET, Did you forget to add a reference in your native project too ?");

        public override void Cancel(long executionId) => throw new System.Exception(
            $"No FFmpeg assembly for shared .NET, Did you forget to add a reference in your native project too ?");

        public override IEnumerable<FFmpegExecution> ListExecutions() => throw new System.Exception(
            $"No FFmpeg assembly for shared .NET, Did you forget to add a reference in your native project too ?");
    }
}