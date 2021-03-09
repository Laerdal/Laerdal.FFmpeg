using Foundation;
using Laerdal.FFmpeg.iOS;

namespace Laerdal.FFmpeg
{
	[Preserve (AllMembers = true)]
    public partial class FFmpegMediaInformation
    {
        public iOS.MediaInformation NativeMediaInformation { get; }
        
        public FFmpegMediaInformation(string path) : base(path) 
        {
            NativeMediaInformation = MobileFFprobe.GetMediaInformation(path);
        }

        public override string FileName => NativeMediaInformation.Filename;
        
        public override string Bitrate => NativeMediaInformation.Bitrate;
        
        public override string Duration => NativeMediaInformation.Duration;
        
        public override string Format => NativeMediaInformation.Format;
        
        public override string Size => NativeMediaInformation.Size;
        
        public override string LongFormat => NativeMediaInformation.LongFormat;
        
        public override string StartTime => NativeMediaInformation.StartTime;
    }
}