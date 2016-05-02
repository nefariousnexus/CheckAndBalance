Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Namespace myLegislation
    'This is the model for the Permissions table in the database.
    Public Class permission
        <Key>
        Public Property permID As Integer
        <Display(Name:="Permission Name")>
        Public Property permName As String
        <Display(Name:="Permission Level")>
        Public Property permLevel As Integer
    End Class
End Namespace