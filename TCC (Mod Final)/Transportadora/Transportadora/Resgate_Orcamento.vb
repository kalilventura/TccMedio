Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Public Class Resgate_Orcamento
    Dim objWord As Microsoft.Office.Interop.Word.Application
    Dim objDoc As Microsoft.Office.Interop.Word.Document
    Dim cn As SqlConnection
    Dim cmd As New SqlCommand
    Dim mr As SqlDataReader
    Dim Cliente As Integer
    Dim CodigoCar As Integer
    Dim Distancia As Double
    Dim Veiculo As String

    Private Sub CancelarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarToolStripMenuItem.Click
        DadosCliente.Show()
        Me.Close()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox3.SelectedItem <> "" Then
            Dim cn As New SqlConnection
            Dim cmd As New SqlCommand
            Dim mr As SqlDataReader  ' para listagem

            cn = New SqlConnection("server=(local)\SQLEXPRESS;uid=sa;pwd=123456;database=Transportadora_Eagles")
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from  Orcamento where Codigo_orcamento='" & TextBox3.Text & "' and Cliente_Orc = '" & DadosCliente.TextBox6.Text & "'"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader   ' somente leitura
            While mr.Read       ' somente para pesquisa e listagem
                TextBox1.Text = mr!Valor_Venda
                TextBox6.Text = mr!Data_exp
                CodigoCar = mr!Codigo_carga
                If mr!Veiculo.ToString = "" Then
                    Veiculo = ""
                Else
                    Veiculo = mr!Veiculo
                End If
                If mr!Distancia_tot.ToString = "" Then
                    Distancia = 0
                Else
                    Distancia = mr!Distancia_tot
                End If
            End While
            cn.Close()
            If TextBox1.Text <> "" Then
                Button1.Visible = True
                Button2.Visible = False
            Else
                MsgBox("Orçamento referido não existe", MsgBoxStyle.Information, "Transportadora Eagles")
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim cn As SqlConnection
            Dim cmd As New SqlCommand
            Dim retorno As Integer
            cn = New SqlConnection("server=(local)\SQLEXPRESS;uid=sa;pwd=123456;database=Transportadora_Eagles")
            cn.Open()
            'Codigo_funcionario =('" & TextBox14.Text & "'),  
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "Update Veiculo Set Status = 1 where Placa= '" & Veiculo & "'"
                .CommandType = CommandType.Text
            End With

            retorno = cmd.ExecuteNonQuery   ' INC , EXC , ALT
            cn.Close()
            'Catch ex As Exception

            'End Try


            Dim CodigoFun As Integer
            '
            ' Try
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from  Usuario where Id_usuario='" & Início.ToolStripStatusLabel2.Text & "'"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            While mr.Read
                CodigoFun = mr!Codigo_funcionario
            End While
            cn.Close()
            'Catch ex As Exception

            'End Try
            'Try

            '    cn.Open()
            '    With cmd
            '        .Connection = cn
            '        .CommandTimeout = 0
            '        .CommandText = "Select TOP 1 * from Carga order by Codigo_carga desc"
            '        .CommandType = CommandType.Text
            '    End With
            '    mr = cmd.ExecuteReader
            '    While mr.Read
            '        CodigoCar = mr!Codigo_carga
            '    End While
            '    cn.Close()

            'Catch ex As Exception

            'End Try
            'Try
            ' Dim retorno As Integer
            If Veiculo <> "" And Distancia <> 0 Then


                cn.Open()

                With cmd
                    .Connection = cn
                    .CommandTimeout = 0
                    .CommandText = "insert into Venda(Forma_Pagamento, Valor_Venda, Data, Distancia_tot, Veiculo, Codigo_cliente, Codigo_funcionario, Codigo_carga) values ('" & ComboBox2.SelectedValue & " ', '" & TextBox1.Text & "', '" & Date.Now.ToString & "','" & Distancia & "','" & Veiculo & "', '" & Cliente & "' , '" & CodigoFun & "', '" & CodigoCar & "')"
                    .CommandType = CommandType.Text
                End With

                retorno = cmd.ExecuteNonQuery
                cn.Close()
            ElseIf Veiculo = "" And Distancia = 0 Then
                cn.Open()

                With cmd
                    .Connection = cn
                    .CommandTimeout = 0
                    .CommandText = "insert into Venda(Forma_Pagamento, Valor_Venda, Data, Distancia_tot, Codigo_cliente, Codigo_funcionario, Codigo_carga) values ('" & ComboBox2.SelectedValue & " ', '" & TextBox1.Text & "', '" & Date.Now.ToString & "', 0 ,'" & Cliente & "' , '" & CodigoFun & "', '" & CodigoCar & "')"
                    .CommandType = CommandType.Text
                End With

                retorno = cmd.ExecuteNonQuery
                cn.Close()

            End If
            cn.Open()

            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "insert into Contas(DataReceb, Valor, Descricao, Estado, Codigo_funcionario) values ('" & Date.Now.ToString & " ', '" & TextBox1.Text & "', '" & "Venda" & "','" & 1 & "', '" & CodigoFun & "')"
                .CommandType = CommandType.Text
            End With

            retorno = cmd.ExecuteNonQuery
            cn.Close()
            ' MsgBox("Venda Concluída")
            'Try


            cn.Open()

            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "delete from Orcamento where Codigo_orcamento = '" & TextBox3.Text & "'"
                .CommandType = CommandType.Text
            End With

            retorno = cmd.ExecuteNonQuery
            cn.Close()
            Dim Razao, CNPJ, Endereco As String
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from Cliente where Codigo_cliente='" & DadosCliente.TextBox6.Text & "'"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            While mr.Read
                Razao = mr!Razao_Social
                CNPJ = mr!CNPJ
                Endereco = mr!Logradouro
            End While
            cn.Close()

            objWord = New Microsoft.Office.Interop.Word.Application
            objDoc = objWord.Documents.Open("C:\Users\kalil\Desktop\TCC (Mod Final)\TransportadoraEagles(Modelo).docx")

            Call Lil("@RazaoSocial", Razao)
            Call Lil("@Endereco", Endereco)
            Call Lil("@CNPJ", CNPJ)
            Dim a As String = Date.Now.ToString
            a = a.Replace("/", "-")
            a = a.Replace(":", "-")
            objWord.ActiveDocument.SaveAs2("C:\Users\kalil\Desktop\Contratos\" & a & " " & Razao & ".docx")
            objDoc = objWord.Documents.Open("C:\Users\kalil\Desktop\Contratos\" & a & " " & Razao & ".docx")
            objDoc.PrintPreview()
            Dim Resultado As DialogResult
            Resultado = MessageBox.Show("Prosseguir com nova operação?", "Transportadora Eagles", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            Select Case Resultado
                Case Windows.Forms.DialogResult.Yes
                    ComboBox1.Enabled = False
                    ComboBox2.Enabled = False
                    Label23.Visible = False
                    Me.Width = 431
                    TextBox1.Text = ""
                    TextBox2.Text = ""
                    TextBox3.Text = ""
                    TextBox4.Text = ""
                    TextBox6.Text = ""
                Case (Windows.Forms.DialogResult.No)
                    Me.Close()
            End Select


            'Catch ex As Exception
            'MessageBox.Show(ex.Message)
            'End Try
        Catch ex As Exception
            MsgBox("Falha ao resgatar orçamento, tente novamente. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
        End Try
    End Sub
    Private Sub Lil(header As String, data As String)
        With objWord.Selection.Find
            .ClearFormatting()
            .Text = header
            .Execute()
            .Forward = True
        End With
        Clipboard.Clear()
        Clipboard.SetText(data)
        objWord.Selection.Paste()
        Clipboard.Clear()

    End Sub
    Private Sub Resgate_Orcamento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Transportadora_EaglesDataSet1.Tipo_carga' table. You can move, or remove it, as needed.
        Me.Tipo_cargaTableAdapter.Fill(Me.Transportadora_EaglesDataSet1.Tipo_carga)
        'TODO: This line of code loads data into the 'Transportadora_EaglesDataSet1.Forma_pagamento' table. You can move, or remove it, as needed.
        Me.Forma_pagamentoTableAdapter.Fill(Me.Transportadora_EaglesDataSet1.Forma_pagamento)
        TextBox4.Text = DadosCliente.Label10.Text
        cn = New SqlConnection("server=(local)\SQLEXPRESS;uid=sa;pwd=123456;database=Transportadora_Eagles")
        cn.Open()
        With cmd
            .Connection = cn
            .CommandTimeout = 0
            .CommandText = "select * from  Orcamento where Cliente_Orc = '" & DadosCliente.TextBox6.Text & "'"
            .CommandType = CommandType.Text
        End With
        mr = cmd.ExecuteReader   ' somente leitura
        While mr.Read

            TextBox3.Items.Add(mr!Codigo_orcamento)

        End While
        cn.Close()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        TextBox2.Text = FormatNumber(((Convert.ToDouble(TextBox1.Text)) / (Convert.ToInt32(ComboBox1.Text))), 2)
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text <> "" Then
            ComboBox1.Enabled = True
            ComboBox2.Enabled = True
            Label23.Visible = True
        Else
            ComboBox1.Enabled = False
            ComboBox2.Enabled = False
            Label23.Visible = False
        End If
    End Sub

    Private Sub Label23_Click(sender As Object, e As System.EventArgs) Handles Label23.Click
        If Me.Width = 431 Then
            Me.Width = 1157
            Label23.Text = "<< Menos"
            cn = New SqlConnection("server=(local)\SQLEXPRESS;uid=sa;pwd=123456;database=Transportadora_Eagles")
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from  Carga where Codigo_carga='" & CodigoCar & "'"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            While mr.Read
                MaskedTextBox2.Text = mr!Peso
                MaskedTextBox1.Text = mr!Cubagem
                ComboBox1.ValueMember = mr!Tipo_carga
                TextBox9.Text = mr!Valor
                TextBox8.Text = mr!Volumes
                MaskedTextBox4.Text = mr!MedidaA
                MaskedTextBox3.Text = mr!MedidaC
                TextBox7.Text = mr!MedidaL
            End While
            cn.Close()
        ElseIf Me.Width = 1157 Then
            Me.Width = 431
            Label23.Text = "Mais >>"
        End If
    End Sub

    Private Sub TextBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TextBox3.SelectedIndexChanged
        Button1.Visible = False
        Button2.Visible = True
    End Sub
End Class