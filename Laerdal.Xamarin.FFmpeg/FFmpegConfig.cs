using System.Collections.Generic;

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
        private static FFmpegConfigImplementation FFmpegConfigImplementation { get; } = new FFmpegConfigImplementation();
        
        /// <summary>
        /// Enables log and statistics redirection.
        /// When redirection is not enabled FFmpeg/FFprobe logs are printed to stderr. By enabling
        /// redirection, they are routed to NSLog and can be routed further to a log delegate.
        /// Statistics redirection behaviour is similar. Statistics are not printed at all if
        /// redirection is not enabled. If it is enabled then it is possible to define a statistics
        /// delegate but if you don't, they are not printed anywhere and only saved as
        /// 'lastReceivedStatistics' data which can be polled with
        /// '{@link #'getLastReceivedStatistics()'.
        /// Note that redirection is enabled by default. If you do not want to use its functionality
        /// please use 'disableRedirection()' to disable it.
        /// </summary>
        public static void EnableRedirection() => FFmpegConfigImplementation.EnableRedirection();

        /// <summary>
        /// Disables log and statistics redirection.
        /// </summary>
        public static void DisableRedirection() => FFmpegConfigImplementation.DisableRedirection();
        
        /// <summary>
        /// Gets and sets log level.
        /// </summary>
        public static int LogLevel
        {
            get => FFmpegConfigImplementation.LogLevel;
            set => FFmpegConfigImplementation.LogLevel = value;
        }
        
        /// <summary>
        /// Sets a LogDelegate. logCallback method inside LogDelegate is used to redirect logs.
        /// </summary>
        public static LogDelegate LogDelegate { 
            set => FFmpegConfigImplementation.LogDelegate = value;
        }
        
        /// <summary>
        /// Sets a StatisticsDelegate. statisticsCallback method inside StatisticsDelegate is used to redirect statistics.
        /// </summary>
        public static StatisticsDelegate StatisticsDelegate { 
            set => FFmpegConfigImplementation.StatisticsDelegate = value;
        }

        /// <summary>
        /// Returns the last received statistics data. It is recommended to call it before starting a new execution.
        /// </summary>
        public static Statistics LastReceivedStatistics => FFmpegConfigImplementation.LastReceivedStatistics;

        /// <summary>
        /// Resets last received statistics.
        /// </summary>
        public static void ResetStatistics() => FFmpegConfigImplementation.ResetStatistics();

        /// <summary>
        /// Sets and overrides fontconfig configuration directory which contains fontconfig configuration (fonts.conf)
        /// </summary>
        public static string FontconfigConfigurationPath {
            set => FFmpegConfigImplementation.FontconfigConfigurationPath = value;
        }

        /// <summary>
        /// Registers fonts inside the given path, so they are available to use in FFmpeg filters.
        ///
        /// Note that you need to build MobileFFmpeg with fontconfig
        /// enabled or use a prebuilt package with fontconfig inside to use this feature.
        /// </summary>
        /// <param name="fontDirectoryPath">directory which contains fonts (.ttf and .otf files)</param>
        /// <param name="fontNameMapping">custom font name mappings, useful to access your fonts with more friendly names</param>
        public static void SetFontDirectory(string fontDirectoryPath, IDictionary<string, string> fontNameMapping) =>
            FFmpegConfigImplementation.SetFontDirectory(fontDirectoryPath, fontNameMapping);

        /// <summary>
        /// Returns guessed package name according to supported external libraries
        /// </summary>
        public static string PackageName => FFmpegConfigImplementation.PackageName;

        /// <summary>
        /// Returns supported external libraries.
        /// </summary>
        public static string[] ExternalLibraries => FFmpegConfigImplementation.ExternalLibraries;

        /// <summary>
        /// Creates a new named pipe to use in FFmpeg operations.
        ///
        /// Please note that creator is responsible of closing created pipes.
        /// </summary>
        /// <returns>the full path of named pipe</returns>
        public static string RegisterNewFFmpegPipe() => FFmpegConfigImplementation.RegisterNewFFmpegPipe();

        /// <summary>
        /// Closes a previously created FFmpeg pipe.
        /// </summary>
        /// <param name="ffmpegPipePath">full path of ffmpeg pipe</param>
        public static void CloseFFmpegPipe(string ffmpegPipePath) => FFmpegConfigImplementation.CloseFFmpegPipe(ffmpegPipePath);

        /// <summary>
        /// Returns FFmpeg version bundled within the library.
        /// </summary>
        public static string FFmpegVersion => FFmpegConfigImplementation.FFmpegVersion;

        /// <summary>
        /// Returns MobileFFmpeg library version.
        /// </summary>
        public static string Version => FFmpegConfigImplementation.Version;

        /// <summary>
        /// Returns MobileFFmpeg library build date.
        /// </summary>
        public static string BuildDate => FFmpegConfigImplementation.BuildDate;

        /// <summary>
        /// Returns return code of last executed command.
        /// </summary>
        public static int LastReturnCode => FFmpegConfigImplementation.LastReturnCode;

        /// <summary>
        /// Returns log output of last executed single FFmpeg/FFprobe command.
        ///
        /// This method does not support executing multiple concurrent commands. If you execute
        /// multiple commands at the same time, this method will return output from all executions.
        ///
        /// Please note that disabling redirection using MobileFFmpegConfig.disableRedirection() method
        /// also disables this functionality.
        /// </summary>
        public static string LastCommandOutput => FFmpegConfigImplementation.LastCommandOutput;

        /// <summary>
        /// Registers a new ignored signal. Ignored signals are not handled by the library.
        ///
        /// By default, the following 5 signals are handled: SIGINT, SIGQUIT, SIGPIPE, SIGTERM and SIGXCPU. Any of them can be
        /// ignored.
        /// </summary>
        /// <param name="signum">signal number to ignore</param>
        public static void IgnoreSignal(int signum) => FFmpegConfigImplementation.IgnoreSignal(signum);
    }
}