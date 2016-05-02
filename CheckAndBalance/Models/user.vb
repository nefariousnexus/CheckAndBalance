Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Namespace myLegislation
    'This is the model for the User table in the database.
    Public Class user
        <Key>
        Public Property userID As Integer
        <Display(Name:="Username")>
        Public Property userName As String
        <Display(Name:="Password")>
        Public Property userPass As String
        <Display(Name:="First Name")>
        Public Property userFName As String
        <Display(Name:="Last Name")>
        Public Property userLName As String
        <Display(Name:="Permission Level")>
        Public Property userPerm As Integer
    End Class
End Namespace