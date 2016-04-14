Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports CheckAndBalance.myLegislation

Namespace Controllers
    Public Class legislationsController
        Inherits System.Web.Mvc.Controller

        Private db As New legislationModel

        ' GET: legislations
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

        ' GET: legislations/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: legislations/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="legID,legTitle,legNum,legFullText")> ByVal legislation As legislation) As ActionResult
            If ModelState.IsValid Then
                db.myLeg.Add(legislation)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(legislation)
        End Function

        ' GET: legislations/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim legislation As legislation = db.myLeg.Find(id)
            If IsNothing(legislation) Then
                Return HttpNotFound()
            End If
            Return View(legislation)
        End Function

        ' POST: legislations/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="legID,legTitle,legNum,legFullText")> ByVal legislation As legislation) As ActionResult
            If ModelState.IsValid Then
                db.Entry(legislation).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(legislation)
        End Function

        ' GET: legislations/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim legislation As legislation = db.myLeg.Find(id)
            If IsNothing(legislation) Then
                Return HttpNotFound()
            End If
            Return View(legislation)
        End Function

        ' POST: legislations/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim legislation As legislation = db.myLeg.Find(id)
            db.myLeg.Remove(legislation)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
