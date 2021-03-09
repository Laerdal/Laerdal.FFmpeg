using System;
using Laerdal.FFmpeg.Android;

namespace Laerdal.FFmpeg
{
    public abstract partial class FFmpegLogDelegate : Java.Lang.Object, ILogCallback
    {
        public void Apply(LogMessage p0)
        {
            OnLogReceived(p0.ExecutionId, p0.Text, p0.Level.Value);
        }
    }
}