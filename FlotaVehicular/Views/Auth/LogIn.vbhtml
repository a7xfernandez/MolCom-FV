@Code
    ViewData("Title") = "Log In"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Log In</h2>

@Html.ValidationSummary(true)

@Using Html.BeginForm()

  @Html.EditorForModel()
  @<p>
    <button type = "submit" > Iniciar Sesión</button>
    <a href="@Url.Action("register", "auth")">Registrarse</a>
  </p>

End Using
