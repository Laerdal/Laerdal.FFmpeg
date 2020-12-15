namespace Laerdal.Xamarin.FFmpeg
{
    public partial class Statistics
    {
        public override double Bitrate => throw new System.Exception(
            $"No FFmpeg assembly for shared .NET, Did you forget to add a reference in your native project too ?");

        public override long Size => throw new System.Exception(
            $"No FFmpeg assembly for shared .NET, Did you forget to add a reference in your native project too ?");

        public override double Speed => throw new System.Exception(
            $"No FFmpeg assembly for shared .NET, Did you forget to add a reference in your native project too ?");

        public override int Time => throw new System.Exception(
            $"No FFmpeg assembly for shared .NET, Did you forget to add a reference in your native project too ?");

        public override long ExecutionId => throw new System.Exception(
            $"No FFmpeg assembly for shared .NET, Did you forget to add a reference in your native project too ?");

        public override float VideoFps => throw new System.Exception(
            $"No FFmpeg assembly for shared .NET, Did you forget to add a reference in your native project too ?");

        public override float VideoQuality => throw new System.Exception(
            $"No FFmpeg assembly for shared .NET, Did you forget to add a reference in your native project too ?");

        public override int VideoFrameNumber => throw new System.Exception(
            $"No FFmpeg assembly for shared .NET, Did you forget to add a reference in your native project too ?");
    }
}