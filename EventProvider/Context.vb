Imports System.Reflection
Imports ova.common.logging.EventProvider.Model
Imports ova.common.Onion.Core.DomainService.SqlService

Namespace Data

    Public Class Context : Inherits ContextAbstract
        Sub New()
            MyBase.New(Assembly.GetAssembly(GetType(Component)), "LoggingEvents")
        End Sub
    End Class

End Namespace