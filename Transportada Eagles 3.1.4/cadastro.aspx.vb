Imports System.Data.SqlClient
Imports System.Data



Partial Class cadastro
    Inherits System.Web.UI.Page


    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cn As SqlConnection
        Dim cmd As New SqlCommand


        Try
            Dim retorno As Integer

            cn = New SqlConnection("server=(local)\SQLEXPRESS;uid=sa;pwd=123456;database=Transportadora_Eagles")
            cn.Open()

            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "insert into dbusuario(Email, Email2, Usuario, senha, senha2, razao_social, nome_fantasia, CNPJ, endereco, n, complemento, bairro, cidade, UF, CEP) values ('" & email.Text & "', '" & email2.Text & "', '" & usuario.Text & "', '" & senha.Text & "', '" & senha2.Text & "', '" & razaosocial.Text & "', '" & nomefantasia.Text & "', '" & cnpj.Text & "', '" & endereco.Text & "', '" & n.Text & "', '" & complemento.Text & "', '" & bairro.Text & "', '" & cid.Text & "', '" & uf.Text & "', '" & cep.Text & "')"
                .CommandType = CommandType.Text
            End With

            retorno = cmd.ExecuteNonQuery

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        Response.Redirect("~/login.aspx")
    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        razaosocial.Text = ""
        nomefantasia.Text = ""
        cnpj.Text = ""
        endereco.Text = ""
        n.Text = ""
        complemento.Text = ""
        bairro.Text = ""
        Cidade.Text = ""
        uf.Text = ""
        cep.Text = ""
        email.Text = ""
        email2.Text = ""
        usuario.Text = ""
        senha.Text = ""
        senha2.Text = ""
        psecreta.Text = "Selecione:"
        rsecreta.Text = ""
        Response.Redirect("~/Default.aspx")
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

            endereco.Enabled = False
            bairro.Enabled = False
            cid.Enabled = False
            uf.Enabled = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cadastro_Load(sender As Object, e As EventArgs) Handles Me.Load
        endereco.Enabled = False
        bairro.Enabled = False
        uf.Enabled = False
        cid.Enabled = False

    End Sub
End Class
