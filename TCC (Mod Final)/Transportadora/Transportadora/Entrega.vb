Imports System.Data.SqlClient

Public Class Entrega

    Dim cn As New SqlConnection
    Dim cmd As New SqlCommand
    Dim mr As SqlDataReader
    Dim Venda, cod As Integer
    Dim Veiculo, Setor As String
    Private Sub CancelarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CancelarToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

            Dim retorno As Integer


            cn.Open()
            'Codigo_funcionario =('" & TextBox14.Text & "'),  
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "Update Venda Set Data_entrega =('" & TextBox6.Text & "') where Codigo_venda= '" & cod & "'"
                .CommandType = CommandType.Text
            End With

            retorno = cmd.ExecuteNonQuery   ' INC , EXC , ALT
            cn.Close()

        If Veiculo <> "" Then


            cn.Open()
            'Codigo_funcionario =('" & TextBox14.Text & "'),  
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "Update Veiculo Set Status = 0 where Placa = '" & Veiculo & "'"
                .CommandType = CommandType.Text
            End With

            retorno = cmd.ExecuteNonQuery   ' INC , EXC , ALT
            cn.Close()

        End If
        cn.Open()
        'Codigo_funcionario =('" & TextBox14.Text & "'),  
        With cmd
            .Connection = cn
            .CommandTimeout = 0
            .CommandText = "Update Carga Set Atividade = 0 where Codigo_carga = '" & Venda & "'"
            .CommandType = CommandType.Text
        End With

        retorno = cmd.ExecuteNonQuery   ' INC , EXC , ALT
        cn.Close()
        If Setor <> "" Then


            cn.Open()
            'Codigo_funcionario =('" & TextBox14.Text & "'),  
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "Update Armazem Set Codigo_carga = null, Estado = 1 where Setor = '" & Setor & "'"
                .CommandType = CommandType.Text
            End With

            retorno = cmd.ExecuteNonQuery   ' INC , EXC , ALT
            cn.Close()
        End If
        Dim Resultado As DialogResult
        Resultado = MessageBox.Show("Prosseguir com nova operação?", "Transportadora Eagles", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        Select Case Resultado
            Case Windows.Forms.DialogResult.Yes
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox6.Text = Date.Now.ToString
                Dim cn As New SqlConnection("server=(local)\SQLEXPRESS;uid=sa;pwd=123456;database=Transportadora_Eagles")
                Dim cmd As New SqlCommand
                Dim mr As SqlDataReader
                cn.Open()
                With cmd
                    .Connection = cn
                    .CommandTimeout = 0
                    .CommandText = "select * from Venda where Data_entrega IS NULL"
                    .CommandType = CommandType.Text
                End With
                mr = cmd.ExecuteReader
                While mr.Read

                    ListBox1.Items.Add(mr!Codigo_carga)

                End While

                cn.Close()
            Case Windows.Forms.DialogResult.No
                Me.Close()
        End Select

    End Sub

    Private Sub Entrega_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TextBox6.Text = Date.Now.ToString
        Dim cn As New SqlConnection("server=(local)\SQLEXPRESS;uid=sa;pwd=123456;database=Transportadora_Eagles")
        Dim cmd As New SqlCommand
        Dim mr As SqlDataReader
        cn.Open()
        With cmd
            .Connection = cn
            .CommandTimeout = 0
            .CommandText = "select * from Venda where Data_entrega IS NULL"
            .CommandType = CommandType.Text
        End With
        mr = cmd.ExecuteReader
        While mr.Read

            ListBox1.Items.Add(mr!Codigo_carga)

        End While

        cn.Close()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

        cn = New SqlConnection("server=(local)\SQLEXPRESS;uid=sa;pwd=123456;database=Transportadora_Eagles")
        Try
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from Venda where Codigo_carga = '" & ListBox1.SelectedItem & "'"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            While mr.Read
                TextBox1.Text = mr!Codigo_cliente
                Venda = mr!Codigo_carga
                TextBox2.Text = mr!Valor_Venda
                cod = mr!Codigo_venda
                If mr!Veiculo.ToString = "" Then
                    Veiculo = ""
                Else
                    Veiculo = mr!Veiculo
                End If
            End While
            cn.Close()


            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from Armazem where Codigo_carga = '" & ListBox1.SelectedItem & "'"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            While mr.Read
                Setor = mr!Setor
            End While
            cn.Close()

        Catch ex As Exception
            MsgBox("Falha na obtenção de dados. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
        Finally
            cn.Close()
        End Try
    End Sub
End Class