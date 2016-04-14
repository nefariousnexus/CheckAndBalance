@ModelType CheckAndBalance.myLegislation.legislation
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>legislation</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.legTitle)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.legTitle)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.legNum)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.legNum)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.legFullText)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.legFullText)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.legID }) |
    @Html.ActionLink("Back to List", "Index")
</p>
