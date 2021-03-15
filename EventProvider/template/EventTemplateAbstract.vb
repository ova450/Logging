Imports Microsoft.Extensions.Logging
Imports ova.common.Onion.Core.Domain.Model

Public MustInherit Class EventTemplateAbstract : Implements IEventTemplateBase

    Sub New(Optional level As LogLevel = LogLevel.Information)
        Me.Level = level
    End Sub

    Public Property Id As Integer Implements IEntityBase.Id
    Public Property Name As String Implements IEntity.Name
    Public Property Level As LogLevel Implements IEventTemplateBase.Level
    Public Property Text As String Implements IEventTemplateBase.Text

    Public Overridable Function EventId() As EventId Implements IEventTemplateBase.EventId
        Return New EventId(Level * 10000 + Id, Name)
    End Function

    Public Sub Replace(ParamArray values() As String) Implements IEventTemplateBase.Replace
        For I = 0 To values.Length - 1
            Text.FieldNumberedReplace(I, values(I))
        Next
    End Sub
End Class
