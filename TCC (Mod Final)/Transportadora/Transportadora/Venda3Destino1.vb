Imports System.Data.SqlClient

Public Class Venda3Destino1

    Private Sub CancelarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CancelarToolStripMenuItem.Click
        Retirada.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If TextBox7.Text <> "" And TextBox8.Text <> "" And TextBox9.Text <> "" And TextBox11.Text <> "" And TextBox12.Text <> "" And TextBox13.Text <> "" Then
            'Dim cn As SqlConnection
            'Dim mr As SqlDataReader
            'Dim cmd As New SqlCommand
            'cn = New SqlConnection("server=(local)\SQLEXPRESS;uid=sa;pwd=123456;database=Transportadora_Eagles")
            'Try
            '    Dim retorno As Integer


            '    cn.Open()

            '    With cmd
            '        .Connection = cn
            '        .CommandTimeout = 0
            '        .CommandText = "insert into Entrega_retirada(Logradouro, Num, Complemento, Bairro, Cidade, UF, Ponto_ref, CEP, Veiculo, Tipo) values ('" & TextBox8.Text & " ', '" & TextBox7.Text & "', '" & TextBox10.Text & "', '" & TextBox9.Text & "' , '" & TextBox11.Text & "', '" & TextBox12.Text & "', '" & TextBox3.Text & "', '" & TextBox13.Text & "', '" & Venda2DadosCarga.ListBox1.SelectedItem & "',  1 )"
            '        .CommandType = CommandType.Text
            '    End With

            '    retorno = cmd.ExecuteNonQuery
            '    cn.Close()
            '    cn.Open()
            '    With cmd
            '        .Connection = cn
            '        .CommandTimeout = 0
            '        .CommandText = "Select TOP 1 * from Entrega_retirada order by Codigo_entrega desc"
            '        .CommandType = CommandType.Text
            '    End With
            '    mr = cmd.ExecuteReader
            '    While mr.Read
            '        Venda6Valor.Label4.Text = mr!Codigo_entrega
            '    End While
            '    cn.Close()
            'Catch ex As Exception

            'Finally
            '    cn.Close()
            'End Try
            Venda6Valor.Show()
            Me.Hide()
        Else
            MsgBox("Todos os campos devem ser preenchidos!", MsgBoxStyle.Exclamation, "ERROR-53105")
        End If



    End Sub


    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If TextBox7.Text <> "" And TextBox8.Text <> "" And TextBox9.Text <> "" And TextBox11.Text <> "" And TextBox12.Text <> "" And TextBox13.Text <> "" Then
            Venda4Destino2.Show()
            Me.Hide()
        End If
    End Sub



    Private Sub LimparToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LimparToolStripMenuItem.Click
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        TextBox12.Text = ""
        TextBox13.Text = ""
    End Sub

    Private Sub TextBox13_TextChanged(sender As Object, e As EventArgs) Handles TextBox13.TextChanged
        If TextBox13.Text.Length = 8 Then
            Dim cn As New SqlConnection
            cn = New SqlConnection("server=(local)\SQLEXPRESS;uid=sa;pwd=123456;database=Transportadora_Eagles")
            Try

                Dim cmd As New SqlCommand
                Dim mr As SqlDataReader  ' para listagem

                cn.Open()
                With cmd
                    .Connection = cn
                    .CommandTimeout = 0
                    .CommandText = "select * from  CEP where CEP='" & TextBox13.Text & "'"
                    .CommandType = CommandType.Text
                End With
                mr = cmd.ExecuteReader   ' somente leitura
                While mr.Read       ' somente para pesquisa e listagem
                    TextBox8.Text = mr!Descricao
                    TextBox9.Text = mr!Bairro
                    TextBox11.Text = mr!Cidade
                    TextBox12.Text = mr!UF
                End While
                cn.Close()
            Catch ex As Exception
                MsgBox("CEP inserido não localizado")
            Finally
                cn.Close()
            End Try
        End If
    End Sub
End Class