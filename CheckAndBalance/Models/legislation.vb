Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Namespace myLegislation
    Public Class legislation
        Public Sub New()
            Me.comments = New List(Of comment)
        End Sub
        <Key>
        Public Property legID As Integer
        <Display(Name:="Title")>
        Public Property legTitle As String
        <Display(Name:="Number")>
        Public Property legNum As String
        <AllowHtml>
        <DataType(DataType.MultilineText)>
        <Display(Name:="Full Text")>
        Public Property legFullText As String
        Public Overridable Property comments As ICollection(Of comment)
    End Class
End Namespace