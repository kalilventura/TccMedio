Imports System.Data.SqlClient

Public Class Pagamento_Contas
    Private Sub CancelarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CancelarToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim CodigoFun As Integer
        Dim cn As SqlConnection
        Dim cmd As New SqlCommand
        Dim mr As SqlDataReader
        cn = New SqlConnection("server=(local)\SQLEXPRESS;uid=sa;pwd=123456;database=Transportadora_Eagles")
        Try
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from  Usuario where Id_usuario='" & TextBox5.Text & "'"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            While mr.Read
                CodigoFun = mr!Codigo_funcionario
            End While
            cn.Close()


            If Label1.Text = "Label1" Then
                Dim retorno As Integer
                cn.Open()

                With cmd
                    .Connection = cn
                    .CommandTimeout = 0
                    .CommandText = "insert into Contas(DataPgto, Valor, DataVenc, Descricao, Estado,Tipo, Codigo_funcionario) values ('" & TextBox4.Text & "', '" & "-" & TextBox2.Text & "', '" & MaskedTextBox1.Text & "', '" & ListBox1.Text & "', '" & 1 & "', '" & 1 & "','" & CodigoFun & "')"
                    .CommandType = CommandType.Text
                End With

                retorno = cmd.ExecuteNonQuery
                'MsgBox("Concluído")
                cn.Close()

            Else

                Dim retorno As Integer
                cn.Open()

                With cmd
                    .Connection = cn
                    .CommandTimeout = 0
                    .CommandText = "Update Contas set DataPgto = ('" & TextBox4.Text & "'), Valor =('" & "-" & TextBox2.Text & "'), DataVenc =('" & MaskedTextBox1.Text & "'), Descricao =('" & ListBox1.Text & "') where Codigo_conta = '" & Label1.Text & "'"
                    .CommandType = CommandType.Text
                End With

                retorno = cmd.ExecuteNonQuery
                'MsgBox("Concluído")
                cn.Close()


            End If
            Dim Resultado As DialogResult
            Resultado = MessageBox.Show("Pagar outra conta?", "Transportadora Eagles", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            Select Case Resultado
                Case Windows.Forms.DialogResult.Yes
                    TextBox2.Text = ""
                    MaskedTextBox1.Text = ""
                Case Windows.Forms.DialogResult.No
                    Me.Close()
            End Select
        Catch ex As Exception
            MsgBox("Falha ao concluir operação, tente novamente. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub Pagamento_Contas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TextBox5.Text = Início.ToolStripStatusLabel2.Text
        TextBox4.Text = Date.Now.Date
    End Sub
End Class