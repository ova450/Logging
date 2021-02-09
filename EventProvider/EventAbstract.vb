Imports Microsoft.Extensions.Logging
Imports ova.common.Onion.Core.Domain.Model

Namespace Model.Abstract

    Public Interface IEvent : Inherits IEntity

        Property Level As LogLevel
        Property Template As String
        Function EventId() As EventId
        Function ToString(ParamArray param() As String) As String

    End Interface

    Public Class EventAbstract : Implements IEvent

        Public Property Id As Integer Implements IEntityBase.Id
        Public Property Name As String Implements IEntity.Name
        Public Property Level As LogLevel Implements IEvent.Level
        Public Property Template As String Implements IEvent.Template

        Public Overridable Function EventId() As EventId Implements IEvent.EventId
            Return New EventId(Level * 10000 + Id, Name)
        End Function

        Private Function TemplateArray() As ArrayList
            Return Template.Split()
        End Function

        Public Overloads Function ToString(ParamArray param() As String) As String Implements IEvent.ToString
            for Each   
        End Function
    End Class

End Namespace
