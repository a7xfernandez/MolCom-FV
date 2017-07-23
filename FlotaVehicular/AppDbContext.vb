Imports Microsoft.AspNet.Identity.EntityFramework

Public Class AppDbContext
    Inherits IdentityDbContext(Of AppUser)
    Public Sub New()
        MyBase.New("DefaultConnection")
    End Sub
End Class
