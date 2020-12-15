using System;
using Foundation;

namespace Laerdal.Xamarin.FFmpeg
{
    public abstract partial class LogDelegate : iOS.LogDelegate
    {
        public override void LogCallback(nint executionId, int level, NSObject message)
        {
            OnLogReceived(executionId, message.Description, level);
        }
    }
}