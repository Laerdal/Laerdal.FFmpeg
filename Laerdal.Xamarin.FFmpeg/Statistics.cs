namespace Laerdal.Xamarin.FFmpeg
{
    public abstract class BaseStatistics
    {
        public abstract double Bitrate { get; }
        public abstract  long Size { get; }
        public abstract double Speed { get; }
        public abstract int Time { get; }
        public abstract long ExecutionId { get; }
        public abstract float VideoFps { get; }
        public abstract float VideoQuality { get; }
        public abstract int VideoFrameNumber { get; }
    }
    
    public partial class Statistics : BaseStatistics
    {
        
    }
}