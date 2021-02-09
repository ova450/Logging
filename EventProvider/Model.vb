Imports Microsoft.Extensions.Logging
Imports ova.common.logging.EventProvider.Model.Abstract
Imports ova.common.Onion.Core.Domain.Navigation

Namespace Model

    Public Class Component : Inherits EventAbstract : Implements INavigationChild(Of BaseEvent)

        Public Overrides Function EventId() As EventId
            Return New EventId(Id * 1000000000, Name)
        End Function
        Public Property BaseEvents As HashSet(Of BaseEvent) Implements INavigationChild(Of BaseEvent).Childs
    End Class

    Public Class Process : Inherits EventAbstract : Implements INavigationChild(Of BaseEvent)
        Public Overrides Function EventId() As EventId
            Return New EventId(Id * 10000000, Name)
        End Function
        Public Property BaseEvents As HashSet(Of BaseEvent) Implements INavigationChild(Of BaseEvent).Childs
    End Class

    Public Class Stage : Inherits EventAbstract : Implements INavigationChild(Of BaseEvent)
        Public Overrides Function EventId() As EventId
            Return New EventId(Id * 100000, Name)
        End Function
        Public Property BaseEvents As HashSet(Of BaseEvent) Implements INavigationChild(Of BaseEvent).Childs
    End Class

    Public Class BaseEvent : Inherits EventAbstract : Implements INavigationParent(Of Component, Process, Stage)

        Public Property ComponentId As Integer Implements INavigationParent(Of Component, Process, Stage).ParentId1
        Public Property Component As Component Implements INavigationParent(Of Component, Process, Stage).Parent1

        Public Property ProcessId As Integer Implements INavigationParent(Of Component, Process, Stage).ParentId2
        Public Property Process As Process Implements INavigationParent(Of Component, Process, Stage).Parent2

        Public Property StageId As Integer Implements INavigationParent(Of Component, Process, Stage).ParentId3
        Public Property Stage As Stage Implements INavigationParent(Of Component, Process, Stage).Parent3

        Public Overrides Function EventId() As EventId
            Return New EventId(ComponentId + ProcessId + StageId + Id, Name)
        End Function

    End Class

End Namespace
