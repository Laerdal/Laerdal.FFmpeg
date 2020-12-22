using System.Collections.Generic;
using System.Linq;
using Foundation;

namespace Laerdal.Xamarin.FFmpeg
{
    internal partial class FFmpegConfigImplementation
    {
        public override void EnableRedirection() => iOS.MobileFFmpegConfig.EnableRedirection();
        public override void DisableRedirection() => iOS.MobileFFmpegConfig.DisableRedirection();
        public override int LogLevel 
        {
            get => iOS.MobileFFmpegConfig.LogLevel;
            set => iOS.MobileFFmpegConfig.SetLogLevel(value);
        }
        public override LogDelegate LogDelegate
        {
            set => iOS.MobileFFmpegConfig.SetLogDelegate(value);
        }
        public override StatisticsDelegate StatisticsDelegate
        {
            set => iOS.MobileFFmpegConfig.SetStatisticsDelegate(value);
        }
        public override Statistics LastReceivedStatistics => new Statistics(iOS.MobileFFmpegConfig.LastReceivedStatistics);
        public override void ResetStatistics() => iOS.MobileFFmpegConfig.ResetStatistics();
        public override string FontconfigConfigurationPath
        {
            set => iOS.MobileFFmpegConfig.SetFontconfigConfigurationPath(value);
        }
        
        public override void SetFontDirectory(string fontDirectoryPath, IDictionary<string, string> fontNameMapping)
        {
            NSObject[] keys = fontNameMapping.Keys.Select(s => (NSObject)new NSString(s)).ToArray();
            NSObject[] values = fontNameMapping.Values.Select(s => (NSObject)new NSString(s)).ToArray();
            iOS.MobileFFmpegConfig.SetFontDirectory(fontDirectoryPath, NSDictionary.FromObjectsAndKeys(values, keys));
        }

        public override string PackageName => iOS.MobileFFmpegConfig.PackageName;
        public override string[] ExternalLibraries => iOS.MobileFFmpegConfig.ExternalLibraries.Select(o => o.Description).ToArray();
        public override string RegisterNewFFmpegPipe() => iOS.MobileFFmpegConfig.RegisterNewFFmpegPipe();
        public override void CloseFFmpegPipe(string ffmpegPipePath) => iOS.MobileFFmpegConfig.CloseFFmpegPipe(ffmpegPipePath);
        public override string BuildDate => iOS.MobileFFmpegConfig.BuildDate;
        public override string Version => iOS.MobileFFmpegConfig.Version;
        public override string FFmpegVersion => iOS.MobileFFmpegConfig.FFmpegVersion;
        public override int LastReturnCode => iOS.MobileFFmpegConfig.LastReturnCode;
        public override string LastCommandOutput => iOS.MobileFFmpegConfig.LastCommandOutput;
        public override void IgnoreSignal(int signum)  => iOS.MobileFFmpegConfig.IgnoreSignal(signum);
    }
}