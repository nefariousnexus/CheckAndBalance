Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Namespace myLegislation
    Public Class comment
        <Key>
        Public Property comID As Integer
        Public Property comSelectedText As String
        Public Property comFullText As String
        Public Property comAuthor As String
        Public Property comLegislation As Integer
    End Class
End Namespace