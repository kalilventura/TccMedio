'Imports System.Data.SqlClient

Public Class ArmVenda2
    'Dim mr As SqlDataReader
    Dim CodigoCar As Integer
    Dim MedidaA As Double
    Dim MedidaL As Double
    Dim MedidaC As Double
    Dim QTD As Integer
    Dim Cubagem As Double
    'Dim cn As SqlConnection
    'Dim cmd As New SqlCommand
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        'Try


        '    Dim retorno As Integer


        '    cn.Open()

        '    With cmd
        '        .Connection = cn
        '        .CommandTimeout = 0
        '        .CommandText = "insert into Carga(Peso, MedidaA, MedidaL, MedidaC, Volumes, Cubagem, Valor, Tipo_Carga, Codigo_cliente) values ('" & TextBox1.Text & " ', '" & TextBox3.Text & "', '" & TextBox7.Text & "', '" & TextBox4.Text & "' , '" & TextBox8.Text & "', '" & TextBox6.Text & "', '" & TextBox9.Text & "', '" & ComboBox1.SelectedValue & "', '" & DadosCliente.TextBox6.Text & "')"
        '        .CommandType = CommandType.Text
        '    End With

        '    retorno = cmd.ExecuteNonQuery
        '    cn.Close()
        ArmVenda3.Show()
        Me.Hide()
        'Catch ex As Exception

        'End Try


        'Try

        '    cn.Open()
        'With cmd
        '.Connection = cn
        '.CommandTimeout = 0
        '.CommandText = "Select TOP 1 * from Carga order by Codigo_carga desc"
        '.CommandType = CommandType.Text
        'End With
        '    mr = cmd.ExecuteReader
        '    While mr.Read
        '        CodigoCar = mr!Codigo_carga
        '    End While
        '    cn.Close()

        'Catch ex As Exception

        'End Try
        'Try
        '    Dim retorno As Integer
        '    cn.Open()
        '    With cmd
        '        .Connection = cn
        '        .CommandTimeout = 0
        '        .CommandText = "Update Armazem Set Codigo_carga =('" & CodigoCar & "'), Estado = 2  where Setor= '" & Label3.Text & "'"
        '        .CommandType = CommandType.Text
        '    End With
        '    retorno = cmd.ExecuteNonQuery
        '    Me.Close()
        'Catch ex As Exception

        'End Try


    End Sub

    Private Sub CancelarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarToolStripMenuItem.Click
        Me.Hide()
        DadosCliente.Show()
    End Sub

    Private Sub TextBox8_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox8.Leave
        TextBox3.ReadOnly = False
    End Sub

    Private Sub TextBox3_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3.Leave
        TextBox4.ReadOnly = False
    End Sub

    Private Sub TextBox4_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox4.Leave
        TextBox7.ReadOnly = False
    End Sub

    Private Sub TextBox7_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox7.LostFocus
        Try
            MedidaA = Convert.ToDouble(TextBox3.Text)
            MedidaL = Convert.ToDouble(TextBox7.Text)
            MedidaC = Convert.ToDouble(TextBox4.Text)
            QTD = Convert.ToInt32(TextBox8.Text)
            Cubagem = (MedidaA * MedidaC * MedidaL * QTD * 300)
            TextBox6.Text = Cubagem

        Catch ex As Exception
            MsgBox("Não foi possível calcular a cubagem, revise as dimensões e quantidade, e tente novamente. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ArmArm.Show()
        PictureBox1.Visible = True
    End Sub

    Private Sub ArmVenda2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'cn = New SqlConnection("server=(local)\SQLEXPRESS;uid=sa;pwd=123456;database=Transportadora_Eagles")
        'TODO: This line of code loads data into the 'Transportadora_EaglesDataSet1.Tipo_carga' table. You can move, or remove it, as needed.
        Me.Tipo_cargaTableAdapter.Fill(Me.Transportadora_EaglesDataSet1.Tipo_carga)
        Label6.Text = DadosCliente.TextBox6.Text
    End Sub

    Private Sub PictureBox1_BackgroundImageChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.BackgroundImageChanged
        Button1.Enabled = True
        Button2.Enabled = False
    End Sub

    
End Class