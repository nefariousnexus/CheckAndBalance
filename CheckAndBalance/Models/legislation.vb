Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Namespace myLegislation
    Public Class legislation
        <Key>
        Public Property legID As Integer
        Public Property legTitle As String
        Public Property legNum As String
        Public Property legFullText As String
        Public Overridable Property comments As ICollection(Of comment)
    End Class
End Namespace