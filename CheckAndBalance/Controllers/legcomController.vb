Imports System.Net
Imports System.Web.Mvc
Imports CheckAndBalance.myLegislation

Namespace Controllers
    Public Class legcomController
        Inherits System.Web.Mvc.Controller

        Private db As New legislationModel

        ' GET: legcom
        Function Index() As ActionResult
            Return View(db.myLeg.ToList())
        End Function

        ' GET: legislations/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim legislation As legislation = db.myLeg.Find(id)
            If IsNothing(legislation) Then
                Return HttpNotFound()
            End If
            Return View(legislation)
        End Function
    End Class
End Namespace