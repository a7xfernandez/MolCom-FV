@Code
    ViewData("Title") = "Register"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Register</h2>


@Html.ValidationSummary(True)

@Using (Html.BeginForm())

    @Html.EditorForModel()
    @<p>
        <button type = "submit" > Register</button>
         <a href="@Url.Action("login", "auth")">Inciar Sesión</a>
    </p>
End Using