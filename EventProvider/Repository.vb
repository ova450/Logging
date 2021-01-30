Imports Microsoft.Extensions.Logging
Imports ova.Common.Core.DomainService.Repository
Imports ova.Common.Logging.EventProvider.Model
Imports Microsoft.EntityFrameworkCore.ChangeTracking
Imports ova.Common.Core.Domain.Model

Namespace Data.Repository

    Public Class EventRepository(Of T As {New, Class, IEntity}) : Inherits RepositoryAbstract(Of T)

        Sub New(databasecontext As Context)
            MyBase.New(databasecontext)
        End Sub

        'Public Function GetEventId(id As Integer) As EventId
        '    Return GetItem(id).EventId()
        'End Function

        Public Overloads Function Add(eventid As EventId) As EntityEntry(Of T)
            Return Add(New T With {.Name = eventid.Name})
        End Function

        Public Overloads Function Add(name As String) As EntityEntry(Of T)
            Return Add(New T With {.Name = name})
        End Function

        Public Overloads Async Function AddAsync(eventid As EventId) As Task(Of EntityEntry(Of T))
            Return Await AddAsync(New T With {.Name = eventid.Name})
        End Function

        Public Overloads Async Function AddAsync(name As String) As Task(Of EntityEntry(Of T))
            Return Await AddAsync(New T With {.Name = name})
        End Function

        Public Overloads Function Remove(eventid As EventId) As EntityEntry(Of T)
            Return Remove(eventid.Id)
        End Function

        Public Overloads Async Function RemoveAsync(eventid As EventId) As Task(Of EntityEntry(Of T))
            Return Await RemoveAsync(eventid.Id)
        End Function

    End Class

    Public Class ComponentRepository : Inherits EventRepository(Of Component)
        Sub New(databasecontext As Context)
            MyBase.New(databasecontext)
        End Sub
    End Class

    Public Class ProcessRepository : Inherits EventRepository(Of Process)
        Sub New(databasecontext As Context)
            MyBase.New(databasecontext)
        End Sub
    End Class

    Public Class EventStageRepository : Inherits EventRepository(Of Stage)
        Sub New(databasecontext As Context)
            MyBase.New(databasecontext)
        End Sub
    End Class

    Public Class BaseEventRepository : Inherits EventRepository(Of BaseEvent)
        Sub New(databasecontext As Context)
            MyBase.New(databasecontext)
        End Sub

        Dim component As Func(Of BaseEvent, UInteger, Boolean) = Function(e, i) i = 0 OrElse e.ComponentId = i
        Dim process As Func(Of BaseEvent, UInteger, Boolean) = Function(e, i) i = 0 OrElse e.ProcessId = i
        Dim stage As Func(Of BaseEvent, UInteger, Boolean) = Function(e, i) i = 0 OrElse e.StageId = i

        Public Function GetItems(Optional ComponentId As Integer = 0, Optional ProcessId As Integer = 0, Optional StageId As Integer = 0) As IQueryable(Of BaseEvent)
            Return GetAll.Where(Function(p) component(p, ComponentId) AndAlso process(p, ProcessId) AndAlso stage(p, StageId))
        End Function

        Public Overloads Function GetItemFirst(Optional ComponentId As Integer = 0, Optional ProcessId As Integer = 0, Optional StageId As Integer = 0) As BaseEvent
            Return GetAll.FirstOrDefault(Function(p) component(p, ComponentId) AndAlso process(p, ProcessId) AndAlso stage(p, StageId))
        End Function

    End Class

End Namespace