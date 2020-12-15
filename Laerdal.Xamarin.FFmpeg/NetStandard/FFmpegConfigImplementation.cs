using System.Collections.Generic;

namespace Laerdal.Xamarin.FFmpeg
{
    internal partial class FFmpegConfigImplementation
    {
        public override void EnableRedirection() => throw new System.Exception($"No FFmpeg assembly for shared .NET, Did you forget to add a reference in your native project too ?");
        public override void DisableRedirection() => throw new System.Exception($"No FFmpeg assembly for shared .NET, Did you forget to add a reference in your native project too ?");
        public override int LogLevel 
        {
            get => throw new System.Exception($"No FFmpeg assembly for shared .NET, Did you forget to add a reference in your native project too ?");
            set => throw new System.Exception($"No FFmpeg assembly for shared .NET, Did you forget to add a reference in your native project too ?");
        }
        public override LogDelegate LogDelegate
        {
            set => throw new System.Exception($"No FFmpeg assembly for shared .NET, Did you forget to add a reference in your native project too ?");
        }
        public override StatisticsDelegate StatisticsDelegate
        {
            set => throw new System.Exception($"No FFmpeg assembly for shared .NET, Did you forget to add a reference in your native project too ?");
        }
        
        public override Statistics LastReceivedStatistics => throw new System.Exception($"No FFmpeg assembly for shared .NET, Did you forget to add a reference in your native project too ?");
        public override void ResetStatistics() => throw new System.Exception($"No FFmpeg assembly for shared .NET, Did you forget to add a reference in your native project too ?");
        public override string FontconfigConfigurationPath
        {
            set => throw new System.Exception($"No FFmpeg assembly for shared .NET, Did you forget to add a reference in your native project too ?");
        }
        
        public override void SetFontDirectory(string fontDirectoryPath, IDictionary<string, string> fontNameMapping) => throw new System.Exception($"No FFmpeg assembly for shared .NET, Did you forget to add a reference in your native project too ?");
        public override string PackageName => throw new System.Exception($"No FFmpeg assembly for shared .NET, Did you forget to add a reference in your native project too ?");
        public override string[] ExternalLibraries=> throw new System.Exception($"No FFmpeg assembly for shared .NET, Did you forget to add a reference in your native project too ?");
        public override string RegisterNewFFmpegPipe() => throw new System.Exception($"No FFmpeg assembly for shared .NET, Did you forget to add a reference in your native project too ?");
        public override void CloseFFmpegPipe(string ffmpegPipePath) => throw new System.Exception($"No FFmpeg assembly for shared .NET, Did you forget to add a reference in your native project too ?");
        public override string FFmpegVersion => throw new System.Exception($"No FFmpeg assembly for shared .NET, Did you forget to add a reference in your native project too ?");
        public override string Version => throw new System.Exception($"No FFmpeg assembly for shared .NET, Did you forget to add a reference in your native project too ?");
        public override string BuildDate => throw new System.Exception($"No FFmpeg assembly for shared .NET, Did you forget to add a reference in your native project too ?");
        public override int LastReturnCode => throw new System.Exception($"No FFmpeg assembly for shared .NET, Did you forget to add a reference in your native project too ?");
        public override string LastCommandOutput => throw new System.Exception($"No FFmpeg assembly for shared .NET, Did you forget to add a reference in your native project too ?");
        public override void IgnoreSignal(int signum) => throw new System.Exception($"No FFmpeg assembly for shared .NET, Did you forget to add a reference in your native project too ?");
    }
}