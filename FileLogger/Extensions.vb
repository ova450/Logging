Imports System.Runtime.CompilerServices
Imports Microsoft.Extensions.DependencyInjection
Imports Microsoft.Extensions.DependencyInjection.Extensions
Imports Microsoft.Extensions.Logging
Imports Microsoft.Extensions.Logging.Configuration
Imports Microsoft.Extensions.Options
Imports ova.Common.Logging.FileLogger

Public Module Extensions
    <Extension()>
    Public Function AddFileLogger(ByVal builder As ILoggingBuilder) As ILoggingBuilder
        builder.AddConfiguration()
        builder.Services.TryAddEnumerable(ServiceDescriptor.Singleton(Of ILoggerProvider, Provider)())
        builder.Services.TryAddEnumerable(ServiceDescriptor.Singleton(Of IConfigureOptions(Of Options), OptionsSetup)())
        builder.Services.TryAddEnumerable(ServiceDescriptor.Singleton(Of IOptionsChangeTokenSource(Of Options), LoggerProviderOptionsChangeTokenSource(Of Options, Provider))())
        Return builder
    End Function

    <Extension()>
    Public Function AddFileLogger(ByVal builder As ILoggingBuilder, ByVal configure As Action(Of Options)) As ILoggingBuilder

        If configure Is Nothing Then Throw New ArgumentNullException(NameOf(configure))

        builder.AddFileLogger()
        builder.Services.Configure(configure)
        Return builder
    End Function
End Module
