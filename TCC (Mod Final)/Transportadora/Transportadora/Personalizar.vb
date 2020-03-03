Public Class Personalizar

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        OpenFileDialog1.ShowDialog()
        Button4.Enabled = False
        Button5.Enabled = False
    End Sub
    
    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        If (CStr(Math.Round(My.Computer.FileSystem.GetFileInfo(OpenFileDialog1.FileName).Length() / 1024))) > 2048 Then
            MsgBox("A Imagem deve ter no máximo 2MB", MsgBoxStyle.Exclamation, "Erro")
        Else
            PictureBox1.Image = System.Drawing.Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            PictureBox2.BackColor = ColorDialog1.Color
            Button3.Enabled = False
            Button5.Enabled = False
        End If
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        PictureBox1.Image = Nothing
        PictureBox2.BackColor = Nothing
        PictureBox3.BackColor = Nothing
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            PictureBox3.BackColor = ColorDialog1.Color
            Button3.Enabled = False
            Button4.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If PictureBox2.BackColor <> Color.White Then
            Início.BackgroundImage = Nothing
            Início.BackColor = PictureBox2.BackColor

        
        ElseIf PictureBox1.Image IsNot Nothing Then
            Dim Caminho As String
            Caminho = OpenFileDialog1.FileName
            Início.BackgroundImage = System.Drawing.Image.FromFile(Caminho)
        End If

        If PictureBox3.BackColor <> Color.White Then

            Início.MenuStrip1.BackColor = PictureBox3.BackColor
            Início.UsuáriosToolStripMenuItem1.BackColor = PictureBox3.BackColor
            Início.FuncionáriosToolStripMenuItem3.BackColor = PictureBox3.BackColor
            Início.ClientesToolStripMenuItem3.BackColor = PictureBox3.BackColor
            Início.VeículosToolStripMenuItem3.BackColor = PictureBox3.BackColor
            Início.UsuáriosToolStripMenuItem2.BackColor = PictureBox3.BackColor
            Início.CargaToolStripMenuItem.BackColor = PictureBox3.BackColor
            Início.FuncionáriosToolStripMenuItem4.BackColor = PictureBox3.BackColor
            Início.ClientesToolStripMenuItem4.BackColor = PictureBox3.BackColor
            Início.FretamentoToolStripMenuItem.BackColor = PictureBox3.BackColor
            Início.ArmazenagemToolStripMenuItem.BackColor = PictureBox3.BackColor
            Início.ResgateDeOrçamentoToolStripMenuItem.BackColor = PictureBox3.BackColor
            Início.BaixaToolStripMenuItem.BackColor = PictureBox3.BackColor
            Início.VeículosToolStripMenuItem4.BackColor = PictureBox3.BackColor
            Início.ArmazémToolStripMenuItem1.BackColor = PictureBox3.BackColor
            Início.PagamentoDeContasToolStripMenuItem.BackColor = PictureBox3.BackColor
            Início.GerenciamentoFinanceiroToolStripMenuItem.BackColor = PictureBox3.BackColor
            Início.GerenciamentoArmazémToolStripMenuItem.BackColor = PictureBox3.BackColor
            Início.StatusStrip1.BackColor = PictureBox3.BackColor
            Início.ToolStripStatusLabel2.BackColor = PictureBox3.BackColor
            Início.Label4.BackColor = PictureBox3.BackColor
            'Início.pgbProcessador.BackColor = PictureBox3.BackColor
            Início.lblProcessador.BackColor = PictureBox3.BackColor
            Início.Label6.BackColor = PictureBox3.BackColor
            'Início.pgbMemoria.Location = New Point(1214, 707)
            Início.Label7.BackColor = PictureBox3.BackColor
            Início.Label8.BackColor = PictureBox3.BackColor
            Início.Label9.BackColor = PictureBox3.BackColor

            Início.lblTotalMemoria.BackColor = PictureBox3.BackColor
            Início.lblMemoriaDisponível.BackColor = PictureBox3.BackColor
            Início.lblMemoriaUsada.BackColor = PictureBox3.BackColor
            'Fazer mudança em todos forms
        End If

        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        'Me.Close()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
