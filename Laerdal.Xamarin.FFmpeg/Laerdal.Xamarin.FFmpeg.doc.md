<a name='assembly'></a>
# Laerdal.Xamarin.FFmpeg

## Contents

- [BaseFFmpegConfigImplementation](#T-Laerdal-Xamarin-FFmpeg-BaseFFmpegConfigImplementation 'Laerdal.Xamarin.FFmpeg.BaseFFmpegConfigImplementation')
  - [BuildDate](#P-Laerdal-Xamarin-FFmpeg-BaseFFmpegConfigImplementation-BuildDate 'Laerdal.Xamarin.FFmpeg.BaseFFmpegConfigImplementation.BuildDate')
  - [ExternalLibraries](#P-Laerdal-Xamarin-FFmpeg-BaseFFmpegConfigImplementation-ExternalLibraries 'Laerdal.Xamarin.FFmpeg.BaseFFmpegConfigImplementation.ExternalLibraries')
  - [FFmpegLogDelegate](#P-Laerdal-Xamarin-FFmpeg-BaseFFmpegConfigImplementation-FFmpegLogDelegate 'Laerdal.Xamarin.FFmpeg.BaseFFmpegConfigImplementation.FFmpegLogDelegate')
  - [FFmpegStatisticsDelegate](#P-Laerdal-Xamarin-FFmpeg-BaseFFmpegConfigImplementation-FFmpegStatisticsDelegate 'Laerdal.Xamarin.FFmpeg.BaseFFmpegConfigImplementation.FFmpegStatisticsDelegate')
  - [FFmpegVersion](#P-Laerdal-Xamarin-FFmpeg-BaseFFmpegConfigImplementation-FFmpegVersion 'Laerdal.Xamarin.FFmpeg.BaseFFmpegConfigImplementation.FFmpegVersion')
  - [FontconfigConfigurationPath](#P-Laerdal-Xamarin-FFmpeg-BaseFFmpegConfigImplementation-FontconfigConfigurationPath 'Laerdal.Xamarin.FFmpeg.BaseFFmpegConfigImplementation.FontconfigConfigurationPath')
  - [LastCommandOutput](#P-Laerdal-Xamarin-FFmpeg-BaseFFmpegConfigImplementation-LastCommandOutput 'Laerdal.Xamarin.FFmpeg.BaseFFmpegConfigImplementation.LastCommandOutput')
  - [LastReceivedFFmpegStatistics](#P-Laerdal-Xamarin-FFmpeg-BaseFFmpegConfigImplementation-LastReceivedFFmpegStatistics 'Laerdal.Xamarin.FFmpeg.BaseFFmpegConfigImplementation.LastReceivedFFmpegStatistics')
  - [LastReturnCode](#P-Laerdal-Xamarin-FFmpeg-BaseFFmpegConfigImplementation-LastReturnCode 'Laerdal.Xamarin.FFmpeg.BaseFFmpegConfigImplementation.LastReturnCode')
  - [LogLevel](#P-Laerdal-Xamarin-FFmpeg-BaseFFmpegConfigImplementation-LogLevel 'Laerdal.Xamarin.FFmpeg.BaseFFmpegConfigImplementation.LogLevel')
  - [PackageName](#P-Laerdal-Xamarin-FFmpeg-BaseFFmpegConfigImplementation-PackageName 'Laerdal.Xamarin.FFmpeg.BaseFFmpegConfigImplementation.PackageName')
  - [Version](#P-Laerdal-Xamarin-FFmpeg-BaseFFmpegConfigImplementation-Version 'Laerdal.Xamarin.FFmpeg.BaseFFmpegConfigImplementation.Version')
  - [CloseFFmpegPipe(ffmpegPipePath)](#M-Laerdal-Xamarin-FFmpeg-BaseFFmpegConfigImplementation-CloseFFmpegPipe-System-String- 'Laerdal.Xamarin.FFmpeg.BaseFFmpegConfigImplementation.CloseFFmpegPipe(System.String)')
  - [DisableRedirection()](#M-Laerdal-Xamarin-FFmpeg-BaseFFmpegConfigImplementation-DisableRedirection 'Laerdal.Xamarin.FFmpeg.BaseFFmpegConfigImplementation.DisableRedirection')
  - [EnableRedirection()](#M-Laerdal-Xamarin-FFmpeg-BaseFFmpegConfigImplementation-EnableRedirection 'Laerdal.Xamarin.FFmpeg.BaseFFmpegConfigImplementation.EnableRedirection')
  - [IgnoreSignal(signum)](#M-Laerdal-Xamarin-FFmpeg-BaseFFmpegConfigImplementation-IgnoreSignal-System-Int32- 'Laerdal.Xamarin.FFmpeg.BaseFFmpegConfigImplementation.IgnoreSignal(System.Int32)')
  - [RegisterNewFFmpegPipe()](#M-Laerdal-Xamarin-FFmpeg-BaseFFmpegConfigImplementation-RegisterNewFFmpegPipe 'Laerdal.Xamarin.FFmpeg.BaseFFmpegConfigImplementation.RegisterNewFFmpegPipe')
  - [ResetStatistics()](#M-Laerdal-Xamarin-FFmpeg-BaseFFmpegConfigImplementation-ResetStatistics 'Laerdal.Xamarin.FFmpeg.BaseFFmpegConfigImplementation.ResetStatistics')
  - [SetFontDirectory(fontDirectoryPath,fontNameMapping)](#M-Laerdal-Xamarin-FFmpeg-BaseFFmpegConfigImplementation-SetFontDirectory-System-String,System-Collections-Generic-IDictionary{System-String,System-String}- 'Laerdal.Xamarin.FFmpeg.BaseFFmpegConfigImplementation.SetFontDirectory(System.String,System.Collections.Generic.IDictionary{System.String,System.String})')
- [BaseFFmpegImplementation](#T-Laerdal-Xamarin-FFmpeg-BaseFFmpegImplementation 'Laerdal.Xamarin.FFmpeg.BaseFFmpegImplementation')
  - [Version](#P-Laerdal-Xamarin-FFmpeg-BaseFFmpegImplementation-Version 'Laerdal.Xamarin.FFmpeg.BaseFFmpegImplementation.Version')
  - [Cancel(executionId)](#M-Laerdal-Xamarin-FFmpeg-BaseFFmpegImplementation-Cancel-System-Int64- 'Laerdal.Xamarin.FFmpeg.BaseFFmpegImplementation.Cancel(System.Int64)')
  - [Execute(arguments)](#M-Laerdal-Xamarin-FFmpeg-BaseFFmpegImplementation-Execute-System-String- 'Laerdal.Xamarin.FFmpeg.BaseFFmpegImplementation.Execute(System.String)')
  - [Execute(arguments)](#M-Laerdal-Xamarin-FFmpeg-BaseFFmpegImplementation-Execute-System-String[]- 'Laerdal.Xamarin.FFmpeg.BaseFFmpegImplementation.Execute(System.String[])')
  - [ListExecutions()](#M-Laerdal-Xamarin-FFmpeg-BaseFFmpegImplementation-ListExecutions 'Laerdal.Xamarin.FFmpeg.BaseFFmpegImplementation.ListExecutions')
- [FFmpeg](#T-Laerdal-Xamarin-FFmpeg-FFmpeg 'Laerdal.Xamarin.FFmpeg.FFmpeg')
  - [Version](#P-Laerdal-Xamarin-FFmpeg-FFmpeg-Version 'Laerdal.Xamarin.FFmpeg.FFmpeg.Version')
  - [Cancel(executionId)](#M-Laerdal-Xamarin-FFmpeg-FFmpeg-Cancel-System-Int64- 'Laerdal.Xamarin.FFmpeg.FFmpeg.Cancel(System.Int64)')
  - [Execute(arguments)](#M-Laerdal-Xamarin-FFmpeg-FFmpeg-Execute-System-String- 'Laerdal.Xamarin.FFmpeg.FFmpeg.Execute(System.String)')
  - [Execute(arguments)](#M-Laerdal-Xamarin-FFmpeg-FFmpeg-Execute-System-String[]- 'Laerdal.Xamarin.FFmpeg.FFmpeg.Execute(System.String[])')
  - [ListExecutions()](#M-Laerdal-Xamarin-FFmpeg-FFmpeg-ListExecutions 'Laerdal.Xamarin.FFmpeg.FFmpeg.ListExecutions')
- [FFmpegConfig](#T-Laerdal-Xamarin-FFmpeg-FFmpegConfig 'Laerdal.Xamarin.FFmpeg.FFmpegConfig')
  - [BuildDate](#P-Laerdal-Xamarin-FFmpeg-FFmpegConfig-BuildDate 'Laerdal.Xamarin.FFmpeg.FFmpegConfig.BuildDate')
  - [ExternalLibraries](#P-Laerdal-Xamarin-FFmpeg-FFmpegConfig-ExternalLibraries 'Laerdal.Xamarin.FFmpeg.FFmpegConfig.ExternalLibraries')
  - [FFmpegLogDelegate](#P-Laerdal-Xamarin-FFmpeg-FFmpegConfig-FFmpegLogDelegate 'Laerdal.Xamarin.FFmpeg.FFmpegConfig.FFmpegLogDelegate')
  - [FFmpegStatisticsDelegate](#P-Laerdal-Xamarin-FFmpeg-FFmpegConfig-FFmpegStatisticsDelegate 'Laerdal.Xamarin.FFmpeg.FFmpegConfig.FFmpegStatisticsDelegate')
  - [FFmpegVersion](#P-Laerdal-Xamarin-FFmpeg-FFmpegConfig-FFmpegVersion 'Laerdal.Xamarin.FFmpeg.FFmpegConfig.FFmpegVersion')
  - [FontconfigConfigurationPath](#P-Laerdal-Xamarin-FFmpeg-FFmpegConfig-FontconfigConfigurationPath 'Laerdal.Xamarin.FFmpeg.FFmpegConfig.FontconfigConfigurationPath')
  - [LastCommandOutput](#P-Laerdal-Xamarin-FFmpeg-FFmpegConfig-LastCommandOutput 'Laerdal.Xamarin.FFmpeg.FFmpegConfig.LastCommandOutput')
  - [LastReceivedFFmpegStatistics](#P-Laerdal-Xamarin-FFmpeg-FFmpegConfig-LastReceivedFFmpegStatistics 'Laerdal.Xamarin.FFmpeg.FFmpegConfig.LastReceivedFFmpegStatistics')
  - [LastReturnCode](#P-Laerdal-Xamarin-FFmpeg-FFmpegConfig-LastReturnCode 'Laerdal.Xamarin.FFmpeg.FFmpegConfig.LastReturnCode')
  - [LogLevel](#P-Laerdal-Xamarin-FFmpeg-FFmpegConfig-LogLevel 'Laerdal.Xamarin.FFmpeg.FFmpegConfig.LogLevel')
  - [PackageName](#P-Laerdal-Xamarin-FFmpeg-FFmpegConfig-PackageName 'Laerdal.Xamarin.FFmpeg.FFmpegConfig.PackageName')
  - [Version](#P-Laerdal-Xamarin-FFmpeg-FFmpegConfig-Version 'Laerdal.Xamarin.FFmpeg.FFmpegConfig.Version')
  - [CloseFFmpegPipe(ffmpegPipePath)](#M-Laerdal-Xamarin-FFmpeg-FFmpegConfig-CloseFFmpegPipe-System-String- 'Laerdal.Xamarin.FFmpeg.FFmpegConfig.CloseFFmpegPipe(System.String)')
  - [DisableRedirection()](#M-Laerdal-Xamarin-FFmpeg-FFmpegConfig-DisableRedirection 'Laerdal.Xamarin.FFmpeg.FFmpegConfig.DisableRedirection')
  - [EnableRedirection()](#M-Laerdal-Xamarin-FFmpeg-FFmpegConfig-EnableRedirection 'Laerdal.Xamarin.FFmpeg.FFmpegConfig.EnableRedirection')
  - [IgnoreSignal(signum)](#M-Laerdal-Xamarin-FFmpeg-FFmpegConfig-IgnoreSignal-System-Int32- 'Laerdal.Xamarin.FFmpeg.FFmpegConfig.IgnoreSignal(System.Int32)')
  - [RegisterNewFFmpegPipe()](#M-Laerdal-Xamarin-FFmpeg-FFmpegConfig-RegisterNewFFmpegPipe 'Laerdal.Xamarin.FFmpeg.FFmpegConfig.RegisterNewFFmpegPipe')
  - [ResetStatistics()](#M-Laerdal-Xamarin-FFmpeg-FFmpegConfig-ResetStatistics 'Laerdal.Xamarin.FFmpeg.FFmpegConfig.ResetStatistics')
  - [SetFontDirectory(fontDirectoryPath,fontNameMapping)](#M-Laerdal-Xamarin-FFmpeg-FFmpegConfig-SetFontDirectory-System-String,System-Collections-Generic-IDictionary{System-String,System-String}- 'Laerdal.Xamarin.FFmpeg.FFmpegConfig.SetFontDirectory(System.String,System.Collections.Generic.IDictionary{System.String,System.String})')

<a name='T-Laerdal-Xamarin-FFmpeg-BaseFFmpegConfigImplementation'></a>
## BaseFFmpegConfigImplementation `type`

##### Namespace

Laerdal.Xamarin.FFmpeg

<a name='P-Laerdal-Xamarin-FFmpeg-BaseFFmpegConfigImplementation-BuildDate'></a>
### BuildDate `property`

##### Summary

Returns MobileFFmpeg library build date.

<a name='P-Laerdal-Xamarin-FFmpeg-BaseFFmpegConfigImplementation-ExternalLibraries'></a>
### ExternalLibraries `property`

##### Summary

Returns supported external libraries.

<a name='P-Laerdal-Xamarin-FFmpeg-BaseFFmpegConfigImplementation-FFmpegLogDelegate'></a>
### FFmpegLogDelegate `property`

##### Summary

Sets a LogDelegate. logCallback method inside LogDelegate is used to redirect logs.

<a name='P-Laerdal-Xamarin-FFmpeg-BaseFFmpegConfigImplementation-FFmpegStatisticsDelegate'></a>
### FFmpegStatisticsDelegate `property`

##### Summary

Sets a StatisticsDelegate. statisticsCallback method inside StatisticsDelegate is used to redirect statistics.

<a name='P-Laerdal-Xamarin-FFmpeg-BaseFFmpegConfigImplementation-FFmpegVersion'></a>
### FFmpegVersion `property`

##### Summary

Returns FFmpeg version bundled within the library.

<a name='P-Laerdal-Xamarin-FFmpeg-BaseFFmpegConfigImplementation-FontconfigConfigurationPath'></a>
### FontconfigConfigurationPath `property`

##### Summary

Sets and overrides fontconfig configuration directory which contains fontconfig configuration (fonts.conf)

<a name='P-Laerdal-Xamarin-FFmpeg-BaseFFmpegConfigImplementation-LastCommandOutput'></a>
### LastCommandOutput `property`

##### Summary

Returns log output of last executed single FFmpeg/FFprobe command.

 This method does not support executing multiple concurrent commands. If you execute
 multiple commands at the same time, this method will return output from all executions.

 Please note that disabling redirection using MobileFFmpegConfig.disableRedirection() method
 also disables this functionality.

<a name='P-Laerdal-Xamarin-FFmpeg-BaseFFmpegConfigImplementation-LastReceivedFFmpegStatistics'></a>
### LastReceivedFFmpegStatistics `property`

##### Summary

Returns the last received statistics data. It is recommended to call it before starting a new execution.

<a name='P-Laerdal-Xamarin-FFmpeg-BaseFFmpegConfigImplementation-LastReturnCode'></a>
### LastReturnCode `property`

##### Summary

Returns return code of last executed command.

<a name='P-Laerdal-Xamarin-FFmpeg-BaseFFmpegConfigImplementation-LogLevel'></a>
### LogLevel `property`

##### Summary

Gets and sets log level.

<a name='P-Laerdal-Xamarin-FFmpeg-BaseFFmpegConfigImplementation-PackageName'></a>
### PackageName `property`

##### Summary

Returns guessed package name according to supported external libraries

<a name='P-Laerdal-Xamarin-FFmpeg-BaseFFmpegConfigImplementation-Version'></a>
### Version `property`

##### Summary

Returns MobileFFmpeg library version.

<a name='M-Laerdal-Xamarin-FFmpeg-BaseFFmpegConfigImplementation-CloseFFmpegPipe-System-String-'></a>
### CloseFFmpegPipe(ffmpegPipePath) `method`

##### Summary

Closes a previously created FFmpeg pipe.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| ffmpegPipePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | full path of ffmpeg pipe |

<a name='M-Laerdal-Xamarin-FFmpeg-BaseFFmpegConfigImplementation-DisableRedirection'></a>
### DisableRedirection() `method`

##### Summary

Disables log and statistics redirection.

##### Parameters

This method has no parameters.

<a name='M-Laerdal-Xamarin-FFmpeg-BaseFFmpegConfigImplementation-EnableRedirection'></a>
### EnableRedirection() `method`

##### Summary

Enables log and statistics redirection.
When redirection is not enabled FFmpeg/FFprobe logs are printed to stderr. By enabling
redirection, they are routed to NSLog and can be routed further to a log delegate.
Statistics redirection behaviour is similar. Statistics are not printed at all if
redirection is not enabled. If it is enabled then it is possible to define a statistics
delegate but if you don't, they are not printed anywhere and only saved as
'lastReceivedStatistics' data which can be polled with
'{@link #'getLastReceivedStatistics()'.
Note that redirection is enabled by default. If you do not want to use its functionality
please use 'disableRedirection()' to disable it.

##### Parameters

This method has no parameters.

<a name='M-Laerdal-Xamarin-FFmpeg-BaseFFmpegConfigImplementation-IgnoreSignal-System-Int32-'></a>
### IgnoreSignal(signum) `method`

##### Summary

Registers a new ignored signal. Ignored signals are not handled by the library.

 By default, the following 5 signals are handled: SIGINT, SIGQUIT, SIGPIPE, SIGTERM and SIGXCPU. Any of them can be
 ignored.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| signum | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | signal number to ignore |

<a name='M-Laerdal-Xamarin-FFmpeg-BaseFFmpegConfigImplementation-RegisterNewFFmpegPipe'></a>
### RegisterNewFFmpegPipe() `method`

##### Summary

Creates a new named pipe to use in FFmpeg operations.

 Please note that creator is responsible of closing created pipes.

##### Returns

the full path of named pipe

##### Parameters

This method has no parameters.

<a name='M-Laerdal-Xamarin-FFmpeg-BaseFFmpegConfigImplementation-ResetStatistics'></a>
### ResetStatistics() `method`

##### Summary

Resets last received statistics.

##### Parameters

This method has no parameters.

<a name='M-Laerdal-Xamarin-FFmpeg-BaseFFmpegConfigImplementation-SetFontDirectory-System-String,System-Collections-Generic-IDictionary{System-String,System-String}-'></a>
### SetFontDirectory(fontDirectoryPath,fontNameMapping) `method`

##### Summary

Registers fonts inside the given path, so they are available to use in FFmpeg filters.

 Note that you need to build MobileFFmpeg with fontconfig
 enabled or use a prebuilt package with fontconfig inside to use this feature.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| fontDirectoryPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | directory which contains fonts (.ttf and .otf files) |
| fontNameMapping | [System.Collections.Generic.IDictionary{System.String,System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IDictionary 'System.Collections.Generic.IDictionary{System.String,System.String}') | custom font name mappings, useful to access your fonts with more friendly names |

<a name='T-Laerdal-Xamarin-FFmpeg-BaseFFmpegImplementation'></a>
## BaseFFmpegImplementation `type`

##### Namespace

Laerdal.Xamarin.FFmpeg

<a name='P-Laerdal-Xamarin-FFmpeg-BaseFFmpegImplementation-Version'></a>
### Version `property`

##### Summary

Global library version

<a name='M-Laerdal-Xamarin-FFmpeg-BaseFFmpegImplementation-Cancel-System-Int64-'></a>
### Cancel(executionId) `method`

##### Summary

Cancels an ongoing operation.
This function does not wait for termination to complete and returns immediately.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| executionId | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | execution id |

<a name='M-Laerdal-Xamarin-FFmpeg-BaseFFmpegImplementation-Execute-System-String-'></a>
### Execute(arguments) `method`

##### Summary

Synchronously executes FFmpeg command provided. Space character is used to split command into arguments.

##### Returns

zero on successful execution, 255 on user cancel and non-zero on error

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| arguments | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | FFmpeg command |

<a name='M-Laerdal-Xamarin-FFmpeg-BaseFFmpegImplementation-Execute-System-String[]-'></a>
### Execute(arguments) `method`

##### Summary

Synchronously executes FFmpeg with arguments provided.

##### Returns

zero on successful execution, 255 on user cancel and non-zero on error

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| arguments | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | FFmpeg command options/arguments as string array |

<a name='M-Laerdal-Xamarin-FFmpeg-BaseFFmpegImplementation-ListExecutions'></a>
### ListExecutions() `method`

##### Summary

Lists ongoing executions.

##### Returns

list of ongoing executions

##### Parameters

This method has no parameters.

<a name='T-Laerdal-Xamarin-FFmpeg-FFmpeg'></a>
## FFmpeg `type`

##### Namespace

Laerdal.Xamarin.FFmpeg

<a name='P-Laerdal-Xamarin-FFmpeg-FFmpeg-Version'></a>
### Version `property`

##### Summary

Global library version

<a name='M-Laerdal-Xamarin-FFmpeg-FFmpeg-Cancel-System-Int64-'></a>
### Cancel(executionId) `method`

##### Summary

Cancels an ongoing operation.
This function does not wait for termination to complete and returns immediately.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| executionId | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | execution id |

<a name='M-Laerdal-Xamarin-FFmpeg-FFmpeg-Execute-System-String-'></a>
### Execute(arguments) `method`

##### Summary

Synchronously executes FFmpeg command provided. Space character is used to split command into arguments.

##### Returns

zero on successful execution, 255 on user cancel and non-zero on error

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| arguments | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | FFmpeg command |

<a name='M-Laerdal-Xamarin-FFmpeg-FFmpeg-Execute-System-String[]-'></a>
### Execute(arguments) `method`

##### Summary

Synchronously executes FFmpeg with arguments provided.

##### Returns

zero on successful execution, 255 on user cancel and non-zero on error

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| arguments | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | FFmpeg command options/arguments as string array |

<a name='M-Laerdal-Xamarin-FFmpeg-FFmpeg-ListExecutions'></a>
### ListExecutions() `method`

##### Summary

Lists ongoing executions.

##### Returns

list of ongoing executions

##### Parameters

This method has no parameters.

<a name='T-Laerdal-Xamarin-FFmpeg-FFmpegConfig'></a>
## FFmpegConfig `type`

##### Namespace

Laerdal.Xamarin.FFmpeg

##### Summary

This class is used to configure MobileFFmpeg library utilities/tools.

 1. LogDelegate: This class redirects FFmpeg/FFprobe output to NSLog by default. As
 an alternative, it is possible not to print messages to NSLog and pass them to a
 LogDelegate function. This function can decide whether to print these logs, show them
 inside another container or ignore them.

 2. setLogLevel:/getLogLevel: Use this methods to set/get
 FFmpeg/FFprobe log severity.

 3. StatsDelegate: It is possible to receive statistics about ongoing
 operation by defining a StatsDelegate or by calling
 getLastReceivedStats method.

 4. Font configuration: It is possible to register custom fonts with
 setFontconfigConfigurationPath: and
 setFontDirectory:with: methods.

<a name='P-Laerdal-Xamarin-FFmpeg-FFmpegConfig-BuildDate'></a>
### BuildDate `property`

##### Summary

Returns MobileFFmpeg library build date.

<a name='P-Laerdal-Xamarin-FFmpeg-FFmpegConfig-ExternalLibraries'></a>
### ExternalLibraries `property`

##### Summary

Returns supported external libraries.

<a name='P-Laerdal-Xamarin-FFmpeg-FFmpegConfig-FFmpegLogDelegate'></a>
### FFmpegLogDelegate `property`

##### Summary

Sets a LogDelegate. logCallback method inside LogDelegate is used to redirect logs.

<a name='P-Laerdal-Xamarin-FFmpeg-FFmpegConfig-FFmpegStatisticsDelegate'></a>
### FFmpegStatisticsDelegate `property`

##### Summary

Sets a StatisticsDelegate. statisticsCallback method inside StatisticsDelegate is used to redirect statistics.

<a name='P-Laerdal-Xamarin-FFmpeg-FFmpegConfig-FFmpegVersion'></a>
### FFmpegVersion `property`

##### Summary

Returns FFmpeg version bundled within the library.

<a name='P-Laerdal-Xamarin-FFmpeg-FFmpegConfig-FontconfigConfigurationPath'></a>
### FontconfigConfigurationPath `property`

##### Summary

Sets and overrides fontconfig configuration directory which contains fontconfig configuration (fonts.conf)

<a name='P-Laerdal-Xamarin-FFmpeg-FFmpegConfig-LastCommandOutput'></a>
### LastCommandOutput `property`

##### Summary

Returns log output of last executed single FFmpeg/FFprobe command.

 This method does not support executing multiple concurrent commands. If you execute
 multiple commands at the same time, this method will return output from all executions.

 Please note that disabling redirection using MobileFFmpegConfig.disableRedirection() method
 also disables this functionality.

<a name='P-Laerdal-Xamarin-FFmpeg-FFmpegConfig-LastReceivedFFmpegStatistics'></a>
### LastReceivedFFmpegStatistics `property`

##### Summary

Returns the last received statistics data. It is recommended to call it before starting a new execution.

<a name='P-Laerdal-Xamarin-FFmpeg-FFmpegConfig-LastReturnCode'></a>
### LastReturnCode `property`

##### Summary

Returns return code of last executed command.

<a name='P-Laerdal-Xamarin-FFmpeg-FFmpegConfig-LogLevel'></a>
### LogLevel `property`

##### Summary

Gets and sets log level.

<a name='P-Laerdal-Xamarin-FFmpeg-FFmpegConfig-PackageName'></a>
### PackageName `property`

##### Summary

Returns guessed package name according to supported external libraries

<a name='P-Laerdal-Xamarin-FFmpeg-FFmpegConfig-Version'></a>
### Version `property`

##### Summary

Returns MobileFFmpeg library version.

<a name='M-Laerdal-Xamarin-FFmpeg-FFmpegConfig-CloseFFmpegPipe-System-String-'></a>
### CloseFFmpegPipe(ffmpegPipePath) `method`

##### Summary

Closes a previously created FFmpeg pipe.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| ffmpegPipePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | full path of ffmpeg pipe |

<a name='M-Laerdal-Xamarin-FFmpeg-FFmpegConfig-DisableRedirection'></a>
### DisableRedirection() `method`

##### Summary

Disables log and statistics redirection.

##### Parameters

This method has no parameters.

<a name='M-Laerdal-Xamarin-FFmpeg-FFmpegConfig-EnableRedirection'></a>
### EnableRedirection() `method`

##### Summary

Enables log and statistics redirection.
When redirection is not enabled FFmpeg/FFprobe logs are printed to stderr. By enabling
redirection, they are routed to NSLog and can be routed further to a log delegate.
Statistics redirection behaviour is similar. Statistics are not printed at all if
redirection is not enabled. If it is enabled then it is possible to define a statistics
delegate but if you don't, they are not printed anywhere and only saved as
'lastReceivedStatistics' data which can be polled with
'{@link #'getLastReceivedStatistics()'.
Note that redirection is enabled by default. If you do not want to use its functionality
please use 'disableRedirection()' to disable it.

##### Parameters

This method has no parameters.

<a name='M-Laerdal-Xamarin-FFmpeg-FFmpegConfig-IgnoreSignal-System-Int32-'></a>
### IgnoreSignal(signum) `method`

##### Summary

Registers a new ignored signal. Ignored signals are not handled by the library.

 By default, the following 5 signals are handled: SIGINT, SIGQUIT, SIGPIPE, SIGTERM and SIGXCPU. Any of them can be
 ignored.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| signum | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | signal number to ignore |

<a name='M-Laerdal-Xamarin-FFmpeg-FFmpegConfig-RegisterNewFFmpegPipe'></a>
### RegisterNewFFmpegPipe() `method`

##### Summary

Creates a new named pipe to use in FFmpeg operations.

 Please note that creator is responsible of closing created pipes.

##### Returns

the full path of named pipe

##### Parameters

This method has no parameters.

<a name='M-Laerdal-Xamarin-FFmpeg-FFmpegConfig-ResetStatistics'></a>
### ResetStatistics() `method`

##### Summary

Resets last received statistics.

##### Parameters

This method has no parameters.

<a name='M-Laerdal-Xamarin-FFmpeg-FFmpegConfig-SetFontDirectory-System-String,System-Collections-Generic-IDictionary{System-String,System-String}-'></a>
### SetFontDirectory(fontDirectoryPath,fontNameMapping) `method`

##### Summary

Registers fonts inside the given path, so they are available to use in FFmpeg filters.

 Note that you need to build MobileFFmpeg with fontconfig
 enabled or use a prebuilt package with fontconfig inside to use this feature.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| fontDirectoryPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | directory which contains fonts (.ttf and .otf files) |
| fontNameMapping | [System.Collections.Generic.IDictionary{System.String,System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IDictionary 'System.Collections.Generic.IDictionary{System.String,System.String}') | custom font name mappings, useful to access your fonts with more friendly names |
