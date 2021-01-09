namespace Laerdal.Xamarin.FFmpeg
{
    public partial class FFmpegMediaInformation
    {
        
        public override string FileName => throw new System.Exception(
            $"No FFmpeg assembly for shared .NET, Did you forget to add a reference in your native project too ?");

        public override string Bitrate => throw new System.Exception(
            $"No FFmpeg assembly for shared .NET, Did you forget to add a reference in your native project too ?");

        public override string Duration => throw new System.Exception(
            $"No FFmpeg assembly for shared .NET, Did you forget to add a reference in your native project too ?");

        public override string Format => throw new System.Exception(
            $"No FFmpeg assembly for shared .NET, Did you forget to add a reference in your native project too ?");

        public override string Size => throw new System.Exception(
            $"No FFmpeg assembly for shared .NET, Did you forget to add a reference in your native project too ?");

        public override string LongFormat => throw new System.Exception(
            $"No FFmpeg assembly for shared .NET, Did you forget to add a reference in your native project too ?");

        public override string StartTime => throw new System.Exception(
            $"No FFmpeg assembly for shared .NET, Did you forget to add a reference in your native project too ?");
        
        public FFmpegMediaInformation(string path) : base(path) 
        {
            throw new System.Exception($"No FFmpeg assembly for shared .NET, Did you forget to add a reference in your native project too ?");
        }
    }
}