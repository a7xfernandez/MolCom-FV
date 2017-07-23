Imports System.Security.Claims

Public Class AppUserPrincipal
    Inherits ClaimsPrincipal
    Public Sub New(principal As ClaimsPrincipal)
        MyBase.New(principal)
    End Sub

    Public ReadOnly Property Name() As String
        Get
            Return Me.FindFirst(ClaimTypes.Name).Value
        End Get
    End Property

    Public ReadOnly Property Country() As String
        Get
            Return Me.FindFirst(ClaimTypes.Country).Value
        End Get
    End Property
End Class
