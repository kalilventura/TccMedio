Imports System.Data.SqlClient
Public Class Login

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cmd As New SqlCommand
        Dim cn As New SqlConnection
        Dim mr As SqlDataReader
        cn = New SqlConnection("server=(local)\SQLSERVER;uid=sa;pwd=123456;database=Transportadora_Eagles")
        cn.Open()
        With cmd
            .Connection = cn
            .CommandTimeout = 0
            .CommandText = "select * from Usuarios where Id_Usuario='" & TextBox1.Text & "' And Id_Senha='" & TextBox2.Text & "'"
            .CommandType = CommandType.Text
        End With
        mr = cmd.ExecuteReader
        If mr.Read Then
            Início.Show()
        Else
            MsgBox("Login invalido", 32, "Login")
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox1.Focus()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        Barra_Progresso.Close()
    End Sub

End Class