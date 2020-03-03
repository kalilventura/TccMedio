Imports System.Data.SqlClient

Public Class NovaSenha

    Private Sub TextBox1_LostFocus(sender As Object, e As System.EventArgs) Handles TextBox1.LostFocus
        If TextBox1.Text <> "" And TextBox2.Text <> "" Then
            If TextBox1.Text <> TextBox2.Text Then
                TextBox1.BackColor = Color.Red
                TextBox2.BackColor = Color.Red
                Button1.Enabled = False
            Else
                TextBox1.BackColor = Color.White
                TextBox2.BackColor = Color.White
                Button1.Enabled = True
            End If
        Else
            Button1.Enabled = False
        End If
    End Sub

    Private Sub TextBox2_LostFocus(sender As Object, e As System.EventArgs) Handles TextBox2.LostFocus
        If TextBox1.Text <> "" And TextBox2.Text <> "" Then
            If TextBox1.Text <> TextBox2.Text Then
                TextBox1.BackColor = Color.Red
                TextBox2.BackColor = Color.Red
                Button1.Enabled = False
            Else
                TextBox1.BackColor = Color.White
                TextBox2.BackColor = Color.White
                Button1.Enabled = True
            End If
        Else
            Button1.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim cn As SqlConnection
        Dim cmd As New SqlCommand
        cn = New SqlConnection("server=(local)\SQLEXPRESS;uid=sa;pwd=123456;database=Transportadora_Eagles")
        Try

            Dim retorno As Integer


            cn.Open()

            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "Update Usuario set SenhaAtv = 1, Id_senha = ('" & TextBox1.Text & "') where Id_usuario = '" & Login.TextBox1.Text & "'"
                .CommandType = CommandType.Text
            End With

            retorno = cmd.ExecuteNonQuery
            cn.Close()
            Me.Close()
            Início.Show()
        Catch ex As Exception
            MsgBox("Falha ao cadastrar nova senha, tente novamente. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As System.EventArgs) Handles TextBox2.TextChanged
        If TextBox1.Text <> "" And TextBox2.Text <> "" Then
            If TextBox1.Text <> TextBox2.Text Then
                'TextBox1.BackColor = Color.Red
                'TextBox2.BackColor = Color.Red
                'Button1.Enabled = False
            Else
                TextBox1.BackColor = Color.White
                TextBox2.BackColor = Color.White
                Button1.Enabled = True
            End If
        Else
            Button1.Enabled = False
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text <> "" And TextBox2.Text <> "" Then
            If TextBox1.Text <> TextBox2.Text Then
                'TextBox1.BackColor = Color.Red
                'TextBox2.BackColor = Color.Red
                'Button1.Enabled = False
            Else
                TextBox1.BackColor = Color.White
                TextBox2.BackColor = Color.White
                Button1.Enabled = True
            End If
        Else
            Button1.Enabled = False
        End If
    End Sub
End Class