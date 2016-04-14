@ModelType IEnumerable(Of CheckAndBalance.myLegislation.legislation)
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
            @Html.DisplayNameFor(Function(model) model.legTitle)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.legNum)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.legFullText)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.legTitle)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.legNum)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.legFullText)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.legID }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.legID }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.legID })
        </td>
    </tr>
Next

</table>
