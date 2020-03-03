Imports System.Data.SqlClient
Public Class DadosCliente

    Private Sub CancelarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CancelarToolStripMenuItem.Click
        Venda2DadosCarga.Close()
        Venda3Destino1.Close()
        Venda4Destino2.Close()
        Venda5Destino3.Close()
        Venda6Valor.Close()
        Venda7Orcamento.Close()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim cn As New SqlConnection
        cn = New SqlConnection("server=(local)\SQLEXPRESS;uid=sa;pwd=123456;database=Transportadora_Eagles")
        Try

            Dim cmd As New SqlCommand
            Dim mr As SqlDataReader

            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from  Cliente where Codigo_cliente='" & TextBox6.Text & "'"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            While mr.Read
                Label8.Text = mr!Razao_Social
                Label9.Text = mr!Nome_Fantasia
                Label10.Text = mr!CNPJ
                'Label11.Text = mr!Telefone
                Label12.Text = mr!Email
            End While
        Catch ex As Exception
            MsgBox("Falha na obtenção de dados. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
        Finally
            cn.Close()
        End Try
    End Sub
    Private Sub Label10_TextChanged(sender As Object, e As System.EventArgs) Handles Label10.TextChanged
        If Label10.Text = "" Then
            Button1.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
        Else
            Button1.Enabled = True
            Button3.Enabled = True
            Button4.Enabled = True

        End If
    End Sub

    Private Sub DadosCliente_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        TextBox6.Text = ""
        Label11.Text = ""
        Label10.Text = ""
        Label12.Text = ""
        Label8.Text = ""
        Label9.Text = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Resgate_Orcamento.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Venda2DadosCarga.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ArmVenda2.Show()
        Me.Hide()
    End Sub
End Class