namespace Laerdal.Xamarin.FFmpeg
{
    public abstract partial class LogDelegate
    {
        protected abstract void OnLogReceived(in long executionId, string text, int levelValue);
    }
}