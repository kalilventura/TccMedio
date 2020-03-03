Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Public Class ArmVenda3
    Dim objWord As Microsoft.Office.Interop.Word.Application
    Dim objDoc As Microsoft.Office.Interop.Word.Document
    Dim FretePeso As Double
    Dim FreteValor As Double
    Dim Pedagio As Double
    Dim Imp As Double
    Dim cn As SqlConnection
    Dim cmd As New SqlCommand
    Dim mr As SqlDataReader


    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim CodigoCar As Integer
        Try


            Dim retorno As Integer


            cn.Open()

            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "insert into Carga(Peso, MedidaA, MedidaL, MedidaC, Volumes, Cubagem, Valor, Tipo_Carga, Codigo_cliente) values ('" & ArmVenda2.TextBox1.Text & " ', '" & ArmVenda2.TextBox3.Text & "', '" & ArmVenda2.TextBox7.Text & "', '" & ArmVenda2.TextBox4.Text & "' , '" & ArmVenda2.TextBox8.Text & "', '" & ArmVenda2.TextBox6.Text & "', '" & ArmVenda2.TextBox9.Text & "', '" & ArmVenda2.ComboBox1.SelectedValue & "', '" & DadosCliente.TextBox6.Text & "')"
                .CommandType = CommandType.Text
            End With

            retorno = cmd.ExecuteNonQuery
            cn.Close()
            'Catch ex As Exception

            'End Try


            'Try

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

            'Catch ex As Exception

            'End Try
            'Try
            'Dim retorno As Integer
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "Update Armazem Set Codigo_carga =('" & CodigoCar & "'), Estado = 2  where Setor= '" & ArmVenda2.Label3.Text & "'"
                .CommandType = CommandType.Text
            End With
            retorno = cmd.ExecuteNonQuery
            ' Me.Close()
            cn.Close()
            'Catch ex As Exception

            'End Try


            Dim CodigoFun As Integer

            'Try
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
            'Dim retorno As Integer
            cn.Open()

            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "insert into Venda(Forma_Pagamento, Valor_Venda, Data, Distancia_tot, Codigo_cliente, Codigo_funcionario, Codigo_carga) values ('" & ComboBox2.SelectedValue & " ', '" & TextBox1.Text & "', '" & Date.Now.ToString & "','" & 0 & "', '" & DadosCliente.TextBox6.Text & "' , '" & CodigoFun & "', '" & CodigoCar & "')"
                .CommandType = CommandType.Text
            End With

            retorno = cmd.ExecuteNonQuery
            cn.Close()
            cn.Open()

            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "insert into Contas(DataReceb, Valor, Descricao, Estado,Tipo, Codigo_funcionario) values ('" & Date.Now.ToString & " ', '" & TextBox1.Text & "', '" & "Venda" & "','" & 1 & "','" & 2 & "', '" & CodigoFun & "')"
                .CommandType = CommandType.Text
            End With

            retorno = cmd.ExecuteNonQuery
            cn.Close()

            'cn.Close()
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
            MsgBox("Falha na venda, tente realizar a operação novamente. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
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
    Private Sub ArmVenda3_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'Transportadora_EaglesDataSet1.Forma_pagamento' table. You can move, or remove it, as needed.
        Me.Forma_pagamentoTableAdapter.Fill(Me.Transportadora_EaglesDataSet1.Forma_pagamento)
        cn = New SqlConnection("server=(local)\SQLEXPRESS;uid=sa;pwd=123456;database=Transportadora_Eagles")
        Try
            FreteValor = (Convert.ToDouble(ArmVenda2.TextBox9.Text) * 0.7)
            Imp = (FreteValor * 0.12)
            TextBox1.Text = FormatNumber((FreteValor + Imp), 2)
        Catch ex As Exception
            MsgBox("Falha na gestão de dados, tente reiniciar a operação. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim CodigoFun As Integer
        Try
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
        Catch ex As Exception
            MsgBox("Falha na gestão de dados, tente realizar a operação novamente. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
        Finally
            cn.Close()
        End Try
        cn.Open()
        Dim retorno As Integer
        With cmd
            .Connection = cn
            .CommandTimeout = 0
            .CommandText = "insert into Contas(DataReceb, Valor, Descricao, Estado, Codigo_funcionario) values ('" & Date.Now.ToString & " ', '" & TextBox1.Text & "', '" & "Venda" & "','" & 1 & "', '" & CodigoFun & "')"
            .CommandType = CommandType.Text
        End With

        retorno = cmd.ExecuteNonQuery
        cn.Close()
        ArmVenda4.Show()
        Me.Hide()
    End Sub

    Private Sub CancelarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarToolStripMenuItem.Click
        ArmVenda2.Show()
        Me.Hide()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        TextBox2.Text = FormatNumber(((Convert.ToDouble(TextBox1.Text)) / (Convert.ToInt32(ComboBox1.Text))), 2)
    End Sub
End Class