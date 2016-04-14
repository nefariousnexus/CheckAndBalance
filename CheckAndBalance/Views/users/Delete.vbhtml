@ModelType CheckAndBalance.myLegislation.user
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
