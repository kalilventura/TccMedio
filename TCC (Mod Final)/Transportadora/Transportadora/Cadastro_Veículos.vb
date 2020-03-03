Imports System.Data.SqlClient
Public Class Cadastro_Veículos

    Dim Status As String
    Dim Marca As String
    Dim CodigoMar As Integer
    Dim mr As SqlDataReader
    Dim Estado As Integer
    Private Sub VoltarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VoltarToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub NovoVeículoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovoVeículoToolStripMenuItem.Click
        Button2.Text = "Concluir"
        Button2.Visible = False
        NovoVeículoToolStripMenuItem.Enabled = False
        TextBox2.ReadOnly = False
        TextBox3.ReadOnly = False
        TextBox4.ReadOnly = False
        TextBox5.ReadOnly = False
        TextBox6.ReadOnly = False
        TextBox7.ReadOnly = False
        TextBox8.ReadOnly = False
        ComboBox1.Enabled = True

    End Sub
    Private Sub AlterarVeículoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlterarVeículoToolStripMenuItem.Click
        Button2.Text = "Confirmar"
        Button2.Visible = True
        AlterarVeículoToolStripMenuItem.Enabled = False
        TextBox2.ReadOnly = False
        TextBox3.ReadOnly = False
        TextBox4.ReadOnly = False
        TextBox5.ReadOnly = False
        TextBox6.ReadOnly = False
        TextBox7.ReadOnly = False
        TextBox8.ReadOnly = False
        ComboBox1.Enabled = True
    End Sub

    Private Sub PreencherCamposToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreencherCamposToolStripMenuItem.Click
        'Me.VeiculoTableAdapter.Fill(Me.Transportadora_EaglesDataSet1.Veiculo)
        ListBox1.Visible = True
        TextBox3.Text = ListBox1.SelectedValue
        If TextBox3.Text = "" Then
            MsgBox("Digíte o código do veículo")
        End If
        Dim Status As Boolean
        Dim cn As New SqlConnection
        Dim cmd As New SqlCommand
        Dim mr As SqlDataReader  ' para listagem
        cn = New SqlConnection("server=(local)\SQLEXPRESS;uid=sa;pwd=123456;database=Transportadora_Eagles")
        Try
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from  Veiculo where Placa='" & TextBox3.Text & "'"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            While mr.Read
                Status = mr!Status
                'TextBox3.Text = mr!Placa
                TextBox4.Text = mr!Modelo 'Lari Maravilhosa
                Marca = mr!Marca
                TextBox5.Text = mr!Ano_Fabricacao
                TextBox6.Text = mr!Cor
                TextBox7.Text = mr!RENAVAM
                TextBox8.Text = mr!Seguro
            End While
            If Status = 0 Then
                ComboBox1.Text = "Disponível"
            Else
                ComboBox1.Text = "Indisponível"
            End If

            cn.Close()
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from  Marca where Codigo_marca='" & Marca & "'"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader   ' somente leitura
            While mr.Read       ' somente para pesquisa e listagem
                TextBox2.Text = mr!Marca

            End While
            cn.Close()
            TextBox2.ReadOnly = True
            TextBox3.ReadOnly = True
            TextBox4.ReadOnly = True
            TextBox5.ReadOnly = True
            TextBox6.ReadOnly = True
            TextBox7.ReadOnly = True
            TextBox8.ReadOnly = True
            ComboBox1.Enabled = False
            Button2.Text = "Excluir"
        Catch ex As Exception
            MsgBox("Não foi possível preencher os campos, tente novamente. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
        Finally
            cn.Close()
        End Try

    End Sub
    Private Sub LimparToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LimparToolStripMenuItem.Click
        'TextBox1.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox2.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        ComboBox1.Text = ""
        ListBox1.Visible = False
        NovoVeículoToolStripMenuItem.Enabled = True
        TextBox2.ReadOnly = True
        TextBox3.ReadOnly = False
        TextBox4.ReadOnly = True
        TextBox5.ReadOnly = True
        TextBox6.ReadOnly = True
        TextBox7.ReadOnly = True
        TextBox8.ReadOnly = True
        ComboBox1.Enabled = False
    End Sub


    Private Sub ListBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        TextBox3.Text = ListBox1.SelectedValue
        'If TextBox3.Text = "" Then
        '    MsgBox("Digíte o código do veículo")
        'End If

        Dim cn As New SqlConnection
        Dim cmd As New SqlCommand
        Dim mr As SqlDataReader  ' para listagem
        cn = New SqlConnection("server=(local)\SQLEXPRESS;uid=sa;pwd=123456;database=Transportadora_Eagles")
        Try
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from  Veiculo where Placa='" & TextBox3.Text & "'"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader   ' somente leitura
            While mr.Read       ' somente para pesquisa e listagem
                Status = mr!Status
                'TextBox3.Text = mr!Placa
                TextBox4.Text = mr!Modelo
                Marca = mr!Marca
                TextBox5.Text = mr!Ano_Fabricacao
                TextBox6.Text = mr!Cor
                TextBox7.Text = mr!RENAVAM
                TextBox8.Text = mr!Seguro
            End While
            If Status = 0 Then
                ComboBox1.Text = "Disponível"
            Else
                ComboBox1.Text = "Indisponível"
            End If

            cn.Close()
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from  Marca where Codigo_marca='" & Marca & "'"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader   ' somente leitura
            While mr.Read       ' somente para pesquisa e listagem
                TextBox2.Text = mr!Marca

            End While
            cn.Close()
        Catch ex As Exception
            MsgBox("Não foi possível preencher os campos, tente novamente. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As System.EventArgs) Handles TextBox3.TextChanged
        AlterarVeículoToolStripMenuItem.Enabled = True
        If TextBox3.Text = "" Then
            AlterarVeículoToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub Cadastro_Veículos_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.VeiculoTableAdapter.Fill(Me.Transportadora_EaglesDataSet1.Veiculo)
        If ListBox1.Visible = True Then
            TextBox3.Text = ListBox1.SelectedValue
            Dim cn As New SqlConnection
            Dim cmd As New SqlCommand
            Dim mr As SqlDataReader  ' para listagem
            cn = New SqlConnection("server=(local)\SQLEXPRESS;uid=sa;pwd=123456;database=Transportadora_Eagles")
            Try
                cn.Open()
                With cmd
                    .Connection = cn
                    .CommandTimeout = 0
                    .CommandText = "select * from  Veiculo where Placa='" & TextBox3.Text & "'"
                    .CommandType = CommandType.Text
                End With
                mr = cmd.ExecuteReader   ' somente leitura
                While mr.Read       ' somente para pesquisa e listagem
                    Status = mr!Status
                    TextBox4.Text = mr!Modelo
                    Marca = mr!Marca
                    TextBox5.Text = mr!Ano_Fabricacao
                    TextBox6.Text = mr!Cor
                    TextBox7.Text = mr!RENAVAM
                    TextBox8.Text = mr!Seguro
                End While
                If Status = 0 Then
                    ComboBox1.Text = "Disponível"
                Else
                    ComboBox1.Text = "Indisponível"
                End If

                cn.Close()
                cn.Open()
                With cmd
                    .Connection = cn
                    .CommandTimeout = 0
                    .CommandText = "select * from  Marca where Codigo_marca='" & Marca & "'"
                    .CommandType = CommandType.Text
                End With
                mr = cmd.ExecuteReader   ' somente leitura
                While mr.Read       ' somente para pesquisa e listagem
                    TextBox2.Text = mr!Marca

                End While
                cn.Close()
            Catch ex As Exception
                MsgBox("Não foi possível preencher os campos, tente novamente. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
            Finally
                cn.Close()
            End Try
        Else
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox2.Clear()
            TextBox5.Clear()
            TextBox6.Clear()
            TextBox7.Clear()
            TextBox8.Clear()
            ComboBox1.Text = ""
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Button2.Text = "Concluir" Then
            Dim Resultado As DialogResult
            Resultado = MessageBox.Show("Deseja inserir o veículo " & TextBox3.Text & "?", "Transportadora Eagles", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            Select Case Resultado
                Case Windows.Forms.DialogResult.Yes
                    Dim cn As SqlConnection
                    cn = New SqlConnection("server=(local)\SQLEXPRESS;uid=sa;pwd=123456;database=Transportadora_Eagles")
                    Dim cmd As New SqlCommand
                    If ComboBox1.Text = "Disponível" Then
                        Estado = 0
                    Else
                        Estado = 1
                    End If
                    'Try


                    cn.Open()
                    With cmd
                        .Connection = cn
                        .CommandTimeout = 0
                        .CommandText = "select * from  Marca where Marca='" & TextBox2.Text & "'"
                        .CommandType = CommandType.Text
                    End With
                    mr = cmd.ExecuteReader
                    While mr.Read       ' somente para pesquisa e listagem
                        CodigoMar = mr!Codigo_marca
                    End While
                    cn.Close()
                    'Catch ex As Exception
                    'MsgBox("Marca não identificada")
                    'End Try
                    Try
                        Dim retorno As Integer

                        cn = New SqlConnection("server=(local)\SQLEXPRESS;uid=sa;pwd=123456;database=Transportadora_Eagles")
                        cn.Open()

                        With cmd
                            .Connection = cn
                            .CommandTimeout = 0
                            .CommandText = "insert into Veiculo(Placa, Modelo, Marca, Ano_fabricacao, Cor, RENAVAM, Seguro, [Status] ) values ('" & TextBox3.Text & "', '" & TextBox4.Text & "', '" & CodigoMar & "', '" & TextBox5.Text & "', '" & TextBox6.Text & "' , '" & TextBox7.Text & "', '" & TextBox8.Text & "', '" & Estado & "')"
                            .CommandType = CommandType.Text
                        End With

                        retorno = cmd.ExecuteNonQuery
                        MsgBox("Cadastro efetuado com sucesso")
                        'TextBox1.Clear()
                        TextBox3.Clear()
                        TextBox4.Clear()
                        TextBox2.Clear()
                        TextBox5.Clear()
                        TextBox6.Clear()
                        TextBox7.Clear()
                        TextBox8.Clear()
                        ComboBox1.Text = ""
                        Button2.Visible = False
                        TextBox2.ReadOnly = False
                        TextBox3.ReadOnly = True
                        TextBox4.ReadOnly = True
                        TextBox5.ReadOnly = True
                        TextBox6.ReadOnly = True
                        TextBox7.ReadOnly = True
                        TextBox8.ReadOnly = True
                        ComboBox1.Enabled = False

                    Catch ex As Exception
                        MsgBox("Falha ao cadastrar novo veículo, revise os dados e tente novamente. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
                    Finally
                        cn.Close()
                    End Try
                Case Windows.Forms.DialogResult.No
            End Select


        ElseIf Button2.Text = "Confirmar" Then
            Dim Resultado As DialogResult
            Resultado = MessageBox.Show("Deseja alterar o veículo " & TextBox3.Text & "?", "Transportadora Eagles", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            Select Case Resultado
                Case Windows.Forms.DialogResult.Yes
                    Dim cn As SqlConnection
                    cn = New SqlConnection("server=(local)\SQLEXPRESS;uid=sa;pwd=123456;database=Transportadora_Eagles")
                    Dim cmd As New SqlCommand
                    If ComboBox1.Text = "Disponível" Then
                        Estado = 0
                    Else
                        Estado = 1
                    End If

                    cn.Open()
                    With cmd
                        .Connection = cn
                        .CommandTimeout = 0
                        .CommandText = "select * from  Marca where Marca='" & TextBox2.Text & "'"
                        .CommandType = CommandType.Text
                    End With
                    mr = cmd.ExecuteReader
                    While mr.Read       ' somente para pesquisa e listagem
                        CodigoMar = mr!Codigo_marca
                    End While
                    cn.Close()



                    Try
                        Dim retorno As Integer


                        cn.Open()

                        With cmd
                            .Connection = cn
                            .CommandTimeout = 0
                            .CommandText = "Update Veiculo Set Modelo =('" & TextBox4.Text & "'), Marca =('" & CodigoMar & "'), Ano_Fabricacao =('" & TextBox5.Text & "'), Cor =('" & TextBox6.Text & "'), RENAVAM =('" & TextBox7.Text & "'),Seguro =('" & TextBox8.Text & "'), [Status] =('" & Estado & "') where Placa = '" & TextBox3.Text & "'"
                            .CommandType = CommandType.Text
                        End With

                        retorno = cmd.ExecuteNonQuery   ' INC , EXC , ALT
                        Button2.Visible = False
                        MsgBox("Alteração efetuada com sucesso")
                        TextBox2.ReadOnly = False
                        TextBox3.ReadOnly = True
                        TextBox4.ReadOnly = True
                        TextBox5.ReadOnly = True
                        TextBox6.ReadOnly = True
                        TextBox7.ReadOnly = True
                        TextBox8.ReadOnly = True
                        ComboBox1.Enabled = False
                    Catch ex As Exception
                        MsgBox("Falha ao alterar informações do veículo, revise os dados e tente novamente. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
                    Finally
                        cn.Close()
                    End Try

                Case Windows.Forms.DialogResult.No
            End Select
        ElseIf Button2.Text = "Excluir" Then
            Dim Resultado As DialogResult
            Resultado = MessageBox.Show("Deseja excluir o veículo " & TextBox3.Text & "?", "Transportadora Eagles", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            Select Case Resultado
                Case Windows.Forms.DialogResult.Yes



                    Dim cn As SqlConnection
                    Dim cmd As New SqlCommand

                    Try

                        Dim retorno As Integer

                        cn = New SqlConnection("server=(local)\SQLEXPRESS;uid=sa;pwd=123456;database=Transportadora_Eagles")
                        cn.Open()

                        With cmd
                            .Connection = cn
                            .CommandTimeout = 0
                            .CommandText = "Update Veiculo set Atividade = 0 where Placa = '" & TextBox3.Text & "'"
                            .CommandType = CommandType.Text
                        End With

                        retorno = cmd.ExecuteNonQuery
                        cn.Close()
                        MsgBox("Exclusão efetuada com sucesso")
                        TextBox3.Clear()
                        TextBox4.Clear()
                        TextBox2.Clear()
                        TextBox5.Clear()
                        TextBox6.Clear()
                        TextBox7.Clear()
                        TextBox8.Clear()
                        ComboBox1.Text = ""
                        Button2.Visible = False
                    Catch ex As Exception
                        MsgBox("Falha durante exclusão do veículo, tente novamente. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
                    Finally
                        cn.Close()
                    End Try
                Case Windows.Forms.DialogResult.No
            End Select
        End If
    End Sub
End Class