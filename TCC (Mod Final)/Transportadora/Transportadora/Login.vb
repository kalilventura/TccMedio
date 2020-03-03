Imports System.Data.SqlClient
Public Class Login

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Cursor = Cursors.WaitCursor
        Dim cmd As New SqlCommand
        Dim cn As New SqlConnection
        Dim mr As SqlDataReader
        Dim Nivel As Integer
        Dim SenhaAtv As Integer
        ' Dim retorno As Integer
        cn = New SqlConnection("server=(local)\SQLEXPRESS;uid=sa;pwd=123456;database=Transportadora_Eagles")
        Try
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from Usuario where Id_Usuario='" & TextBox1.Text & "' And Id_Senha='" & TextBox2.Text & "'"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            If mr.Read Then
                Nivel = mr!Nivel_acesso
                SenhaAtv = mr!SenhaAtv


                cn.Close()
                cn.Dispose()
                If Nivel = 1 Then 'recepcionista

                    Início.VendaToolStripMenuItem2.Visible = False
                    Início.CadastroToolStripMenuItem1.Visible = False
                    Início.ControleDeVeículosToolStripMenuItem.Visible = False
                    Início.BackupRestoreToolStripMenuItem1.Visible = False
                    Início.ControleFinanceiroToolStripMenuItem.Visible = False

                    'Início.VendaToolStripMenuItem2.Enabled = False
                    'Início.CadastroToolStripMenuItem1.Enabled = False
                    'Início.ControleDeVeículosToolStripMenuItem.Enabled = False
                    'Início.BackupRestoreToolStripMenuItem1.Enabled = False
                    'Início.ControleFinanceiroToolStripMenuItem.Enabled = False


                    Início.Label4.Location = New Point(1216, 655)
                    Início.pgbProcessador.Location = New Point(1214, 674)
                    Início.lblProcessador.Location = New Point(1314, 671)
                    Início.Label6.Location = New Point(1214, 691)
                    Início.pgbMemoria.Location = New Point(1214, 707)
                    Início.Label7.Visible = False
                    Início.Label8.Visible = False
                    Início.Label9.Visible = False

                    Início.lblTotalMemoria.Visible = False
                    Início.lblMemoriaDisponível.Visible = False
                    Início.lblMemoriaUsada.Visible = False

                ElseIf Nivel = 2 Then 'vendedor


                    Início.UsuáriosToolStripMenuItem1.Visible = False
                    Início.FuncionáriosToolStripMenuItem3.Visible = False
                    Início.VeículosToolStripMenuItem3.Visible = False
                    Início.BackupRestoreToolStripMenuItem1.Visible = False
                    Início.ControleFinanceiroToolStripMenuItem.Visible = False

                    'Início.UsuáriosToolStripMenuItem1.Enabled = False
                    'Início.FuncionáriosToolStripMenuItem3.Enabled = False
                    'Início.VeículosToolStripMenuItem3.Enabled = False
                    'Início.BackupRestoreToolStripMenuItem1.Enabled = False
                    'Início.ControleFinanceiroToolStripMenuItem.Enabled = False

                    Início.Label4.Location = New Point(1216, 655)
                    Início.pgbProcessador.Location = New Point(1214, 674)
                    Início.lblProcessador.Location = New Point(1314, 671)
                    Início.Label6.Location = New Point(1214, 691)
                    Início.pgbMemoria.Location = New Point(1214, 707)
                    Início.Label7.Visible = False
                    Início.Label8.Visible = False
                    Início.Label9.Visible = False

                    Início.lblTotalMemoria.Visible = False
                    Início.lblMemoriaDisponível.Visible = False
                    Início.lblMemoriaUsada.Visible = False
                ElseIf Nivel = 3 Then 'contador
                    Início.CadastroToolStripMenuItem1.Enabled = False
                    Início.VendaToolStripMenuItem2.Enabled = False
                    Início.ControleDeVeículosToolStripMenuItem.Enabled = False
                    Início.ConsultaToolStripMenuItem1.Enabled = False
                    Início.BackupRestoreToolStripMenuItem1.Enabled = False
                    Início.Label4.Location = New Point(1216, 655)
                    Início.pgbProcessador.Location = New Point(1214, 674)
                    Início.lblProcessador.Location = New Point(1314, 671)
                    Início.Label6.Location = New Point(1214, 691)
                    Início.pgbMemoria.Location = New Point(1214, 707)
                    Início.Label7.Visible = False
                    Início.Label8.Visible = False
                    Início.Label9.Visible = False

                    Início.lblTotalMemoria.Visible = False
                    Início.lblMemoriaDisponível.Visible = False
                    Início.lblMemoriaUsada.Visible = False


                ElseIf Nivel = 4 Then 'gerencia



                    Início.BackupRestoreToolStripMenuItem1.Visible = False

                    'Início.BackupRestoreToolStripMenuItem1.Enabled = False
                    Início.Label4.Location = New Point(1216, 655)
                    Início.pgbProcessador.Location = New Point(1214, 674)
                    Início.lblProcessador.Location = New Point(1314, 671)
                    Início.Label6.Location = New Point(1214, 691)
                    Início.pgbMemoria.Location = New Point(1214, 707)
                    Início.Label7.Visible = False
                    Início.Label8.Visible = False
                    Início.Label9.Visible = False

                    Início.lblTotalMemoria.Visible = False
                    Início.lblMemoriaDisponível.Visible = False
                    Início.lblMemoriaUsada.Visible = False

                ElseIf Nivel = 5 Then 'técnico




                    Início.Label7.Visible = True
                    Início.Label8.Visible = True
                    Início.Label9.Visible = True

                    Início.lblTotalMemoria.Visible = True
                    Início.lblMemoriaDisponível.Visible = True
                    Início.lblMemoriaUsada.Visible = True
                    Início.Label4.Location = New Point(1216, 602)
                    Início.pgbProcessador.Location = New Point(1214, 621)
                    Início.lblProcessador.Location = New Point(1314, 618)
                    Início.Label6.Location = New Point(1214, 638)
                    Início.pgbMemoria.Location = New Point(1214, 654)

                End If

                If SenhaAtv = 0 Then
                    NovaSenha.Show()
                Else
                    Início.Show()
                End If

            Else
                MsgBox("Login ou senha invalidos", 32, "Login")
                TextBox1.Clear()
                TextBox2.Clear()
                TextBox1.Focus()
            End If
            cn.Close()
            cn.Dispose()
        Catch ex As Exception
            MsgBox("Falha ao iniciar aplicação, tente reiniciar. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim Resultado As DialogResult
            Resultado = MessageBox.Show("Deseja encerrar?", "Transportadora Eagles", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            Select Case Resultado
                Case Windows.Forms.DialogResult.Yes
                    Me.Close()
                    Barra_Progresso.Close()
                Case Windows.Forms.DialogResult.No

            End Select


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Falha ao fechar a aplicação")
        End Try



    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.Cursor = Cursors.WaitCursor
            Dim cmd As New SqlCommand
            Dim cn As New SqlConnection
            Dim mr As SqlDataReader
            Dim Nivel As Integer
            Dim SenhaAtv As Integer
            ' Dim retorno As Integer
            cn = New SqlConnection("server=(local)\SQLEXPRESS;uid=sa;pwd=123456;database=Transportadora_Eagles")
            Try
                cn.Open()
                With cmd
                    .Connection = cn
                    .CommandTimeout = 0
                    .CommandText = "select * from Usuario where Id_Usuario='" & TextBox1.Text & "' And Id_Senha='" & TextBox2.Text & "'"
                    .CommandType = CommandType.Text
                End With
                mr = cmd.ExecuteReader
                If mr.Read Then
                    Nivel = mr!Nivel_acesso
                    SenhaAtv = mr!SenhaAtv


                    cn.Close()
                    cn.Dispose()
                    If Nivel = 1 Then 'recepcionista

                        Início.VendaToolStripMenuItem2.Visible = False
                        Início.CadastroToolStripMenuItem1.Visible = False
                        Início.ControleDeVeículosToolStripMenuItem.Visible = False
                        Início.BackupRestoreToolStripMenuItem1.Visible = False
                        Início.ControleFinanceiroToolStripMenuItem.Visible = False

                        'Início.VendaToolStripMenuItem2.Enabled = False
                        'Início.CadastroToolStripMenuItem1.Enabled = False
                        'Início.ControleDeVeículosToolStripMenuItem.Enabled = False
                        'Início.BackupRestoreToolStripMenuItem1.Enabled = False
                        'Início.ControleFinanceiroToolStripMenuItem.Enabled = False


                        Início.Label4.Location = New Point(1216, 655)
                        Início.pgbProcessador.Location = New Point(1214, 674)
                        Início.lblProcessador.Location = New Point(1314, 671)
                        Início.Label6.Location = New Point(1214, 691)
                        Início.pgbMemoria.Location = New Point(1214, 707)
                        Início.Label7.Visible = False
                        Início.Label8.Visible = False
                        Início.Label9.Visible = False

                        Início.lblTotalMemoria.Visible = False
                        Início.lblMemoriaDisponível.Visible = False
                        Início.lblMemoriaUsada.Visible = False

                    ElseIf Nivel = 2 Then 'vendedor


                        Início.UsuáriosToolStripMenuItem1.Visible = False
                        Início.FuncionáriosToolStripMenuItem3.Visible = False
                        Início.VeículosToolStripMenuItem3.Visible = False
                        Início.BackupRestoreToolStripMenuItem1.Visible = False
                        Início.ControleFinanceiroToolStripMenuItem.Visible = False

                        'Início.UsuáriosToolStripMenuItem1.Enabled = False
                        'Início.FuncionáriosToolStripMenuItem3.Enabled = False
                        'Início.VeículosToolStripMenuItem3.Enabled = False
                        'Início.BackupRestoreToolStripMenuItem1.Enabled = False
                        'Início.ControleFinanceiroToolStripMenuItem.Enabled = False

                        Início.Label4.Location = New Point(1216, 655)
                        Início.pgbProcessador.Location = New Point(1214, 674)
                        Início.lblProcessador.Location = New Point(1314, 671)
                        Início.Label6.Location = New Point(1214, 691)
                        Início.pgbMemoria.Location = New Point(1214, 707)
                        Início.Label7.Visible = False
                        Início.Label8.Visible = False
                        Início.Label9.Visible = False

                        Início.lblTotalMemoria.Visible = False
                        Início.lblMemoriaDisponível.Visible = False
                        Início.lblMemoriaUsada.Visible = False
                    ElseIf Nivel = 3 Then 'contador
                        Início.CadastroToolStripMenuItem1.Enabled = False
                        Início.VendaToolStripMenuItem2.Enabled = False
                        Início.ControleDeVeículosToolStripMenuItem.Enabled = False
                        Início.ConsultaToolStripMenuItem1.Enabled = False
                        Início.BackupRestoreToolStripMenuItem1.Enabled = False
                        Início.Label4.Location = New Point(1216, 655)
                        Início.pgbProcessador.Location = New Point(1214, 674)
                        Início.lblProcessador.Location = New Point(1314, 671)
                        Início.Label6.Location = New Point(1214, 691)
                        Início.pgbMemoria.Location = New Point(1214, 707)
                        Início.Label7.Visible = False
                        Início.Label8.Visible = False
                        Início.Label9.Visible = False

                        Início.lblTotalMemoria.Visible = False
                        Início.lblMemoriaDisponível.Visible = False
                        Início.lblMemoriaUsada.Visible = False


                    ElseIf Nivel = 4 Then 'gerencia



                        Início.BackupRestoreToolStripMenuItem1.Visible = False

                        'Início.BackupRestoreToolStripMenuItem1.Enabled = False
                        Início.Label4.Location = New Point(1216, 655)
                        Início.pgbProcessador.Location = New Point(1214, 674)
                        Início.lblProcessador.Location = New Point(1314, 671)
                        Início.Label6.Location = New Point(1214, 691)
                        Início.pgbMemoria.Location = New Point(1214, 707)
                        Início.Label7.Visible = False
                        Início.Label8.Visible = False
                        Início.Label9.Visible = False

                        Início.lblTotalMemoria.Visible = False
                        Início.lblMemoriaDisponível.Visible = False
                        Início.lblMemoriaUsada.Visible = False

                    ElseIf Nivel = 5 Then 'técnico




                        Início.Label7.Visible = True
                        Início.Label8.Visible = True
                        Início.Label9.Visible = True

                        Início.lblTotalMemoria.Visible = True
                        Início.lblMemoriaDisponível.Visible = True
                        Início.lblMemoriaUsada.Visible = True
                        Início.Label4.Location = New Point(1216, 602)
                        Início.pgbProcessador.Location = New Point(1214, 621)
                        Início.lblProcessador.Location = New Point(1314, 618)
                        Início.Label6.Location = New Point(1214, 638)
                        Início.pgbMemoria.Location = New Point(1214, 654)

                    End If

                    If SenhaAtv = 0 Then
                        NovaSenha.Show()
                    Else
                        Início.Show()
                    End If

                Else
                    MsgBox("Login ou senha invalidos", 32, "Login")
                    TextBox1.Clear()
                    TextBox2.Clear()
                    TextBox1.Focus()
                End If
                cn.Close()
                cn.Dispose()
            Catch ex As Exception
                MsgBox("Falha ao iniciar aplicação, tente reiniciar. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
            End Try
            Me.Cursor = Cursors.Default
        End If
    End Sub
End Class