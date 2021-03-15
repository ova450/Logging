Imports System.Reflection
Imports System.Runtime.CompilerServices

Public Module EventTemplateFields

    <Extension>
    Public Sub FieldNumberedReplace(ByRef template As String, index As Integer, value As String, Optional prefix As String = "value")
        template.Replace($"<{prefix}{index}>", value)
    End Sub

    <Extension>
    Public Sub FieldNamedReplace1(ByRef template As String, field As String, f As Func(Of String))
        template.Replace($"<{field}>", f.Invoke)
    End Sub

    <Extension>
    Public Sub FieldNamedReplace(ByRef template As String, field As String, f As String)
        template.Replace($"<{field}>", f)
    End Sub

    <Extension>
    Public Function ListValues(list As IEnumerable(Of TypeInfo)) As String
        Dim str As String = String.Empty
        For Each value In list
            str &= $", { value.FullName }"
        Next
        Return Right(str, str.Length - 1)
    End Function

    <Extension>
    Public Function ListValues(list As IEnumerable(Of Type)) As String
        Dim str As String = String.Empty
        For Each value In list
            str &= $", { value.FullName }"
        Next
        Return Right(str, str.Length - 1)
    End Function

    <Extension>
    Public Function ListValues(list() As String) As String
        Dim str As String = String.Empty
        For Each value In list
            str &= $", { value }"
        Next
        Return Right(str, str.Length - 1)
    End Function

    <Extension>
    Public Function ListValues(list() As AssemblyName) As String
        Dim str As String = String.Empty
        For Each value In list
            str &= $", {value.FullName}"
        Next
        Return Right(str, str.Length - 1)
    End Function

    <Extension>
    Public Function ListValues(list() As Assembly) As String
        Dim str As String = String.Empty
        For Each value In list
            str &= $", {value.FullName}"
        Next
        Return Right(str, str.Length - 1)
    End Function

    <Extension>
    Public Function ListValues(list As IEnumerable(Of [Module])) As String
        Dim str As String = String.Empty
        For Each value In list
            str &= $", { value.Name }"
        Next
        Return Right(str, str.Length - 1)
    End Function

    <Extension>
    Public Function ListValues(list() As ParameterInfo) As String
        Dim str As String = String.Empty
        For Each value In list
            str &= $", {value.Name}"
        Next
        Return Right(str, str.Length - 1)
    End Function

    '<Extension>
    'Public Function ListValues(list As IEnumerable(Of CustomAttributeData)) As String
    '    Dim str As String = String.Empty
    '    For Each value In list
    '        str &= $", { value. }"
    '    Next
    '    Return Right(str, str.Length - 1)
    'End Function   
    Public Function ListValues(list() As [Module]) As String
        Dim str As String = String.Empty
        For Each value In list
            str &= $", {value.Name}"
        Next
        Return Right(str, str.Length - 1)
    End Function


    <Extension>
    Function ReferenceToNumbered(name As String)
        Return $"{name} must be loaded To FieldNumred fields, i.e. '<value1>',  '<value2>', etc."
    End Function

    <Extension>
    Function IsNotRecommended(name As String)
        Return $"{name} is not recommended by Microsoft"
    End Function

End Module


