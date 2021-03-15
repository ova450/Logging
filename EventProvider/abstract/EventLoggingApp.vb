Imports System.Reflection
Imports System.Runtime.CompilerServices

Namespace Model.Abstract

    Public Class EventLogging : Inherits EventLoggingAbstract : Implements IEventLogging

        Public Overloads Sub TemplateReplace() Implements IEventLogging.TemplateReplace
            With Assembly.GetExecutingAssembly
                Template.FieldNamedReplace("ExecutingAssembly.Location", .FullName)
                Template.FieldNamedReplace("ExecutingAssembly.HostContext", .HostContext)
                Template.FieldNamedReplace("ExecutingAssembly.ImageRuntimeVersion", .ImageRuntimeVersion)
                Template.FieldNamedReplace("ExecutingAssembly.IsCollectible", .IsCollectible)
                Template.FieldNamedReplace("ExecutingAssembly.IsDynamic", .IsDynamic)
                Template.FieldNamedReplace("ExecutingAssembly.IsFullyTrusted", .IsFullyTrusted)
                Template.FieldNamedReplace("ExecutingAssembly.Location", .Location)
                Template.FieldNamedReplace("ExecutingAssembly.ReflectionOnly", .ReflectionOnly)
                Template.FieldNamedReplace("ExecutingAssembly.Location", .SecurityRuleSet)
                Template.FieldNamedReplace("ExecutingAssembly.Location", .GetHashCode)
                With .GetName
                    Template.FieldNamedReplace("ExecutingAssembly.GetName.Name", .Name)
                    Template.FieldNamedReplace("ExecutingAssembly.GetName.FullName", .FullName)
                    Template.FieldNamedReplace("ExecutingAssembly.GetName.CultureName", .CultureName)
                    Template.FieldNamedReplace("ExecutingAssembly.GetName.GetPublicKey", .GetPublicKey.ToString)
                    Template.FieldNamedReplace("ExecutingAssembly.GetName.GetPublicKeyToken", .GetPublicKeyToken.ToString)
                    Template.FieldNamedReplace("ExecutingAssembly.GetName.Version", .Version.ToString)
                    Template.FieldNamedReplace("ExecutingAssembly.GetName.VersionCompatibility", .VersionCompatibility.ToString)
                    Template.FieldNamedReplace("ExecutingAssembly.GetName.ContentType", .ContentType.ToString)
                    Template.FieldNamedReplace("ExecutingAssembly.GetName.Flags", .Flags.ToString)
                    Template.FieldNamedReplace("ExecutingAssembly.GetName.ProcessorArchitecture", .ProcessorArchitecture.ToString)
                    Template.FieldNamedReplace("ExecutingAssembly.GetName.Version", .Version.ToString)
                    With .CultureInfo
                        Template.FieldNamedReplace("ExecutingAssembly.GetName.CultureInfo.Name", .Name)
                        Template.FieldNamedReplace("ExecutingAssembly.GetName.CultureInfo.TwoLetterISOLanguageName", .TwoLetterISOLanguageName)
                        Template.FieldNamedReplace("ExecutingAssembly.GetName.CultureInfo.CultureTypes", .CultureTypes.ToString)
                        Template.FieldNamedReplace("ExecutingAssembly.GetName.CultureInfo.GetHashCode", .GetHashCode)
                    End With
                End With
                Template.FieldNamedReplace("ExecutingAssembly.DefinedTypes", .DefinedTypes.ListValues)
                Template.FieldNamedReplace("ExecutingAssembly.ExportedTypes", .ExportedTypes.ListValues)
                Template.FieldNamedReplace("ExecutingAssembly.GetExportedTypes", .GetExportedTypes.ListValues)
                Template.FieldNamedReplace("ExecutingAssembly.GetManifestResourceNames", .GetManifestResourceNames.ListValues)
                Template.FieldNamedReplace("ExecutingAssembly.GetReferencedAssemblies", .GetReferencedAssemblies.ListValues)
                Template.FieldNamedReplace("ExecutingAssembly.Modules", .Modules.ListValues)
                Template.FieldNamedReplace("ExecutingAssembly.GetLoadedModules", .GetLoadedModules.ListValues)
                Template.FieldNamedReplace("ExecutingAssembly.CustomAttributes", "CustomAttributes".ReferenceToNumbered)        ' reference
                Template.FieldNamedReplace("ExecutingAssembly.EntryPoint.Name", .EntryPoint.Name)
                Template.FieldNamedReplace("Assembly.GetEntryAssembly.FullName", Assembly.GetEntryAssembly.FullName)
                Template.FieldNamedReplace("Assembly.GetCallingAssembly.GetName.FullName", Assembly.GetCallingAssembly.GetName.FullName)
                Template.FieldNamedReplace("ExecutingAssembly.GetSatelliteAssembly(.GetName.CultureInfo).FullName", .GetSatelliteAssembly(.GetName.CultureInfo).FullName)
                Template.FieldNamedReplace("ExecutingAssembly.GlobalAssemblyCache", "GlobalAssemblyCache is deprecated")
                Template.FieldNamedReplace("ExecutingAssembly.ManifestModule.FullyQualifiedName", .ManifestModule.FullyQualifiedName)
            End With
            With AppDomain.CurrentDomain()
                Template.FieldNamedReplace("CurrentDomain.BaseDirectory", .BaseDirectory)
                Template.FieldNamedReplace("CurrentDomain.DynamicDirectory", .DynamicDirectory)
                Template.FieldNamedReplace("CurrentDomain.FriendlyName", .FriendlyName)
                Template.FieldNamedReplace("CurrentDomain.Id", .Id)
                Template.FieldNamedReplace("CurrentDomain.IsFullyTrusted", .IsFullyTrusted)
                Template.FieldNamedReplace("CurrentDomain.IsHomogenous", .IsHomogenous)
                Template.FieldNamedReplace("CurrentDomain.RelativeSearchPath", .RelativeSearchPath)
                Template.FieldNamedReplace("CurrentDomain.ShadowCopyFiles", .ShadowCopyFiles)
                Template.FieldNamedReplace("CurrentDomain.GetHashCode", .GetHashCode)
                Template.FieldNamedReplace("CurrentDomain.GetType", .GetType.FullName)
                Template.FieldNamedReplace("CurrentDomain.GetType", .GetType.Name)
                Template.FieldNamedReplace("CurrentDomain.IsDefaultAppDomain", .IsDefaultAppDomain)
                Template.FieldNamedReplace("CurrentDomain.IsFinalizingForUnload", .IsFinalizingForUnload)
                With .SetupInformation
                    Template.FieldNamedReplace("CurrentDomain.ApplicationBase", .ApplicationBase)
                    Template.FieldNamedReplace("CurrentDomain.TargetFrameworkName", .TargetFrameworkName)
                End With
                Template.FieldNamedReplace("CurrentDomain.IsFinalizingForUnload", .ApplyPolicy(Assembly.GetExecutingAssembly.GetName.Name))
                Template.FieldNamedReplace("CurrentDomain.IsFinalizingForUnload", .MonitoringSurvivedMemorySize)
                Template.FieldNamedReplace("CurrentDomain.IsFinalizingForUnload", .MonitoringTotalAllocatedMemorySize)
                Template.FieldNamedReplace("CurrentDomain.IsFinalizingForUnload", .MonitoringTotalProcessorTime.ToString)

                Template.FieldNamedReplace("CurrentDomain.IsFinalizingForUnload", .ReflectionOnlyGetAssemblies.ListValues)
                Template.FieldNamedReplace("CurrentDomain.IsFinalizingForUnload", .GetAssemblies.ListValues)
                Template.FieldNamedReplace("CurrentDomain.IsFinalizingForUnload", .ReflectionOnlyGetAssemblies.ListValues)

                Template.FieldNamedReplace("CurrentDomain.IsFinalizingForUnload", "CurrentDomain.PermissionSet".IsNotRecommended)

                Template.FieldNamedReplace("CurrentDomain.IsFinalizingForUnload", "CurrentDomain.GetData".ReferenceToNumbered)
                Template.FieldNamedReplace("CurrentDomain.IsFinalizingForUnload", "CurrentDomain.GetLifetimeService".ReferenceToNumbered)
                Template.FieldNamedReplace("CurrentDomain.IsFinalizingForUnload", "CurrentDomain.IsCompatibilitySwitchSet".ReferenceToNumbered)
            End With
        End Sub
        Public Overloads Sub TemplateReplace(type As Type) Implements IEventLogging.TemplateReplace
            With type
                With .Module
                    Template.FieldNamedReplace("module.Name", .Name)
                    Template.FieldNamedReplace("module.ScopeName", .ScopeName)
                    Template.FieldNamedReplace("module.FullyQualifiedName", .FullyQualifiedName)
                    Template.FieldNamedReplace("module.FullyQualifiedName", .MetadataToken)
                    Template.FieldNamedReplace("module.MDStreamVersion", .MDStreamVersion)
                    Template.FieldNamedReplace("module.MetadataToken", .MetadataToken)
                    Template.FieldNamedReplace("module.ModuleVersionId", .ModuleVersionId.ToString)
                    Template.FieldNamedReplace("module.GetModuleVersionId", .GetModuleVersionId.ToString)
                    Template.FieldNamedReplace("module.GetHashCode", .GetHashCode)
                    Template.FieldNamedReplace("module.HasModuleVersionId", .HasModuleVersionId)
                    Template.FieldNamedReplace("module.FullyQualifiedName", .IsResource)
                End With
                With .GetTypeInfo
                    Template.FieldNamedReplace("typeinfo.Name", .Name)
                    Template.FieldNamedReplace("typeinfo.FullName", .FullName)
                    Template.FieldNamedReplace("typeinfo.AssemblyQualifiedName", .AssemblyQualifiedName)
                    Template.FieldNamedReplace("typeinfo.GUID", .GUID.ToString)
                    Template.FieldNamedReplace("typeinfo.GetMetadataToken", .GetMetadataToken)
                    Template.FieldNamedReplace("typeinfo.MetadataToken", .MetadataToken)
                    Template.FieldNamedReplace("typeinfo.Namespace", .Namespace)
                    Template.FieldNamedReplace("typeinfo.BaseType.Name", .BaseType.Name)
                    Template.FieldNamedReplace("typeinfo.HasElementType", .HasElementType)
                    Template.FieldNamedReplace("typeinfo.IsAbstract", .IsAbstract)
                    Template.FieldNamedReplace("typeinfo.IsAnsiClass", .IsAnsiClass)
                    Template.FieldNamedReplace("typeinfo.IsArray", .IsArray)
                    Template.FieldNamedReplace("typeinfo.IsAutoClass", .IsAutoClass)
                    Template.FieldNamedReplace("typeinfo.IsAutoLayout", .IsAutoLayout)
                    Template.FieldNamedReplace("typeinfo.IsByRef", .IsByRef)
                    Template.FieldNamedReplace("typeinfo.IsByRefLike", .IsByRefLike)
                    Template.FieldNamedReplace("typeinfo.IsClass", .IsClass)
                    Template.FieldNamedReplace("typeinfo.IsCollectible", .IsCollectible)
                    Template.FieldNamedReplace("typeinfo.IsCOMObject", .IsCOMObject)
                    Template.FieldNamedReplace("typeinfo.IsConstructedGenericType", .IsConstructedGenericType)
                    Template.FieldNamedReplace("typeinfo.IsContextful", .IsContextful)
                    Template.FieldNamedReplace("typeinfo.IsEnum", .IsEnum)
                    Template.FieldNamedReplace("typeinfo.IsExplicitLayout", .IsExplicitLayout)
                    Template.FieldNamedReplace("typeinfo.IsGenericMethodParameter", .IsGenericMethodParameter)
                    Template.FieldNamedReplace("typeinfo.IsGenericParameter", .IsGenericParameter)
                    Template.FieldNamedReplace("typeinfo.IsGenericType", .IsGenericType)
                    Template.FieldNamedReplace("typeinfo.IsGenericTypeDefinition", .IsGenericTypeDefinition)
                    Template.FieldNamedReplace("typeinfo.IsGenericTypeParameter", .IsGenericTypeParameter)
                    Template.FieldNamedReplace("typeinfo.IsConstructedGenericType", .IsConstructedGenericType)
                    Template.FieldNamedReplace("typeinfo.IsContextful", .IsContextful)
                    Template.FieldNamedReplace("typeinfo.IsImport", .IsImport)
                    Template.FieldNamedReplace("typeinfo.IsInterface", .IsInterface)
                    Template.FieldNamedReplace("typeinfo.IsSignatureType", .IsSignatureType)
                    Template.FieldNamedReplace("typeinfo.IsLayoutSequential", .IsLayoutSequential)
                    Template.FieldNamedReplace("typeinfo.IsMarshalByRef", .IsMarshalByRef)
                    Template.FieldNamedReplace("typeinfo.IsNested", .IsNested)
                    Template.FieldNamedReplace("typeinfo.IsNestedAssembly", .IsNestedAssembly)
                    Template.FieldNamedReplace("typeinfo.IsNestedFamANDAssem", .IsNestedFamANDAssem)
                    Template.FieldNamedReplace("typeinfo.IsNestedFamily", .IsNestedFamily)
                    Template.FieldNamedReplace("typeinfo.IsNestedPrivate", .IsNestedPrivate)
                    Template.FieldNamedReplace("typeinfo.IsNestedPublic", .IsNestedPublic)
                    Template.FieldNamedReplace("typeinfo.IsNotPublic", .IsNotPublic)
                    Template.FieldNamedReplace("typeinfo.IsPointer", .IsPointer)
                    Template.FieldNamedReplace("typeinfo.IsPrimitive", .IsPrimitive)
                    Template.FieldNamedReplace("typeinfo.IsPublic", .IsPublic)
                    Template.FieldNamedReplace("typeinfo.IsSpecialName", .IsSpecialName)
                    Template.FieldNamedReplace("typeinfo.IsSealed", .IsSealed)
                    Template.FieldNamedReplace("typeinfo.IsSecuritySafeCritical", .IsSecuritySafeCritical)
                    Template.FieldNamedReplace("typeinfo.IsSecurityTransparent", .IsSecurityTransparent)
                    Template.FieldNamedReplace("typeinfo.IsSerializable", .IsSerializable)
                    Template.FieldNamedReplace("typeinfo.IsSignatureType", .IsSignatureType)
                    Template.FieldNamedReplace("typeinfo.IsSZArray", .IsSZArray)
                    Template.FieldNamedReplace("typeinfo.GetArrayRank", .GetArrayRank)
                End With
            End With
        End Sub
        Public Overloads Sub TemplateReplace(methodinfo As MethodInfo) Implements IEventLogging.TemplateReplace
            With methodinfo
                Template.FieldNamedReplace("methodinfo.Name", .Name)
                Template.FieldNamedReplace("methodinfo.GetHashCode", .GetHashCode)
                Template.FieldNamedReplace("methodinfo.HasMetadataToken", .HasMetadataToken)
                Template.FieldNamedReplace("methodinfo.GetMetadataToken", .GetMetadataToken)
                Template.FieldNamedReplace("methodinfo.MetadataToken", .MetadataToken)

                Template.FieldNamedReplace("methodinfo.GetType", .GetType.FullName)
                Template.FieldNamedReplace("methodinfo.GetRuntimeBaseDefinition.Name", .GetRuntimeBaseDefinition.Name)
                Template.FieldNamedReplace("methodinfo.GetBaseDefinition", .GetBaseDefinition.Name)
                Template.FieldNamedReplace("methodinfo.GetCurrentMethod", MethodInfo.GetCurrentMethod.DeclaringType.FullName)

                Template.FieldNamedReplace("methodinfo.Attributes", .Attributes)
                Template.FieldNamedReplace("methodinfo.CallingConvention", .CallingConvention)
                Template.FieldNamedReplace("methodinfo.ContainsGenericParameters", .ContainsGenericParameters)
                Template.FieldNamedReplace("methodinfo.MemberType", .MemberType)
                Template.FieldNamedReplace("methodinfo.MethodImplementationFlags", .MethodImplementationFlags)
                Template.FieldNamedReplace("methodinfo.GetMethodImplementationFlags", .GetMethodImplementationFlags)

                Template.FieldNamedReplace("methodinfo.IsAbstract", .IsAbstract)
                Template.FieldNamedReplace("methodinfo.IsAssembly", .IsAssembly)
                Template.FieldNamedReplace("methodinfo.IsCollectible", .IsCollectible)
                Template.FieldNamedReplace("methodinfo.IsConstructor", .IsConstructor)
                Template.FieldNamedReplace("methodinfo.IsFamily", .IsFamily)
                Template.FieldNamedReplace("methodinfo.IsFamilyAndAssembly", .IsFamilyAndAssembly)
                Template.FieldNamedReplace("methodinfo.IsFamilyOrAssembly", .IsFamilyOrAssembly)
                Template.FieldNamedReplace("methodinfo.IsFinal", .IsFinal)
                Template.FieldNamedReplace("methodinfo.IsGenericMethod", .IsGenericMethod)
                Template.FieldNamedReplace("methodinfo.IsGenericMethodDefinition", .IsGenericMethodDefinition)
                Template.FieldNamedReplace("methodinfo.IsHideBySig", .IsHideBySig)
                Template.FieldNamedReplace("methodinfo.IsPrivate", .IsPrivate)
                Template.FieldNamedReplace("methodinfo.IsPublic", .IsPublic)
                Template.FieldNamedReplace("methodinfo.IsSecurityCritical", .IsSecurityCritical)
                Template.FieldNamedReplace("methodinfo.IsSecuritySafeCritical", .IsSecuritySafeCritical)
                Template.FieldNamedReplace("methodinfo.IsSpecialName", .IsSpecialName)
                Template.FieldNamedReplace("methodinfo.IsStatic", .IsStatic)
                Template.FieldNamedReplace("methodinfo.IsVirtual", .IsVirtual)
                Template.FieldNamedReplace("methodinfo.IsConstructedGenericMethod", .IsConstructedGenericMethod)

                Template.FieldNamedReplace("methodinfo.CustomAttributes", "methodinfo.CustomAttributes".ReferenceToNumbered)

                Template.FieldNamedReplace("methodinfo.DeclaringType", .DeclaringType.FullName)
                Template.FieldNamedReplace("methodinfo.ReflectedType", .ReflectedType.FullName)
                Template.FieldNamedReplace("methodinfo.ReturnType", .ReturnType.FullName)




                Template.FieldNamedReplace("methodinfo.ReturnParameter", .ReturnParameter.ParameterType.FullName)
                Template.FieldNamedReplace("methodinfo.Module", .Module.FullyQualifiedName)
                Template.FieldNamedReplace("methodinfo.Module", .Module.ScopeName)
                Template.FieldNamedReplace("methodinfo.Module", .Module.ResolveString(.GetMetadataToken))
                Template.FieldNamedReplace("methodinfo.ReturnParameter", .ReturnParameter.Name)
                Template.FieldNamedReplace("methodinfo.ReturnParameter", .ReturnParameter.DefaultValue.ToString)
                Template.FieldNamedReplace("methodinfo.ReturnParameter", .ReturnParameter.DefaultValue.GetType.FullName)
                Template.FieldNamedReplace("methodinfo.ReturnParameter", .ReturnParameter.Position)
                Template.FieldNamedReplace("methodinfo.ReturnParameter", .ReturnParameter.Attributes)

                Template.FieldNamedReplace("methodinfo.GetGenericArguments", .GetGenericArguments.ListValues)

                Template.FieldNamedReplace("methodinfo.GetGenericMethodDefinition", .GetGenericMethodDefinition.Name)
                Template.FieldNamedReplace("methodinfo.GetGenericMethodDefinition", .GetGenericMethodDefinition.DeclaringType.FullName)

                Template.FieldNamedReplace("methodinfo.GetParameters", .GetParameters.ListValues)

                Template.FieldNamedReplace("methodinfo.HasSameMetadataDefinitionAs", ".HasSameMetadataDefinitionAs".ReferenceToNumbered)
                Template.FieldNamedReplace("methodinfo.GetMethodFromHandle", ".GetMethodFromHandle".ReferenceToNumbered)
                Template.FieldNamedReplace("methodinfo.GetMethodBody", ".GetMethodBody".ReferenceToNumbered)
                Template.FieldNamedReplace("methodinfo.IsDefined", "methodinfo.IsDefined".ReferenceToNumbered)
                Template.FieldNamedReplace("methodinfo.ReturnTypeCustomAttributes", "methodinfo.ReturnTypeCustomAttributes".ReferenceToNumbered)
                Template.FieldNamedReplace("methodinfo.MethodHandle", "methodinfo.MethodHandle".ReferenceToNumbered)
                Template.FieldNamedReplace("methodinfo.GetCustomAttributes", "methodinfo.GetCustomAttributes".ReferenceToNumbered)
                Template.FieldNamedReplace("methodinfo.GetCustomAttributesData", "methodinfo.GetCustomAttributesData)".ReferenceToNumbered)
                Template.FieldNamedReplace("methodinfo.GetCustomAttribute", ".GetCustomAttribute".ReferenceToNumbered)
            End With
        End Sub

        Public Overloads Sub TemplateReplace(activity As Activity) Implements IEventLogging.TemplateReplace
            Throw New NotImplementedException()
        End Sub

        Public Overloads Sub TemplateReplace(activitycontext As ActivityContext) Implements IEventLogging.TemplateReplace
            Throw New NotImplementedException()
        End Sub

        Public Overloads Sub TemplateReplace(activityevent As ActivityEvent) Implements IEventLogging.TemplateReplace
            Throw New NotImplementedException()
        End Sub

        Public Overloads Sub TemplateReplace(typeinfo As TypeInfo) Implements IEventLogging.TemplateReplace
            Throw New NotImplementedException()
        End Sub

        Public Overloads Sub TemplateReplace(eventinfo As EventInfo) Implements IEventLogging.TemplateReplace
            Throw New NotImplementedException()
        End Sub

        Public Overloads Sub TemplateReplace(fieldinfo As FieldInfo) Implements IEventLogging.TemplateReplace
            Throw New NotImplementedException()
        End Sub

        Public Overloads Sub TemplateReplace(imagefilemachine As ImageFileMachine) Implements IEventLogging.TemplateReplace
            Throw New NotImplementedException()
        End Sub

        Public Overloads Sub TemplateReplace(reflect As IReflect) Implements IEventLogging.TemplateReplace
            Throw New NotImplementedException()
        End Sub

        Public Overloads Sub TemplateReplace(manifestresourceinfo As ManifestResourceInfo) Implements IEventLogging.TemplateReplace
            Throw New NotImplementedException()
        End Sub

        Public Overloads Sub TemplateReplace(memberinfo As MemberInfo) Implements IEventLogging.TemplateReplace
            Throw New NotImplementedException()
        End Sub

        Public Overloads Sub TemplateReplace(methodbase As MethodBase) Implements IEventLogging.TemplateReplace
            Throw New NotImplementedException()
        End Sub

        Public Overloads Sub TemplateReplace(methodbody As MethodBody) Implements IEventLogging.TemplateReplace
            Throw New NotImplementedException()
        End Sub

        Public Overloads Sub TemplateReplace(parameterinfo As ParameterInfo) Implements IEventLogging.TemplateReplace
            Throw New NotImplementedException()
        End Sub

        Public Overloads Sub TemplateReplace(propertyinfo As PropertyInfo) Implements IEventLogging.TemplateReplace
            Throw New NotImplementedException()
        End Sub

        Public Overloads Sub TemplateReplace(reflectioncontext As ReflectionContext) Implements IEventLogging.TemplateReplace
            Throw New NotImplementedException()
        End Sub
    End Class

End Namespace
