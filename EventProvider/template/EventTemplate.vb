Imports System.Reflection

Namespace Template

    Public Class EventTemplate : Inherits EventTemplateAbstract : Implements IEventTemplate

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
        Public Overloads Sub Replace(type As Type) Implements IEventTemplate.Replace
            With type
                With .Module
                    Text.FieldNamedReplace("module.Name", .Name)
                    Text.FieldNamedReplace("module.ScopeName", .ScopeName)
                    Text.FieldNamedReplace("module.FullyQualifiedName", .FullyQualifiedName)
                    Text.FieldNamedReplace("module.FullyQualifiedName", .MetadataToken)
                    Text.FieldNamedReplace("module.MDStreamVersion", .MDStreamVersion)
                    Text.FieldNamedReplace("module.MetadataToken", .MetadataToken)
                    Text.FieldNamedReplace("module.ModuleVersionId", .ModuleVersionId.ToString)
                    Text.FieldNamedReplace("module.GetModuleVersionId", .GetModuleVersionId.ToString)
                    Text.FieldNamedReplace("module.GetHashCode", .GetHashCode)
                    Text.FieldNamedReplace("module.HasModuleVersionId", .HasModuleVersionId)
                    Text.FieldNamedReplace("module.FullyQualifiedName", .IsResource)
                End With
                With .GetTypeInfo
                    Text.FieldNamedReplace("typeinfo.Name", .Name)
                    Text.FieldNamedReplace("typeinfo.FullName", .FullName)
                    Text.FieldNamedReplace("typeinfo.AssemblyQualifiedName", .AssemblyQualifiedName)
                    Text.FieldNamedReplace("typeinfo.GUID", .GUID.ToString)
                    Text.FieldNamedReplace("typeinfo.GetMetadataToken", .GetMetadataToken)
                    Text.FieldNamedReplace("typeinfo.MetadataToken", .MetadataToken)
                    Text.FieldNamedReplace("typeinfo.Namespace", .Namespace)
                    Text.FieldNamedReplace("typeinfo.BaseType.Name", .BaseType.Name)
                    Text.FieldNamedReplace("typeinfo.HasElementType", .HasElementType)
                    Text.FieldNamedReplace("typeinfo.IsAbstract", .IsAbstract)
                    Text.FieldNamedReplace("typeinfo.IsAnsiClass", .IsAnsiClass)
                    Text.FieldNamedReplace("typeinfo.IsArray", .IsArray)
                    Text.FieldNamedReplace("typeinfo.IsAutoClass", .IsAutoClass)
                    Text.FieldNamedReplace("typeinfo.IsAutoLayout", .IsAutoLayout)
                    Text.FieldNamedReplace("typeinfo.IsByRef", .IsByRef)
                    Text.FieldNamedReplace("typeinfo.IsByRefLike", .IsByRefLike)
                    Text.FieldNamedReplace("typeinfo.IsClass", .IsClass)
                    Text.FieldNamedReplace("typeinfo.IsCollectible", .IsCollectible)
                    Text.FieldNamedReplace("typeinfo.IsCOMObject", .IsCOMObject)
                    Text.FieldNamedReplace("typeinfo.IsConstructedGenericType", .IsConstructedGenericType)
                    Text.FieldNamedReplace("typeinfo.IsContextful", .IsContextful)
                    Text.FieldNamedReplace("typeinfo.IsEnum", .IsEnum)
                    Text.FieldNamedReplace("typeinfo.IsExplicitLayout", .IsExplicitLayout)
                    Text.FieldNamedReplace("typeinfo.IsGenericMethodParameter", .IsGenericMethodParameter)
                    Text.FieldNamedReplace("typeinfo.IsGenericParameter", .IsGenericParameter)
                    Text.FieldNamedReplace("typeinfo.IsGenericType", .IsGenericType)
                    Text.FieldNamedReplace("typeinfo.IsGenericTypeDefinition", .IsGenericTypeDefinition)
                    Text.FieldNamedReplace("typeinfo.IsGenericTypeParameter", .IsGenericTypeParameter)
                    Text.FieldNamedReplace("typeinfo.IsConstructedGenericType", .IsConstructedGenericType)
                    Text.FieldNamedReplace("typeinfo.IsContextful", .IsContextful)
                    Text.FieldNamedReplace("typeinfo.IsImport", .IsImport)
                    Text.FieldNamedReplace("typeinfo.IsInterface", .IsInterface)
                    Text.FieldNamedReplace("typeinfo.IsSignatureType", .IsSignatureType)
                    Text.FieldNamedReplace("typeinfo.IsLayoutSequential", .IsLayoutSequential)
                    Text.FieldNamedReplace("typeinfo.IsMarshalByRef", .IsMarshalByRef)
                    Text.FieldNamedReplace("typeinfo.IsNested", .IsNested)
                    Text.FieldNamedReplace("typeinfo.IsNestedAssembly", .IsNestedAssembly)
                    Text.FieldNamedReplace("typeinfo.IsNestedFamANDAssem", .IsNestedFamANDAssem)
                    Text.FieldNamedReplace("typeinfo.IsNestedFamily", .IsNestedFamily)
                    Text.FieldNamedReplace("typeinfo.IsNestedPrivate", .IsNestedPrivate)
                    Text.FieldNamedReplace("typeinfo.IsNestedPublic", .IsNestedPublic)
                    Text.FieldNamedReplace("typeinfo.IsNotPublic", .IsNotPublic)
                    Text.FieldNamedReplace("typeinfo.IsPointer", .IsPointer)
                    Text.FieldNamedReplace("typeinfo.IsPrimitive", .IsPrimitive)
                    Text.FieldNamedReplace("typeinfo.IsPublic", .IsPublic)
                    Text.FieldNamedReplace("typeinfo.IsSpecialName", .IsSpecialName)
                    Text.FieldNamedReplace("typeinfo.IsSealed", .IsSealed)
                    Text.FieldNamedReplace("typeinfo.IsSecuritySafeCritical", .IsSecuritySafeCritical)
                    Text.FieldNamedReplace("typeinfo.IsSecurityTransparent", .IsSecurityTransparent)
                    Text.FieldNamedReplace("typeinfo.IsSerializable", .IsSerializable)
                    Text.FieldNamedReplace("typeinfo.IsSignatureType", .IsSignatureType)
                    Text.FieldNamedReplace("typeinfo.IsSZArray", .IsSZArray)
                    Text.FieldNamedReplace("typeinfo.GetArrayRank", .GetArrayRank)
                End With
            End With
        End Sub
        Public Overloads Sub Replace(methodinfo As MethodInfo) Implements IEventTemplate.Replace
            With methodinfo
                Text.FieldNamedReplace("methodinfo.Name", .Name)
                Text.FieldNamedReplace("methodinfo.GetHashCode", .GetHashCode)
                Text.FieldNamedReplace("methodinfo.HasMetadataToken", .HasMetadataToken)
                Text.FieldNamedReplace("methodinfo.GetMetadataToken", .GetMetadataToken)
                Text.FieldNamedReplace("methodinfo.MetadataToken", .MetadataToken)

                Text.FieldNamedReplace("methodinfo.GetType", .GetType.FullName)
                Text.FieldNamedReplace("methodinfo.GetRuntimeBaseDefinition.Name", .GetRuntimeBaseDefinition.Name)
                Text.FieldNamedReplace("methodinfo.GetBaseDefinition", .GetBaseDefinition.Name)
                Text.FieldNamedReplace("methodinfo.GetCurrentMethod", MethodInfo.GetCurrentMethod.DeclaringType.FullName)

                Text.FieldNamedReplace("methodinfo.Attributes", .Attributes)
                Text.FieldNamedReplace("methodinfo.CallingConvention", .CallingConvention)
                Text.FieldNamedReplace("methodinfo.ContainsGenericParameters", .ContainsGenericParameters)
                Text.FieldNamedReplace("methodinfo.MemberType", .MemberType)
                Text.FieldNamedReplace("methodinfo.MethodImplementationFlags", .MethodImplementationFlags)
                Text.FieldNamedReplace("methodinfo.GetMethodImplementationFlags", .GetMethodImplementationFlags)

                Text.FieldNamedReplace("methodinfo.IsAbstract", .IsAbstract)
                Text.FieldNamedReplace("methodinfo.IsAssembly", .IsAssembly)
                Text.FieldNamedReplace("methodinfo.IsCollectible", .IsCollectible)
                Text.FieldNamedReplace("methodinfo.IsConstructor", .IsConstructor)
                Text.FieldNamedReplace("methodinfo.IsFamily", .IsFamily)
                Text.FieldNamedReplace("methodinfo.IsFamilyAndAssembly", .IsFamilyAndAssembly)
                Text.FieldNamedReplace("methodinfo.IsFamilyOrAssembly", .IsFamilyOrAssembly)
                Text.FieldNamedReplace("methodinfo.IsFinal", .IsFinal)
                Text.FieldNamedReplace("methodinfo.IsGenericMethod", .IsGenericMethod)
                Text.FieldNamedReplace("methodinfo.IsGenericMethodDefinition", .IsGenericMethodDefinition)
                Text.FieldNamedReplace("methodinfo.IsHideBySig", .IsHideBySig)
                Text.FieldNamedReplace("methodinfo.IsPrivate", .IsPrivate)
                Text.FieldNamedReplace("methodinfo.IsPublic", .IsPublic)
                Text.FieldNamedReplace("methodinfo.IsSecurityCritical", .IsSecurityCritical)
                Text.FieldNamedReplace("methodinfo.IsSecuritySafeCritical", .IsSecuritySafeCritical)
                Text.FieldNamedReplace("methodinfo.IsSpecialName", .IsSpecialName)
                Text.FieldNamedReplace("methodinfo.IsStatic", .IsStatic)
                Text.FieldNamedReplace("methodinfo.IsVirtual", .IsVirtual)
                Text.FieldNamedReplace("methodinfo.IsConstructedGenericMethod", .IsConstructedGenericMethod)

                Text.FieldNamedReplace("methodinfo.CustomAttributes", "methodinfo.CustomAttributes".ReferenceToNumbered)

                Text.FieldNamedReplace("methodinfo.DeclaringType", .DeclaringType.FullName)
                Text.FieldNamedReplace("methodinfo.ReflectedType", .ReflectedType.FullName)
                Text.FieldNamedReplace("methodinfo.ReturnType", .ReturnType.FullName)




                Text.FieldNamedReplace("methodinfo.ReturnParameter", .ReturnParameter.ParameterType.FullName)
                Text.FieldNamedReplace("methodinfo.Module", .Module.FullyQualifiedName)
                Text.FieldNamedReplace("methodinfo.Module", .Module.ScopeName)
                Text.FieldNamedReplace("methodinfo.Module", .Module.ResolveString(.GetMetadataToken))
                Text.FieldNamedReplace("methodinfo.ReturnParameter", .ReturnParameter.Name)
                Text.FieldNamedReplace("methodinfo.ReturnParameter", .ReturnParameter.DefaultValue.ToString)
                Text.FieldNamedReplace("methodinfo.ReturnParameter", .ReturnParameter.DefaultValue.GetType.FullName)
                Text.FieldNamedReplace("methodinfo.ReturnParameter", .ReturnParameter.Position)
                Text.FieldNamedReplace("methodinfo.ReturnParameter", .ReturnParameter.Attributes)

                Text.FieldNamedReplace("methodinfo.GetGenericArguments", .GetGenericArguments.ListValues)

                Text.FieldNamedReplace("methodinfo.GetGenericMethodDefinition", .GetGenericMethodDefinition.Name)
                Text.FieldNamedReplace("methodinfo.GetGenericMethodDefinition", .GetGenericMethodDefinition.DeclaringType.FullName)

                Text.FieldNamedReplace("methodinfo.GetParameters", .GetParameters.ListValues)

                Text.FieldNamedReplace("methodinfo.HasSameMetadataDefinitionAs", ".HasSameMetadataDefinitionAs".ReferenceToNumbered)
                Text.FieldNamedReplace("methodinfo.GetMethodFromHandle", ".GetMethodFromHandle".ReferenceToNumbered)
                Text.FieldNamedReplace("methodinfo.GetMethodBody", ".GetMethodBody".ReferenceToNumbered)
                Text.FieldNamedReplace("methodinfo.IsDefined", "methodinfo.IsDefined".ReferenceToNumbered)
                Text.FieldNamedReplace("methodinfo.ReturnTypeCustomAttributes", "methodinfo.ReturnTypeCustomAttributes".ReferenceToNumbered)
                Text.FieldNamedReplace("methodinfo.MethodHandle", "methodinfo.MethodHandle".ReferenceToNumbered)
                Text.FieldNamedReplace("methodinfo.GetCustomAttributes", "methodinfo.GetCustomAttributes".ReferenceToNumbered)
                Text.FieldNamedReplace("methodinfo.GetCustomAttributesData", "methodinfo.GetCustomAttributesData)".ReferenceToNumbered)
                Text.FieldNamedReplace("methodinfo.GetCustomAttribute", ".GetCustomAttribute".ReferenceToNumbered)
            End With
        End Sub

        Public Overloads Sub Replace(activity As Activity) Implements IEventTemplate.Replace
            Throw New NotImplementedException()
        End Sub

        Public Overloads Sub Replace(activitycontext As ActivityContext) Implements IEventTemplate.Replace
            Throw New NotImplementedException()
        End Sub

        Public Overloads Sub Replace(activityevent As ActivityEvent) Implements IEventTemplate.Replace
            Throw New NotImplementedException()
        End Sub

        Public Overloads Sub Replace(typeinfo As TypeInfo) Implements IEventTemplate.Replace
            Throw New NotImplementedException()
        End Sub

        Public Overloads Sub Replace(eventinfo As EventInfo) Implements IEventTemplate.Replace
            Throw New NotImplementedException()
        End Sub

        Public Overloads Sub Replace(fieldinfo As FieldInfo) Implements IEventTemplate.Replace
            Throw New NotImplementedException()
        End Sub

        Public Overloads Sub Replace(imagefilemachine As ImageFileMachine) Implements IEventTemplate.Replace
            Throw New NotImplementedException()
        End Sub

        Public Overloads Sub Replace(reflect As IReflect) Implements IEventTemplate.Replace
            Throw New NotImplementedException()
        End Sub

        Public Overloads Sub Replace(manifestresourceinfo As ManifestResourceInfo) Implements IEventTemplate.Replace
            Throw New NotImplementedException()
        End Sub

        Public Overloads Sub Replace(memberinfo As MemberInfo) Implements IEventTemplate.Replace
            Throw New NotImplementedException()
        End Sub

        Public Overloads Sub Replace(methodbase As MethodBase) Implements IEventTemplate.Replace
            Throw New NotImplementedException()
        End Sub

        Public Overloads Sub Replace(methodbody As MethodBody) Implements IEventTemplate.Replace
            Throw New NotImplementedException()
        End Sub

        Public Overloads Sub Replace(parameterinfo As ParameterInfo) Implements IEventTemplate.Replace
            Throw New NotImplementedException()
        End Sub

        Public Overloads Sub Replace(propertyinfo As PropertyInfo) Implements IEventTemplate.Replace
            Throw New NotImplementedException()
        End Sub

        Public Overloads Sub Replace(reflectioncontext As ReflectionContext) Implements IEventTemplate.Replace
            Throw New NotImplementedException()
        End Sub
    End Class

End Namespace