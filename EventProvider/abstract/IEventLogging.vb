Imports System.Reflection
Imports Microsoft.Extensions.Logging
Imports ova.common.Onion.Core.Domain.Model
Imports ova.сommon.UnixTime
Imports ova.common.logging.EventProvider.EventTemplateFields
Imports ova.common.logging.EventProvider.Template

Namespace Model.Abstract

    'Public Interface ILogger : Inherits IEntity, Microsoft.Extensions.Logging.ILogger
    '    Overloads Sub Log(Of TState)(eventId As EventId, state As TState, exception As Exception, formatter As Func(Of TState, Exception, String))
    '    Overloads Sub Log(eventId As EventId)                                                           ' reflection fields
    '    Overloads Sub LogEvent(eventId As EventId, ParamArray valuesoffieldsnumered() As String)        ' numered fields
    '    Overloads Sub LogEvent(eventId As EventId, state As TState, exception As Exception, formatter As Func(Of TState, Exception, String))
    '    Overloads Sub LogException(eventId As EventId, state As TState, exception As Exception, formatter As Func(Of TState, Exception, String))
    '    Overloads Sub Log(Of TState)(eventId As EventId, state As TState, exception As Exception, formatter As Func(Of TState, Exception, String))
    '    Overloads Sub Log(Of TState)(eventId As EventId, state As TState, exception As Exception, formatter As Func(Of TState, Exception, String))
    '    Overloads Sub Log(Of TState)(eventId As EventId, state As TState, exception As Exception, formatter As Func(Of TState, Exception, String))
    '    Overloads Sub LogException(exception As Exception)
    '    Overloads Sub LogException(exception As Exception, formatter As Func(Of Exception, String))
    '    Overloads Sub Log(Of TState)(state As TState, exception As Exception, formatter As Func(Of TState, Exception, String))

    'End Interface

    Class LoggerApp : Implements IEntity, ILogger

        Public Property Id As Integer Implements IEntityBase.Id
        Public Property Name As String Implements IEntity.Name



        Public Sub Log(logLevel As LogLevel, eventId As EventId)

            Dim templates() As IEventTemplateBase
            Dim template = templates.FirstOrDefault(Function(e) e.Id = eventId.Id)

            Dim result = $"{Timestamp()} {eventId.Id} {eventId.Name} {Formatter(template.Message)}"
            System.Console.WriteLine(result)

        End Sub

        Private Sub Log(Of TState)(logLevel As LogLevel, eventId As EventId, state As TState, exception As Exception, formatter As Func(Of TState, Exception, String)) Implements ILogger.Log
            Throw New NotImplementedException()
        End Sub

        Private Shared Function Formatter(ByRef template As String) As String
            With AppDomain.CurrentDomain
                template.FieldNamedReplace("Id", .Id)
                template.FieldNamedReplace("FriendlyName", .FriendlyName)
                template.FieldNamedReplace("BaseDirectory", .BaseDirectory)
                template.FieldNamedReplace("DynamicDirectory", .DynamicDirectory)
                template.FieldNamedReplace("RelativeSearchPath", .RelativeSearchPath)
                template.FieldNamedReplace("GetHashCode", .GetHashCode)
                With .SetupInformation
                    template.FieldNamedReplace("ApplicationBase", .ApplicationBase)
                    template.FieldNamedReplace("TargetFrameworkName", .TargetFrameworkName)
                End With
                template.FieldNamedReplace("IsFullyTrusted", .IsFullyTrusted)
                template.FieldNamedReplace("IsHomogenous", .IsHomogenous)
                template.FieldNamedReplace("ShadowCopyFiles", .ShadowCopyFiles)
                template.FieldNamedReplace("IsDefaultAppDomain", .IsDefaultAppDomain)
                template.FieldNamedReplace("IsFinalizingForUnload", .IsFinalizingForUnload)
                template.FieldNamedReplace("IsFinalizingForUnload", .MonitoringSurvivedMemorySize)
                template.FieldNamedReplace("IsFinalizingForUnload", .MonitoringTotalAllocatedMemorySize)
                template.FieldNamedReplace("IsFinalizingForUnload", .MonitoringTotalProcessorTime.ToString)

                template.FieldNamedReplace("GetType", .GetType.FullName)
                template.FieldNamedReplace("GetType", .GetType.Name)

                template.FieldNamedReplace("ReflectionOnlyGetAssemblies", .ReflectionOnlyGetAssemblies.ListValues)
                template.FieldNamedReplace("GetAssemblies", .GetAssemblies.ListValues)
                template.FieldNamedReplace("ReflectionOnlyGetAssemblies", .ReflectionOnlyGetAssemblies.ListValues)

                template.FieldNamedReplace("PermissionSet", "PermissionSet".IsNotRecommended)

                template.FieldNamedReplace("GetData", "GetData".ReferenceToNumbered)
                template.FieldNamedReplace("GetLifetimeService", "GetLifetimeService".ReferenceToNumbered)
                template.FieldNamedReplace("IsCompatibilitySwitchSet", "IsCompatibilitySwitchSet".ReferenceToNumbered)
            End With
            Return template
        End Function
        Public Function IsEnabled(logLevel As LogLevel) As Boolean Implements ILogger.IsEnabled
            Throw New NotImplementedException()
        End Function

        Public Function BeginScope(Of TState)(state As TState) As IDisposable Implements ILogger.BeginScope
            Throw New NotImplementedException()
        End Function

    End Class





    Public Sub Log(Of TState)(logLevel As LogLevel, eventId As EventId, state As TState, exception As Exception, formatter As Func(Of TState, Exception, String)) Implements ILogger.Log
        Throw New NotImplementedException()
    End Sub




    Public Overloads Sub Replace() Implements IEventTemplate.Replace
        With Assembly.GetExecutingAssembly
            Text.FieldNamedReplace("ExecutingAssembly.Location", .FullName)
            Text.FieldNamedReplace("ExecutingAssembly.HostContext", .HostContext)
            Text.FieldNamedReplace("ExecutingAssembly.ImageRuntimeVersion", .ImageRuntimeVersion)
            Text.FieldNamedReplace("ExecutingAssembly.IsCollectible", .IsCollectible)
            Text.FieldNamedReplace("ExecutingAssembly.IsDynamic", .IsDynamic)
            Text.FieldNamedReplace("ExecutingAssembly.IsFullyTrusted", .IsFullyTrusted)
            Text.FieldNamedReplace("ExecutingAssembly.Location", .Location)
            Text.FieldNamedReplace("ExecutingAssembly.ReflectionOnly", .ReflectionOnly)
            Text.FieldNamedReplace("ExecutingAssembly.Location", .SecurityRuleSet)
            Text.FieldNamedReplace("ExecutingAssembly.Location", .GetHashCode)
            With .GetName
                Text.FieldNamedReplace("ExecutingAssembly.GetName.Name", .Name)
                Text.FieldNamedReplace("ExecutingAssembly.GetName.FullName", .FullName)
                Text.FieldNamedReplace("ExecutingAssembly.GetName.CultureName", .CultureName)
                Text.FieldNamedReplace("ExecutingAssembly.GetName.GetPublicKey", .GetPublicKey.ToString)
                Text.FieldNamedReplace("ExecutingAssembly.GetName.GetPublicKeyToken", .GetPublicKeyToken.ToString)
                Text.FieldNamedReplace("ExecutingAssembly.GetName.Version", .Version.ToString)
                Text.FieldNamedReplace("ExecutingAssembly.GetName.VersionCompatibility", .VersionCompatibility.ToString)
                Text.FieldNamedReplace("ExecutingAssembly.GetName.ContentType", .ContentType.ToString)
                Text.FieldNamedReplace("ExecutingAssembly.GetName.Flags", .Flags.ToString)
                Text.FieldNamedReplace("ExecutingAssembly.GetName.ProcessorArchitecture", .ProcessorArchitecture.ToString)
                Text.FieldNamedReplace("ExecutingAssembly.GetName.Version", .Version.ToString)
                With .CultureInfo
                    Text.FieldNamedReplace("ExecutingAssembly.GetName.CultureInfo.Name", .Name)
                    Text.FieldNamedReplace("ExecutingAssembly.GetName.CultureInfo.TwoLetterISOLanguageName", .TwoLetterISOLanguageName)
                    Text.FieldNamedReplace("ExecutingAssembly.GetName.CultureInfo.CultureTypes", .CultureTypes.ToString)
                    Text.FieldNamedReplace("ExecutingAssembly.GetName.CultureInfo.GetHashCode", .GetHashCode)
                End With
            End With
            Text.FieldNamedReplace("ExecutingAssembly.DefinedTypes", .DefinedTypes.ListValues)
            Text.FieldNamedReplace("ExecutingAssembly.ExportedTypes", .ExportedTypes.ListValues)
            Text.FieldNamedReplace("ExecutingAssembly.GetExportedTypes", .GetExportedTypes.ListValues)
            Text.FieldNamedReplace("ExecutingAssembly.GetManifestResourceNames", .GetManifestResourceNames.ListValues)
            Text.FieldNamedReplace("ExecutingAssembly.GetReferencedAssemblies", .GetReferencedAssemblies.ListValues)
            Text.FieldNamedReplace("ExecutingAssembly.Modules", .Modules.ListValues)
            Text.FieldNamedReplace("ExecutingAssembly.GetLoadedModules", .GetLoadedModules.ListValues)
            Text.FieldNamedReplace("ExecutingAssembly.CustomAttributes", "CustomAttributes".ReferenceToNumbered)        ' reference
            Text.FieldNamedReplace("ExecutingAssembly.EntryPoint.Name", .EntryPoint.Name)
            Text.FieldNamedReplace("Assembly.GetEntryAssembly.FullName", Assembly.GetEntryAssembly.FullName)
            Text.FieldNamedReplace("Assembly.GetCallingAssembly.GetName.FullName", Assembly.GetCallingAssembly.GetName.FullName)
            Text.FieldNamedReplace("ExecutingAssembly.GetSatelliteAssembly(.GetName.CultureInfo).FullName", .GetSatelliteAssembly(.GetName.CultureInfo).FullName)
            Text.FieldNamedReplace("ExecutingAssembly.GlobalAssemblyCache", "GlobalAssemblyCache is deprecated")
            Text.FieldNamedReplace("ExecutingAssembly.ManifestModule.FullyQualifiedName", .ManifestModule.FullyQualifiedName)
        End With
        With AppDomain.CurrentDomain()
            Text.FieldNamedReplace("CurrentDomain.BaseDirectory", .BaseDirectory)
            Text.FieldNamedReplace("CurrentDomain.DynamicDirectory", .DynamicDirectory)
            Text.FieldNamedReplace("CurrentDomain.FriendlyName", .FriendlyName)
            Text.FieldNamedReplace("CurrentDomain.Id", .Id)
            Text.FieldNamedReplace("CurrentDomain.IsFullyTrusted", .IsFullyTrusted)
            Text.FieldNamedReplace("CurrentDomain.IsHomogenous", .IsHomogenous)
            Text.FieldNamedReplace("CurrentDomain.RelativeSearchPath", .RelativeSearchPath)
            Text.FieldNamedReplace("CurrentDomain.ShadowCopyFiles", .ShadowCopyFiles)
            Text.FieldNamedReplace("CurrentDomain.GetHashCode", .GetHashCode)
            Text.FieldNamedReplace("CurrentDomain.GetType", .GetType.FullName)
            Text.FieldNamedReplace("CurrentDomain.GetType", .GetType.Name)
            Text.FieldNamedReplace("CurrentDomain.IsDefaultAppDomain", .IsDefaultAppDomain)
            Text.FieldNamedReplace("CurrentDomain.IsFinalizingForUnload", .IsFinalizingForUnload)
            With .SetupInformation
                Text.FieldNamedReplace("CurrentDomain.ApplicationBase", .ApplicationBase)
                Text.FieldNamedReplace("CurrentDomain.TargetFrameworkName", .TargetFrameworkName)
            End With
            Text.FieldNamedReplace("CurrentDomain.IsFinalizingForUnload", .ApplyPolicy(Assembly.GetExecutingAssembly.GetName.Name))
            Text.FieldNamedReplace("CurrentDomain.IsFinalizingForUnload", .MonitoringSurvivedMemorySize)
            Text.FieldNamedReplace("CurrentDomain.IsFinalizingForUnload", .MonitoringTotalAllocatedMemorySize)
            Text.FieldNamedReplace("CurrentDomain.IsFinalizingForUnload", .MonitoringTotalProcessorTime.ToString)

            Text.FieldNamedReplace("CurrentDomain.IsFinalizingForUnload", .ReflectionOnlyGetAssemblies.ListValues)
            Text.FieldNamedReplace("CurrentDomain.IsFinalizingForUnload", .GetAssemblies.ListValues)
            Text.FieldNamedReplace("CurrentDomain.IsFinalizingForUnload", .ReflectionOnlyGetAssemblies.ListValues)

            Text.FieldNamedReplace("CurrentDomain.IsFinalizingForUnload", "CurrentDomain.PermissionSet".IsNotRecommended)

            Text.FieldNamedReplace("CurrentDomain.IsFinalizingForUnload", "CurrentDomain.GetData".ReferenceToNumbered)
            Text.FieldNamedReplace("CurrentDomain.IsFinalizingForUnload", "CurrentDomain.GetLifetimeService".ReferenceToNumbered)
            Text.FieldNamedReplace("CurrentDomain.IsFinalizingForUnload", "CurrentDomain.IsCompatibilitySwitchSet".ReferenceToNumbered)
        End With
    End Sub



    End Class

    Public Interface IEventLogging
        Overloads Sub TemplateReplace()
        Overloads Sub TemplateReplace(type As Type)
        Overloads Sub TemplateReplace(methodinfo As MethodInfo)
        Overloads Sub TemplateReplace(activity As Activity)
        Overloads Sub TemplateReplace(activitycontext As ActivityContext)
        Overloads Sub TemplateReplace(activityevent As ActivityEvent)
        Overloads Sub TemplateReplace(typeinfo As TypeInfo)
        Overloads Sub TemplateReplace(eventinfo As EventInfo)
        Overloads Sub TemplateReplace(fieldinfo As FieldInfo)
        Overloads Sub TemplateReplace(imagefilemachine As ImageFileMachine)
        Overloads Sub TemplateReplace(reflect As IReflect)
        Overloads Sub TemplateReplace(manifestresourceinfo As ManifestResourceInfo)
        Overloads Sub TemplateReplace(memberinfo As MemberInfo)
        Overloads Sub TemplateReplace(methodbase As MethodBase)
        Overloads Sub TemplateReplace(methodbody As MethodBody)
        Overloads Sub TemplateReplace(parameterinfo As ParameterInfo)
        Overloads Sub TemplateReplace(propertyinfo As PropertyInfo)
        Overloads Sub TemplateReplace(reflectioncontext As ReflectionContext)
    End Interface
End Namespace

