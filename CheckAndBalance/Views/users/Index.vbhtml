@ModelType IEnumerable(Of CheckAndBalance.myLegislation.user)
@Code
ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.userName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.userPass)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.userFName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.userLName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.userPerm)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.userName)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.userPass)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.userFName)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.userLName)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.userPerm)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.userID }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.userID }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.userID })
        </td>
    </tr>
Next

</table>
