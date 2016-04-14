@ModelType CheckAndBalance.myLegislation.legislation
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
