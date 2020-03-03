Public Class Barra_Progresso

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'Timer1.Enabled = True
        LineShape1.X2 = LineShape1.X2 + 5

        'Timer1.Start()
        If LineShape1.X2 = 28 Then
            Label1.Text = "Carregando..."
        ElseIf LineShape1.X2 = 48 Then
            Label1.Text = "Iniciando Formulários..."
        ElseIf LineShape1.X2 = 248 Then
            Label1.Text = "Carregando Plugins..."
        ElseIf LineShape1.X2 = 388 Then
            Label1.Text = "Iniciando componentes..."
        ElseIf LineShape1.X2 = 448 Then
            Label1.Text = "Concluindo..."
        ElseIf LineShape1.X2 = 503 Then
            Me.Hide()
            Timer1.Stop()
            'LineShape1.X2 = 28
            Login.Show()
        End If
        Label2.Text = (LineShape1.X2 \ 5) & ("%")
    End Sub

    Private Sub Barra_Progresso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'LineShape1.X2 = 28
        'Label1.Text = ""
        'Label2.Text = ""
        Timer1.Start()
    End Sub
End Class