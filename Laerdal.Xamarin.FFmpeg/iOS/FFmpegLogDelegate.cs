using System;
using Foundation;

namespace Laerdal.Xamarin.FFmpeg
{
	[Preserve (AllMembers = true)]
    public abstract partial class FFmpegLogDelegate : iOS.LogDelegate
    {
        public override void LogCallback(long executionId, int level, string message)
        {
            OnLogReceived(executionId, message, level);
        }
    }
}