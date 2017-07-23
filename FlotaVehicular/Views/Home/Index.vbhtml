@Code
    ViewData("Title") = "Home Page"
End Code

<div class="jumbotron">
    <h1>ASP.NET</h1>
    <p>
        Hola @CurrentUser.Name
    </p>
    <p>
        <a href="@Url.Action("logout", "auth")">Salir</a>
    </p>
</div>