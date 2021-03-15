Imports System.Reflection
Imports Microsoft.Extensions.Logging
Imports ova.common.Onion.Core.Domain.Model

Namespace Template

    Public Interface IEventTemplateBase : Inherits IEntity
        'Property Level As LogLevel
        Property Message As String
        Function EventId() As EventId

        'Overloads Sub Replace(ParamArray values() As String)

    End Interface

    Public Interface IEventTemplate
        Overloads Sub Replace()
        Overloads Sub Replace(type As Type)
        Overloads Sub Replace(methodinfo As MethodInfo)
        Overloads Sub Replace(activity As Activity)
        Overloads Sub Replace(activitycontext As ActivityContext)
        Overloads Sub Replace(activityevent As ActivityEvent)
        Overloads Sub Replace(typeinfo As TypeInfo)
        Overloads Sub Replace(eventinfo As EventInfo)
        Overloads Sub Replace(fieldinfo As FieldInfo)
        Overloads Sub Replace(imagefilemachine As ImageFileMachine)
        Overloads Sub Replace(reflect As IReflect)
        Overloads Sub Replace(manifestresourceinfo As ManifestResourceInfo)
        Overloads Sub Replace(memberinfo As MemberInfo)
        Overloads Sub Replace(methodbase As MethodBase)
        Overloads Sub Replace(methodbody As MethodBody)
        Overloads Sub Replace(parameterinfo As ParameterInfo)
        Overloads Sub Replace(propertyinfo As PropertyInfo)
        Overloads Sub Replace(reflectioncontext As ReflectionContext)
    End Interface

End Namespace