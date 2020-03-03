Imports System.Data.SqlClient
Public Class Cadastro_Usuários
    Private Sub VoltarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VoltarToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub NovoUsuárioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovoUsuárioToolStripMenuItem.Click
        Button2.Text = "Concluir"
        ComboBox1.Text = Nothing
        TextBox1.Text = ""
        TextBox3.Text = ""

    End Sub

    Private Sub ExcluirUsuárioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcluirUsuárioToolStripMenuItem.Click
        Dim Resultado As DialogResult
        Resultado = MessageBox.Show("Deseja excluir o Usuário " & TextBox1.Text & "?", "Transportadora Eagles", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        Select Case Resultado
            Case Windows.Forms.DialogResult.Yes
                Dim cn As SqlConnection
                Dim cmd As New SqlCommand
                cn = New SqlConnection("server=(local)\SQLEXPRESS;uid=sa;pwd=123456;database=Transportadora_Eagles")
                Try

                    Dim retorno As Integer


                    cn.Open()

                    With cmd
                        .Connection = cn
                        .CommandTimeout = 0
                        .CommandText = "delete from Usuario where Id_usuario = '" & TextBox1.Text & "'"
                        .CommandType = CommandType.Text
                    End With

                    retorno = cmd.ExecuteNonQuery
                    MsgBox("Exclusão efetuada com sucesso")
                    ComboBox1.Text = ""
                    TextBox1.Clear()
                    '  TextBox2.Clear()
                    Button2.Enabled = False
                Catch ex As Exception
                    MsgBox("Falha durante exclusão, tente realizar a operação novamente. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
                Finally
                    NovoUsuárioToolStripMenuItem.Enabled = True
                End Try
            Case Windows.Forms.DialogResult.No
        End Select
    End Sub
    Private Sub PreencherCamposToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreencherCamposToolStripMenuItem.Click
        If TextBox3.Text = "" Then
            MsgBox("Digíte o Código do funcionário!")
        Else
            Dim cn As New SqlConnection
            Dim cmd As New SqlCommand
            Dim mr As SqlDataReader  ' para listagem
            cn = New SqlConnection("server=(local)\SQLEXPRESS;uid=sa;pwd=123456;database=Transportadora_Eagles")
            Try
                cn.Open()
                With cmd
                    .Connection = cn
                    .CommandTimeout = 0
                    .CommandText = "select * from  Usuario where Codigo_funcionario='" & TextBox3.Text & "'"
                    .CommandType = CommandType.Text
                End With
                mr = cmd.ExecuteReader   ' somente leitura
                While mr.Read       ' somente para pesquisa e listagem
                    TextBox1.Text = mr!Id_usuario
                    ComboBox1.Text = mr!Nivel_acesso
                End While
            Catch ex As Exception
                MsgBox("Não foi possível preencher os campos, revise o Código e tente novamente. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
            Finally
                cn.Close()
            End Try
            ComboBox1.Enabled = False
            Button1.Enabled = False
            Button2.Enabled = True
            NovoUsuárioToolStripMenuItem.Enabled = True
            Button2.Text = "Resetar senha"
        End If
    End Sub

    Private Sub LimparToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LimparToolStripMenuItem.Click
        ComboBox1.Text = Nothing
        TextBox1.Clear()
        'TextBox2.Clear()
        TextBox3.Clear()
        Button2.Enabled = False
        NovoUsuárioToolStripMenuItem.Enabled = True
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        ExcluirUsuárioToolStripMenuItem.Enabled = True
        If TextBox1.Text = "" Then
            ExcluirUsuárioToolStripMenuItem.Enabled = False

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cn As New SqlConnection
        Dim cmd As New SqlCommand
        Dim mr As SqlDataReader  ' para listagem
        Dim Nome As String
        Dim Codigo As String
        cn = New SqlConnection("server=(local)\SQLEXPRESS;uid=sa;pwd=123456;database=Transportadora_Eagles")
        Try
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from  Funcionario where Codigo_funcionario='" & TextBox3.Text & "'"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader   ' somente leitura
            While mr.Read       ' somente para pesquisa e listagem
                Nome = mr!Nome_Funcionario
                Codigo = mr!Codigo_funcionario
                TextBox1.Text = Nome & "_" & Codigo
            End While
            Button2.Enabled = True
        Catch ex As Exception
            MsgBox("Não foi possível gerar nome de usuário, tente novamente. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If Button2.Text = "Resetar senha" Then


            Dim cn As SqlConnection
            Dim cmd As New SqlCommand
            cn = New SqlConnection("server=(local)\SQLEXPRESS;uid=sa;pwd=123456;database=Transportadora_Eagles")
            Try

                Dim retorno As Integer


                cn.Open()

                With cmd
                    .Connection = cn
                    .CommandTimeout = 0
                    .CommandText = "Update Usuario set SenhaAtv = 0, Id_senha = ('" & "0000" & "') where Id_usuario = '" & TextBox1.Text & "'"
                    .CommandType = CommandType.Text
                End With

                retorno = cmd.ExecuteNonQuery
                cn.Close()
            Catch ex As Exception
                MsgBox("Não foi possível resetar a senha, tente novamente. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
            Finally
                cn.Close()
            End Try
            Button2.Enabled = False
        ElseIf Button2.Text = "Concluir"
            NovoUsuárioToolStripMenuItem.Enabled = False
            Dim cn As SqlConnection
            Dim cmd As New SqlCommand
            cn = New SqlConnection("server=(local)\SQLEXPRESS;uid=sa;pwd=123456;database=Transportadora_Eagles")
            Try
                Dim retorno As Integer


                cn.Open()

                With cmd
                    .Connection = cn
                    .CommandTimeout = 0
                    .CommandText = "insert into Usuario(Nivel_acesso, Id_usuario, Id_senha, Codigo_funcionario, SenhaAtv) values ('" & ComboBox1.Text & "', '" & TextBox1.Text & "', '" & "0000" & "' , '" & TextBox3.Text & "', 0 )"
                    .CommandType = CommandType.Text
                End With

                retorno = cmd.ExecuteNonQuery
                MsgBox("Cadastro efetuado com sucesso")
                ComboBox1.Text = ""
                TextBox1.Clear()
                'TextBox2.Clear()
                Button2.Enabled = False
            Catch ex As Exception
                MsgBox("Falha ao cadastrar usuário!")
            Finally
                NovoUsuárioToolStripMenuItem.Enabled = True
            End Try

        End If
    End Sub
End Class