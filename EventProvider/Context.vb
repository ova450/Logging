Imports System.Reflection
Imports ova.Common.Core.DomainService.SqlService
Imports ova.Common.Logging.EventProvider.Model

Namespace Data

    Public Class Context : Inherits ContextAbstract
        Sub New()
            MyBase.New(Assembly.GetAssembly(GetType(Component)), "LoggingEvents")
        End Sub
    End Class

End Namespace