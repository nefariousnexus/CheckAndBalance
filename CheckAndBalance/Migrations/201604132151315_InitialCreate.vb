Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class InitialCreate
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.legislations",
                Function(c) New With
                    {
                        .legID = c.Int(nullable := False, identity := True),
                        .legTitle = c.String(),
                        .legNum = c.String(),
                        .legFullText = c.String()
                    }) _
                .PrimaryKey(Function(t) t.legID)
            
        End Sub
        
        Public Overrides Sub Down()
            DropTable("dbo.legislations")
        End Sub
    End Class
End Namespace
