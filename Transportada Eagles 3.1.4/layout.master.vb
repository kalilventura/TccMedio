Imports System.Data
Imports System.Data.SqlClient

Partial Class MasterPage
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim cmd As New SqlCommand
        Dim asd, asd2 As String
        Dim cn As New SqlConnection
        Dim mr As SqlDataReader


        '    If Not Request.Cookies("Login") Is Nothing Then
        '        Dim Valor As HttpCookie = Request.Cookies("Login")
        '        asd = Valor.Values("Email")
        '        asd2 = Valor.Values("Senha")
        '        Label4.Visible = True
        '        Label3.Visible = True
        '        Label5.Visible = False
        '        LinkButton1.Visible = True
        '        LinkButton2.Visible = False
        '        LinkButton3.Visible = False
        '        LinkButton16.Visible = True
        '        LinkButton19.Visible = True
        '    Else
        '        Label4.Visible = False
        '        LinkButton1.Visible = False
        '        LinkButton2.Visible = True
        '        LinkButton16.Visible = False
        '        LinkButton19.Visible = False

        '    End If
        '    cn = New SqlConnection("server = (local)\SQLEXPRESS; uid = sa; pwd = 123456; database = Transportadora_Eagles")
        '    cn.Open()
        '    With cmd
        '        .Connection = cn
        '        .CommandTimeout = 0
        '        .CommandText = "select * from dbusuario where Email = '" & asd & "' and Senha = '" & asd2 & "'"
        '        .CommandType = CommandType.Text
        '    End With
        '    mr = cmd.ExecuteReader
        '    While mr.Read




        '        Label3.Text = mr!Usuario

        '    End While

    End Sub

    Protected Sub LinkButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkButton1.Click

        FormsAuthentication.SignOut()
        Dim grava1 As New HttpCookie("Login")
        grava1.Expires = DateTime.Now.AddDays(-1)
        Response.Cookies.Add(grava1)
        Response.Redirect("~/Default.aspx")


    End Sub

    Protected Sub LinkButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkButton2.Click
        Response.Redirect("~/login.aspx")
    End Sub

    Protected Sub LinkButton3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkButton3.Click
        Response.Redirect("~/cadastro.aspx")
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Response.Redirect("~/Default.aspx")
    End Sub


    Protected Sub LinkButton13_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkButton13.Click
        Response.Redirect("~/Default.aspx")
    End Sub

    Protected Sub LinkButton14_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkButton14.Click
        Response.Redirect("~/serviços.aspx")
    End Sub

    Protected Sub LinkButton15_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkButton15.Click
        Response.Redirect("~/empresa.aspx")
    End Sub

    Protected Sub LinkButton16_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkButton16.Click
        Response.Redirect("~/contratar/orçamento.aspx")
    End Sub

    Protected Sub LinkButton18_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkButton18.Click
        Response.Redirect("~/vantagens.aspx")
    End Sub

    Protected Sub LinkButton17_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkButton17.Click
        Response.Redirect("~/contato.aspx")
    End Sub

    Protected Sub LinkButton19_Click(sender As Object, e As EventArgs) Handles LinkButton19.Click
        Response.Redirect("~/altcadastro.aspx")
    End Sub
End Class

