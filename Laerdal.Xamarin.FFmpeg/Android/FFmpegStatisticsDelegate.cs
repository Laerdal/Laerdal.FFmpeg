using Laerdal.Xamarin.FFmpeg.Android;

namespace Laerdal.Xamarin.FFmpeg
{
    public abstract partial class FFmpegStatisticsDelegate : Java.Lang.Object, IStatisticsCallback
    {
        public void Apply(Android.Statistics p0)
        {
            OnStatisticsReceived(new FFmpegStatistics(p0));
        }
    }
}