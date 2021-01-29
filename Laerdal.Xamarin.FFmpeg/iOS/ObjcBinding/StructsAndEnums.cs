using System;
using Foundation;

namespace Laerdal.Xamarin.FFmpeg.iOS
{
    public enum Level : long
    {
        /* This log level is defined by MobileFFmpeg. It is used to specify logs printed to stderr by ffmpeg. Logs that has this level are not filtered and always redirected. */
        STDERR=-16,
        /* Print no output. */
        QUIET=-8,
        /* Something went really wrong and we will crash now. */
        PANIC=0,
        /* Something went wrong and recovery is not possible. For example, no header was found for a format which depends on headers or an illegal combination of parameters is used. */
        FATAL=8,
        /* Something went wrong and cannot losslessly be recovered. However, not all future data is affected. */
        ERROR=16,
        /* Something somehow does not look correct. This may or may not lead to problems. An example would be the use of '-vstrict -2'. */
        WARNING=24,
        /* Standard information. */
        INFO=32,
        /* Detailed information. */
        VERBOSE=40,
        /* Stuff which is only useful for libav* developers. */
        DEBUG=48,
        /* Extremely verbose debugging, useful for libav* development. */
        TRACE=56,
    }

    public enum Abi : long
    {
        /* Represents armeabi-v7a ABI with NEON support */
        ARMV7A_NEON=1,
        /* Represents armeabi-v7a ABI */
        ARMV7A=2,
        /* Represents armeabi ABI */
        ARM=3,
        /* Represents x86 ABI */
        X86=4,
        /* Represents x86_64 ABI */
        X86_64=5,
        /* Represents arm64-v8a ABI */
        ARM64_V8A=6,
        /* Represents not supported ABIs */
        UNKNOWN=7,
    }
    
    public enum Signal : long
    {
        SIGINT=2,
        SIGQUIT=3,
        SIGPIPE=13,
        SIGTERM=15,
        SIGXCPU=24,
    }
}
