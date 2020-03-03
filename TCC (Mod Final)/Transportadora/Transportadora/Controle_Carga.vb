Imports System.Data.SqlClient
Public Class Controle_Carga
    Dim cn As New SqlConnection("server=(local)\SQLEXPRESS;uid=sa;pwd=123456;database=Transportadora_Eagles")
    Dim cmd As New SqlCommand
    Dim mr As SqlDataReader
    Dim Tipo, CodigoCli, Situacao, Codigo_fretamento, Codigo_entrega As Integer
    Dim DataSai, DataEntre As String

    Private Sub ListBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        cn = New SqlConnection("server=(local)\SQLEXPRESS;uid=sa;pwd=123456;database=Transportadora_Eagles")
        'Try
        cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from Carga where Codigo_carga = '" & ListBox1.SelectedItem & "'"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            While mr.Read
                TextBox1.Text = mr!Peso
                TextBox8.Text = mr!Cubagem
                TextBox7.Text = mr!MedidaA
                TextBox6.Text = mr!MedidaL
                TextBox4.Text = mr!MedidaC
                TextBox2.Text = mr!Volumes
                TextBox9.Text = mr!Valor
                Tipo = mr!Tipo_carga
                CodigoCli = mr!Codigo_cliente
                Situacao = mr!Atividade
            End While
            cn.Close()

            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from Cliente where Codigo_cliente = '" & CodigoCli & "'"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            While mr.Read
                TextBox5.Text = mr!Nome_Fantasia
            End While
            cn.Close()


            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from Tipo_carga where Codigo_Tipo_carga = '" & Tipo & "'"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            While mr.Read
                TextBox3.Text = mr!Descricao
            End While
            cn.Close()
            If Situacao = True Then
                ComboBox1.Text = "Pendente"
            Else
                ComboBox1.Text = "Entregue"
            End If


            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
            .CommandText = "select * from Fretamento where Codigo_carga = '" & ListBox1.SelectedItem & "'"
            .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            While mr.Read
                Codigo_fretamento = mr!Codigo_fretamento
                DataEntre = mr!Data_entrega
                DataSai = mr!Data_saida
            End While
            cn.Close()
            TextBox12.Text = DataSai
            TextBox11.Text = DataEntre
        RadioButton1.Checked = True
        cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
            .CommandText = "select * from Entrega_retirada where Fretamento = '" & Codigo_fretamento & "' And Tipo = 0"
            .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            While mr.Read
            TextBox13.Text = mr!CEP
            TextBox18.Text = mr!Logradouro
            TextBox19.Text = mr!Num
            TextBox16.Text = mr!Complemento
            TextBox17.Text = mr!Bairro
            TextBox15.Text = mr!Cidade
            TextBox14.Text = mr!UF
            TextBox10.Text = mr!Ponto_ref

        End While
            cn.Close()



    End Sub

    Private Sub VoltarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VoltarToolStripMenuItem.Click
        Me.Hide()
    End Sub
    Private Sub Controle_Carga_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim cn As New SqlConnection("server=(local)\SQLEXPRESS;uid=sa;pwd=123456;database=Transportadora_Eagles")
        Dim cmd As New SqlCommand
        Dim mr As SqlDataReader
        cn.Open()
        With cmd
            .Connection = cn
            .CommandTimeout = 0
            .CommandText = "select * from Carga"
            .CommandType = CommandType.Text
        End With
        mr = cmd.ExecuteReader
        While mr.Read

            ListBox1.Items.Add(mr!Codigo_carga)

        End While
        cn.Close()

    End Sub

    Private Sub Label28_Click(sender As Object, e As EventArgs) Handles Label28.Click
        RadioButton1.Checked = True
        If Label28.Text = "<< Endereço" Then
            Label20.Visible = False
            Label22.Visible = False
            Label26.Visible = False
            Label24.Visible = False
            Label23.Visible = False
            Label21.Visible = False
            Label18.Visible = False
            Label19.Visible = False
            Label27.Visible = False
            Label25.Visible = False

            TextBox13.Visible = False
            TextBox18.Visible = False
            TextBox16.Visible = False
            TextBox17.Visible = False
            TextBox15.Visible = False
            TextBox14.Visible = False
            TextBox10.Visible = False
            TextBox12.Visible = False
            TextBox11.Visible = False
            TextBox19.Visible = False

            GroupBox1.Visible = False

            Label28.Text = "Endereço >>"
        ElseIf Label28.Text = "Endereço >>" Then
            RadioButton1.Checked = True
            Label20.Visible = True
            Label26.Visible = True
            Label24.Visible = True
            Label23.Visible = True
            Label22.Visible = True
            Label21.Visible = True
            Label18.Visible = True
            Label19.Visible = True
            Label27.Visible = True
            Label25.Visible = True

            TextBox13.Visible = True
            TextBox18.Visible = True
            TextBox16.Visible = True
            TextBox17.Visible = True
            TextBox15.Visible = True
            TextBox14.Visible = True
            TextBox10.Visible = True
            TextBox12.Visible = True
            TextBox11.Visible = True
            TextBox19.Visible = True

            GroupBox1.Visible = True
            Label28.Text = "<< Endereço"


        End If

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton1.Checked Then

            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from Entrega_retirada where Fretamento = '" & Codigo_fretamento & "' And Tipo = 0"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            While mr.Read
                TextBox13.Text = mr!CEP
                TextBox18.Text = mr!Logradouro
                TextBox19.Text = mr!Num
                TextBox16.Text = mr!Complemento
                TextBox17.Text = mr!Bairro
                TextBox15.Text = mr!Cidade
                TextBox14.Text = mr!UF
                TextBox10.Text = mr!Ponto_ref
                TextBox12.Text = DataSai
                TextBox11.Text = DataEntre
            End While
            cn.Close()
        ElseIf RadioButton2.Checked Then

            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from Entrega_retirada where Fretamento = '" & Codigo_fretamento & "' And Tipo = 1"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            While mr.Read
                TextBox13.Text = mr!CEP
                TextBox18.Text = mr!Logradouro
                TextBox19.Text = mr!Num
                TextBox16.Text = mr!Complemento
                TextBox17.Text = mr!Bairro
                TextBox15.Text = mr!Cidade
                TextBox14.Text = mr!UF
                TextBox10.Text = mr!Ponto_ref
                TextBox12.Text = "Não aplicável"
                TextBox11.Text = "Não aplicável"
            End While
            cn.Close()
        ElseIf RadioButton3.Checked Then

            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from Entrega_retirada where Fretamento = '" & Codigo_fretamento & "' And Tipo = 2"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            While mr.Read
                TextBox13.Text = mr!CEP
                TextBox18.Text = mr!Logradouro
                TextBox19.Text = mr!Num
                TextBox16.Text = mr!Complemento
                TextBox17.Text = mr!Bairro
                TextBox15.Text = mr!Cidade
                TextBox14.Text = mr!UF
                TextBox10.Text = mr!Ponto_ref
                TextBox12.Text = "Não aplicável"
                TextBox11.Text = "Não aplicável"
            End While
            cn.Close()
        ElseIf RadioButton4.Checked Then

            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from Entrega_retirada where Fretamento = '" & Codigo_fretamento & "' And Tipo = 3"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            While mr.Read
                TextBox13.Text = mr!CEP
                TextBox18.Text = mr!Logradouro
                TextBox19.Text = mr!Num
                TextBox16.Text = mr!Complemento
                TextBox17.Text = mr!Bairro
                TextBox15.Text = mr!Cidade
                TextBox14.Text = mr!UF
                TextBox10.Text = mr!Ponto_ref
                TextBox12.Text = "Não aplicável"
                TextBox11.Text = "Não aplicável"
            End While
            cn.Close()
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton1.Checked Then

            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from Entrega_retirada where Fretamento = '" & Codigo_fretamento & "' And Tipo = 0"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            While mr.Read
                TextBox13.Text = mr!CEP
                TextBox18.Text = mr!Logradouro
                TextBox19.Text = mr!Num
                TextBox16.Text = mr!Complemento
                TextBox17.Text = mr!Bairro
                TextBox15.Text = mr!Cidade
                TextBox14.Text = mr!UF
                TextBox10.Text = mr!Ponto_ref
                TextBox12.Text = DataSai
                TextBox11.Text = DataEntre
            End While
            cn.Close()
        ElseIf RadioButton2.Checked Then

            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from Entrega_retirada where Fretamento = '" & Codigo_fretamento & "' And Tipo = 1"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            While mr.Read
                TextBox13.Text = mr!CEP
                TextBox18.Text = mr!Logradouro
                TextBox19.Text = mr!Num
                TextBox16.Text = mr!Complemento
                TextBox17.Text = mr!Bairro
                TextBox15.Text = mr!Cidade
                TextBox14.Text = mr!UF
                TextBox10.Text = mr!Ponto_ref
                TextBox12.Text = "Não aplicável"
                TextBox11.Text = "Não aplicável"
            End While
            cn.Close()
        ElseIf RadioButton3.Checked Then

            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from Entrega_retirada where Fretamento = '" & Codigo_fretamento & "' And Tipo = 2"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            While mr.Read
                TextBox13.Text = mr!CEP
                TextBox18.Text = mr!Logradouro
                TextBox19.Text = mr!Num
                TextBox16.Text = mr!Complemento
                TextBox17.Text = mr!Bairro
                TextBox15.Text = mr!Cidade
                TextBox14.Text = mr!UF
                TextBox10.Text = mr!Ponto_ref
                TextBox12.Text = "Não aplicável"
                TextBox11.Text = "Não aplicável"
            End While
            cn.Close()
        ElseIf RadioButton4.Checked Then

            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from Entrega_retirada where Fretamento = '" & Codigo_fretamento & "' And Tipo = 3"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            While mr.Read
                TextBox13.Text = mr!CEP
                TextBox18.Text = mr!Logradouro
                TextBox19.Text = mr!Num
                TextBox16.Text = mr!Complemento
                TextBox17.Text = mr!Bairro
                TextBox15.Text = mr!Cidade
                TextBox14.Text = mr!UF
                TextBox10.Text = mr!Ponto_ref
                TextBox12.Text = "Não aplicável"
                TextBox11.Text = "Não aplicável"
            End While
            cn.Close()
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton1.Checked Then

            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from Entrega_retirada where Fretamento = '" & Codigo_fretamento & "' And Tipo = 0"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            While mr.Read
                TextBox13.Text = mr!CEP
                TextBox18.Text = mr!Logradouro
                TextBox19.Text = mr!Num
                TextBox16.Text = mr!Complemento
                TextBox17.Text = mr!Bairro
                TextBox15.Text = mr!Cidade
                TextBox14.Text = mr!UF
                TextBox10.Text = mr!Ponto_ref
                TextBox12.Text = DataSai
                TextBox11.Text = DataEntre
            End While
            cn.Close()
        ElseIf RadioButton2.Checked Then

            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from Entrega_retirada where Fretamento = '" & Codigo_fretamento & "' And Tipo = 1"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            While mr.Read
                TextBox13.Text = mr!CEP
                TextBox18.Text = mr!Logradouro
                TextBox19.Text = mr!Num
                TextBox16.Text = mr!Complemento
                TextBox17.Text = mr!Bairro
                TextBox15.Text = mr!Cidade
                TextBox14.Text = mr!UF
                TextBox10.Text = mr!Ponto_ref
                TextBox12.Text = "Não aplicável"
                TextBox11.Text = "Não aplicável"
            End While
            cn.Close()
        ElseIf RadioButton3.Checked Then

            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from Entrega_retirada where Fretamento = '" & Codigo_fretamento & "' And Tipo = 2"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            While mr.Read
                TextBox13.Text = mr!CEP
                TextBox18.Text = mr!Logradouro
                TextBox19.Text = mr!Num
                TextBox16.Text = mr!Complemento
                TextBox17.Text = mr!Bairro
                TextBox15.Text = mr!Cidade
                TextBox14.Text = mr!UF
                TextBox10.Text = mr!Ponto_ref
                TextBox12.Text = "Não aplicável"
                TextBox11.Text = "Não aplicável"
            End While
            cn.Close()
        ElseIf RadioButton4.Checked Then

            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from Entrega_retirada where Fretamento = '" & Codigo_fretamento & "' And Tipo = 3"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            While mr.Read
                TextBox13.Text = mr!CEP
                TextBox18.Text = mr!Logradouro
                TextBox19.Text = mr!Num
                TextBox16.Text = mr!Complemento
                TextBox17.Text = mr!Bairro
                TextBox15.Text = mr!Cidade
                TextBox14.Text = mr!UF
                TextBox10.Text = mr!Ponto_ref
                TextBox12.Text = "Não aplicável"
                TextBox11.Text = "Não aplicável"
            End While
            cn.Close()
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then

            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from Entrega_retirada where Fretamento = '" & Codigo_fretamento & "' And Tipo = 0"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            While mr.Read
                TextBox13.Text = mr!CEP
                TextBox18.Text = mr!Logradouro
                TextBox19.Text = mr!Num
                TextBox16.Text = mr!Complemento
                TextBox17.Text = mr!Bairro
                TextBox15.Text = mr!Cidade
                TextBox14.Text = mr!UF
                TextBox10.Text = mr!Ponto_ref
                TextBox12.Text = DataSai
                TextBox11.Text = DataEntre
            End While
            cn.Close()
        ElseIf RadioButton2.Checked Then

            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from Entrega_retirada where Fretamento = '" & Codigo_fretamento & "' And Tipo = 1"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            While mr.Read
                TextBox13.Text = mr!CEP
                TextBox18.Text = mr!Logradouro
                TextBox19.Text = mr!Num
                TextBox16.Text = mr!Complemento
                TextBox17.Text = mr!Bairro
                TextBox15.Text = mr!Cidade
                TextBox14.Text = mr!UF
                TextBox10.Text = mr!Ponto_ref
                TextBox12.Text = "Não aplicável"
                TextBox11.Text = "Não aplicável"
            End While
            cn.Close()
        ElseIf RadioButton3.Checked Then

            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from Entrega_retirada where Fretamento = '" & Codigo_fretamento & "' And Tipo = 2"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            While mr.Read
                TextBox13.Text = mr!CEP
                TextBox18.Text = mr!Logradouro
                TextBox19.Text = mr!Num
                TextBox16.Text = mr!Complemento
                TextBox17.Text = mr!Bairro
                TextBox15.Text = mr!Cidade
                TextBox14.Text = mr!UF
                TextBox10.Text = mr!Ponto_ref
                TextBox12.Text = "Não aplicável"
                TextBox11.Text = "Não aplicável"
            End While
            cn.Close()
        ElseIf RadioButton4.Checked Then

            cn.Open()
                With cmd
                    .Connection = cn
                    .CommandTimeout = 0
                    .CommandText = "select * from Entrega_retirada where Fretamento = '" & Codigo_fretamento & "' And Tipo = 3"
                    .CommandType = CommandType.Text
                End With
                mr = cmd.ExecuteReader
                While mr.Read
                    TextBox13.Text = mr!CEP
                    TextBox18.Text = mr!Logradouro
                    TextBox19.Text = mr!Num
                    TextBox16.Text = mr!Complemento
                    TextBox17.Text = mr!Bairro
                    TextBox15.Text = mr!Cidade
                    TextBox14.Text = mr!UF
                    TextBox10.Text = mr!Ponto_ref
                TextBox12.Text = "Não aplicável"
                TextBox11.Text = "Não aplicável"
            End While
                cn.Close()
            End If
    End Sub
End Class