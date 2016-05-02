@ModelType IEnumerable(Of CheckAndBalance.myLegislation.legislation)
@Code
    ViewData("Title") = "Index"
End Code

<h2>Legislation</h2>
@* Table for displaying a list of Legislations. *@
<table class="table">
    @For Each item In Model
        @<tr>
            <td>
                @Html.DisplayFor(Function(modelItem) item.legNum)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.legTitle)
            </td>
            <td>
                @Html.ActionLink("View", "Details", New With {.id = item.legID})
            </td>
        </tr>
    Next
</table>

