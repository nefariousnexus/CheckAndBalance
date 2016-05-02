Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

'This is the model for the Comments table in the database.
Namespace myLegislation
    Public Class comment
        <Key>
        Public Property comID As Integer
        <Display(Name:="Selected Text")>
        Public Property comSelectedText As String
        <Display(Name:="Comment")>
        Public Property comFullText As String
        <Display(Name:="Authors")>
        Public Property comAuthor As String
        <Display(Name:="Legislation")>
        Public Property comLegislation As Integer
    End Class
End Namespace