Imports System.Data.SqlClient
Public Class Gerenciamento_financeiro
    Private Sub CancelarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CancelarToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Gerenciamento_financeiro_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Dim cn As New SqlConnection("server=(local)\SQLEXPRESS;uid=sa;pwd=123456;database=Transportadora_Eagles")
        Dim cmd As New SqlCommand
        Dim mr As SqlDataReader
        cn.Open()
        With cmd
            .Connection = cn
            .CommandTimeout = 0
            .CommandText = "select * from  Funcionario where Codigo_cargo = 4 or Codigo_cargo = 5"
            .CommandType = CommandType.Text
        End With
        mr = cmd.ExecuteReader
        While mr.Read

            ListBox1.Items.Add(mr!Nome_Funcionario)

        End While
        cn.Close()
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable

        DataGridView1.DataSource = ""
        cn.Open()
        With cmd
            .Connection = cn
            .CommandTimeout = 0
            .CommandText = "select * from Contas"
            .CommandType = CommandType.Text
        End With
        With da
            .SelectCommand = cmd
            .Fill(dt)
            .Dispose()
            DataGridView1.DataSource = dt
        End With
        cn.Close()

        Dim valor As Decimal

        For Each col As DataGridViewRow In DataGridView1.Rows

            valor = valor + col.Cells(3).Value

        Next



        txtlucro.Text = FormatNumber(valor, 2)
        For r As Integer = 0 To DataGridView1.Rows.Count - 1
            If DataGridView1.Rows(r).Cells(3).Value < 0 Then
                DataGridView1.Rows(r).DefaultCellStyle.ForeColor = Color.Red
            End If
        Next r

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            GroupBox1.Visible = True
        Else
            GroupBox1.Visible = False
            Dim da As New SqlDataAdapter
            Dim dt As New DataTable

            DataGridView1.DataSource = ""
            Dim cn As New SqlConnection("server=(local)\SQLEXPRESS;uid=sa;pwd=123456;database=Transportadora_Eagles")
            Dim cmd As New SqlCommand
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from Contas"
                .CommandType = CommandType.Text
            End With
            With da
                .SelectCommand = cmd
                .Fill(dt)
                .Dispose()
                DataGridView1.DataSource = dt
            End With
            cn.Close()
        End If
        Dim valor As Decimal

        For Each col As DataGridViewRow In DataGridView1.Rows

            valor = valor + col.Cells(3).Value

        Next



        txtlucro.Text = FormatNumber(valor, 2)
        For r As Integer = 0 To DataGridView1.Rows.Count - 1
            If DataGridView1.Rows(r).Cells(3).Value < 0 Then
                DataGridView1.Rows(r).DefaultCellStyle.ForeColor = Color.Red
            End If
        Next r
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            GroupBox2.Visible = True
        Else
            GroupBox2.Visible = False
        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked = True Then
            ListBox1.Visible = True
        Else
            ListBox1.Visible = False
        End If
    End Sub

    'Private Sub CheckBox3_CheckedChanged(sender As System.Object, e As System.EventArgs)
    '    If CheckBox3.Checked = True Then
    '        RadioButton1.Checked = True
    '        GroupBox4.Visible = True
    '    Else
    '        GroupBox4.Visible = False
    '    End If
    'End Sub

    Private Sub CheckBox5_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = True Then
            RadioButton4.Checked = True
            GroupBox5.Visible = True
        Else
            GroupBox5.Visible = False
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton4.CheckedChanged
        If CheckBox2.Checked = True Or CheckBox6.Checked = True Then
            DirectCast(DataGridView1.DataSource, DataTable).DefaultView.RowFilter = "Tipo = 1"
            Dim valor1 As Decimal

            For Each col As DataGridViewRow In DataGridView1.Rows

                valor1 = valor1 + col.Cells(3).Value

            Next



            txtlucro.Text = FormatNumber(valor1, 2)
            For r As Integer = 0 To DataGridView1.Rows.Count - 1
                If DataGridView1.Rows(r).Cells(3).Value < 0 Then
                    DataGridView1.Rows(r).DefaultCellStyle.ForeColor = Color.Red
                End If
            Next r
        Else
            Dim cn As New SqlConnection("server=(local)\SQLEXPRESS;uid=sa;pwd=123456;database=Transportadora_Eagles")
            Dim cmd As New SqlCommand
            Dim mr As SqlDataReader
            Dim da As New SqlDataAdapter
            Dim dt As New DataTable
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from Contas where Tipo = 1"
                .CommandType = CommandType.Text
            End With
            With da
                .SelectCommand = cmd
                .Fill(dt)
                .Dispose()
                DataGridView1.DataSource = dt
            End With
            mr = cmd.ExecuteReader
            cn.Close()
        End If
        Dim valor As Decimal

        For Each col As DataGridViewRow In DataGridView1.Rows

            valor = valor + col.Cells(3).Value

        Next



        txtlucro.Text = FormatNumber(valor, 2)
        For r As Integer = 0 To DataGridView1.Rows.Count - 1
            If DataGridView1.Rows(r).Cells(3).Value < 0 Then
                DataGridView1.Rows(r).DefaultCellStyle.ForeColor = Color.Red
            End If
        Next r
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If CheckBox2.Checked = True Or CheckBox6.Checked = True Then
            DirectCast(DataGridView1.DataSource, DataTable).DefaultView.RowFilter = "Tipo = 2"
            Dim valor As Decimal

            For Each col As DataGridViewRow In DataGridView1.Rows

                valor = valor + col.Cells(3).Value

            Next



            txtlucro.Text = FormatNumber(valor, 2)
            For r As Integer = 0 To DataGridView1.Rows.Count - 1
                If DataGridView1.Rows(r).Cells(3).Value < 0 Then
                    DataGridView1.Rows(r).DefaultCellStyle.ForeColor = Color.Red
                End If
            Next r
        Else
            Dim cn As New SqlConnection("server=(local)\SQLEXPRESS;uid=sa;pwd=123456;database=Transportadora_Eagles")
            Dim cmd As New SqlCommand
            Dim mr As SqlDataReader
            Dim da As New SqlDataAdapter
            Dim dt As New DataTable
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from Contas where Tipo = 2"
                .CommandType = CommandType.Text
            End With
            With da
                .SelectCommand = cmd
                .Fill(dt)
                .Dispose()
                DataGridView1.DataSource = dt
            End With
            mr = cmd.ExecuteReader
            cn.Close()
            Dim valor As Decimal

            For Each col As DataGridViewRow In DataGridView1.Rows

                valor = valor + col.Cells(3).Value

            Next



            txtlucro.Text = FormatNumber(valor, 2)
            For r As Integer = 0 To DataGridView1.Rows.Count - 1
                If DataGridView1.Rows(r).Cells(3).Value < 0 Then
                    DataGridView1.Rows(r).DefaultCellStyle.ForeColor = Color.Red
                End If
            Next r
        End If

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs)
        If CheckBox2.Checked = True Or CheckBox5.Checked = True Or CheckBox6.Checked = True Then
            DirectCast(DataGridView1.DataSource, DataTable).DefaultView.RowFilter = "Estado = 1 "
            Dim valor As Decimal

            For Each col As DataGridViewRow In DataGridView1.Rows

                valor = valor + col.Cells(3).Value

            Next



            txtlucro.Text = FormatNumber(valor, 2)
            For r As Integer = 0 To DataGridView1.Rows.Count - 1
                If DataGridView1.Rows(r).Cells(3).Value < 0 Then
                    DataGridView1.Rows(r).DefaultCellStyle.ForeColor = Color.Red
                End If
            Next r
        Else
            Dim cn As New SqlConnection("server=(local)\SQLEXPRESS;uid=sa;pwd=123456;database=Transportadora_Eagles")
            Dim cmd As New SqlCommand
            Dim mr As SqlDataReader
            Dim da As New SqlDataAdapter
            Dim dt As New DataTable
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from Contas where Estado = 1 "
                .CommandType = CommandType.Text
            End With
            With da
                .SelectCommand = cmd
                .Fill(dt)
                .Dispose()
                DataGridView1.DataSource = dt
            End With
            mr = cmd.ExecuteReader
            cn.Close()
            Dim valor As Decimal

            For Each col As DataGridViewRow In DataGridView1.Rows

                valor = valor + col.Cells(3).Value

            Next



            txtlucro.Text = FormatNumber(valor, 2)
            For r As Integer = 0 To DataGridView1.Rows.Count - 1
                If DataGridView1.Rows(r).Cells(3).Value < 0 Then
                    DataGridView1.Rows(r).DefaultCellStyle.ForeColor = Color.Red
                End If
            Next r
        End If

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As System.Object, e As System.EventArgs)
        If CheckBox2.Checked = True Or CheckBox5.Checked = True Or CheckBox6.Checked = True Then
            DirectCast(DataGridView1.DataSource, DataTable).DefaultView.RowFilter = "Estado = 2"
            Dim valor As Decimal

            For Each col As DataGridViewRow In DataGridView1.Rows

                valor = valor + col.Cells(3).Value

            Next



            txtlucro.Text = FormatNumber(valor, 2)
        Else
            Dim cn As New SqlConnection("server=(local)\SQLEXPRESS;uid=sa;pwd=123456;database=Transportadora_Eagles")
            Dim cmd As New SqlCommand
            Dim mr As SqlDataReader
            Dim da As New SqlDataAdapter
            Dim dt As New DataTable
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from Contas where Estado = 2"
                .CommandType = CommandType.Text
            End With
            With da
                .SelectCommand = cmd
                .Fill(dt)
                .Dispose()
                DataGridView1.DataSource = dt
            End With
            mr = cmd.ExecuteReader
            cn.Close()
            Dim valor As Decimal

            For Each col As DataGridViewRow In DataGridView1.Rows

                valor = valor + col.Cells(3).Value

            Next



            txtlucro.Text = FormatNumber(valor, 2)
        End If
        For r As Integer = 0 To DataGridView1.Rows.Count - 1
            If DataGridView1.Rows(r).Cells(3).Value < 0 Then
                DataGridView1.Rows(r).DefaultCellStyle.ForeColor = Color.Red
            End If
        Next r
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

        Dim Codigo As String
        Codigo = ""
        Dim cn As New SqlConnection("server=(local)\SQLEXPRESS;uid=sa;pwd=123456;database=Transportadora_Eagles")
        Dim cmd As New SqlCommand
        Dim mr As SqlDataReader
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        cn.Open()
        With cmd
            .Connection = cn
            .CommandTimeout = 0
            .CommandText = "select * from Funcionario where Nome_Funcionario = '" & ListBox1.SelectedItem & "' And (Codigo_cargo = 4 or Codigo_cargo = 5) "
            .CommandType = CommandType.Text
        End With
        mr = cmd.ExecuteReader
        While mr.Read
            Codigo = mr!Codigo_funcionario
        End While
        cn.Close()
        If CheckBox2.Checked = True Or CheckBox5.Checked = True Then
            DirectCast(DataGridView1.DataSource, DataTable).DefaultView.RowFilter = "Codigo_funcionario = '" & Codigo & "'"
            Dim valor As Decimal

            For Each col As DataGridViewRow In DataGridView1.Rows

                valor = valor + col.Cells(3).Value

            Next



            txtlucro.Text = FormatNumber(valor, 2)
        Else
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from Contas where Codigo_funcionario = '" & Codigo & "'"
                .CommandType = CommandType.Text
            End With
            With da
                .SelectCommand = cmd
                .Fill(dt)
                .Dispose()
                DataGridView1.DataSource = dt
            End With
            mr = cmd.ExecuteReader
            cn.Close()
            Dim valor As Decimal

            For Each col As DataGridViewRow In DataGridView1.Rows

                valor = valor + col.Cells(3).Value

            Next



            txtlucro.Text = FormatNumber(valor, 2)
        End If
        For r As Integer = 0 To DataGridView1.Rows.Count - 1
            If DataGridView1.Rows(r).Cells(3).Value < 0 Then
                DataGridView1.Rows(r).DefaultCellStyle.ForeColor = Color.Red
            End If
        Next r
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        Dim cn As New SqlConnection("server=(local)\SQLEXPRESS;uid=sa;pwd=123456;database=Transportadora_Eagles")
        Dim cmd As New SqlCommand
        Dim mr As SqlDataReader
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        If RadioButton5.Checked = True Then
            If CheckBox6.Checked = True Or CheckBox5.Checked = True Then
                DirectCast(DataGridView1.DataSource, DataTable).DefaultView.RowFilter = "DataPgto  > '" & DateTimePicker1.Value.Date & "' and DataPgto < '" & DateTimePicker2.Value.Date & "'"
                Dim valor As Decimal

                For Each col As DataGridViewRow In DataGridView1.Rows

                    valor = valor + col.Cells(3).Value

                Next



                txtlucro.Text = FormatNumber(valor, 2)
            Else
                cn.Open()
                With cmd
                    .Connection = cn
                    .CommandTimeout = 0
                    .CommandText = "select * from Contas where DataPgto  > '" & DateTimePicker1.Value.Date & "' and DataPgto < '" & DateTimePicker2.Value.Date & "'"
                    .CommandType = CommandType.Text
                End With
                With da
                    .SelectCommand = cmd
                    .Fill(dt)
                    .Dispose()
                    DataGridView1.DataSource = dt
                End With
                mr = cmd.ExecuteReader
                cn.Close()
                Dim valor As Decimal

                For Each col As DataGridViewRow In DataGridView1.Rows

                    valor = valor + col.Cells(3).Value

                Next



                txtlucro.Text = FormatNumber(valor, 2)
            End If
        ElseIf RadioButton6.Checked = True Then
            If CheckBox6.Checked = True Or CheckBox5.Checked = True Then
                DirectCast(DataGridView1.DataSource, DataTable).DefaultView.RowFilter = "DataVenc  > '" & DateTimePicker1.Value.Date & "' and DataVenc < '" & DateTimePicker2.Value.Date & "'"
                Dim valor As Decimal

                For Each col As DataGridViewRow In DataGridView1.Rows

                    valor = valor + col.Cells(3).Value

                Next



                txtlucro.Text = FormatNumber(valor, 2)
            Else
                cn.Open()
                With cmd
                    .Connection = cn
                    .CommandTimeout = 0
                    .CommandText = "select * from Contas where DataVenc  > '" & DateTimePicker1.Value.Date & "' and DataVenc < '" & DateTimePicker2.Value.Date & "'"
                    .CommandType = CommandType.Text
                End With
                With da
                    .SelectCommand = cmd
                    .Fill(dt)
                    .Dispose()
                    DataGridView1.DataSource = dt
                End With
                mr = cmd.ExecuteReader
                cn.Close()
                Dim valor As Decimal

                For Each col As DataGridViewRow In DataGridView1.Rows

                    valor = valor + col.Cells(3).Value

                Next



                txtlucro.Text = FormatNumber(valor, 2)
            End If
        End If
        For r As Integer = 0 To DataGridView1.Rows.Count - 1
            If DataGridView1.Rows(r).Cells(3).Value < 0 Then
                DataGridView1.Rows(r).DefaultCellStyle.ForeColor = Color.Red
            End If
        Next r
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        Dim cn As New SqlConnection("server=(local)\SQLEXPRESS;uid=sa;pwd=123456;database=Transportadora_Eagles")
        Dim cmd As New SqlCommand
        Dim mr As SqlDataReader
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        If RadioButton5.Checked = True Then
            If CheckBox6.Checked = True Or CheckBox5.Checked = True Then
                DirectCast(DataGridView1.DataSource, DataTable).DefaultView.RowFilter = "DataPgto  > '" & DateTimePicker1.Value.Date & "' and DataPgto < '" & DateTimePicker2.Value.Date & "'"
                Dim valor As Decimal

                For Each col As DataGridViewRow In DataGridView1.Rows

                    valor = valor + col.Cells(3).Value

                Next



                txtlucro.Text = FormatNumber(valor, 2)
            Else
                cn.Open()
                With cmd
                    .Connection = cn
                    .CommandTimeout = 0
                    .CommandText = "select * from Contas where DataPgto  > '" & DateTimePicker1.Value.Date & "' and DataPgto < '" & DateTimePicker2.Value.Date & "'"
                    .CommandType = CommandType.Text
                End With
                With da
                    .SelectCommand = cmd
                    .Fill(dt)
                    .Dispose()
                    DataGridView1.DataSource = dt
                End With
                mr = cmd.ExecuteReader
                cn.Close()
                Dim valor As Decimal

                For Each col As DataGridViewRow In DataGridView1.Rows

                    valor = valor + col.Cells(3).Value

                Next



                txtlucro.Text = FormatNumber(valor, 2)
            End If
        ElseIf RadioButton6.Checked = True Then
            If CheckBox6.Checked = True Or CheckBox5.Checked = True Then
                DirectCast(DataGridView1.DataSource, DataTable).DefaultView.RowFilter = "DataVenc  > '" & DateTimePicker1.Value.Date & "' and DataVenc < '" & DateTimePicker2.Value.Date & "'"
                Dim valor As Decimal

                For Each col As DataGridViewRow In DataGridView1.Rows

                    valor = valor + col.Cells(3).Value

                Next



                txtlucro.Text = FormatNumber(valor, 2)
            Else
                cn.Open()
                With cmd
                    .Connection = cn
                    .CommandTimeout = 0
                    .CommandText = "select * from Contas where DataVenc  > '" & DateTimePicker1.Value.Date & "' and DataVenc < '" & DateTimePicker2.Value.Date & "'"
                    .CommandType = CommandType.Text
                End With
                With da
                    .SelectCommand = cmd
                    .Fill(dt)
                    .Dispose()
                    DataGridView1.DataSource = dt
                End With
                mr = cmd.ExecuteReader
                cn.Close()
                Dim valor As Decimal

                For Each col As DataGridViewRow In DataGridView1.Rows

                    valor = valor + col.Cells(3).Value

                Next



                txtlucro.Text = FormatNumber(valor, 2)
            End If
        End If
        For r As Integer = 0 To DataGridView1.Rows.Count - 1
            If DataGridView1.Rows(r).Cells(3).Value < 0 Then
                DataGridView1.Rows(r).DefaultCellStyle.ForeColor = Color.Red
            End If
        Next r
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton6.CheckedChanged
        Dim cn As New SqlConnection("server=(local)\SQLEXPRESS;uid=sa;pwd=123456;database=Transportadora_Eagles")
        Dim cmd As New SqlCommand
        Dim mr As SqlDataReader
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        If RadioButton5.Checked = True Then
            If CheckBox6.Checked = True Or CheckBox5.Checked = True Then
                DirectCast(DataGridView1.DataSource, DataTable).DefaultView.RowFilter = "DataPgto  > '" & DateTimePicker1.Value.Date & "' and DataPgto < '" & DateTimePicker2.Value.Date & "'"
                Dim valor As Decimal

                For Each col As DataGridViewRow In DataGridView1.Rows

                    valor = valor + col.Cells(3).Value

                Next



                txtlucro.Text = FormatNumber(valor, 2)
            Else
                cn.Open()
                With cmd
                    .Connection = cn
                    .CommandTimeout = 0
                    .CommandText = "select * from Contas where DataPgto  > '" & DateTimePicker1.Value.Date & "' and DataPgto < '" & DateTimePicker2.Value.Date & "'"
                    .CommandType = CommandType.Text
                End With
                With da
                    .SelectCommand = cmd
                    .Fill(dt)
                    .Dispose()
                    DataGridView1.DataSource = dt
                End With
                mr = cmd.ExecuteReader
                cn.Close()
                Dim valor As Decimal

                For Each col As DataGridViewRow In DataGridView1.Rows

                    valor = valor + col.Cells(3).Value

                Next



                txtlucro.Text = FormatNumber(valor, 2)
            End If
        ElseIf RadioButton6.Checked = True Then
            If CheckBox6.Checked = True Or CheckBox5.Checked = True Then
                DirectCast(DataGridView1.DataSource, DataTable).DefaultView.RowFilter = "DataVenc  > '" & DateTimePicker1.Value.Date & "' and DataVenc < '" & DateTimePicker2.Value.Date & "'"
                Dim valor As Decimal

                For Each col As DataGridViewRow In DataGridView1.Rows

                    valor = valor + col.Cells(3).Value

                Next



                txtlucro.Text = FormatNumber(valor, 2)
            Else
                cn.Open()
                With cmd
                    .Connection = cn
                    .CommandTimeout = 0
                    .CommandText = "select * from Contas where DataVenc  > '" & DateTimePicker1.Value.Date & "' and DataVenc < '" & DateTimePicker2.Value.Date & "'"
                    .CommandType = CommandType.Text
                End With
                With da
                    .SelectCommand = cmd
                    .Fill(dt)
                    .Dispose()
                    DataGridView1.DataSource = dt
                End With
                mr = cmd.ExecuteReader
                cn.Close()
                Dim valor As Decimal

                For Each col As DataGridViewRow In DataGridView1.Rows

                    valor = valor + col.Cells(3).Value

                Next



                txtlucro.Text = FormatNumber(valor, 2)
            End If
        End If
        For r As Integer = 0 To DataGridView1.Rows.Count - 1
            If DataGridView1.Rows(r).Cells(3).Value < 0 Then
                DataGridView1.Rows(r).DefaultCellStyle.ForeColor = Color.Red
            End If
        Next r
    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        Try
            Pagamento_Contas.Label1.Text = DataGridView1(0, DataGridView1.CurrentRow.Index).Value
            Pagamento_Contas.TextBox2.Text = DataGridView1(3, DataGridView1.CurrentRow.Index).Value
            Pagamento_Contas.ListBox1.Text = DataGridView1(5, DataGridView1.CurrentRow.Index).Value
            Pagamento_Contas.Show()
        Catch ex As NullReferenceException
            MsgBox("Falha na obtenção de dados, tente reiniciar a operação. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
        End Try

    End Sub
End Class