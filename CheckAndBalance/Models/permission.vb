Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Namespace myLegislation
    Public Class permission
        <Key>
        Public Property permID As Integer
        Public Property permName As String
        Public Property permLevel As Integer
    End Class
End Namespace