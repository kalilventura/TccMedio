Imports System.Data.SqlClient

Public Class Venda2DadosCarga
    Dim MedidaA As Double
    Dim MedidaL As Double
    Dim MedidaC As Double
    Dim QTD As Integer
    Dim Cubagem As Double
    'Dim Peso As Double
    Private Sub CancelarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CancelarToolStripMenuItem.Click
        DadosCliente.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "" And TextBox5.Text <> "" And TextBox6.Text <> "" And TextBox7.Text <> "" And TextBox8.Text <> "" And TextBox9.Text <> "" And ComboBox1.Text <> "" And ListBox1.SelectedItem <> Nothing Then
            Me.Hide()
            Retirada.Show()
        Else
            MsgBox("Todos os campos devem ser preenchidos!", MsgBoxStyle.Exclamation, "ERROR-53105")
        End If




    End Sub

    Private Sub Venda2DadosCarga_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cn As New SqlConnection("server=(local)\SQLEXPRESS;uid=sa;pwd=123456;database=Transportadora_Eagles")
        Dim cmd As New SqlCommand
        Dim mr As SqlDataReader
        cn.Open()
        With cmd
            .Connection = cn
            .CommandTimeout = 0
            .CommandText = "select * from Veiculo where Status = 0 And Atividade = 1"
            .CommandType = CommandType.Text
        End With
        mr = cmd.ExecuteReader
        While mr.Read

            ListBox1.Items.Add(mr!Placa)

        End While
        cn.Close()

        'fundo(Me)
        'fundotextbox(Me)
        'TODO: This line of code loads data into the 'Transportadora_EaglesDataSet1.Tipo_carga' table. You can move, or remove it, as needed.
        Me.Tipo_cargaTableAdapter.Fill(Me.Transportadora_EaglesDataSet1.Tipo_carga)
        'TODO: This line of code loads data into the 'Transportadora_EaglesDataSet1.Veiculo' table. You can move, or remove it, as needed.
        'Me.VeiculoTableAdapter.Fill(Me.Transportadora_EaglesDataSet1.Veiculo)

    End Sub
    Private Sub TextBox8_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox8.Leave
        If TextBox8.Text <> "" Then
            TextBox3.ReadOnly = False
        End If
    End Sub

    Private Sub TextBox3_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3.Leave
        TextBox4.ReadOnly = False
    End Sub

    Private Sub TextBox4_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox4.Leave
        TextBox7.ReadOnly = False
    End Sub
    Private Sub TextBox7_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox7.LostFocus
        If Convert.ToDouble(TextBox3.Text) > 2 Then
            TextBox3.BackColor = Color.Red

        ElseIf Convert.ToDouble(TextBox4.Text) > 2 Then
            TextBox4.BackColor = Color.Red

        ElseIf Convert.ToDouble(TextBox7.Text) > 7 Then
            TextBox7.BackColor = Color.Red
            Else
                Try
                    MedidaA = Convert.ToDouble(TextBox3.Text)
                    MedidaL = Convert.ToDouble(TextBox7.Text)
                    MedidaC = Convert.ToDouble(TextBox4.Text)
                    QTD = Convert.ToInt32(TextBox8.Text)
                    Cubagem = (MedidaA * MedidaC * MedidaL * QTD * 300)
                TextBox6.Text = Cubagem
                TextBox3.BackColor = Color.White
                TextBox4.BackColor = Color.White
                TextBox7.BackColor = Color.White
            Catch ex As Exception
                    MsgBox("Erro ao calcular cubagem, revise as dimensões e quantidade e tente novamente. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
                End Try
            End If

    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        Dim strValid As String
        strValid = "0123456789"
        Dim KeyAscii As Integer
        If InStr(strValid, Chr(KeyAscii)) = 0 Then
            KeyAscii = 0
        End If
    End Sub
End Class