Imports System.IO
Imports Microsoft.Extensions.Logging

Public Class Options

    Private _folder As String
    Private _MaxFileSizeInMB As UInteger = 2
    Private _RetainPolicyFileCount As Integer = 5

    Public Property LogLevel As LogLevel = LogLevel.Information

    Public Property Folder As String
        Get
            Return If(Not String.IsNullOrWhiteSpace(_folder), _folder, Path.GetDirectoryName(Me.[GetType]().Assembly.Location))
        End Get
        Set(ByVal value As String)
            _folder = value
        End Set
    End Property

    Public Property MaxFileSizeInMB As UInteger
        Get
            Return _MaxFileSizeInMB
        End Get
        Set(ByVal value As UInteger)
            _MaxFileSizeInMB = If(value > 0, value, _MaxFileSizeInMB)
        End Set
    End Property

    Public Property RetainPolicyFileCount As Integer
        Get
            Return _RetainPolicyFileCount
        End Get
        Set(ByVal value As Integer)
            _RetainPolicyFileCount = If(value > 5, value, _RetainPolicyFileCount)
        End Set
    End Property

End Class
