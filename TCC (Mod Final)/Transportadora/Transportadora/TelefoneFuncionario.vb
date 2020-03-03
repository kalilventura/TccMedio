Public Class TelefoneFuncionario

    Private Sub VoltarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VoltarToolStripMenuItem.Click
        Me.Hide()
    End Sub

    Private Sub LimparToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LimparToolStripMenuItem.Click
        ComboBox1.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Label2.Visible = True
        TextBox2.Visible = True
    End Sub
End Class