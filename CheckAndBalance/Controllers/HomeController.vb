Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "It is checkandbalnce.org's mission to ensure that every citizen 
                                that wishes to ensure that the Bills that are being drafted and 
                                voted on by Congress, have the ability to read these Bills in
                                their entirety and then comment on all or part of each Bill in 
                                such a way that the ones we vote into office, the same ones 
                                drafting these Bills, can read these comments and know how their 
                                constituents feel about the Bills."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Contact us at:"

        Return View()
    End Function
End Class
