Imports System.Data.SqlClient
Public Class SqlServer
    Public objconn As New SqlClient.SqlConnection  'Efetua a conexão com o Banco de Dados
    Public dados As New SqlClient.SqlCommand  'Executa as ações no Banco de Dados
    Public strConexao As String = "Data Source=(local)\SQLEXPRESS;Initial Catalog=Transportadora_Eagles;Persist Security Info=True;User ID=sa; Password=123456"
    Public restoreSucesso As Boolean

    Public Function Backup(ByVal strCaminho As String) As String
        Dim strBackup As String

        strBackup = "backup database Transportadora_Eagles " & vbCrLf _
                    & "to disk = '" & strCaminho & "'" & vbCrLf _
                    & "with name = 'BACKUP_" & Date.Now & "'," & vbCrLf _
                    & "SKIP," & vbCrLf _
                    & "NOUNLOAD," & vbCrLf _
                    & "        STATS = 10"

        Backup = BackupExec(strBackup.ToString)

        Return Backup
    End Function
    Public Function Restore(ByVal strCaminho As String) As String
        Dim strRestore As String

        'Apagar o banco antes de executar este processo
        strRestore = "EXEC msdb.dbo.sp_delete_database_backuphistory @database_name = 'Transportadora_Eagles' USE [master] ALTER DATABASE  [Transportadora_Eagles] SET  SINGLE_USER WITH ROLLBACK IMMEDIATE USE [master] DROP DATABASE [Transportadora_Eagles]" & vbCrLf _
                     & "RESTORE DATABASE Transportadora_Eagles " & vbCrLf _
                     & "from disk = '" & strCaminho & "'" & vbCrLf _
                     & "with REPLACE, STATS = 10 "

        Restore = RestoreExec(strRestore.ToString)

        Return Restore
    End Function
    Public Function Conectar(ByVal strCon As String) As SqlClient.SqlConnection 'OleDb.OleDbConnection
        With objconn

            .ConnectionString = strCon
            Try
                .Open()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End With
        Return objconn
    End Function
    Public Sub Desconectar()
        Try
            objconn.Close()
            objconn.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Function BackupExec(ByVal str_sql As String) As String

        objconn = Conectar(strConexao)

        With dados
            .CommandText = str_sql.ToString
            .CommandTimeout = 9999
            .CommandType = CommandType.Text
            .Connection = objconn
            Try
                .ExecuteNonQuery()
                Return "Backup Efetuado Com Sucesso!"
            Catch ex As Exception
                Return CStr(MessageBox.Show(ex.Message))
            Finally
                dados.Dispose()
                Desconectar()
            End Try
        End With
    End Function

    Public Function RestoreExec(ByVal str_sql As String) As String
        objconn = Conectar("Data Source=(local)\SQLEXPRESS;Initial Catalog=Transportadora_Eagles;Persist Security Info=True;User ID=sa; Password=123456")



        With dados
            .CommandText = str_sql.ToString
            .CommandTimeout = 9999
            .CommandType = CommandType.Text
            .Connection = objconn
            Try
                .ExecuteNonQuery()
                Return "Restore Efetuado Com Sucesso!"
                restoreSucesso = True
            Catch ex As Exception
                restoreSucesso = False
                Return CStr(MessageBox.Show(ex.Message))
            Finally
                dados.Dispose()
                Desconectar()
            End Try
        End With
    End Function














    'Function ObtemBancoDeDadosSQLSever(ByVal ConnString As String) As String()
    '    Dim cn As New SqlConnection("Server=(local)\SQLEXPRESS;uid=sa;pwd=123456;database=master")
    '    Dim dbLista As New ArrayList

    '    Dim cmd As New SqlCommand("SELECT * FROM sysdatabases", cn)
    '    Dim reader As SqlDataReader
    '    Try
    '        cn.Open()
    '        Try
    '            reader = cmd.ExecuteReader()
    '        Catch ex As Exception
    '            MsgBox(ex.Message())
    '        End Try
    '        While reader.Read()

    '            dbLista.Add(reader("name"))
    '        End While
    '    Finally
    '        cn.Close()
    '    End Try

    '    Return dbLista.ToArray(GetType(String))

    'End Function

    Function BackupDatabase(ByVal connString As String, ByVal nomeDB As String, ByVal backupFile As String)

        Dim cn As New SqlConnection("Server=(local)\SQLEXPRESS;uid=sa;pwd=123456;database=master")

        Try
            Dim cmdBackup As New SqlCommand("BACKUP DATABASE " & nomeDB & " TO DISK = '" & backupFile & "'", cn)
            cn.Open()
            cmdBackup.ExecuteNonQuery()
        Finally
            cn.Close()
        End Try
    End Function

    'Function RestauraDatabase(ByVal connString As String, ByVal nomeDB As String, ByVal backupFile As String)

    '    Dim cn As New SqlConnection("Server=(local)\SQLEXPRESS;uid=sa;pwd=123456;database=master")
    '    Try

    '        Dim cmdBackup As New SqlCommand("RESTORE DATABASE [" & nomeDB & "] FROM DISK = '" & backupFile & "'", cn)
    '        cn.Open()
    '        cmdBackup.ExecuteNonQuery()
    '    Finally
    '        cn.Close()
    '    End Try
    'End Function

End Class
