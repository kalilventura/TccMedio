Imports System.Data.SqlClient
Imports System.Data
Partial Class altcadastro
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        endereco.Enabled = False
        bairro.Enabled = False
        uf.Enabled = False
        cid.Enabled = False
        If Page.IsPostBack = False Then
            carrega()
        End If

    End Sub
    Sub carrega()
        Try
            Dim asd, asd2 As String
            If Not Request.Cookies("Login") Is Nothing Then
                Dim Valor As HttpCookie = Request.Cookies("Login")
                asd = Valor.Values("Email")
                asd2 = Valor.Values("Senha")
            End If
            razaosocial.Enabled = False
            nomefantasia.Enabled = False
            cnpj.Enabled = False
            cid.Enabled = False
            uf.Enabled = False
            endereco.Enabled = False
            bairro.Enabled = False
            Dim cmd As New SqlCommand

            Dim cn As New SqlConnection
            Dim mr As SqlDataReader



            cn = New SqlConnection("server = (local)\SQLEXPRESS; uid = sa; pwd = 123456; database = Transportadora_Eagles")
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from dbusuario where Email = '" & asd & "' and Senha = '" & asd2 & "'"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader


            While mr.Read
                razaosocial.Text = mr!razao_social
                nomefantasia.Text = mr!nome_fantasia
                cnpj.Text = mr!CNPJ
                endereco.Text = mr!endereco
                bairro.Text = mr!bairro
                uf.Text = mr!UF
                cep.Text = mr!cep
                n.Text = mr!n
                complemento.Text = mr!complemento
                cid.Text = mr!Cidade
                'TextBox10.Text = ""
                'TextBox7.Text = ""
            End While

            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cn As SqlConnection
        Dim cmd As New SqlCommand
        Dim mr As SqlDataReader



        cn = New SqlConnection("server =(local)\SQLEXPRESS; uid = sa; pwd = 123456; database = Transportadora_Eagles")
        cn.Open()
        With cmd
            .Connection = cn
            .CommandTimeout = 0
            .CommandText = "select * from dbusuario where Email = '" & email.Text & "' and senha = '" & senha.Text & "'"
            .CommandType = CommandType.Text
        End With
        mr = cmd.ExecuteReader



        If mr.Read Then
            Dim grava1 As New HttpCookie("Login")
            grava1.Values("Email") = email.Text
            grava1.Values("senha") = senha.Text
            grava1.Expires = DateTime.Now.AddDays(1)
            Response.Cookies.Add(grava1)
            Dim retorno As Integer

            cn = New SqlConnection("server=(local)\SQLEXPRESS;uid=sa;pwd=123456;database=Transportadora_Eagles")
            cn.Open()


            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "Update dbusuario Set endereco =('" & endereco.Text & "'), n =('" & n.Text & "'), complemento =('" & complemento.Text & "'), cep =('" & cep.Text & "'), cidade =('" & cid.Text & "'), bairro =('" & bairro.Text & "'), uf =('" & uf.Text & "')"
                .CommandType = CommandType.Text
            End With


            retorno = cmd.ExecuteNonQuery

        ElseIf email.Text = "" Or senha.Text = "" Then
            Label20.Text = "Email ou Senha incorretos"
            email.Text = ""
            senha.Text = ""

        End If
        cn.Close()

    End Sub
    Protected Sub LinkButton20_Click(sender As Object, e As EventArgs) Handles LinkButton20.Click
        Try
            Dim cn As New SqlConnection
            Dim cmd As New SqlCommand
            Dim mr As SqlDataReader  ' para listagem
            cn = New SqlConnection("server=(local)\SQLEXPRESS;uid=sa;pwd=123456;database=Transportadora_Eagles")
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from  CEP where CEP='" & cep.Text & "'"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader   ' somente leitura
            While mr.Read       ' somente para pesquisa e listagem

                endereco.Text = mr!Descricao
                bairro.Text = mr!Bairro
                cid.Text = mr!Cidade
                uf.Text = mr!UF

            End While
            cn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class
