Imports Microsoft.AspNet.Identity
Imports System.Security.Claims
Imports System.Threading.Tasks

Public Class AppUserClaimsIdentityFactory
    Inherits ClaimsIdentityFactory(Of AppUser)
    Public Shadows Async Function CreateAsync(manager As UserManager(Of AppUser), user As AppUser, authenticationType As String) As Task(Of ClaimsIdentity)
        Dim identity = Await MyBase.CreateAsync(manager, user, authenticationType)
        'identity.AddClaim(New Claim(ClaimTypes.Country, user.Country))

        Return identity
    End Function
End Class
