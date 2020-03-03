Imports System.Data.SqlClient
Public Class Controle_Veículos
    Dim cn As New SqlConnection
    Dim cmd As New SqlCommand
    Dim mr As SqlDataReader
    Dim Status As String
    Private Sub Controle_Veículos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Transportadora_EaglesDataSet1.Veiculo' table. You can move, or remove it, as needed.
        Me.VeiculoTableAdapter.Fill(Me.Transportadora_EaglesDataSet1.Veiculo)
        cn = New SqlConnection("server=(local)\SQLEXPRESS;uid=sa;pwd=123456;database=Transportadora_Eagles")
        Try
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from Veiculo where Placa = '" & ComboBox1.SelectedValue & "'"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            While mr.Read
                Status = mr!Status
            End While
            If Status = 0 Then
                PictureBox1.BackColor = Color.Lime
                RadioButton2.Checked = True
                PictureBox4.Visible = False
            ElseIf Status = 1 Then
                PictureBox1.BackColor = Color.Red
                RadioButton3.Checked = True
                PictureBox4.Visible = False
            ElseIf Status = 2 Then
                PictureBox1.BackColor = Color.Gold
                RadioButton1.Checked = True
                PictureBox4.Visible = True
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox("Falha ao carregar formulário, reinicie-o!. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        cn = New SqlConnection("server=(local)\SQLEXPRESS;uid=sa;pwd=123456;database=Transportadora_Eagles")
        Try
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from Veiculo where Placa = '" & ComboBox1.SelectedValue & "'"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            While mr.Read
                Status = mr!Status
            End While
            If Status = 0 Then
                PictureBox1.BackColor = Color.Lime
                RadioButton2.Checked = True
                PictureBox4.Visible = False
            ElseIf Status = 1 Then
                PictureBox1.BackColor = Color.Red
                RadioButton3.Checked = True
                PictureBox4.Visible = False
            ElseIf Status = 2 Then
                PictureBox1.BackColor = Color.Gold
                RadioButton1.Checked = True
                PictureBox4.Visible = True
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox("Falha na gestão de dados, tente reiniciar a operação. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub VoltarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VoltarToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        GroupBox1.Enabled = True
        Button2.Visible = False
        Button1.Visible = True
        Button3.Visible = True
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        GroupBox1.Enabled = False
        Button2.Visible = True
        Button1.Visible = False
        Button3.Visible = False
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Button1.Visible = False
        Button2.Visible = True
        GroupBox1.Enabled = False
        Button3.Visible = False
        If RadioButton1.Checked = True Then
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "Update Veiculo set Status = 2 where Placa = '" & ComboBox1.SelectedValue & "'"
            .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            cn.Close()
        ElseIf RadioButton2.Checked = True Then
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "Update Veiculo set Status = 0 where Placa = '" & ComboBox1.SelectedValue & "'"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            cn.Close()
        ElseIf RadioButton3.Checked = True Then
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "Update Veiculo set Status = 1 where Placa = '" & ComboBox1.SelectedValue & "'"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            cn.Close()


        End If
        cn.Open()
        With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from Veiculo where Placa = '" & ComboBox1.SelectedValue & "'"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            While mr.Read
                Status = mr!Status
            End While
            If Status = 0 Then
                PictureBox1.BackColor = Color.Lime
                RadioButton2.Checked = True
                PictureBox4.Visible = False
            ElseIf Status = 1 Then
                PictureBox1.BackColor = Color.Red
                RadioButton3.Checked = True
                PictureBox4.Visible = False
            ElseIf Status = 2 Then
                PictureBox1.BackColor = Color.Gold
                RadioButton1.Checked = True
                PictureBox4.Visible = True
            End If
            cn.Close()
    End Sub
End Class