Imports System.Data.SqlClient
Public Class Cadastro_Funcionários
    Dim Codigo As Integer
    Private Sub VoltarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VoltarToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub NovoFuncionárioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovoFuncionárioToolStripMenuItem.Click
        NovoFuncionárioToolStripMenuItem.Enabled = False
        AlterarFuncionárioToolStripMenuItem.Enabled = False
        Button3.Visible = True
        Button2.Text = "Concluir"
        TextBox14.Clear()
        ComboBox2.Text = Nothing
        ComboBox5.Text = Nothing
        TextBox1.Clear()
        TextBox3.Clear()
        TextBox5.Clear()
        TextBox4.Clear()
        TextBox6.Clear()
        TextBox9.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox10.Clear()
        TextBox15.Clear()
        TextBox2.Clear()
        TextBox18.Clear()
        TextBox17.Clear()
        TextBox12.Clear()
        ComboBox1.Text = Nothing
        ComboBox4.Text = Nothing
        TextBox16.Clear()
        TextBox11.Clear()
        TextBox13.Clear()
        ComboBox3.Text = Nothing

        TextBox14.ReadOnly = False
        ComboBox2.Enabled = True
        ComboBox5.Enabled = True
        TextBox9.ReadOnly = False
        TextBox1.ReadOnly = False
        TextBox3.ReadOnly = False
        TextBox5.ReadOnly = False
        TextBox4.ReadOnly = False
        TextBox6.ReadOnly = False
        TextBox7.ReadOnly = False
        TextBox8.ReadOnly = False
        TextBox10.ReadOnly = False
        TextBox15.ReadOnly = False
        TextBox2.ReadOnly = False
        TextBox18.ReadOnly = False
        TextBox17.ReadOnly = False
        TextBox12.ReadOnly = False
        ComboBox1.Enabled = True
        ComboBox4.Enabled = True
        TextBox16.ReadOnly = False
        TextBox11.ReadOnly = False
        TextBox13.ReadOnly = False
        ComboBox3.Enabled = True

    End Sub
    Private Sub AlterarFuncionárioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlterarFuncionárioToolStripMenuItem.Click
        NovoFuncionárioToolStripMenuItem.Enabled = False
        AlterarFuncionárioToolStripMenuItem.Enabled = False
        Button3.Visible = True
        Button2.Text = "Confirmar"
        TextBox14.ReadOnly = False
        ComboBox2.Enabled = True
        ComboBox5.Enabled = True
        TextBox1.ReadOnly = False
        TextBox3.ReadOnly = False
        TextBox5.ReadOnly = False
        TextBox4.ReadOnly = False
        TextBox6.ReadOnly = False
        TextBox7.ReadOnly = False
        TextBox8.ReadOnly = False
        TextBox10.ReadOnly = False
        TextBox15.ReadOnly = False
        TextBox2.ReadOnly = False
        TextBox18.ReadOnly = False
        TextBox17.ReadOnly = False
        TextBox12.ReadOnly = False
        ComboBox1.Enabled = True
        ComboBox4.Enabled = True
        TextBox16.ReadOnly = False
        TextBox11.ReadOnly = False
        TextBox13.ReadOnly = False
        ComboBox3.Enabled = True

    End Sub

    Private Sub PreencherCamposToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreencherCamposToolStripMenuItem.Click
        Dim cn As New SqlConnection
        Dim a As String
        Try
            If TextBox14.Text = "" And TextBox12.Text = "" Then
                MsgBox("Digíte o código ou CPF do funcionário")



                Dim cmd As New SqlCommand
                Dim mr As SqlDataReader

                If TextBox14.Text <> "" Then


                    cn = New SqlConnection("server=(local)\SQLEXPRESS;uid=sa;pwd=123456;database=Transportadora_Eagles")
                    cn.Open()
                    With cmd
                        .Connection = cn
                        .CommandTimeout = 0
                        .CommandText = "select * from  Funcionario where Codigo_funcionario='" & TextBox14.Text & "'"
                        .CommandType = CommandType.Text
                    End With
                    mr = cmd.ExecuteReader
                    While mr.Read
                        TextBox1.Text = mr!Nome_funcionario
                        TextBox9.Text = mr!Sobreome_Funcionario
                        ComboBox2.SelectedValue = mr!Codigo_cargo
                        TextBox5.Text = mr!Logradouro
                        TextBox6.Text = mr!Num
                        TextBox7.Text = mr!Complemento
                        TextBox8.Text = mr!Bairro
                        TextBox3.Text = mr!Cidade
                        TextBox4.Text = mr!UF
                        TextBox10.Text = mr!CEP
                        TextBox15.Text = mr!NIT_PIS_PASEP
                        TextBox2.Text = mr!RG
                        TextBox18.Text = mr!Titulo_Eleitor
                        TextBox17.Text = mr!Carteira_Habilitacao
                        TextBox12.Text = mr!CPF
                        ComboBox1.SelectedValue = mr!Grau_escolaridade
                        ComboBox3.SelectedValue = mr!Sexo
                        ComboBox5.SelectedValue = mr!Nacionalidade
                        ComboBox4.SelectedValue = mr!EstadoCivil
                        TextBox16.Text = mr!Data_Nascimento
                        a = mr!Atividade
                        TextBox13.Text = mr!Email
                    End While
                    cn.Close()

                ElseIf TextBox12.Text <> "" Then
                    cn = New SqlConnection("server=(local)\SQLEXPRESS;uid=sa;pwd=123456;database=Transportadora_Eagles")
                    cn.Open()
                    With cmd
                        .Connection = cn
                        .CommandTimeout = 0
                        .CommandText = "select * from  Funcionario where CPF='" & TextBox12.Text & "'"
                        .CommandType = CommandType.Text
                    End With
                    mr = cmd.ExecuteReader   ' somente leitura
                    While mr.Read       ' somente para pesquisa e listagem
                        TextBox14.Text = mr!Codigo_funcionario
                        TextBox1.Text = mr!Nome_funcionario
                        TextBox9.Text = mr!Sobreome_Funcionario
                        ComboBox2.SelectedValue = mr!Codigo_cargo
                        TextBox5.Text = mr!Logradouro
                        TextBox6.Text = mr!Num
                        TextBox7.Text = mr!Complemento
                        TextBox8.Text = mr!Bairro
                        TextBox3.Text = mr!Cidade
                        TextBox4.Text = mr!UF
                        TextBox10.Text = mr!CEP
                        TextBox15.Text = mr!NIT_PIS_PASEP
                        TextBox2.Text = mr!RG
                        TextBox18.Text = mr!Titulo_Eleitor
                        TextBox17.Text = mr!Carteira_Habilitacao
                        a = mr!Atividade
                        ComboBox1.SelectedValue = mr!Grau_escolaridade
                        ComboBox3.SelectedValue = mr!Sexo
                        ComboBox5.SelectedValue = mr!Nacionalidade
                        ComboBox4.SelectedValue = mr!EstadoCivil
                        TextBox16.Text = mr!Data_Nascimento
                        'TextBox19.Text = mr!Telefone
                        TextBox13.Text = mr!Email
                    End While
                    cn.Close()

                End If
                TextBox14.ReadOnly = True
                ComboBox2.Enabled = False
                ComboBox5.Enabled = False
                TextBox1.ReadOnly = True
                TextBox3.ReadOnly = True
                TextBox5.ReadOnly = True
                TextBox4.ReadOnly = True
                TextBox6.ReadOnly = True
                TextBox7.ReadOnly = True
                TextBox8.ReadOnly = True
                TextBox10.ReadOnly = True
                TextBox15.ReadOnly = True
                TextBox2.ReadOnly = True
                TextBox18.ReadOnly = True
                TextBox17.ReadOnly = True
                TextBox12.ReadOnly = True
                TextBox11.ReadOnly = True
                ComboBox1.Enabled = False
                ComboBox4.Enabled = False
                TextBox16.ReadOnly = True
                TextBox11.ReadOnly = True
                TextBox13.ReadOnly = True
                ComboBox3.Enabled = False
                Button2.Text = "Excluir Funcionário"
                AlterarFuncionárioToolStripMenuItem.Enabled = True
                NovoFuncionárioToolStripMenuItem.Enabled = True
            End If
        Catch ex As Exception
            MsgBox("Não foi possível preencher os campos, revise o Código ou CPF e tente novamente. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
        End Try
        If a = "False" Then
            TextBox11.Text = "Inativo"
        ElseIf a = "True" Then
            TextBox11.Text = "Ativo"
        End If
    End Sub

    Private Sub LimparToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LimparToolStripMenuItem.Click
        TextBox14.Text = ""
        ComboBox2.Text = Nothing
        ComboBox5.Text = Nothing
        TextBox1.Clear()
        TextBox3.Clear()
        TextBox5.Clear()
        TextBox4.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox10.Clear()
        TextBox15.Clear()
        TextBox2.Clear()
        TextBox18.Clear()
        TextBox17.Clear()
        TextBox12.Text = ""
        ComboBox1.Text = Nothing
        ComboBox4.Text = Nothing
        TextBox16.Clear()
        TextBox11.Clear()
        TextBox13.Clear()
        ComboBox3.Text = Nothing
        TextBox14.ReadOnly = False
        TextBox12.ReadOnly = False
        TextBox9.ReadOnly = True
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TelefoneFuncionario.Show()
    End Sub

    Private Sub TextBox10_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox10.LostFocus
        Dim cn As New SqlConnection
        Try

            Dim cmd As New SqlCommand
            Dim mr As SqlDataReader  ' para listagem
            cn = New SqlConnection("server=(local)\SQLEXPRESS;uid=sa;pwd=123456;database=Transportadora_Eagles")
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from  CEP where CEP='" & TextBox10.Text & "'"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader   ' somente leitura
            While mr.Read       ' somente para pesquisa e listagem
                TextBox5.Text = mr!Descricao
                TextBox8.Text = mr!Bairro
                TextBox3.Text = mr!Cidade
                TextBox4.Text = mr!UF
            End While
            cn.Close()
        Catch ex As Exception
            MsgBox("Não foi possível preencher os campos, revise o Código ou CNPJ e tente novamente. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub Cadastro_Funcionários_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim cn As New SqlConnection("server=(local)\SQLEXPRESS;uid=sa;pwd=123456;database=Transportadora_Eagles")
        Dim cmd As New SqlCommand
        'Dim mr As SqlDataReader
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable

        DataGridView1.DataSource = ""
        cn.Open()
        With cmd
            .Connection = cn
            .CommandTimeout = 0
            .CommandText = "select Codigo_funcionario, Nome_Funcionario, CPF from Funcionario"
            .CommandType = CommandType.Text
        End With
        With da
            .SelectCommand = cmd
            .Fill(dt)
            .Dispose()
            DataGridView1.DataSource = dt
        End With
        cn.Close()


        'TODO: This line of code loads data into the 'Transportadora_EaglesDataSet12.Sexo' table. You can move, or remove it, as needed.
        Me.SexoTableAdapter1.Fill(Me.Transportadora_EaglesDataSet12.Sexo)
        'TODO: This line of code loads data into the 'Transportadora_EaglesDataSet12.Escolaridade' table. You can move, or remove it, as needed.
        Me.EscolaridadeTableAdapter1.Fill(Me.Transportadora_EaglesDataSet12.Escolaridade)
        'TODO: This line of code loads data into the 'Transportadora_EaglesDataSet12.Nacionalidade' table. You can move, or remove it, as needed.
        Me.NacionalidadeTableAdapter1.Fill(Me.Transportadora_EaglesDataSet12.Nacionalidade)
        'TODO: This line of code loads data into the 'Transportadora_EaglesDataSet12.Estado_civil' table. You can move, or remove it, as needed.
        Me.Estado_civilTableAdapter1.Fill(Me.Transportadora_EaglesDataSet12.Estado_civil)
        'TODO: This line of code loads data into the 'Transportadora_EaglesDataSet12.Cargo' table. You can move, or remove it, as needed.
        Me.CargoTableAdapter1.Fill(Me.Transportadora_EaglesDataSet12.Cargo)




    End Sub

    Private Sub TextBox12_LostFocus(sender As Object, e As System.EventArgs) Handles TextBox12.LostFocus
        If FU_ValidaCPF(TextBox12.Text) = 0 Then
            TextBox12.BackColor = Color.Red '81.862.543/0001-10
            'TextBox12.Focus()
        Else
            TextBox12.BackColor = Color.White
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cn As SqlConnection
        Dim cmd As New SqlCommand
        If Button2.Text = "Excluir Funcionário" Then


            Dim Resultado As DialogResult
            Resultado = MessageBox.Show("Deseja excluir o Funcionário " & TextBox1.Text & " " & TextBox9.Text & "?", "Transportadora Eagles", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            Select Case Resultado
                Case Windows.Forms.DialogResult.Yes


                    Try

                        Dim retorno As Integer

                        cn = New SqlConnection("server=(local)\SQLEXPRESS;uid=sa;pwd=123456;database=Transportadora_Eagles")
                        cn.Open()

                        With cmd
                            .Connection = cn
                            .CommandTimeout = 0
                            .CommandText = "Update Funcionario set Atividade = 0 where Codigo_funcionario = '" & TextBox14.Text & "'"
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
            Resultado = MessageBox.Show("Deseja cadastrar novo funcionário " & TextBox1.Text & " " & TextBox9.Text & "?", "Transportadora Eagles", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            Select Case Resultado
                Case Windows.Forms.DialogResult.Yes
                    Dim hoje As Date = Date.Now.ToShortDateString

                    Dim Nasc As Date = Convert.ToDateTime(TextBox16.Text)

                    If (hoje - Nasc).TotalDays > 6570 Or CheckBox1.Checked = True Then

                        Dim mr As SqlDataReader
                        Try
                            Dim retorno As Integer

                            cn = New SqlConnection("server=(local)\SQLEXPRESS;uid=sa;pwd=123456;database=Transportadora_Eagles")
                            cn.Open()

                            With cmd
                                .Connection = cn
                                .CommandTimeout = 0
                                .CommandText = "insert into Funcionario(Nome_Funcionario, Sobreome_Funcionario, Codigo_cargo, Logradouro, Num, Complemento, Bairro, Cidade, UF, CEP, NIT_PIS_PASEP, RG, Titulo_Eleitor, Carteira_Habilitacao, CPF, Grau_Escolaridade, Sexo, EstadoCivil, Data_Nascimento, Email ) values ('" & TextBox1.Text & "', '" & TextBox9.Text & "'  ,'" & ComboBox2.SelectedValue & "', '" & TextBox5.Text & "', '" & TextBox6.Text & "', '" & TextBox7.Text & "' , '" & TextBox8.Text & "', '" & TextBox3.Text & "', '" & TextBox4.Text & "', '" & TextBox10.Text & "', '" & TextBox15.Text & "', '" & TextBox2.Text & "', '" & TextBox18.Text & "', '" & TextBox17.Text & "', '" & TextBox12.Text & "', '" & ComboBox1.SelectedValue & "', '" & ComboBox3.SelectedValue & "', '" & ComboBox4.SelectedValue & "', '" & TextBox16.Text & "', '" & TextBox13.Text & "')"
                                .CommandType = CommandType.Text
                            End With

                            retorno = cmd.ExecuteNonQuery
                            cn.Close()
                            cn.Open()
                            With cmd
                                .Connection = cn
                                .CommandTimeout = 0
                                .CommandText = "select * from  Funcionario where Nome_Funcionario='" & TextBox1.Text & "'"
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
                                    .CommandText = "insert into Telefone_funcionario(Codigo_funcionario, Numero, Operadora) values ('" & Codigo & "', '" & TelefoneFuncionario.TextBox1.Text & "', '" & TelefoneFuncionario.ComboBox1.Text & "')"
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
                                    .CommandText = "insert into Telefone_funcionario(Codigo_funcionario, Numero, Operadora) values ('" & Codigo & "', '" & TelefoneFuncionario.TextBox2.Text & "', '" & TelefoneFuncionario.ComboBox1.Text & "')"
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
                            MsgBox("Falha durante cadastro de novo funcionário, revise os dados e tente realizar a operação novamente. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
                        End Try
                    Else
                        TextBox16.BackColor = Color.Red
                    End If
                Case Windows.Forms.DialogResult.No
            End Select

        End If
        If Button2.Text = "Confirmar" Then
            Dim Resultado As DialogResult
            Resultado = MessageBox.Show("Deseja atualizar o cadastro de " & TextBox1.Text & " " & TextBox9.Text & "?", "Transportadora Eagles", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
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
                        MsgBox("Falha durante alteração, tente realizar a operação novamente. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
                    Finally
                        cn.Close()
                    End Try
                Case Windows.Forms.DialogResult.No
            End Select
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button2.Text = "Excluir Funcionário"
        TextBox14.Clear()
        ComboBox2.Text = Nothing
        ComboBox5.Text = Nothing
        TextBox1.Clear()
        TextBox3.Clear()
        TextBox5.Clear()
        TextBox4.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox10.Clear()
        TextBox15.Clear()
        TextBox2.Clear()
        TextBox18.Clear()
        TextBox9.Clear()
        TextBox17.Clear()
        TextBox12.Clear()
        ComboBox1.Text = Nothing
        ComboBox4.Text = Nothing
        TextBox16.Clear()
        TextBox11.Clear()
        TextBox13.Clear()
        ComboBox3.Text = Nothing


        TextBox9.ReadOnly = True
        ComboBox2.Enabled = False
        ComboBox5.Enabled = False
        TextBox1.ReadOnly = True
        TextBox3.ReadOnly = True
        TextBox5.ReadOnly = True
        TextBox4.ReadOnly = True
        TextBox6.ReadOnly = True
        TextBox7.ReadOnly = True
        TextBox8.ReadOnly = True
        TextBox10.ReadOnly = True
        TextBox15.ReadOnly = True
        TextBox2.ReadOnly = True
        TextBox18.ReadOnly = True
        TextBox17.ReadOnly = True
        ComboBox1.Enabled = False
        ComboBox4.Enabled = False
        TextBox16.ReadOnly = True
        TextBox11.ReadOnly = True
        TextBox13.ReadOnly = True
        ComboBox3.Enabled = False
        Button3.Visible = False
        NovoFuncionárioToolStripMenuItem.Enabled = True
    End Sub
End Class