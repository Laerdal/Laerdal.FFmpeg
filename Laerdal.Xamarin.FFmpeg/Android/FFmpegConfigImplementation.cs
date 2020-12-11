using System.Collections.Generic;
using System.Linq;
using Android.App;

namespace Laerdal.Xamarin.FFmpeg
{
    public partial class FFmpegConfigImplementation
    {
        public override void EnableRedirection() => Android.Config.EnableRedirection();
        public override void DisableRedirection() => Android.Config.DisableRedirection();
        
        // TODO : Switch to an Enum
        public override int LogLevel 
        {
            get => Android.Config.LogLevel.Value;
            set => Android.Config.LogLevel = Android.Level.From(value);
        }
        public override LogDelegate LogDelegate
        {
            set => Android.Config.EnableLogCallback(value);
        }
        public override StatisticsDelegate StatisticsDelegate
        {
            set => Android.Config.EnableStatisticsCallback(value);
        }
        public override Statistics GetLastReceivedStatistics => new Statistics(Android.Config.LastReceivedStatistics);
        public override void ResetStatistics() => Android.Config.ResetStatistics();
        public override string FontconfigConfigurationPath
        {
            set => Android.Config.SetFontconfigConfigurationPath(value);
        }

        public override void SetFontDirectory(string fontDirectoryPath, IDictionary<string, string> fontNameMapping) => Android.Config.SetFontDirectory(Application.Context, fontDirectoryPath, fontNameMapping);
        public override string PackageName => Android.Config.PackageName;
        public override string[] ExternalLibraries => Android.Config.ExternalLibraries.ToArray();
        public override string RegisterNewFFmpegPipe() => Android.Config.RegisterNewFFmpegPipe(Application.Context);
        public override void CloseFFmpegPipe(string ffmpegPipePath) => Android.Config.CloseFFmpegPipe(ffmpegPipePath);
        public override string BuildDate => Android.Config.BuildDate;
        public override string Version => Android.Config.Version;
        public override string FFmpegVersion => Android.Config.FFmpegVersion;
        public override int LastReturnCode => Android.Config.LastReturnCode;
        public override string LastCommandOutput => Android.Config.LastCommandOutput;
        public override void IgnoreSignal(int signum)  => Android.Config.IgnoreSignal(Android.Signal.Values().SingleOrDefault(s => s.Value == signum));
    }
}