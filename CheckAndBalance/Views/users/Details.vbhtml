@ModelType CheckAndBalance.myLegislation.user
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>user</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.userName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.userName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.userPass)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.userPass)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.userFName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.userFName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.userLName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.userLName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.userPerm)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.userPerm)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.userID }) |
    @Html.ActionLink("Back to List", "Index")
</p>
