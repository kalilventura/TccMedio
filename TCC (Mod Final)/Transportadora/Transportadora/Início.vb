Public Class Início
    Dim Idx As Decimal
    Dim total As Integer
    Dim cpu As Integer
    Private Sub Início_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer2.Start()
        Timer3.Start()
        ToolTip1.SetToolTip(PictureBox2, "Personalização")
        ToolStripStatusLabel1.Text = "Usuário: "
        ToolStripStatusLabel2.Text = Login.TextBox1.Text
        Login.Close()
        '53105





    End Sub
    Private Sub UsuáriosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuáriosToolStripMenuItem1.Click
        Cadastro_Usuários.Show()
    End Sub

    Private Sub FuncionáriosToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FuncionáriosToolStripMenuItem3.Click
        Cadastro_Funcionários.TextBox14.ReadOnly = False
        Cadastro_Funcionários.TextBox9.ReadOnly = False
        Cadastro_Funcionários.ComboBox2.Enabled = True
        Cadastro_Funcionários.ComboBox5.Enabled = True
        Cadastro_Funcionários.TextBox1.ReadOnly = False
        Cadastro_Funcionários.TextBox3.ReadOnly = False
        Cadastro_Funcionários.TextBox5.ReadOnly = False
        Cadastro_Funcionários.TextBox4.ReadOnly = False
        Cadastro_Funcionários.TextBox6.ReadOnly = False
        Cadastro_Funcionários.TextBox7.ReadOnly = False
        Cadastro_Funcionários.TextBox8.ReadOnly = False
        Cadastro_Funcionários.TextBox10.ReadOnly = False
        Cadastro_Funcionários.TextBox15.ReadOnly = False
        Cadastro_Funcionários.TextBox2.ReadOnly = False
        Cadastro_Funcionários.TextBox18.ReadOnly = False
        Cadastro_Funcionários.TextBox17.ReadOnly = False
        Cadastro_Funcionários.TextBox12.ReadOnly = False
        Cadastro_Funcionários.ComboBox1.Enabled = True
        Cadastro_Funcionários.ComboBox4.Enabled = True
        Cadastro_Funcionários.TextBox16.ReadOnly = False
        Cadastro_Funcionários.TextBox11.ReadOnly = False
        Cadastro_Funcionários.TextBox13.ReadOnly = False
        Cadastro_Funcionários.ComboBox3.Enabled = True
        Cadastro_Funcionários.Button2.Text = "Concluir"
        Cadastro_Funcionários.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem3.Click
        Cadastro_Clientes.TextBox1.ReadOnly = False
        Cadastro_Clientes.TextBox2.ReadOnly = False
        Cadastro_Clientes.TextBox3.ReadOnly = False
        Cadastro_Clientes.TextBox4.ReadOnly = False
        Cadastro_Clientes.TextBox5.ReadOnly = False
        Cadastro_Clientes.TextBox6.ReadOnly = False
        Cadastro_Clientes.TextBox7.ReadOnly = False
        Cadastro_Clientes.TextBox8.ReadOnly = False
        Cadastro_Clientes.TextBox9.ReadOnly = False
        Cadastro_Clientes.TextBox10.ReadOnly = False
        Cadastro_Clientes.TextBox11.ReadOnly = False
        Cadastro_Clientes.TextBox12.ReadOnly = False
        Cadastro_Clientes.TextBox13.ReadOnly = False
        Cadastro_Clientes.Show()
    End Sub

    Private Sub UsuáriosToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuáriosToolStripMenuItem2.Click
        Cadastro_Usuários.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem4.Click
        Cadastro_Clientes.TextBox1.ReadOnly = True
        Cadastro_Clientes.TextBox2.ReadOnly = True
        Cadastro_Clientes.TextBox4.ReadOnly = True
        Cadastro_Clientes.TextBox5.ReadOnly = True
        Cadastro_Clientes.TextBox7.ReadOnly = True
        Cadastro_Clientes.TextBox8.ReadOnly = True
        Cadastro_Clientes.TextBox9.ReadOnly = True
        Cadastro_Clientes.TextBox10.ReadOnly = True
        Cadastro_Clientes.TextBox11.ReadOnly = True
        Cadastro_Clientes.TextBox12.ReadOnly = True
        Cadastro_Clientes.TextBox13.ReadOnly = True
        Cadastro_Clientes.Show()
    End Sub

    Private Sub VeículosToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VeículosToolStripMenuItem3.Click
        Cadastro_Veículos.TextBox2.ReadOnly = False
        Cadastro_Veículos.TextBox3.ReadOnly = False
        Cadastro_Veículos.TextBox4.ReadOnly = False
        Cadastro_Veículos.TextBox5.ReadOnly = False
        Cadastro_Veículos.TextBox6.ReadOnly = False
        Cadastro_Veículos.TextBox7.ReadOnly = False
        Cadastro_Veículos.TextBox8.ReadOnly = False
        Cadastro_Veículos.ComboBox1.Enabled = True
        Cadastro_Veículos.ListBox1.Visible = False
        Cadastro_Veículos.Show()
    End Sub

    Private Sub FuncionáriosToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FuncionáriosToolStripMenuItem4.Click
        Cadastro_Funcionários.TextBox9.ReadOnly = True
        Cadastro_Funcionários.ComboBox2.Enabled = False
        Cadastro_Funcionários.ComboBox5.Enabled = False
        Cadastro_Funcionários.TextBox1.ReadOnly = True
        Cadastro_Funcionários.TextBox3.ReadOnly = True
        Cadastro_Funcionários.TextBox5.ReadOnly = True
        Cadastro_Funcionários.TextBox4.ReadOnly = True
        Cadastro_Funcionários.TextBox6.ReadOnly = True
        Cadastro_Funcionários.TextBox7.ReadOnly = True
        Cadastro_Funcionários.TextBox8.ReadOnly = True
        Cadastro_Funcionários.TextBox10.ReadOnly = True
        Cadastro_Funcionários.TextBox15.ReadOnly = True
        Cadastro_Funcionários.TextBox2.ReadOnly = True
        Cadastro_Funcionários.TextBox18.ReadOnly = True
        Cadastro_Funcionários.TextBox17.ReadOnly = True
        Cadastro_Funcionários.ComboBox1.Enabled = False
        Cadastro_Funcionários.ComboBox4.Enabled = False
        Cadastro_Funcionários.TextBox16.ReadOnly = True
        Cadastro_Funcionários.TextBox11.ReadOnly = True
        Cadastro_Funcionários.TextBox13.ReadOnly = True
        Cadastro_Funcionários.ComboBox3.Enabled = False
        Cadastro_Funcionários.Button2.Text = "Excluir Funcionário"
        Cadastro_Funcionários.Show()
    End Sub

    Private Sub VeículosToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VeículosToolStripMenuItem4.Click
        Cadastro_Veículos.TextBox2.ReadOnly = True
        Cadastro_Veículos.TextBox3.ReadOnly = True
        Cadastro_Veículos.TextBox4.ReadOnly = True
        Cadastro_Veículos.TextBox5.ReadOnly = True
        Cadastro_Veículos.TextBox6.ReadOnly = True
        Cadastro_Veículos.TextBox7.ReadOnly = True
        Cadastro_Veículos.TextBox8.ReadOnly = True
        Cadastro_Veículos.ComboBox1.Enabled = False
        Cadastro_Veículos.ListBox1.Visible = True
        Cadastro_Veículos.Show()
    End Sub

    Private Sub SairToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SairToolStripMenuItem1.Click
        Try
            Dim Resultado As DialogResult
            Resultado = MessageBox.Show("Deseja encerrar?", "Transportadora Eagles", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            Select Case Resultado
                Case Windows.Forms.DialogResult.Yes
                    Me.Close()
                    Login.Close()
                    Barra_Progresso.Close()
                Case Windows.Forms.DialogResult.No
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Falha ao fechar a aplicação")
        End Try
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.BackColor = Color.White
        Me.BackgroundImage = Nothing
        MenuStrip1.BackColor = Color.DeepSkyBlue
        UsuáriosToolStripMenuItem1.BackColor = Color.DeepSkyBlue
        FuncionáriosToolStripMenuItem3.BackColor = Color.DeepSkyBlue
        ClientesToolStripMenuItem3.BackColor = Color.DeepSkyBlue
        VeículosToolStripMenuItem3.BackColor = Color.DeepSkyBlue
        UsuáriosToolStripMenuItem2.BackColor = Color.DeepSkyBlue
        FuncionáriosToolStripMenuItem4.BackColor = Color.DeepSkyBlue
        ClientesToolStripMenuItem4.BackColor = Color.DeepSkyBlue
        CargaToolStripMenuItem.BackColor = Color.DeepSkyBlue
        FretamentoToolStripMenuItem.BackColor = Color.DeepSkyBlue
        ArmazenagemToolStripMenuItem.BackColor = Color.DeepSkyBlue
        ResgateDeOrçamentoToolStripMenuItem.BackColor = Color.DeepSkyBlue
        BaixaToolStripMenuItem.BackColor = Color.DeepSkyBlue
        VeículosToolStripMenuItem4.BackColor = Color.DeepSkyBlue
        ArmazémToolStripMenuItem1.BackColor = Color.DeepSkyBlue
        PagamentoDeContasToolStripMenuItem.BackColor = Color.DeepSkyBlue
        GerenciamentoFinanceiroToolStripMenuItem.BackColor = Color.DeepSkyBlue
        GerenciamentoArmazémToolStripMenuItem.BackColor = Color.DeepSkyBlue
        StatusStrip1.BackColor = Color.DeepSkyBlue
        ToolStripStatusLabel2.BackColor = Color.DeepSkyBlue
        Label4.BackColor = Color.DeepSkyBlue
        'Início.pgbProcessador.BackColor = PictureBox3.BackColor
        lblProcessador.BackColor = Color.DeepSkyBlue
        Label6.BackColor = Color.DeepSkyBlue
        'Início.pgbMemoria.Location = New Point(1214, 707)
        Label7.BackColor = Color.DeepSkyBlue
        Label8.BackColor = Color.DeepSkyBlue
        Label9.BackColor = Color.DeepSkyBlue

        lblTotalMemoria.BackColor = Color.DeepSkyBlue
        lblMemoriaDisponível.BackColor = Color.DeepSkyBlue
        lblMemoriaUsada.BackColor = Color.DeepSkyBlue

    End Sub

    Private Sub LogOffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOffToolStripMenuItem.Click
        Try
            Dim Resultado As DialogResult
            Resultado = MessageBox.Show("Deseja fazer LogOff?", "Transportadora Eagles", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            Select Case Resultado
                Case Windows.Forms.DialogResult.Yes
                    Login.Show()
                    Me.Close()
                Case Windows.Forms.DialogResult.No

            End Select


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Falha ao fechar a aplicação")
        End Try




    End Sub

    Private Sub BackupRestoreToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackupRestoreToolStripMenuItem1.Click
        BackupRestore.Show()
    End Sub

    Private Sub PagamentoDeContasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PagamentoDeContasToolStripMenuItem.Click
        Pagamento_Contas.Show()
    End Sub
    Private Sub GerenciamentoFinanceiroToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GerenciamentoFinanceiroToolStripMenuItem.Click
        Gerenciamento_armazém.AlterarToolStripMenuItem.Visible = True
        Gerenciamento_financeiro.Show()
    End Sub

    Private Sub ArmazémToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArmazémToolStripMenuItem1.Click
        'Gerenciamento_armazém.PictureBox1.Enabled = False
        'Gerenciamento_armazém.PictureBox2.Enabled = False
        'Gerenciamento_armazém.PictureBox3.Enabled = False
        'Gerenciamento_armazém.PictureBox4.Enabled = False
        'Gerenciamento_armazém.PictureBox5.Enabled = False
        'Gerenciamento_armazém.PictureBox6.Enabled = False
        'Gerenciamento_armazém.PictureBox7.Enabled = False
        'Gerenciamento_armazém.PictureBox8.Enabled = False
        'Gerenciamento_armazém.PictureBox9.Enabled = False
        'Gerenciamento_armazém.PictureBox10.Enabled = False
        'Gerenciamento_armazém.PictureBox11.Enabled = False
        'Gerenciamento_armazém.PictureBox12.Enabled = False
        'Gerenciamento_armazém.PictureBox13.Enabled = False
        'Gerenciamento_armazém.PictureBox14.Enabled = False
        'Gerenciamento_armazém.PictureBox15.Enabled = False
        'Gerenciamento_armazém.PictureBox16.Enabled = False
        'Gerenciamento_armazém.PictureBox17.Enabled = False
        'Gerenciamento_armazém.PictureBox18.Enabled = False
        'Gerenciamento_armazém.PictureBox19.Enabled = False
        'Gerenciamento_armazém.PictureBox20.Enabled = False
        'Gerenciamento_armazém.PictureBox21.Enabled = False
        'Gerenciamento_armazém.PictureBox22.Enabled = False
        'Gerenciamento_armazém.PictureBox23.Enabled = False
        'Gerenciamento_armazém.PictureBox24.Enabled = False
        'Gerenciamento_armazém.PictureBox25.Enabled = False
        'Gerenciamento_armazém.PictureBox26.Enabled = False
        'Gerenciamento_armazém.PictureBox27.Enabled = False
        'Gerenciamento_armazém.PictureBox28.Enabled = False
        'Gerenciamento_armazém.PictureBox29.Enabled = False
        'Gerenciamento_armazém.PictureBox30.Enabled = False
        'Gerenciamento_armazém.PictureBox31.Enabled = False
        'Gerenciamento_armazém.PictureBox32.Enabled = False
        Gerenciamento_armazém.AlterarToolStripMenuItem.Visible = False
        Gerenciamento_armazém.Show()
    End Sub

    Private Sub ControleDeVeículosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ControleDeVeículosToolStripMenuItem.Click
        Controle_Veículos.Show()
    End Sub

    Private Sub GerenciamentoArmazémToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GerenciamentoArmazémToolStripMenuItem.Click
        Gerenciamento_armazém.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        Personalizar.Show()
    End Sub

    Private Sub GerenciamentoDeCargaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        Controle_Carga.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As System.EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel4.Text = Date.Now.ToString
        
    End Sub

    Private Sub FretamentoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FretamentoToolStripMenuItem.Click
        DadosCliente.TextBox6.Text = ""
        DadosCliente.Label11.Text = ""
        DadosCliente.Label10.Text = ""
        DadosCliente.Label12.Text = ""
        DadosCliente.Label8.Text = ""
        DadosCliente.Label9.Text = ""
        DadosCliente.Button3.Visible = False
        DadosCliente.Button4.Visible = False
        DadosCliente.Button1.Visible = True
        DadosCliente.Show()
    End Sub

    Private Sub ArmazenagemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArmazenagemToolStripMenuItem.Click
        DadosCliente.TextBox6.Text = ""
        DadosCliente.Label11.Text = ""
        DadosCliente.Label10.Text = ""
        DadosCliente.Label12.Text = ""
        DadosCliente.Label8.Text = ""
        DadosCliente.Label9.Text = ""
        DadosCliente.Button3.Visible = True
        DadosCliente.Button4.Visible = False
        DadosCliente.Button1.Visible = False
        DadosCliente.Show()
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        total = Val(My.Computer.Info.TotalPhysicalMemory) / 1024 / 1024
        lblTotalMemoria.Text = total & " MB"
        lblMemoriaDisponível.Text = (Int(Val(My.Computer.Info.AvailablePhysicalMemory) / 1024 / 1024)) & " MB"
        lblMemoriaUsada.Text = total - Val(lblMemoriaDisponível.Text) & " MB"
        pgbMemoria.Maximum = Val(lblTotalMemoria.Text)
        pgbMemoria.Value = Val(lblMemoriaUsada.Text)
        cpu = PerformanceCounter1.NextValue
        lblProcessador.Text = cpu & " %"
    End Sub

    Private Sub Timer3_Tick(sender As System.Object, e As System.EventArgs) Handles Timer3.Tick
        pgbProcessador.Value = cpu
        If pgbProcessador.Value < cpu Then
            pgbProcessador.Value += 1
        ElseIf pgbProcessador.Value > cpu Then
            pgbProcessador.Value -= 1
        End If
    End Sub

    Private Sub CargaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CargaToolStripMenuItem.Click
        Controle_Carga.Show()
    End Sub

    Private Sub ResgateDeOrçamentoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ResgateDeOrçamentoToolStripMenuItem.Click
        DadosCliente.TextBox6.Text = ""
        DadosCliente.Label11.Text = ""
        DadosCliente.Label10.Text = ""
        DadosCliente.Label12.Text = ""
        DadosCliente.Label8.Text = ""
        DadosCliente.Label9.Text = ""
        DadosCliente.Button3.Visible = False
        DadosCliente.Button4.Visible = True
        DadosCliente.Button1.Visible = False
        DadosCliente.Show()
    End Sub

    Private Sub BaixaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BaixaToolStripMenuItem.Click
        Entrega.Show()
    End Sub
End Class
