Imports System.Data.SqlClient

Public Class ArmVenda4
    Dim cn As SqlConnection
    Dim cmd As New SqlCommand
    Dim mr As SqlDataReader
    Dim CodigoFun, CodigoCar, CodigoOrc As Integer
    Private Sub ArmVenda4_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        TextBox2.Text = ArmVenda3.TextBox1.Text
        cn = New SqlConnection("server=(local)\SQLEXPRESS;uid=sa;pwd=123456;database=Transportadora_Eagles")
        'Try
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
        'Catch ex As Exception

        'End Try
        'Try

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
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Try
        If TextBox6.Text < Date.Now.ToString Then
            TextBox6.BackColor = Color.Red
        Else
            TextBox6.BackColor = Color.White
            Dim retorno As Integer
            cn.Open()

            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "insert into Orcamento(Cliente_Orc, Telefone_orc, Email, Valor_Venda, Data, Data_exp, Codigo_funcionario, Codigo_carga) values ('" & DadosCliente.TextBox6.Text & " ', '" & TextBox4.Text & "', '" & TextBox5.Text & "', '" & TextBox2.Text & "' , '" & Date.Now.ToString & "', '" & TextBox6.Text & "', '" & CodigoFun & "', '" & CodigoCar & "')"
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

            'Catch ex As Exception

            'End Try
        End If
    End Sub

    Private Sub CancelarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CancelarToolStripMenuItem.Click
        ArmVenda3.Show()
        Me.Hide()
    End Sub
End Class