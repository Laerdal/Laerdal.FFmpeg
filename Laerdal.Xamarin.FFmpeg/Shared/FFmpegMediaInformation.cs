namespace Laerdal.Xamarin.FFmpeg
{
    public abstract class BaseFFmpegMediaInformation
    {
        public string Path { get; }

        protected BaseFFmpegMediaInformation(string path)
        {
            Path = path;
        }

        public abstract string FileName { get; }
        public abstract string Bitrate { get; }
        public abstract string Duration { get; }
        public abstract string Format { get; }
        public abstract string Size { get; }
        public abstract string LongFormat { get; }
        public abstract string StartTime { get; }
    }


    public partial class FFmpegMediaInformation : BaseFFmpegMediaInformation
    {
    }
}