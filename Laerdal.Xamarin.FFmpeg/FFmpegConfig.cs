namespace Laerdal.Xamarin.FFmpeg
{
    /// <summary>
    ///  This class is used to configure MobileFFmpeg library utilities/tools.
    /// 
    ///  1. LogDelegate: This class redirects FFmpeg/FFprobe output to NSLog by default. As
    ///  an alternative, it is possible not to print messages to NSLog and pass them to a
    ///  LogDelegate function. This function can decide whether to print these logs, show them
    ///  inside another container or ignore them.
    /// 
    ///  2. setLogLevel:/getLogLevel: Use this methods to set/get
    ///  FFmpeg/FFprobe log severity.
    /// 
    ///  3. StatsDelegate: It is possible to receive statistics about ongoing
    ///  operation by defining a StatsDelegate or by calling
    ///  getLastReceivedStats method.
    /// 
    ///  4. Font configuration: It is possible to register custom fonts with
    ///  setFontconfigConfigurationPath: and
    ///  setFontDirectory:with: methods.
    /// </summary>
    public static class FFmpegConfig
    {
        


    }
}