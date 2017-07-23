Imports System.Security.Claims
Imports Microsoft.AspNet.Identity.EntityFramework

Public Class AppUser
    Inherits IdentityUser

    'Public ReadOnly Property Name() As String
    '    Get
    '        Return Me.FindFirst(ClaimTypes.Name).Value
    '    End Get
    'End Property

    'Public ReadOnly Property Country() As String
    '    Get
    '        Return Me.FindFirst(ClaimTypes.Country).Value
    '    End Get
    'End Property
End Class
