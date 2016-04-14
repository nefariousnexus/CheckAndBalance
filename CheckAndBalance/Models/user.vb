Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Namespace myLegislation
    Public Class user
        <Key>
        Public Property userID As Integer
        Public Property userName As String
        Public Property userPass As String
        Public Property userFName As String
        Public Property userLName As String
        Public Property userPerm As Integer
    End Class
End Namespace