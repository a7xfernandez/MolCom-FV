Imports Microsoft.AspNet.Identity
Imports Microsoft.AspNet.Identity.EntityFramework
Imports Microsoft.Owin
Imports Microsoft.Owin.Security.Cookies
Imports Owin

Public Class Startup
    Private Shared m_UserManagerFactory As Func(Of UserManager(Of AppUser))
    Public Shared Property UserManagerFactory() As Func(Of UserManager(Of AppUser))
        Get
            Return m_UserManagerFactory
        End Get
        Private Set
            m_UserManagerFactory = Value
        End Set
    End Property

    Public Sub Configuration(app As IAppBuilder)
        ' this is the same as before
        app.UseCookieAuthentication(New CookieAuthenticationOptions() With {
            .AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
            .LoginPath = New PathString("/auth/login")
        })

        ' configure the user manager
        UserManagerFactory = Function()
                                 Dim usermanager = New UserManager(Of AppUser)(New UserStore(Of AppUser)(New AppDbContext()))
                                 ' allow alphanumeric characters in username
                                 usermanager.UserValidator = New UserValidator(Of AppUser)(usermanager) With {
                                    .AllowOnlyAlphanumericUserNames = False
                                }

                                 ' use out custom claims provider
                                 usermanager.ClaimsIdentityFactory = New AppUserClaimsIdentityFactory()

                                 Return usermanager

                             End Function

    End Sub
End Class

