Imports System.Data.SqlClient
Public Class BackupRestore

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        '    Dim conexaoSQLServer As String = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Master"
        '    Dim sqlUtils As New SqlServer

        '    Dim databases() As String = sqlUtils.ObtemBancoDeDadosSQLSever(conexaoSQLServer)
        '    Dim listaDB As String
        '    For Each listaDB In databases
        '        lstBDSQLServer.Items.Add(listaDB)

        '    Next
        'Catch ex As Exception
        '    MsgBox("Falha em 'Listar bancos'")
        'End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Cursor = Cursors.WaitCursor
        Dim sqlUtils As New SqlServer
        Dim caminho As String = SaveFileDialog1.FileName

        Dim conexaoSQLServer As String = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Master"
        Try
            sqlUtils.BackupDatabase(conexaoSQLServer, "Transportadora_Eagles", caminho)
            MsgBox("Backup do banco de dados Transportadora_Eagles realizado com sucesso.")
            Dim cn As SqlConnection
            Dim cmd As New SqlCommand
            Dim retorno As Integer
            cn = New SqlConnection("server=(local)\SQLEXPRESS;uid=sa;pwd=123456;database=Transportadora_Eagles")
            Dim Data As String
            Data = Date.Now.ToShortDateString
            Data = Data.Replace("/", "-")
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "insert into DadosBackup(Data, Usuario) values ('" & Data & "', '" & Início.ToolStripStatusLabel2.Text & "')"
                .CommandType = CommandType.Text
            End With

            retorno = cmd.ExecuteNonQuery
            cn.Close()


        Catch ex As Exception
            MsgBox("Falha ao realizar Backup, reinicie a aplicação e tente novamente. Se o erro persistir consulte o suporte", MsgBoxStyle.Critical, "Transportadora Eagles")
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Cursor = Cursors.WaitCursor

        On Error GoTo Err
        Dim rst As New SqlServer

        'OpenFileDialog1.AddExtension = True
        'OpenFileDialog1.DefaultExt = ".bak"
        ''OpenFileDialog1.Filter = "All Files|*.*|bak Files (*)|*.bak"
        'OpenFileDialog1.Filter = "bak Files (*)|*.bak"
        'OpenFileDialog1.Title = "Escolha um backup para restaurar"
        'OpenFileDialog1.FileName = ""

        'OpenFileDialog1.ShowDialog()

        'TextBox2.Text = OpenFileDialog1.FileName

        If TextBox2.Text = "" Then
            MsgBox("Escolha um backup para restaurar!", MsgBoxStyle.Information, "Transportadora Eagles")
            'btnCaminho.Focus()
        Else
            Dim resposta As String = rst.Restore(OpenFileDialog1.FileName)

            MessageBox.Show(resposta)
            TextBox2.Text = ""
            MsgBox("A base de dados foi restaurada com sucesso. A aplicação será reiniciada!", MsgBoxStyle.Information, "Transportadora Eagles")
            Application.Restart()
            Me.Close()
        End If

        Exit Sub
Err:
        MsgBox("Falha ao restaurar backup, reinicie a aplicação e tente novamente. Se o erro persistir consulte o suporte", MsgBoxStyle.Critical, "Transportadora Eagles")
        TextBox2.Text = ""
        Exit Sub
        Me.Cursor = Cursors.Default








        'Try
        'Dim cmd As New SqlCommand
        'Dim cn As New SqlConnection("server=(local)\SQLEXPRESS;uid=sa;pwd=123456;database=master")
        'cn.Open()
        'With cmd
        '    .Connection = cn
        '    .CommandTimeout = 0
        '    .CommandText = "DECLARE @spid INT Declare @SQL VARCHAR(8000) SET @spid = @@SPID; SET @SQL = ''; SELECT @SQL += 'KILL ' + CONVERT(VARCHAR(5), spid) + ';'  FROM [master]..sysprocesses WHERE [dbid] = db_id('Transportadora_Eagles') and spid != @spid; EXEC(@SQL)"
        '    .CommandType = CommandType.Text
        'End With
        'cn.Close()
        'Dim conexaoSQLServer As String = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Master"

        'Dim sqlUtils As New SqlServer
        'Dim caminho As String = OpenFileDialog1.FileName

        'sqlUtils.RestauraDatabase(conexaoSQLServer, lstBDSQLServer.SelectedItem, caminho)
        'cn.Open()
        'MsgBox("Restauração do banco de dados " & lstBDSQLServer.SelectedItem & " efetuada com sucesso.")
        'Catch ex As Exception

        'End Try

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        TextBox1.Text = SaveFileDialog1.FileName
        Button1.Enabled = True
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        TextBox2.Text = OpenFileDialog1.FileName
        Button2.Enabled = True
    End Sub

    Private Sub lstBDSQLServer_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)
        Button4.Enabled = True
        Button5.Enabled = True
    End Sub

    Private Sub VoltarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VoltarToolStripMenuItem.Click
        Início.Show()
        Me.Close()
    End Sub

    Private Sub BackupRestore_Load(sender As Object, e As EventArgs) Handles Me.Load
        Início.Hide()
        Dim cn As New SqlConnection("server=(local)\SQLEXPRESS;uid=sa;pwd=123456;database=Transportadora_Eagles")
        Dim cmd As New SqlCommand
        Dim mr As SqlDataReader
        Dim Data1 As Date
        Dim Data As String
        cn.Open()
        With cmd
            .Connection = cn
            .CommandTimeout = 0
            .CommandText = "Select TOP 1 * from DadosBackup order by CodDados desc"
            .CommandType = CommandType.Text
        End With
        mr = cmd.ExecuteReader   ' somente leitura
        While mr.Read       ' somente para pesquisa e listagem
            Data = mr!data
        End While
        cn.Close()
        Data = Data.Replace("-", "/")
        Data1 = Data
        Label2.Text = Data
        Dim Hoje As Date = Date.Now.ToShortDateString
        If (Hoje - Data1).TotalDays <= 2 Then
            Label2.ForeColor = Color.Green
            Label1.ForeColor = Color.Green
        ElseIf (Hoje - Data1).TotalDays > 2 And (Hoje - Data1).TotalDays < 5 Then
            Label2.ForeColor = Color.Gold
            Label1.ForeColor = Color.Gold
        ElseIf (Hoje - Data1).TotalDays >= 5 Then
            Label2.ForeColor = Color.Red
            Label1.ForeColor = Color.Red
        End If
    End Sub
End Class
