@ModelType CheckAndBalance.myLegislation.legislation
@Code
    ViewData("Title") = "Details"
End Code

<h2>@Html.DisplayFor(Function(model) model.legNum) - @Html.DisplayFor(Function(model) model.legTitle)</h2>

<div class="row">
    <div class="col-sm-8"><p>@Html.DisplayFor(Function(model) model.legFullText)</p></div>
    <div class="col-sm-4">
        <div class="well">@Html.DisplayFor(Function(model) model.comments)</div>
    </div>
</div>
