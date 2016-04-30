Imports System.Net
Imports System.Web.Mvc
Imports CheckAndBalance.myLegislation

Namespace Controllers
    Public Class legComController
        Inherits System.Web.Mvc.Controller

        Private db As New legislationModel

        ' GET: legCom
        Function Index() As ActionResult
            Return View(db.myLeg.ToList())
        End Function

        ' GET: legCom/Details/5
        Function Details(ByVal id As Integer) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim legislation As legislation = db.myLeg.Find(id)
            If IsNothing(legislation) Then
                Return HttpNotFound()
            End If
            Return View(legislation)
        End Function

        ' GET: legCom/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: legCom/Create
        <HttpPost()>
        Function Create(ByVal collection As FormCollection) As ActionResult
            Try
                ' TODO: Add insert logic here

                Return RedirectToAction("Index")
            Catch
                Return View()
            End Try
        End Function

        ' GET: legCom/Edit/5
        Function Edit(ByVal id As Integer) As ActionResult
            Return View()
        End Function

        ' POST: legCom/Edit/5
        <HttpPost()>
        Function Edit(ByVal id As Integer, ByVal collection As FormCollection) As ActionResult
            Try
                ' TODO: Add update logic here

                Return RedirectToAction("Index")
            Catch
                Return View()
            End Try
        End Function

        ' GET: legCom/Delete/5
        Function Delete(ByVal id As Integer) As ActionResult
            Return View()
        End Function

        ' POST: legCom/Delete/5
        <HttpPost()>
        Function Delete(ByVal id As Integer, ByVal collection As FormCollection) As ActionResult
            Try
                ' TODO: Add delete logic here

                Return RedirectToAction("Index")
            Catch
                Return View()
            End Try
        End Function
    End Class
End Namespace