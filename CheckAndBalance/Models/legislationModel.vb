Imports System
Imports System.ComponentModel.DataAnnotations
Imports System.Data.Entity
Imports System.Linq
Imports System.ComponentModel.DataAnnotations.Schema

Namespace myLegislation
    Public Class legislationModel
        Inherits DbContext

        ' Your context has been configured to use a 'legislationModel' connection string from your application's 
        ' configuration file (App.config or Web.config). By default, this connection string targets the 
        ' 'CheckAndBalance.legislationModel' database on your LocalDb instance. 
        ' 
        ' If you wish to target a different database and/or database provider, modify the 'legislationModel' 
        ' connection string in the application configuration file.
        Public Sub New()
            MyBase.New("name=legislationModel")
        End Sub

        ' Add a DbSet for each entity type that you want to include in your model. For more information 
        ' on configuring and using a Code First model, see http:'go.microsoft.com/fwlink/?LinkId=390109.
        ' Public Overridable Property MyEntities() As DbSet(Of MyEntity)
        Public Overridable Property myLeg() As DbSet(Of legislation)
        Public Overridable Property myUser() As DbSet(Of user)
        Public Overridable Property myComment() As DbSet(Of comment)
        Public Overridable Property myPerm() As DbSet(Of permission)
    End Class

    'Public Class MyEntity
    '    Public Property Id() As Int32
    '    Public Property Name() As String
    'End Class
End Namespace
