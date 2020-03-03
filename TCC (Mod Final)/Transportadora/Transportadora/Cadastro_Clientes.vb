Imports System.Data.SqlClient
Public Class Cadastro_Clientes
    Dim Cidade As Integer
    Dim UF As Integer
    Dim Codigo As Integer
    Private Sub VoltarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VoltarToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub NovoClienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovoClienteToolStripMenuItem.Click
        TextBox1.ReadOnly = False
        TextBox2.ReadOnly = False
        TextBox3.ReadOnly = False
        TextBox4.ReadOnly = False
        TextBox5.ReadOnly = False
        TextBox6.ReadOnly = False
        TextBox7.ReadOnly = False
        TextBox8.ReadOnly = False
        TextBox9.ReadOnly = False
        TextBox10.ReadOnly = False
        TextBox11.ReadOnly = False
        TextBox12.ReadOnly = False
        TextBox13.ReadOnly = False
        Button2.Text = "Concluir"
        Button3.Visible = True




    End Sub

    Private Sub AlterarClienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlterarClienteToolStripMenuItem.Click
        TextBox1.ReadOnly = False
        TextBox2.ReadOnly = False
        TextBox3.ReadOnly = False
        TextBox4.ReadOnly = False
        TextBox5.ReadOnly = False
        TextBox6.ReadOnly = False
        TextBox7.ReadOnly = False
        TextBox8.ReadOnly = False
        TextBox9.ReadOnly = False
        TextBox10.ReadOnly = False
        TextBox11.ReadOnly = False
        TextBox12.ReadOnly = False
        TextBox13.ReadOnly = False
        Button2.Text = "Confirmar"
        Button3.Visible = True


    End Sub

    Private Sub PreencherCamposToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreencherCamposToolStripMenuItem.Click
        If TextBox6.Text = "" And TextBox3.Text = "" Then
            MsgBox("Digíte o Código ou CNPJ do cliente")
            TextBox1.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox2.Clear()
            TextBox5.Clear()
            TextBox6.Clear()
            TextBox7.Clear()
            TextBox8.Clear()
            TextBox9.Clear()
            TextBox10.Clear()
            TextBox11.Clear()
            TextBox12.Clear()
            TextBox13.Clear()
        Else
            TextBox1.ReadOnly = True
            TextBox2.ReadOnly = True
            TextBox3.ReadOnly = True
            TextBox4.ReadOnly = True
            TextBox5.ReadOnly = True
            TextBox6.ReadOnly = True
            TextBox7.ReadOnly = True
            TextBox8.ReadOnly = True
            TextBox9.ReadOnly = True
            TextBox10.ReadOnly = True
            TextBox11.ReadOnly = True
            TextBox12.ReadOnly = True
            TextBox13.ReadOnly = True
            Dim cn As New SqlConnection
            cn = New SqlConnection("server=(local)\SQLEXPRESS;uid=sa;pwd=123456;database=Transportadora_Eagles")
            Try
                Dim a As String
                Dim cmd As New SqlCommand
                Dim mr As SqlDataReader  ' para listagem

                If TextBox6.Text <> "" Then

                    cn.Open()
                    With cmd
                        .Connection = cn
                        .CommandTimeout = 0
                        .CommandText = "select * from  Cliente where Codigo_cliente='" & TextBox6.Text & "'"
                        .CommandType = CommandType.Text
                    End With
                    mr = cmd.ExecuteReader   ' somente leitura
                    While mr.Read       ' somente para pesquisa e listagem
                        TextBox1.Text = mr!Razao_Social
                        TextBox2.Text = mr!Nome_Fantasia
                        TextBox3.Text = mr!CNPJ
                        TextBox8.Text = mr!Logradouro
                        TextBox7.Text = mr!Num
                        TextBox10.Text = mr!Complemento
                        TextBox9.Text = mr!Bairro
                        TextBox11.Text = mr!Cidade
                        TextBox12.Text = mr!UF
                        TextBox13.Text = mr!CEP
                        TextBox5.Text = mr!Email
                        a = mr!Atividade
                    End While
                    cn.Close()
                ElseIf TextBox3.Text <> "" Then

                    cn.Open()
                    With cmd
                        .Connection = cn
                        .CommandTimeout = 0
                        .CommandText = "select * from  Cliente where CNPJ = '" & TextBox3.Text & "'"
                        .CommandType = CommandType.Text
                    End With
                    mr = cmd.ExecuteReader   ' somente leitura
                    While mr.Read       ' somente para pesquisa e listagem
                        TextBox6.Text = mr!Codigo_cliente
                        TextBox1.Text = mr!Razao_Social
                        TextBox2.Text = mr!Nome_Fantasia
                        TextBox8.Text = mr!Logradouro
                        TextBox7.Text = mr!Num
                        TextBox10.Text = mr!Complemento
                        TextBox9.Text = mr!Bairro
                        TextBox11.Text = mr!Cidade
                        TextBox12.Text = mr!UF
                        TextBox13.Text = mr!CEP
                        TextBox4.Text = mr!Telefone
                        TextBox5.Text = mr!Email
                        a = mr!Atividade
                    End While
                    cn.Close()

                End If
                If a = "False" Then
                    TextBox4.Text = "Inativo"
                ElseIf a = "True" Then
                    TextBox4.Text = "Ativo"
                End If
                AlterarClienteToolStripMenuItem.Enabled = True
            Catch ex As Exception
                MsgBox("Não foi possível preencher os campos, revise o Código ou CNPJ e tente novamente. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
            Finally
                cn.Close()
            End Try

        End If
    End Sub
    Private Sub LimparToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LimparToolStripMenuItem.Click
        TextBox1.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox2.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox10.Clear()
        TextBox11.Clear()
        TextBox12.Clear()
        TextBox13.Clear()
        TextBox6.ReadOnly = False
        TextBox3.ReadOnly = False
        NovoClienteToolStripMenuItem.Enabled = True
    End Sub

    Private Sub TextBox13_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox13.LostFocus

        Dim cn As New SqlConnection
            Dim cmd As New SqlCommand
            Dim mr As SqlDataReader  ' para listagem
        cn = New SqlConnection("server=(local)\SQLEXPRESS;uid=sa;pwd=123456;database=Transportadora_Eagles")
        Try
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
                'TextBox10.Text = ""
                'TextBox7.Text = ""
            End While
            cn.Close()
        Catch ex As Exception
            MsgBox("Não foi possível realizar a consulta de CEP, revise os dados ou insira o endereço manualmente. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub TextBox3_LostFocus(sender As Object, e As System.EventArgs) Handles TextBox3.LostFocus
        If Not ValidaCNPJ(TextBox3.Text) Then
            TextBox3.BackColor = Color.Red
        Else
            TextBox3.BackColor = Color.White
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        TelefoneFuncionario.Show()
    End Sub
    Private Sub TextBox3_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox3.TextChanged
        PreencherCamposToolStripMenuItem.Enabled = True
        AlterarClienteToolStripMenuItem.Enabled = True
        If TextBox3.Text = "" Then
            AlterarClienteToolStripMenuItem.Enabled = False
            PreencherCamposToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cn As SqlConnection
        Dim cmd As New SqlCommand
        If Button2.Text = "Excluir Cliente" Then


            Dim Resultado As DialogResult
            Resultado = MessageBox.Show("Deseja excluir o cliente " & TextBox1.Text & "?", "Transportadora Eagles", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            Select Case Resultado
                Case Windows.Forms.DialogResult.Yes


                    Try

                        Dim retorno As Integer

                        cn = New SqlConnection("server=(local)\SQLEXPRESS;uid=sa;pwd=123456;database=Transportadora_Eagles")
                        cn.Open()

                        With cmd
                            .Connection = cn
                            .CommandTimeout = 0
                            .CommandText = "Update Cliente set Atividade = 0 where Codigo_cliente = '" & TextBox6.Text & "'"
                            .CommandType = CommandType.Text
                        End With

                        retorno = cmd.ExecuteNonQuery

                        MsgBox("Exclusão efetuada com sucesso")
                        TextBox1.Clear()
                    Catch ex As Exception
                        MsgBox("Falha durante exclusão, tente realizar a operação novamente. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
                    Finally
                        cn.Close()
                    End Try
                Case Windows.Forms.DialogResult.No
            End Select
        End If
        If Button2.Text = "Concluir" Then
            Dim Resultado As DialogResult
            Resultado = MessageBox.Show("Deseja inserir novo cliente com os dados fornecidos?", "Transportadora Eagles", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            Select Case Resultado
                Case Windows.Forms.DialogResult.Yes
                    Dim mr As SqlDataReader
                    Try
                        Dim retorno As Integer

                        cn = New SqlConnection("server=(local)\SQLEXPRESS;uid=sa;pwd=123456;database=Transportadora_Eagles")
                        cn.Open()

                        With cmd
                            .Connection = cn
                            .CommandTimeout = 0
                            .CommandText = "insert into Cliente(Razao_Social, Nome_Fantasia, CNPJ, Logradouro, Num, Complemento, Bairro, Cidade, UF, CEP, Email ) values ('" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & TextBox3.Text & "', '" & TextBox8.Text & "', '" & TextBox7.Text & "' , '" & TextBox10.Text & "', '" & TextBox9.Text & "', '" & TextBox11.Text & "','" & TextBox12.Text & "','" & TextBox13.Text & "','" & TextBox5.Text & "')"
                            .CommandType = CommandType.Text
                        End With

                        retorno = cmd.ExecuteNonQuery
                        cn.Close()
                        cn.Open()
                        With cmd
                            .Connection = cn
                            .CommandTimeout = 0
                            .CommandText = "select * from  Cliente where Razao_Social='" & TextBox1.Text & "'"
                            .CommandType = CommandType.Text
                        End With
                        mr = cmd.ExecuteReader
                        While mr.Read
                            Codigo = mr!Codigo_cliente
                        End While
                        cn.Close()
                        If TelefoneFuncionario.TextBox1.Text <> "" Then
                            cn.Open()
                            With cmd
                                .Connection = cn
                                .CommandTimeout = 0
                                .CommandText = "insert into Telefone_cliente(Codigo_cliente, Numero, Operadora) values ('" & Codigo & "', '" & TelefoneFuncionario.TextBox1.Text & "', '" & TelefoneFuncionario.ComboBox1.Text & "')"
                                .CommandType = CommandType.Text
                            End With

                            retorno = cmd.ExecuteNonQuery
                            cn.Close()
                        End If
                        If TelefoneFuncionario.TextBox2.Text <> "" Then
                            cn.Open()
                            With cmd
                                .Connection = cn
                                .CommandTimeout = 0
                                .CommandText = "insert into Telefone_cliente(Codigo_cliente, Numero, Operadora) values ('" & Codigo & "', '" & TelefoneFuncionario.TextBox2.Text & "', '" & TelefoneFuncionario.ComboBox1.Text & "')"
                                .CommandType = CommandType.Text
                            End With

                            retorno = cmd.ExecuteNonQuery
                            cn.Close()
                        End If
                        MsgBox("Cadastro efetuado com sucesso")
                        TextBox1.Clear()
                        TextBox3.Clear()
                        TextBox2.Clear()
                        TextBox4.Clear()
                        TextBox5.Clear()
                        TextBox6.Clear()
                        TextBox7.Clear()
                        TextBox8.Clear()
                        TextBox9.Clear()
                        TextBox10.Clear()
                        TextBox11.Clear()
                        TextBox12.Clear()
                        TextBox13.Clear()
                    Catch ex As Exception
                        MsgBox("Falha durante cadastro, tente realizar a operação novamente.", MsgBoxStyle.Information, "Transportadora Eagles")
                    End Try
                Case Windows.Forms.DialogResult.No
            End Select
        End If


        If Button2.Text = "Confirmar" Then
            Dim Resultado As DialogResult
            Resultado = MessageBox.Show("Deseja alterar cliente com os dados fornecidos?", "Transportadora Eagles", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            Select Case Resultado
                Case Windows.Forms.DialogResult.Yes
                    Try
                        Dim retorno As Integer

                        cn = New SqlConnection("server=(local)\SQLEXPRESS;uid=sa;pwd=123456;database=Transportadora_Eagles")
                        cn.Open()

                        With cmd
                            .Connection = cn
                            .CommandTimeout = 0
                            .CommandText = "Update Cliente Set Razao_Social =('" & TextBox1.Text & "'),Nome_Fantasia =('" & TextBox2.Text & "'), CNPJ =('" & TextBox3.Text & "'), Logradouro =('" & TextBox8.Text & "'), Num =('" & TextBox7.Text & "'), Complemento =('" & TextBox10.Text & "'), Bairro =('" & TextBox9.Text & "'), Cidade =('" & TextBox11.Text & "'), UF =('" & TextBox12.Text & "'), CEP =('" & TextBox13.Text & "'), Email =('" & TextBox5.Text & "') where Codigo_cliente= '" & TextBox6.Text & "'"
                            .CommandType = CommandType.Text
                        End With

                        retorno = cmd.ExecuteNonQuery
                        MsgBox("Alteração efetuada com sucesso")
                        TextBox1.Clear()
                        TextBox3.Clear()
                        TextBox4.Clear()
                        TextBox2.Clear()
                        TextBox5.Clear()
                        TextBox6.Clear()
                        TextBox7.Clear()
                        TextBox8.Clear()
                        TextBox9.Clear()
                        TextBox10.Clear()
                        TextBox11.Clear()
                        TextBox12.Clear()
                        TextBox13.Clear()
                    Catch ex As Exception
                        MsgBox("Falha durante a alteração, tente realizar a operação novamente.", MsgBoxStyle.Information, "Transportadora Eagles")
                    Finally
                        cn.Close()
                    End Try

                Case Windows.Forms.DialogResult.No
            End Select
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Button3.Visible = False
        TextBox1.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox2.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox10.Clear()
        TextBox11.Clear()
        TextBox12.Clear()
        TextBox13.Clear()

        TextBox1.ReadOnly = True
        TextBox2.ReadOnly = True

        TextBox4.ReadOnly = True
        TextBox5.ReadOnly = True

        TextBox7.ReadOnly = True
        TextBox8.ReadOnly = True
        TextBox9.ReadOnly = True
        TextBox10.ReadOnly = True
        TextBox11.ReadOnly = True
        TextBox12.ReadOnly = True
        TextBox13.ReadOnly = True

        NovoClienteToolStripMenuItem.Enabled = True

        Button2.Text = "Excluir Cliente"
    End Sub

    Private Sub Cadastro_Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cn As New SqlConnection("server=(local)\SQLEXPRESS;uid=sa;pwd=123456;database=Transportadora_Eagles")
        Dim cmd As New SqlCommand
        Dim mr As SqlDataReader
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable

        DataGridView1.DataSource = ""
        cn.Open()
        With cmd
            .Connection = cn
            .CommandTimeout = 0
            .CommandText = "select Codigo_cliente, Nome_Fantasia, CNPJ from Cliente"
            .CommandType = CommandType.Text
        End With
        With da
            .SelectCommand = cmd
            .Fill(dt)
            .Dispose()
            DataGridView1.DataSource = dt
        End With
        cn.Close()
    End Sub


End Class