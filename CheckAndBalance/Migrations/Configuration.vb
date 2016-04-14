Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Migrations
Imports System.Linq

Namespace Migrations

    Friend NotInheritable Class Configuration 
        Inherits DbMigrationsConfiguration(Of myLegislation.legislationModel)

        Public Sub New()
            AutomaticMigrationsEnabled = True
            ContextKey = "CheckAndBalance.myLegislation.legislationModel"
        End Sub

        Protected Overrides Sub Seed(context As myLegislation.legislationModel)
            '  This method will be called after migrating to the latest version.

            '  You can use the DbSet(Of T).AddOrUpdate() helper extension method 
            '  to avoid creating duplicate seed data. E.g.
            '
            '    context.People.AddOrUpdate(
            '       Function(c) c.FullName,
            '       New Customer() With {.FullName = "Andrew Peters"},
            '       New Customer() With {.FullName = "Brice Lambson"},
            '       New Customer() With {.FullName = "Rowan Miller"})

            context.myLeg.AddOrUpdate(
                Function(c) c.legTitle,
                New myLegislation.legislation() With {.legID = 1, .legTitle = "Test Legislation 1", .legNum = "HR1111", .legFullText = "Important legislation text."},
                New myLegislation.legislation() With {.legID = 2, .legTitle = "Test Legislation 2", .legNum = "HB2222", .legFullText = "Important legislation text."},
                New myLegislation.legislation() With {.legID = 3, .legTitle = "Test Legislation 3", .legNum = "SR3333", .legFullText = "Important legislation text."})
            context.myUser.AddOrUpdate(
                Function(c) c.userName,
                New myLegislation.user() With {.userID = 1, .userName = "j.picard", .userPass = "makeitso", .userFName = "Jean-Luc", .userLName = "Picard", .userPerm = 1},
                New myLegislation.user() With {.userID = 2, .userName = "w.riker", .userPass = "redalert", .userFName = "William", .userLName = "Riker", .userPerm = 2},
                New myLegislation.user() With {.userID = 3, .userName = "d.soong", .userPass = "affirmative", .userFName = "Data", .userLName = "Soong", .userPerm = 3})
            context.myComment.AddOrUpdate(
                Function(c) c.comSelectedText,
                New myLegislation.comment() With {.comID = 1, .comSelectedText = "legislation text", .comFullText = "Comment on legislation.", .comAuthor = 1, .comLegislation = 1},
                New myLegislation.comment() With {.comID = 2, .comSelectedText = "legislation text", .comFullText = "Comment on legislation.", .comAuthor = 2, .comLegislation = 2},
                New myLegislation.comment() With {.comID = 3, .comSelectedText = "legislation text", .comFullText = "Comment on legislation.", .comAuthor = 3, .comLegislation = 3})
            context.myPerm.AddOrUpdate(
                New myLegislation.permission() With {.permID = 1, .permName = "Alpha", .permLevel = 1},
                New myLegislation.permission() With {.permID = 2, .permName = "Bravo", .permLevel = 2},
                New myLegislation.permission() With {.permID = 3, .permName = "Charlie", .permLevel = 3})
            context.SaveChanges()
        End Sub

    End Class

End Namespace
