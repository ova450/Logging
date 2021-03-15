Imports Microsoft.Extensions.Logging
Imports ova.common.Onion.Core.Domain.Model

Namespace Template

    Public MustInherit Class EventLoggingAbstract : Implements IEventLoggingBase

        Sub New(Optional level As LogLevel = LogLevel.Information)
            Me.Level = level
        End Sub

        Public Property Level As LogLevel Implements IEventLoggingBase.Level
        Public Property Template As String Implements IEventLoggingBase.Template
        Public Property Name As String Implements IEntity.Name
        Public Property Id As Integer Implements IEntityBase.Id

        Public Overridable Function EventId() As EventId Implements IEventLoggingBase.EventId
            Return New EventId(Level * 10000 + Id, Name)
        End Function

        Public Sub TemplateReplace(ParamArray values() As String) Implements IEventLoggingBase.TemplateReplace
            For I = 0 To values.Length - 1
                Template.FieldNumberedReplace(I, values(I))
            Next
        End Sub

    End Class

End Namespace

