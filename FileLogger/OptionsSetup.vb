Imports Microsoft.Extensions.Logging.Configuration
Imports Microsoft.Extensions.Options

Friend Class OptionsSetup : Inherits ConfigureFromConfigurationOptions(Of Options)

    Public Sub New(ByVal providerConfiguration As ILoggerProviderConfiguration(Of Provider))
            MyBase.New(providerConfiguration.Configuration)
        End Sub

    End Class

