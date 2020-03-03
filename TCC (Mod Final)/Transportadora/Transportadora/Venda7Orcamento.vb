Imports System.Data.SqlClient

Public Class Venda7Orcamento
    Dim cn As SqlConnection
    Dim cmd As New SqlCommand
    Dim mr As SqlDataReader
    Dim CodigoFun, CodigoCar, CodigoOrc As Integer
    Private Sub CancelarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarToolStripMenuItem.Click
        Venda6Valor.Show()
        Me.Close()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Label4.Text = Date.Now.ToString
        If TextBox6.Text < Date.Now.ToString Then
            TextBox6.BackColor = Color.Red
        Else
            TextBox6.BackColor = Color.White
            Try
                Dim retorno As Integer
                cn.Open()

                With cmd
                    .Connection = cn
                    .CommandTimeout = 0
                    .CommandText = "insert into Orcamento(Cliente_Orc, Telefone_orc, Email, Valor_Venda, Data,Veiculo,Distancia_tot, Data_exp, Codigo_funcionario, Codigo_carga) values ('" & DadosCliente.TextBox6.Text & " ', '" & TextBox4.Text & "', '" & TextBox5.Text & "', '" & TextBox2.Text & "' , '" & Date.Now.ToString & "','" & Venda2DadosCarga.ListBox1.SelectedItem & "','" & Venda2DadosCarga.TextBox5.Text & "', '" & TextBox6.Text & "', '" & CodigoFun & "', '" & CodigoCar & "')"
                    .CommandType = CommandType.Text
                End With

                retorno = cmd.ExecuteNonQuery
                cn.Close()

                cn.Open()
                With cmd
                    .Connection = cn
                    .CommandTimeout = 0
                    .CommandText = "Select TOP 1 * from Orcamento order by Codigo_orcamento desc"
                    .CommandType = CommandType.Text
                End With
                mr = cmd.ExecuteReader
                While mr.Read
                    CodigoOrc = mr!Codigo_orcamento
                End While
                cn.Close()

                MsgBox("Código de orçamento: " & CodigoOrc & ". Guarde para efetuar o resgate.", MsgBoxStyle.Information, "Transportadora Eagles")
                Me.Close()
            Catch ex As Exception
                MsgBox("Falha no orçamento, tente realizar a operação novamente. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
            Finally
                cn.Close()
            End Try
        End If
    End Sub

    Private Sub Venda7Orcamento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn = New SqlConnection("server=(local)\SQLEXPRESS;uid=sa;pwd=123456;database=Transportadora_Eagles")
        Try
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from  Usuario where Id_usuario='" & Início.ToolStripStatusLabel2.Text & "'"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            While mr.Read
                CodigoFun = mr!Codigo_funcionario
            End While
            cn.Close()
        Catch ex As Exception
            MsgBox("Falha na gestão de dados, tente realizar a operação novamente. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
        Finally
            cn.Close()
        End Try
        Try

            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "Select TOP 1 * from Carga order by Codigo_carga desc"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            While mr.Read
                CodigoCar = mr!Codigo_carga
            End While
            cn.Close()
            TextBox1.Text = DadosCliente.TextBox6.Text
            TextBox2.Text = Venda6Valor.TextBox1.Text
        Catch ex As Exception
            MsgBox("Falha na gestão de dados, tente realizar a operação novamente. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
        Finally
            cn.Close()
        End Try
    End Sub
End Class