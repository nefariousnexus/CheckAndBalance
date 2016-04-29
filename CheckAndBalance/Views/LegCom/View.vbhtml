@modeltype CheckAndBalance.myLegislation.legislation
@Code
    ViewData("Title") = "View"
End Code

<h2>@Html.DisplayFor(Function(model) model.legNum)</h2>

<h3>@Html.DisplayFor(Function(model) model.legTitle)</h3>

<p>@Html.DisplayFor(Function(model) model.legFullText)</p>