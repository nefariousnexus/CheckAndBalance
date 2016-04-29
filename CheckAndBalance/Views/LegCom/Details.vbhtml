@modeltype CheckAndBalance.myLegislation.legislation
@Code
    ViewData("Title") = "Details"
End Code

<h2>@Html.DisplayFor(Function(model) model.legNum)</h2>

<h3>@Html.DisplayFor(Function(model) model.legTitle)</h3>

<div class="row">
    <div class="col-sm-8"><p>@Html.DisplayFor(Function(model) model.legFullText)</p></div>
    <div class="col-sm-4">
        <div class="well"><p>@Html.DisplayFor(Function(model) model.legTitle)</p></div>
    </div>
</div>