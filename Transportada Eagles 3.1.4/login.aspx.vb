Imports System.Data.SqlClient
Imports System.Data

Partial Class login
    Inherits System.Web.UI.Page
    Protected Sub LinkButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkButton1.Click
        Dim grava1 As New HttpCookie("Login")
        grava1.Expires = DateTime.Now.AddDays(-1)
        Response.Cookies.Add(grava1)
        Response.Redirect("~/Default.aspx")

    End Sub
    Protected Sub LinkButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkButton2.Click
        Dim cmd As New SqlCommand
        Dim cn As New SqlConnection
        Dim mr As SqlDataReader



        cn = New SqlConnection("server =(local)\SQLEXPRESS; uid = sa; pwd = 123456; database = Transportadora_Eagles")
        cn.Open()
        With cmd
            .Connection = cn
            .CommandTimeout = 0
            .CommandText = "select * from dbusuario where Email = '" & TextBox1.Text & "' and senha = '" & TextBox2.Text & "'"
            .CommandType = CommandType.Text
        End With
        mr = cmd.ExecuteReader

        If mr.Read Then

            Dim grava1 As New HttpCookie("Login")
            grava1.Values("Email") = TextBox1.Text
            grava1.Values("senha") = TextBox2.Text
            grava1.Expires = DateTime.Now.AddDays(1)
            Response.Cookies.Add(grava1)

            FormsAuthentication.RedirectFromLoginPage(mr.Read, False)


        ElseIf TextBox1.Text = "" Or TextBox2.Text = "" Then
            Label4.Text = "Email ou Senha incorretos"
            TextBox1.Text = ""
            TextBox2.Text = ""

        End If

        cn.Close()




    End Sub
End Class
