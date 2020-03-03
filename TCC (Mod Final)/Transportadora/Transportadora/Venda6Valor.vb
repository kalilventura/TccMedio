Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Public Class Venda6Valor
    Dim objWord As Microsoft.Office.Interop.Word.Application
    Dim objDoc As Microsoft.Office.Interop.Word.Document
    Dim FretePeso As Double
    Dim FreteValor As Double
    Dim Pedagio As Double
    Dim Imp As Double
    Dim cn As SqlConnection
    Dim cmd As New SqlCommand
    Dim mr As SqlDataReader


    Private Sub CancelarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarToolStripMenuItem.Click
        Venda3Destino1.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim cn As SqlConnection
        Dim cmd As New SqlCommand
        cn = New SqlConnection("server=(local)\SQLEXPRESS;uid=sa;pwd=123456;database=Transportadora_Eagles")
        Try
            Dim retorno As Integer


            cn.Open()

            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "insert into Carga(Peso, MedidaA, MedidaL, MedidaC, Volumes, Cubagem, Valor, Tipo_Carga, Codigo_cliente) values ('" & Venda2DadosCarga.TextBox1.Text & " ', '" & Venda2DadosCarga.TextBox3.Text & "', '" & Venda2DadosCarga.TextBox7.Text & "', '" & Venda2DadosCarga.TextBox4.Text & "' , '" & Venda2DadosCarga.TextBox8.Text & "', '" & Venda2DadosCarga.TextBox6.Text & "', '" & Venda2DadosCarga.TextBox9.Text & "', '" & Venda2DadosCarga.ComboBox1.SelectedValue & "', '" & DadosCliente.TextBox6.Text & "')"
                .CommandType = CommandType.Text
            End With

            retorno = cmd.ExecuteNonQuery
            cn.Close()
        Catch ex As Exception
            MsgBox("Falha na gestão de dados, tente reiniciar a operação. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
        Finally
            cn.Close()
        End Try
        Venda7Orcamento.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cn As SqlConnection
        Dim cmd As New SqlCommand
        Dim CodigoCar, CodigoFun, CodigoFretamento As Integer
        cn = New SqlConnection("server=(local)\SQLEXPRESS;uid=sa;pwd=123456;database=Transportadora_Eagles")
        Try
            Dim retorno As Integer


            cn.Open()

            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "insert into Carga(Peso, MedidaA, MedidaL, MedidaC, Volumes, Cubagem, Valor, Tipo_Carga, Codigo_cliente) values ('" & Venda2DadosCarga.TextBox1.Text & " ', '" & Venda2DadosCarga.TextBox3.Text & "', '" & Venda2DadosCarga.TextBox7.Text & "', '" & Venda2DadosCarga.TextBox4.Text & "' , '" & Venda2DadosCarga.TextBox8.Text & "', '" & Venda2DadosCarga.TextBox6.Text & "', '" & Venda2DadosCarga.TextBox9.Text & "', '" & Venda2DadosCarga.ComboBox1.SelectedValue & "', '" & DadosCliente.TextBox6.Text & "')"
                .CommandType = CommandType.Text
            End With

            retorno = cmd.ExecuteNonQuery
            cn.Close()

            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "Select TOP 1 * from Carga order by Codigo_carga desc"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            While mr.Read
                CodigoCar = mr!Codigo_carga
            End While
            cn.Close()
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
            Dim DR1, DR2 As Date
            DR1 = Retirada.TextBox1.Text

            DR2 = Retirada.TextBox2.Text


            cn.Open()

            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "insert into Fretamento(Distancia_tot, Data_saida, Data_entrega, Codigo_funcionario, Codigo_carga) values ('" & Convert.ToInt32(Venda2DadosCarga.TextBox5.Text) & " ', '" & DR1.ToShortDateString & "', '" & DR2.ToShortDateString & "', '" & Convert.ToInt32(CodigoFun) & "' , '" & Convert.ToInt32(CodigoCar) & "')"
                .CommandType = CommandType.Text
            End With

            retorno = cmd.ExecuteNonQuery
            cn.Close()
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "Select TOP 1 * from Fretamento order by Codigo_fretamento desc"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            While mr.Read
                CodigoFretamento = mr!Codigo_fretamento
            End While
            cn.Close()
            cn.Open()

            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "insert into Entrega_retirada(Logradouro, Num, Complemento, Bairro, Cidade, UF, Ponto_ref, CEP, Veiculo, Tipo,Fretamento) values ('" & Retirada.TextBox8.Text & " ', '" & Retirada.TextBox7.Text & "', '" & Retirada.TextBox10.Text & "', '" & Retirada.TextBox9.Text & "' , '" & Retirada.TextBox11.Text & "', '" & Retirada.TextBox12.Text & "', '" & Retirada.TextBox3.Text & "', '" & Retirada.TextBox13.Text & "', '" & Venda2DadosCarga.ListBox1.SelectedItem & "',  0,'" & CodigoFretamento & "' )"
                .CommandType = CommandType.Text
            End With

            retorno = cmd.ExecuteNonQuery
            cn.Close()
            cn.Open()

            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "insert into Entrega_retirada(Logradouro, Num, Complemento, Bairro, Cidade, UF, Ponto_ref, CEP, Veiculo, Tipo,Fretamento) values ('" & Venda3Destino1.TextBox8.Text & " ', '" & Venda3Destino1.TextBox7.Text & "', '" & Venda3Destino1.TextBox10.Text & "', '" & Venda3Destino1.TextBox9.Text & "' , '" & Venda3Destino1.TextBox11.Text & "', '" & Venda3Destino1.TextBox12.Text & "', '" & Venda3Destino1.TextBox3.Text & "', '" & Venda3Destino1.TextBox13.Text & "', '" & Venda2DadosCarga.ListBox1.SelectedItem & "',  1,'" & CodigoFretamento & "' )"
                .CommandType = CommandType.Text
            End With

            retorno = cmd.ExecuteNonQuery
            cn.Close()

            If Label1.Text <> "" Then


                cn.Open()

                With cmd
                    .Connection = cn
                    .CommandTimeout = 0
                    .CommandText = "insert into Entrega_retirada(Logradouro, Num, Complemento, Bairro, Cidade, UF, Ponto_ref, CEP, Veiculo, Tipo,Fretamento) values ('" & Venda4Destino2.TextBox8.Text & " ', '" & Venda4Destino2.TextBox7.Text & "', '" & Venda4Destino2.TextBox10.Text & "', '" & Venda4Destino2.TextBox9.Text & "' , '" & Venda4Destino2.TextBox11.Text & "', '" & Venda4Destino2.TextBox12.Text & "', '" & Venda4Destino2.TextBox3.Text & "', '" & Venda4Destino2.TextBox13.Text & "', '" & Venda2DadosCarga.ListBox1.SelectedItem & "',  2,'" & CodigoFretamento & "' )"
                    .CommandType = CommandType.Text
                End With

                retorno = cmd.ExecuteNonQuery
                cn.Close()
            End If
            If Label2.Text <> "" Then


                cn.Open()

                With cmd
                    .Connection = cn
                    .CommandTimeout = 0
                    .CommandText = "insert into Entrega_retirada(Logradouro, Num, Complemento, Bairro, Cidade, UF, Ponto_ref, CEP, Veiculo, Tipo,Fretamento) values ('" & Venda5Destino3.TextBox8.Text & " ', '" & Venda5Destino3.TextBox7.Text & "', '" & Venda5Destino3.TextBox10.Text & "', '" & Venda5Destino3.TextBox9.Text & "' , '" & Venda5Destino3.TextBox11.Text & "', '" & Venda5Destino3.TextBox12.Text & "', '" & Venda5Destino3.TextBox3.Text & "', '" & Venda5Destino3.TextBox13.Text & "', '" & Venda2DadosCarga.ListBox1.SelectedItem & "',  3,'" & CodigoFretamento & "' )"
                    .CommandType = CommandType.Text
                End With

                retorno = cmd.ExecuteNonQuery
                cn.Close()
            End If
            'cn.Open()
            'With cmd
            '    .Connection = cn
            '    .CommandTimeout = 0
            '    .CommandText = "Select TOP 1 * from Entrega_retirada order by Codigo_entrega desc"
            '    .CommandType = CommandType.Text
            'End With
            'mr = cmd.ExecuteReader
            'While mr.Read
            '    Label4.Text = mr!Codigo_entrega
            'End While
            'cn.Close()
            'If Label8.Text <> "" Then
            'cn.Open()
            '    With cmd
            '        .Connection = cn
            '        .CommandTimeout = 0
            '        .CommandText = "insert into Fretamento_entrega(Codigo_entrega, Codigo_fretamento) values ('" & Convert.ToInt32(Label8.Text) & "' , '" & CodigoFretamento & "')"
            '        .CommandType = CommandType.Text
            '    End With
            '    retorno = cmd.ExecuteNonQuery
            '    cn.Close()
            ''End If
            ''If Label4.Text <> "" Then
            'cn.Open()

            '    With cmd
            '        .Connection = cn
            '        .CommandTimeout = 0
            '        .CommandText = "insert into Fretamento_entrega(Codigo_entrega, Codigo_fretamento) values ('" & Convert.ToInt32(Label4.Text) & "' , '" & CodigoFretamento & "')"
            '        .CommandType = CommandType.Text
            '    End With

            '    retorno = cmd.ExecuteNonQuery
            '    cn.Close()
            ''End If
            ''If Label5.Text <> "" Then

            'cn.Open()

            '    With cmd
            '        .Connection = cn
            '        .CommandTimeout = 0
            '        .CommandText = "insert into Fretamento_entrega(Codigo_entrega, Codigo_fretamento) values ('" & Convert.ToInt32(Label5.Text) & "' , '" & CodigoFretamento & "')"
            '        .CommandType = CommandType.Text
            '    End With

            '    retorno = cmd.ExecuteNonQuery
            '    cn.Close()
            ''End If
            ''If Label6.Text <> "" Then
            'cn.Open()
            '    With cmd
            '        .Connection = cn
            '        .CommandTimeout = 0
            '        .CommandText = "insert into Fretamento_entrega(Codigo_entrega, Codigo_fretamento) values ('" & Convert.ToInt32(Label6.Text) & "' , '" & CodigoFretamento & "')"
            '        .CommandType = CommandType.Text
            '    End With
            '    retorno = cmd.ExecuteNonQuery
            '    cn.Close()
            ''End If
        Catch ex As Exception
            MsgBox("Falha na gestão de dados, tente reiniciar a operação. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
        Finally
            cn.Close()
        End Try
        Try
            Dim retorno As Integer
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "Update Veiculo Set Status =('" & 1 & "') where Placa= '" & Venda2DadosCarga.ListBox1.Text & "'"
                .CommandType = CommandType.Text
            End With

            retorno = cmd.ExecuteNonQuery
            cn.Close()
        Catch ex As Exception
            MsgBox("Falha na gestão de dados, tente reiniciar a operação. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
        Finally
            cn.Close()
        End Try




        Try
            Dim retorno As Integer
            cn.Open()

            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "insert into Venda(Forma_Pagamento, Valor_Venda, Data, Distancia_tot, Veiculo, Codigo_cliente, Codigo_funcionario, Codigo_carga) values ('" & ComboBox2.SelectedValue & " ', '" & TextBox1.Text & "', '" & Date.Now.ToString & "','" & Venda2DadosCarga.TextBox5.Text & "','" & Venda2DadosCarga.ListBox1.Text & "', '" & DadosCliente.TextBox6.Text & "' , '" & CodigoFun & "', '" & CodigoCar & "')"
                .CommandType = CommandType.Text
            End With

            retorno = cmd.ExecuteNonQuery
            cn.Close()


            cn.Open()

            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "insert into Contas(DataReceb, Valor, Descricao, Estado, Codigo_funcionario) values ('" & Date.Now.ToString & " ', '" & TextBox1.Text & "', '" & "Venda" & "','" & 1 & "', '" & CodigoFun & "')"
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
        Catch ex As Exception
            MsgBox("Falha ao realizar venda, tente reiniciar a operação. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
        Finally
            cn.Close()
        End Try
        Me.Close()
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
    Private Sub Venda6Valor_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'Transportadora_EaglesDataSet1.Forma_pagamento' table. You can move, or remove it, as needed.
        Me.Forma_pagamentoTableAdapter.Fill(Me.Transportadora_EaglesDataSet1.Forma_pagamento)
        cn = New SqlConnection("server=(local)\SQLEXPRESS;uid=sa;pwd=123456;database=Transportadora_Eagles")
        Try
            If Convert.ToDouble(Venda2DadosCarga.TextBox1.Text) > Convert.ToDouble(Venda2DadosCarga.TextBox6.Text) Then
                FretePeso = (Convert.ToDouble(Venda2DadosCarga.TextBox1.Text) * 0.35)
                FreteValor = (Convert.ToDouble(Venda2DadosCarga.TextBox9.Text) * 0.005)
                Pedagio = (((Math.Ceiling(Convert.ToDouble(Venda2DadosCarga.TextBox1.Text))) / 100) * 2.5)
                Imp = ((FretePeso + FreteValor + Pedagio) * 0.12)
                TextBox1.Text = FormatNumber((FretePeso + FreteValor + Pedagio + Imp), 2)
            Else
                FretePeso = (Convert.ToDouble(Venda2DadosCarga.TextBox6.Text) * 0.35)
                FreteValor = (Convert.ToDouble(Venda2DadosCarga.TextBox9.Text) * 0.005)
                Pedagio = (((Math.Ceiling(Convert.ToDouble(Venda2DadosCarga.TextBox1.Text))) / 100) * 2.5)
                Imp = ((FretePeso + FreteValor + Pedagio) * 0.12)
                TextBox1.Text = FormatNumber((FretePeso + FreteValor + Pedagio + Imp), 2)
            End If

        Catch ex As Exception
            MsgBox("Falha ao calcular valor de venda, tente reiniciar a operação. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        TextBox2.Text = FormatNumber(((Convert.ToDouble(TextBox1.Text)) / (Convert.ToInt32(ComboBox1.Text))), 2)
    End Sub
End Class