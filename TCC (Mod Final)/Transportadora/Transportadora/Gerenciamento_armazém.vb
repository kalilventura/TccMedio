Imports System.Data.SqlClient

Public Class Gerenciamento_armazém
    Dim Estado As String
    Dim Codigo As String
    Dim cn As New SqlConnection
    Dim cmd As New SqlCommand
    Dim mr As SqlDataReader
    Dim A1, A2, A3, A4, A5, A6, A7, A8, B1, B2, B3, B4, B5, B6, B7, B8, C1, C2, C3, C4, C5, C6, C7, C8, D1, D2, D3, D4, D5, D6, D7, D8 As String
    Private Sub Armazém_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Codigo = ""
        cn = New SqlConnection("server=(local)\SQLEXPRESS;uid=sa;pwd=123456;database=Transportadora_Eagles")
        Try
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from Armazem where Setor = '" & "A1" & "'"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            While mr.Read
                Estado = mr!Estado
                If Estado = 2 Then
                    Codigo = mr!Codigo_carga
                End If
            End While
            If Estado = 2 Then
                PictureBox1.BackColor = Color.Red
                PictureBox1.Enabled = True
                ToolTip1.SetToolTip(PictureBox1, "Carga: " + Codigo.ToString + " Clique para ir para controle carga") 'Comentário flutuante
                A1 = Codigo
            ElseIf Estado = 1 Then
                PictureBox1.Enabled = False
                PictureBox1.BackColor = Color.Lime
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox("Falha ao carregar formulário, reinicie-o!. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
        Finally
            cn.Close()
        End Try
        Try
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from Armazem where Setor = '" & "A2" & "'"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            While mr.Read
                Estado = mr!Estado
                If Estado = 2 Then
                    Codigo = mr!Codigo_carga
                End If
            End While
            If Estado = 2 Then
                PictureBox2.BackColor = Color.Red
                PictureBox2.Enabled = True
                ToolTip2.SetToolTip(PictureBox2, "Carga: " + Codigo.ToString + " Clique para ir para controle carga") 'Comentário flutuante
                A2 = Codigo
            ElseIf Estado = 1 Then
                PictureBox2.Enabled = False
                PictureBox2.BackColor = Color.Lime
            End If
            cn.Close()


        Catch ex As Exception
            MsgBox("Falha ao carregar formulário, reinicie-o!. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
        Finally
            cn.Close()
        End Try




        Try
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from Armazem where Setor = '" & "A3" & "'"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            While mr.Read
                Estado = mr!Estado
                If Estado = 2 Then
                    Codigo = mr!Codigo_carga
                End If
            End While
            If Estado = 2 Then
                PictureBox3.BackColor = Color.Red
                PictureBox3.Enabled = True
                ToolTip3.SetToolTip(PictureBox3, "Carga: " + Codigo.ToString + " Clique para ir para controle carga") 'Comentário flutuante
                A3 = Codigo
            ElseIf Estado = 1 Then
                PictureBox3.Enabled = False
                PictureBox3.BackColor = Color.Lime
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox("Falha ao carregar formulário, reinicie-o!. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
        Finally
            cn.Close()
        End Try





        Try
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from Armazem where Setor = '" & "A4" & "'"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            While mr.Read
                Estado = mr!Estado
                If Estado = 2 Then
                    Codigo = mr!Codigo_carga
                End If
            End While
            If Estado = 2 Then
                PictureBox4.BackColor = Color.Red
                PictureBox4.Enabled = True
                ToolTip4.SetToolTip(PictureBox4, "Carga: " + Codigo.ToString + " Clique para ir para controle carga") 'Comentário flutuante
                A4 = Codigo
            ElseIf Estado = 1 Then
                PictureBox4.Enabled = False
                PictureBox4.BackColor = Color.Lime
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox("Falha ao carregar formulário, reinicie-o!. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
        Finally
            cn.Close()
        End Try



        Try
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from Armazem where Setor = '" & "A5" & "'"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            While mr.Read
                Estado = mr!Estado
                If Estado = 2 Then
                    Codigo = mr!Codigo_carga
                End If
            End While
            If Estado = 2 Then
                PictureBox5.BackColor = Color.Red
                PictureBox5.Enabled = True
                ToolTip5.SetToolTip(PictureBox5, "Carga: " + Codigo.ToString + " Clique para ir para controle carga") 'Comentário flutuante
                A5 = Codigo
            ElseIf Estado = 1 Then
                PictureBox5.Enabled = False
                PictureBox5.BackColor = Color.Lime
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox("Falha ao carregar formulário, reinicie-o!. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
        Finally
            cn.Close()
        End Try




        Try
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from Armazem where Setor = '" & "A6" & "'"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            While mr.Read
                Estado = mr!Estado
                If Estado = 2 Then
                    Codigo = mr!Codigo_carga
                End If
            End While
            If Estado = 2 Then
                PictureBox6.BackColor = Color.Red
                PictureBox6.Enabled = True
                ToolTip6.SetToolTip(PictureBox6, "Carga: " + Codigo.ToString + " Clique para ir para controle carga") 'Comentário flutuante
                A6 = Codigo
            ElseIf Estado = 1 Then
                PictureBox6.Enabled = False
                PictureBox6.BackColor = Color.Lime
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox("Falha ao carregar formulário, reinicie-o!. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
        Finally
            cn.Close()
        End Try




        Try
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from Armazem where Setor = '" & "A7" & "'"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            While mr.Read
                Estado = mr!Estado
                If Estado = 2 Then
                    Codigo = mr!Codigo_carga
                End If
            End While
            If Estado = 2 Then
                PictureBox7.BackColor = Color.Red
                PictureBox7.Enabled = True
                ToolTip7.SetToolTip(PictureBox7, "Carga: " + Codigo.ToString + " Clique para ir para controle carga") 'Comentário flutuante
                A7 = Codigo
            ElseIf Estado = 1 Then
                PictureBox7.Enabled = False
                PictureBox7.BackColor = Color.Lime
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox("Falha ao carregar formulário, reinicie-o!. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
        Finally
            cn.Close()
        End Try



        Try
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from Armazem where Setor = '" & "A8" & "'"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            While mr.Read
                Estado = mr!Estado
                If Estado = 2 Then
                    Codigo = mr!Codigo_carga
                End If
            End While
            If Estado = 2 Then
                PictureBox8.BackColor = Color.Red
                PictureBox8.Enabled = True
                ToolTip8.SetToolTip(PictureBox8, "Carga: " + Codigo.ToString + " Clique para ir para controle carga") 'Comentário flutuante
                A8 = Codigo
            ElseIf Estado = 1 Then
                PictureBox8.Enabled = False
                PictureBox8.BackColor = Color.Lime
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox("Falha ao carregar formulário, reinicie-o!. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
        Finally
            cn.Close()
        End Try



        Try
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from Armazem where Setor = '" & "B1" & "'"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            While mr.Read
                Estado = mr!Estado
                If Estado = 2 Then
                    Codigo = mr!Codigo_carga
                End If
            End While
            If Estado = 2 Then
                PictureBox9.BackColor = Color.Red
                PictureBox9.Enabled = True
                ToolTip9.SetToolTip(PictureBox9, "Carga: " + Codigo.ToString + " Clique para ir para controle carga") 'Comentário flutuante
                B1 = Codigo
            ElseIf Estado = 1 Then
                PictureBox9.Enabled = False
                PictureBox9.BackColor = Color.Lime
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox("Falha ao carregar formulário, reinicie-o!. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
        Finally
            cn.Close()
        End Try



        Try
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from Armazem where Setor = '" & "B2" & "'"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            While mr.Read
                Estado = mr!Estado
                If Estado = 2 Then
                    Codigo = mr!Codigo_carga
                End If
            End While
            If Estado = 2 Then
                PictureBox10.BackColor = Color.Red
                PictureBox10.Enabled = True
                ToolTip10.SetToolTip(PictureBox10, "Carga: " + Codigo.ToString + " Clique para ir para controle carga") 'Comentário flutuante
                B2 = Codigo
            ElseIf Estado = 1 Then
                PictureBox10.Enabled = False
                PictureBox10.BackColor = Color.Lime
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox("Falha ao carregar formulário, reinicie-o!. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
        Finally
            cn.Close()
        End Try



        Try
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from Armazem where Setor = '" & "B3" & "'"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            While mr.Read
                Estado = mr!Estado
                If Estado = 2 Then
                    Codigo = mr!Codigo_carga
                End If
            End While
            If Estado = 2 Then
                PictureBox11.BackColor = Color.Red
                PictureBox11.Enabled = True
                ToolTip11.SetToolTip(PictureBox11, "Carga: " + Codigo.ToString + " Clique para ir para controle carga") 'Comentário flutuante
                B3 = Codigo
            ElseIf Estado = 1 Then
                PictureBox11.Enabled = False
                PictureBox11.BackColor = Color.Lime
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox("Falha ao carregar formulário, reinicie-o!. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
        Finally
            cn.Close()
        End Try



        Try
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from Armazem where Setor = '" & "B4" & "'"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            While mr.Read
                Estado = mr!Estado
                If Estado = 2 Then
                    Codigo = mr!Codigo_carga
                End If
            End While
            If Estado = 2 Then
                PictureBox12.BackColor = Color.Red
                PictureBox12.Enabled = True
                ToolTip12.SetToolTip(PictureBox12, "Carga: " + Codigo.ToString + " Clique para ir para controle carga") 'Comentário flutuante
                B4 = Codigo
            ElseIf Estado = 1 Then
                PictureBox12.Enabled = False
                PictureBox12.BackColor = Color.Lime
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox("Falha ao carregar formulário, reinicie-o!. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
        Finally
            cn.Close()
        End Try



        Try
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from Armazem where Setor = '" & "B5" & "'"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            While mr.Read
                Estado = mr!Estado
                If Estado = 2 Then
                    Codigo = mr!Codigo_carga
                End If
            End While
            If Estado = 2 Then
                PictureBox13.BackColor = Color.Red
                PictureBox13.Enabled = True
                ToolTip13.SetToolTip(PictureBox13, "Carga: " + Codigo.ToString + " Clique para ir para controle carga") 'Comentário flutuante
                B5 = Codigo
            ElseIf Estado = 1 Then
                PictureBox13.Enabled = False
                PictureBox13.BackColor = Color.Lime
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox("Falha ao carregar formulário, reinicie-o!. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
        Finally
            cn.Close()
        End Try



        Try
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from Armazem where Setor = '" & "B6" & "'"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            While mr.Read
                Estado = mr!Estado
                If Estado = 2 Then
                    Codigo = mr!Codigo_carga
                End If
            End While
            If Estado = 2 Then
                PictureBox14.BackColor = Color.Red
                PictureBox14.Enabled = True
                ToolTip14.SetToolTip(PictureBox14, "Carga: " + Codigo.ToString + " Clique para ir para controle carga") 'Comentário flutuante
                B6 = Codigo
            ElseIf Estado = 1 Then
                PictureBox14.Enabled = False
                PictureBox14.BackColor = Color.Lime
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox("Falha ao carregar formulário, reinicie-o!. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
        Finally
            cn.Close()
        End Try



        Try
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from Armazem where Setor = '" & "B7" & "'"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            While mr.Read
                Estado = mr!Estado
                If Estado = 2 Then
                    Codigo = mr!Codigo_carga
                End If
            End While
            If Estado = 2 Then
                PictureBox15.BackColor = Color.Red
                PictureBox15.Enabled = True
                ToolTip15.SetToolTip(PictureBox15, "Carga: " + Codigo.ToString + " Clique para ir para controle carga") 'Comentário flutuante
                B7 = Codigo
            ElseIf Estado = 1 Then
                PictureBox15.Enabled = False
                PictureBox15.BackColor = Color.Lime
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox("Falha ao carregar formulário, reinicie-o!. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
        Finally
            cn.Close()
        End Try



        Try
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from Armazem where Setor = '" & "B8" & "'"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            While mr.Read
                Estado = mr!Estado
                If Estado = 2 Then
                    Codigo = mr!Codigo_carga
                End If
            End While
            If Estado = 2 Then
                PictureBox16.BackColor = Color.Red
                PictureBox16.Enabled = True
                ToolTip16.SetToolTip(PictureBox16, "Carga: " + Codigo.ToString + " Clique para ir para controle carga") 'Comentário flutuante
                B8 = Codigo
            ElseIf Estado = 1 Then
                PictureBox16.Enabled = False
                PictureBox16.BackColor = Color.Lime
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox("Falha ao carregar formulário, reinicie-o!. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
        Finally
            cn.Close()
        End Try



        Try
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from Armazem where Setor = '" & "C1" & "'"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            While mr.Read
                Estado = mr!Estado
                If Estado = 2 Then
                    Codigo = mr!Codigo_carga
                End If
            End While
            If Estado = 2 Then
                PictureBox17.BackColor = Color.Red
                PictureBox17.Enabled = True
                ToolTip17.SetToolTip(PictureBox17, "Carga: " + Codigo.ToString + " Clique para ir para controle carga") 'Comentário flutuante
                C1 = Codigo
            ElseIf Estado = 1 Then
                PictureBox17.Enabled = False
                PictureBox17.BackColor = Color.Lime
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox("Falha ao carregar formulário, reinicie-o!. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
        Finally
            cn.Close()
        End Try



        Try
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from Armazem where Setor = '" & "C2" & "'"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            While mr.Read
                Estado = mr!Estado
                If Estado = 2 Then
                    Codigo = mr!Codigo_carga
                End If
            End While
            If Estado = 2 Then
                PictureBox18.BackColor = Color.Red
                PictureBox18.Enabled = True
                ToolTip18.SetToolTip(PictureBox18, "Carga: " + Codigo.ToString + " Clique para ir para controle carga") 'Comentário flutuante
                C2 = Codigo
            ElseIf Estado = 1 Then
                PictureBox18.Enabled = False
                PictureBox18.BackColor = Color.Lime
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox("Falha ao carregar formulário, reinicie-o!. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
        Finally
            cn.Close()
        End Try



        Try
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from Armazem where Setor = '" & "C3" & "'"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            While mr.Read
                Estado = mr!Estado
                If Estado = 2 Then
                    Codigo = mr!Codigo_carga
                End If
            End While
            If Estado = 2 Then
                PictureBox19.BackColor = Color.Red
                PictureBox19.Enabled = True
                ToolTip19.SetToolTip(PictureBox19, "Carga: " + Codigo.ToString + " Clique para ir para controle carga") 'Comentário flutuante
                C3 = Codigo
            ElseIf Estado = 1 Then
                PictureBox19.Enabled = False
                PictureBox19.BackColor = Color.Lime
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox("Falha ao carregar formulário, reinicie-o!. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
        Finally
            cn.Close()

        End Try



        Try
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from Armazem where Setor = '" & "C4" & "'"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            While mr.Read
                Estado = mr!Estado
                If Estado = 2 Then
                    Codigo = mr!Codigo_carga
                End If
            End While
            If Estado = 2 Then
                PictureBox20.BackColor = Color.Red
                PictureBox20.Enabled = True
                ToolTip20.SetToolTip(PictureBox20, "Carga: " + Codigo.ToString + " Clique para ir para controle carga") 'Comentário flutuante
                C4 = Codigo
            ElseIf Estado = 1 Then
                PictureBox20.Enabled = False
                PictureBox20.BackColor = Color.Lime
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox("Falha ao carregar formulário, reinicie-o!. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
        Finally
            cn.Close()
        End Try



        Try
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from Armazem where Setor = '" & "C5" & "'"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            While mr.Read
                Estado = mr!Estado
                If Estado = 2 Then
                    Codigo = mr!Codigo_carga
                End If
            End While
            If Estado = 2 Then
                PictureBox21.BackColor = Color.Red
                PictureBox21.Enabled = True
                ToolTip21.SetToolTip(PictureBox21, "Carga: " + Codigo.ToString + " Clique para ir para controle carga") 'Comentário flutuante
                C5 = Codigo
            ElseIf Estado = 1 Then
                PictureBox21.Enabled = False
                PictureBox21.BackColor = Color.Lime
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox("Falha ao carregar formulário, reinicie-o!. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
        Finally
            cn.Close()
        End Try



        Try
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from Armazem where Setor = '" & "C6" & "'"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            While mr.Read
                Estado = mr!Estado
                If Estado = 2 Then
                    Codigo = mr!Codigo_carga
                End If
            End While
            If Estado = 2 Then
                PictureBox22.BackColor = Color.Red
                PictureBox22.Enabled = True
                ToolTip22.SetToolTip(PictureBox22, "Carga: " + Codigo.ToString + " Clique para ir para controle carga") 'Comentário flutuante
                C6 = Codigo
            ElseIf Estado = 1 Then
                PictureBox22.Enabled = False
                PictureBox22.BackColor = Color.Lime
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox("Falha ao carregar formulário, reinicie-o!. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
        Finally
            cn.Close()
        End Try



        Try
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from Armazem where Setor = '" & "C7" & "'"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            While mr.Read
                Estado = mr!Estado
                If Estado = 2 Then
                    Codigo = mr!Codigo_carga
                End If
            End While
            If Estado = 2 Then
                PictureBox23.BackColor = Color.Red
                PictureBox23.Enabled = True
                ToolTip23.SetToolTip(PictureBox23, "Carga: " + Codigo.ToString + " Clique para ir para controle carga") 'Comentário flutuante
                C7 = Codigo
            ElseIf Estado = 1 Then
                PictureBox23.Enabled = False
                PictureBox23.BackColor = Color.Lime
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox("Falha ao carregar formulário, reinicie-o!. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
        Finally
            cn.Close()
        End Try



        Try
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from Armazem where Setor = '" & "C8" & "'"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            While mr.Read
                Estado = mr!Estado
                If Estado = 2 Then
                    Codigo = mr!Codigo_carga
                End If
            End While
            If Estado = 2 Then
                PictureBox24.BackColor = Color.Red
                PictureBox24.Enabled = True
                ToolTip24.SetToolTip(PictureBox24, "Carga: " + Codigo.ToString + " Clique para ir para controle carga") 'Comentário flutuante
                C8 = Codigo
            ElseIf Estado = 1 Then
                PictureBox24.Enabled = False
                PictureBox24.BackColor = Color.Lime
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox("Falha ao carregar formulário, reinicie-o!. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
        Finally
            cn.Close()
        End Try



        Try
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from Armazem where Setor = '" & "D1" & "'"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            While mr.Read
                Estado = mr!Estado
                If Estado = 2 Then
                    Codigo = mr!Codigo_carga
                End If
            End While
            If Estado = 2 Then
                PictureBox25.BackColor = Color.Red
                PictureBox25.Enabled = True
                ToolTip25.SetToolTip(PictureBox25, "Carga: " + Codigo.ToString + " Clique para ir para controle carga") 'Comentário flutuante
                D1 = Codigo
            ElseIf Estado = 1 Then
                PictureBox25.Enabled = False
                PictureBox25.BackColor = Color.Lime
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox("Falha ao carregar formulário, reinicie-o!. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
        Finally
            cn.Close()
        End Try



        Try
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from Armazem where Setor = '" & "D2" & "'"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            While mr.Read
                Estado = mr!Estado
                If Estado = 2 Then
                    Codigo = mr!Codigo_carga
                End If
            End While
            If Estado = 2 Then
                PictureBox26.BackColor = Color.Red
                PictureBox26.Enabled = True
                ToolTip26.SetToolTip(PictureBox26, "Carga: " + Codigo.ToString + " Clique para ir para controle carga") 'Comentário flutuante
                D1 = Codigo
            ElseIf Estado = 1 Then
                PictureBox26.Enabled = False
                PictureBox26.BackColor = Color.Lime
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox("Falha ao carregar formulário, reinicie-o!. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
        Finally
            cn.Close()
        End Try


        Try
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from Armazem where Setor = '" & "D3" & "'"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            While mr.Read
                Estado = mr!Estado
                If Estado = 2 Then
                    Codigo = mr!Codigo_carga
                End If
            End While
            If Estado = 2 Then
                PictureBox27.BackColor = Color.Red
                PictureBox27.Enabled = True
                ToolTip27.SetToolTip(PictureBox27, "Carga: " + Codigo.ToString + " Clique para ir para controle carga") 'Comentário flutuante
                D3 = Codigo
            ElseIf Estado = 1 Then
                PictureBox27.Enabled = False
                PictureBox27.BackColor = Color.Lime
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox("Falha ao carregar formulário, reinicie-o!. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
        Finally
            cn.Close()
        End Try


        Try
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from Armazem where Setor = '" & "D4" & "'"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            While mr.Read
                Estado = mr!Estado
                If Estado = 2 Then
                    Codigo = mr!Codigo_carga
                End If
            End While
            If Estado = 2 Then
                PictureBox28.BackColor = Color.Red
                PictureBox28.Enabled = True
                ToolTip28.SetToolTip(PictureBox28, "Carga: " + Codigo.ToString + " Clique para ir para controle carga") 'Comentário flutuante
                D4 = Codigo
            ElseIf Estado = 1 Then
                PictureBox28.Enabled = False
                PictureBox28.BackColor = Color.Lime
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox("Falha ao carregar formulário, reinicie-o!. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
        Finally
            cn.Close()
        End Try



        Try
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from Armazem where Setor = '" & "D5" & "'"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            While mr.Read
                Estado = mr!Estado
                If Estado = 2 Then
                    Codigo = mr!Codigo_carga
                End If
            End While
            If Estado = 2 Then
                PictureBox29.BackColor = Color.Red
                PictureBox29.Enabled = True
                ToolTip29.SetToolTip(PictureBox29, "Carga: " + Codigo.ToString + " Clique para ir para controle carga") 'Comentário flutuante
                D5 = Codigo
            ElseIf Estado = 1 Then
                PictureBox29.Enabled = False
                PictureBox29.BackColor = Color.Lime
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox("Falha ao carregar formulário, reinicie-o!. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
        Finally
            cn.Close()
        End Try

        Try
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from Armazem where Setor = '" & "D6" & "'"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            While mr.Read
                Estado = mr!Estado
                If Estado = 2 Then
                    Codigo = mr!Codigo_carga
                End If
            End While
            If Estado = 2 Then
                PictureBox30.BackColor = Color.Red
                PictureBox30.Enabled = True
                ToolTip30.SetToolTip(PictureBox30, "Carga: " + Codigo.ToString + " Clique para ir para controle carga") 'Comentário flutuante
                D6 = Codigo
            ElseIf Estado = 1 Then
                PictureBox30.Enabled = False
                PictureBox30.BackColor = Color.Lime
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox("Falha ao carregar formulário, reinicie-o!. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
        Finally
            cn.Close()
        End Try



        Try
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from Armazem where Setor = '" & "D7" & "'"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            While mr.Read
                Estado = mr!Estado
                If Estado = 2 Then
                    Codigo = mr!Codigo_carga
                End If
            End While
            If Estado = 2 Then
                PictureBox31.BackColor = Color.Red
                PictureBox31.Enabled = True
                ToolTip31.SetToolTip(PictureBox31, "Carga: " + Codigo.ToString + " Clique para ir para controle carga") 'Comentário flutuante
                D7 = Codigo
            ElseIf Estado = 1 Then
                PictureBox31.Enabled = False
                PictureBox31.BackColor = Color.Lime
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox("Falha ao carregar formulário, reinicie-o!. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
        Finally
            cn.Close()
        End Try

        Try
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from Armazem where Setor = '" & "D8" & "'"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            While mr.Read
                Estado = mr!Estado
                If Estado = 2 Then
                    Codigo = mr!Codigo_carga
                End If
            End While
            If Estado = 2 Then
                PictureBox32.BackColor = Color.Red
                PictureBox32.Enabled = True
                ToolTip32.SetToolTip(PictureBox32, "Carga: " + Codigo.ToString + " Clique para ir para controle carga") 'Comentário flutuante
                D8 = Codigo
            ElseIf Estado = 1 Then
                PictureBox32.Enabled = False
                PictureBox32.BackColor = Color.Lime
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox("Falha ao carregar formulário, reinicie-o!. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
        Finally
            cn.Close()
        End Try

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As System.EventArgs) Handles PictureBox1.Click
        Controle_Carga.Show()

        Controle_Carga.ListBox1.SelectedValue = A1
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Controle_Carga.Show()

        Controle_Carga.ListBox1.SelectedValue = A2
    End Sub

    Private Sub VoltarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VoltarToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Controle_Carga.Show()

        Controle_Carga.ListBox1.SelectedValue = A3
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Controle_Carga.Show()

        Controle_Carga.ListBox1.SelectedValue = A4
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        Controle_Carga.Show()

        Controle_Carga.ListBox1.SelectedValue = A5
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        Controle_Carga.Show()

        Controle_Carga.ListBox1.SelectedValue = A6
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        Controle_Carga.Show()

        Controle_Carga.ListBox1.SelectedValue = A7
    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        Controle_Carga.Show()

        Controle_Carga.ListBox1.SelectedValue = A8
    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        Controle_Carga.Show()

        Controle_Carga.ListBox1.SelectedValue = B1
    End Sub

    Private Sub PictureBox10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox10.Click
        Controle_Carga.Show()

        Controle_Carga.ListBox1.SelectedValue = B2
    End Sub

    Private Sub PictureBox11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox11.Click
        Controle_Carga.Show()

        Controle_Carga.ListBox1.SelectedValue = B3
    End Sub

    Private Sub PictureBox12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox12.Click
        Controle_Carga.Show()

        Controle_Carga.ListBox1.SelectedValue = B4
    End Sub

    Private Sub PictureBox13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox13.Click
        Controle_Carga.Show()

        Controle_Carga.ListBox1.SelectedValue = B5
    End Sub

    Private Sub PictureBox14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox14.Click
        Controle_Carga.Show()

        Controle_Carga.ListBox1.SelectedValue = B6
    End Sub

    Private Sub PictureBox15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox15.Click
        Controle_Carga.Show()

        Controle_Carga.ListBox1.SelectedValue = B7
    End Sub

    Private Sub PictureBox16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox16.Click
        Controle_Carga.Show()

        Controle_Carga.ListBox1.SelectedValue = B8
    End Sub

    Private Sub PictureBox17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox17.Click
        Controle_Carga.Show()

        Controle_Carga.ListBox1.SelectedValue = C1
    End Sub

    Private Sub PictureBox18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox18.Click
        Controle_Carga.Show()

        Controle_Carga.ListBox1.SelectedValue = C2
    End Sub

    Private Sub PictureBox19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox19.Click
        Controle_Carga.Show()

        Controle_Carga.ListBox1.SelectedValue = C3
    End Sub

    Private Sub PictureBox20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox20.Click
        Controle_Carga.Show()

        Controle_Carga.ListBox1.SelectedValue = C4
    End Sub

    Private Sub PictureBox21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox21.Click
        Controle_Carga.Show()

        Controle_Carga.ListBox1.SelectedValue = C5
    End Sub

    Private Sub PictureBox22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox22.Click
        Controle_Carga.Show()

        Controle_Carga.ListBox1.SelectedValue = C6
    End Sub

    Private Sub PictureBox23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox23.Click
        Controle_Carga.Show()

        Controle_Carga.ListBox1.SelectedValue = C7
    End Sub

    Private Sub PictureBox24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox24.Click
        Controle_Carga.Show()

        Controle_Carga.ListBox1.SelectedValue = C8
    End Sub

    Private Sub PictureBox25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox25.Click
        Controle_Carga.Show()

        Controle_Carga.ListBox1.SelectedValue = D1
    End Sub

    Private Sub PictureBox26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox26.Click
        Controle_Carga.Show()

        Controle_Carga.ListBox1.SelectedValue = D2
    End Sub

    Private Sub PictureBox27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox27.Click
        Controle_Carga.Show()

        Controle_Carga.ListBox1.SelectedValue = D3
    End Sub

    Private Sub PictureBox28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox28.Click
        Controle_Carga.Show()

        Controle_Carga.ListBox1.SelectedValue = D4
    End Sub

    Private Sub PictureBox29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox29.Click
        Controle_Carga.Show()

        Controle_Carga.ListBox1.SelectedValue = D5
    End Sub

    Private Sub PictureBox30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox30.Click
        Controle_Carga.Show()

        Controle_Carga.ListBox1.SelectedValue = D6
    End Sub

    Private Sub PictureBox31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox31.Click
        Controle_Carga.Show()

        Controle_Carga.ListBox1.SelectedValue = D7
    End Sub

    Private Sub PictureBox32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox32.Click
        Controle_Carga.Show()

        Controle_Carga.ListBox1.SelectedValue = D8
    End Sub

    Private Sub AlterarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AlterarToolStripMenuItem.Click
        Me.Height = 443
        Button1.Visible = True
        Button2.Visible = True
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Height = 300
        Button1.Visible = False
        Button2.Visible = False
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        TextBox1.Text = TextBox1.Text.ToUpper
        If TextBox1.Text = "A1" Or TextBox1.Text = "A2" Or TextBox1.Text = "A3" Or TextBox1.Text = "A4" Or TextBox1.Text = "A5" Or TextBox1.Text = "A6" Or TextBox1.Text = "A7" Or TextBox1.Text = "A8" Or TextBox1.Text = "B1" Or TextBox1.Text = "B2" Or TextBox1.Text = "B3" Or TextBox1.Text = "B4" Or TextBox1.Text = "B5" Or TextBox1.Text = "B6" Or TextBox1.Text = "B7" Or TextBox1.Text = "B8" Or TextBox1.Text = "C1" Or TextBox1.Text = "C2" Or TextBox1.Text = "C3" Or TextBox1.Text = "C4" Or TextBox1.Text = "C5" Or TextBox1.Text = "C6" Or TextBox1.Text = "C7" Or TextBox1.Text = "C8" Or TextBox1.Text = "D1" Or TextBox1.Text = "D2" Or TextBox1.Text = "D3" Or TextBox1.Text = "D4" Or TextBox1.Text = "D5" Or TextBox1.Text = "D6" Or TextBox1.Text = "D7" Or TextBox1.Text = "D8" Then
            Me.Height = 300
            Button1.Visible = False
            Button2.Visible = False

            Dim retorno As Integer
            cn = New SqlConnection("server=(local)\SQLEXPRESS;uid=sa;pwd=123456;database=Transportadora_Eagles")
            cn.Open()

            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "Update Armazem set Estado = 1, Codigo_carga = Null where Setor = '" & TextBox1.Text & "'"
                .CommandType = CommandType.Text
            End With

            retorno = cmd.ExecuteNonQuery
            cn.Close()

            Try
                Dim Resultado As DialogResult
                Resultado = MessageBox.Show("Prosseguir com nova operação?", "Transportadora Eagles", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                Select Case Resultado
                    Case Windows.Forms.DialogResult.Yes
                        Codigo = ""
                        cn = New SqlConnection("server=(local)\SQLEXPRESS;uid=sa;pwd=123456;database=Transportadora_Eagles")
                        Try
                            cn.Open()
                            With cmd
                                .Connection = cn
                                .CommandTimeout = 0
                                .CommandText = "select * from Armazem where Setor = '" & "A1" & "'"
                                .CommandType = CommandType.Text
                            End With
                            mr = cmd.ExecuteReader
                            While mr.Read
                                Estado = mr!Estado
                                If Estado = 2 Then
                                    Codigo = mr!Codigo_carga
                                End If
                            End While
                            If Estado = 2 Then
                                PictureBox1.BackColor = Color.Red
                                PictureBox1.Enabled = True
                                ToolTip1.SetToolTip(PictureBox1, "Carga: " + Codigo.ToString + " Clique para ir para controle carga") 'Comentário flutuante
                                A1 = Codigo
                            ElseIf Estado = 1 Then
                                PictureBox1.Enabled = False
                                PictureBox1.BackColor = Color.Lime
                            End If
                            cn.Close()
                        Catch ex As Exception
                            MsgBox("Falha na gestão de dados, tente reiniciar a operação. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
                        Finally
                            cn.Close()
                        End Try
                        Try
                            cn.Open()
                            With cmd
                                .Connection = cn
                                .CommandTimeout = 0
                                .CommandText = "select * from Armazem where Setor = '" & "A2" & "'"
                                .CommandType = CommandType.Text
                            End With
                            mr = cmd.ExecuteReader
                            While mr.Read
                                Estado = mr!Estado
                                If Estado = 2 Then
                                    Codigo = mr!Codigo_carga
                                End If
                            End While
                            If Estado = 2 Then
                                PictureBox2.BackColor = Color.Red
                                PictureBox2.Enabled = True
                                ToolTip2.SetToolTip(PictureBox2, "Carga: " + Codigo.ToString + " Clique para ir para controle carga") 'Comentário flutuante
                                A2 = Codigo
                            ElseIf Estado = 1 Then
                                PictureBox2.Enabled = False
                                PictureBox2.BackColor = Color.Lime
                            End If
                            cn.Close()


                        Catch ex As Exception
                            MsgBox("Falha na gestão de dados, tente reiniciar a operação. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
                        Finally
                            cn.Close()
                        End Try




                        Try
                            cn.Open()
                            With cmd
                                .Connection = cn
                                .CommandTimeout = 0
                                .CommandText = "select * from Armazem where Setor = '" & "A3" & "'"
                                .CommandType = CommandType.Text
                            End With
                            mr = cmd.ExecuteReader
                            While mr.Read
                                Estado = mr!Estado
                                If Estado = 2 Then
                                    Codigo = mr!Codigo_carga
                                End If
                            End While
                            If Estado = 2 Then
                                PictureBox3.BackColor = Color.Red
                                PictureBox3.Enabled = True
                                ToolTip3.SetToolTip(PictureBox3, "Carga: " + Codigo.ToString + " Clique para ir para controle carga") 'Comentário flutuante
                                A3 = Codigo
                            ElseIf Estado = 1 Then
                                PictureBox3.Enabled = False
                                PictureBox3.BackColor = Color.Lime
                            End If
                            cn.Close()
                        Catch ex As Exception
                            MsgBox("Falha na gestão de dados, tente reiniciar a operação. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
                        Finally
                            cn.Close()
                        End Try





                        Try
                            cn.Open()
                            With cmd
                                .Connection = cn
                                .CommandTimeout = 0
                                .CommandText = "select * from Armazem where Setor = '" & "A4" & "'"
                                .CommandType = CommandType.Text
                            End With
                            mr = cmd.ExecuteReader
                            While mr.Read
                                Estado = mr!Estado
                                If Estado = 2 Then
                                    Codigo = mr!Codigo_carga
                                End If
                            End While
                            If Estado = 2 Then
                                PictureBox4.BackColor = Color.Red
                                PictureBox4.Enabled = True
                                ToolTip4.SetToolTip(PictureBox4, "Carga: " + Codigo.ToString + " Clique para ir para controle carga") 'Comentário flutuante
                                A4 = Codigo
                            ElseIf Estado = 1 Then
                                PictureBox4.Enabled = False
                                PictureBox4.BackColor = Color.Lime
                            End If
                            cn.Close()
                        Catch ex As Exception
                            MsgBox("Falha na gestão de dados, tente reiniciar a operação. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
                        Finally
                            cn.Close()
                        End Try



                        Try
                            cn.Open()
                            With cmd
                                .Connection = cn
                                .CommandTimeout = 0
                                .CommandText = "select * from Armazem where Setor = '" & "A5" & "'"
                                .CommandType = CommandType.Text
                            End With
                            mr = cmd.ExecuteReader
                            While mr.Read
                                Estado = mr!Estado
                                If Estado = 2 Then
                                    Codigo = mr!Codigo_carga
                                End If
                            End While
                            If Estado = 2 Then
                                PictureBox5.BackColor = Color.Red
                                PictureBox5.Enabled = True
                                ToolTip5.SetToolTip(PictureBox5, "Carga: " + Codigo.ToString + " Clique para ir para controle carga") 'Comentário flutuante
                                A5 = Codigo
                            ElseIf Estado = 1 Then
                                PictureBox5.Enabled = False
                                PictureBox5.BackColor = Color.Lime
                            End If
                            cn.Close()
                        Catch ex As Exception
                            MsgBox("Falha na gestão de dados, tente reiniciar a operação. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
                        Finally
                            cn.Close()
                        End Try




                        Try
                            cn.Open()
                            With cmd
                                .Connection = cn
                                .CommandTimeout = 0
                                .CommandText = "select * from Armazem where Setor = '" & "A6" & "'"
                                .CommandType = CommandType.Text
                            End With
                            mr = cmd.ExecuteReader
                            While mr.Read
                                Estado = mr!Estado
                                If Estado = 2 Then
                                    Codigo = mr!Codigo_carga
                                End If
                            End While
                            If Estado = 2 Then
                                PictureBox6.BackColor = Color.Red
                                PictureBox6.Enabled = True
                                ToolTip6.SetToolTip(PictureBox6, "Carga: " + Codigo.ToString + " Clique para ir para controle carga") 'Comentário flutuante
                                A6 = Codigo
                            ElseIf Estado = 1 Then
                                PictureBox6.Enabled = False
                                PictureBox6.BackColor = Color.Lime
                            End If
                            cn.Close()
                        Catch ex As Exception
                            MsgBox("Falha na gestão de dados, tente reiniciar a operação. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
                        Finally
                            cn.Close()
                        End Try




                        Try
                            cn.Open()
                            With cmd
                                .Connection = cn
                                .CommandTimeout = 0
                                .CommandText = "select * from Armazem where Setor = '" & "A7" & "'"
                                .CommandType = CommandType.Text
                            End With
                            mr = cmd.ExecuteReader
                            While mr.Read
                                Estado = mr!Estado
                                If Estado = 2 Then
                                    Codigo = mr!Codigo_carga
                                End If
                            End While
                            If Estado = 2 Then
                                PictureBox7.BackColor = Color.Red
                                PictureBox7.Enabled = True
                                ToolTip7.SetToolTip(PictureBox7, "Carga: " + Codigo.ToString + " Clique para ir para controle carga") 'Comentário flutuante
                                A7 = Codigo
                            ElseIf Estado = 1 Then
                                PictureBox7.Enabled = False
                                PictureBox7.BackColor = Color.Lime
                            End If
                            cn.Close()
                        Catch ex As Exception
                            MsgBox("Falha na gestão de dados, tente reiniciar a operação. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
                        Finally
                            cn.Close()
                        End Try



                        Try
                            cn.Open()
                            With cmd
                                .Connection = cn
                                .CommandTimeout = 0
                                .CommandText = "select * from Armazem where Setor = '" & "A8" & "'"
                                .CommandType = CommandType.Text
                            End With
                            mr = cmd.ExecuteReader
                            While mr.Read
                                Estado = mr!Estado
                                If Estado = 2 Then
                                    Codigo = mr!Codigo_carga
                                End If
                            End While
                            If Estado = 2 Then
                                PictureBox8.BackColor = Color.Red
                                PictureBox8.Enabled = True
                                ToolTip8.SetToolTip(PictureBox8, "Carga: " + Codigo.ToString + " Clique para ir para controle carga") 'Comentário flutuante
                                A8 = Codigo
                            ElseIf Estado = 1 Then
                                PictureBox8.Enabled = False
                                PictureBox8.BackColor = Color.Lime
                            End If
                            cn.Close()
                        Catch ex As Exception
                            MsgBox("Falha na gestão de dados, tente reiniciar a operação. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
                        Finally
                            cn.Close()
                        End Try



                        Try
                            cn.Open()
                            With cmd
                                .Connection = cn
                                .CommandTimeout = 0
                                .CommandText = "select * from Armazem where Setor = '" & "B1" & "'"
                                .CommandType = CommandType.Text
                            End With
                            mr = cmd.ExecuteReader
                            While mr.Read
                                Estado = mr!Estado
                                If Estado = 2 Then
                                    Codigo = mr!Codigo_carga
                                End If
                            End While
                            If Estado = 2 Then
                                PictureBox9.BackColor = Color.Red
                                PictureBox9.Enabled = True
                                ToolTip9.SetToolTip(PictureBox9, "Carga: " + Codigo.ToString + " Clique para ir para controle carga") 'Comentário flutuante
                                B1 = Codigo
                            ElseIf Estado = 1 Then
                                PictureBox9.Enabled = False
                                PictureBox9.BackColor = Color.Lime
                            End If
                            cn.Close()
                        Catch ex As Exception
                            MsgBox("Falha na gestão de dados, tente reiniciar a operação. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
                        Finally
                            cn.Close()
                        End Try



                        Try
                            cn.Open()
                            With cmd
                                .Connection = cn
                                .CommandTimeout = 0
                                .CommandText = "select * from Armazem where Setor = '" & "B2" & "'"
                                .CommandType = CommandType.Text
                            End With
                            mr = cmd.ExecuteReader
                            While mr.Read
                                Estado = mr!Estado
                                If Estado = 2 Then
                                    Codigo = mr!Codigo_carga
                                End If
                            End While
                            If Estado = 2 Then
                                PictureBox10.BackColor = Color.Red
                                PictureBox10.Enabled = True
                                ToolTip10.SetToolTip(PictureBox10, "Carga: " + Codigo.ToString + " Clique para ir para controle carga") 'Comentário flutuante
                                B2 = Codigo
                            ElseIf Estado = 1 Then
                                PictureBox10.Enabled = False
                                PictureBox10.BackColor = Color.Lime
                            End If
                            cn.Close()
                        Catch ex As Exception
                            MsgBox("Falha na gestão de dados, tente reiniciar a operação. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
                        Finally
                            cn.Close()
                        End Try



                        Try
                            cn.Open()
                            With cmd
                                .Connection = cn
                                .CommandTimeout = 0
                                .CommandText = "select * from Armazem where Setor = '" & "B3" & "'"
                                .CommandType = CommandType.Text
                            End With
                            mr = cmd.ExecuteReader
                            While mr.Read
                                Estado = mr!Estado
                                If Estado = 2 Then
                                    Codigo = mr!Codigo_carga
                                End If
                            End While
                            If Estado = 2 Then
                                PictureBox11.BackColor = Color.Red
                                PictureBox11.Enabled = True
                                ToolTip11.SetToolTip(PictureBox11, "Carga: " + Codigo.ToString + " Clique para ir para controle carga") 'Comentário flutuante
                                B3 = Codigo
                            ElseIf Estado = 1 Then
                                PictureBox11.Enabled = False
                                PictureBox11.BackColor = Color.Lime
                            End If
                            cn.Close()
                        Catch ex As Exception
                            MsgBox("Falha na gestão de dados, tente reiniciar a operação. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
                        Finally
                            cn.Close()
                        End Try



                        Try
                            cn.Open()
                            With cmd
                                .Connection = cn
                                .CommandTimeout = 0
                                .CommandText = "select * from Armazem where Setor = '" & "B4" & "'"
                                .CommandType = CommandType.Text
                            End With
                            mr = cmd.ExecuteReader
                            While mr.Read
                                Estado = mr!Estado
                                If Estado = 2 Then
                                    Codigo = mr!Codigo_carga
                                End If
                            End While
                            If Estado = 2 Then
                                PictureBox12.BackColor = Color.Red
                                PictureBox12.Enabled = True
                                ToolTip12.SetToolTip(PictureBox12, "Carga: " + Codigo.ToString + " Clique para ir para controle carga") 'Comentário flutuante
                                B4 = Codigo
                            ElseIf Estado = 1 Then
                                PictureBox12.Enabled = False
                                PictureBox12.BackColor = Color.Lime
                            End If
                            cn.Close()
                        Catch ex As Exception
                            MsgBox("Falha na gestão de dados, tente reiniciar a operação. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
                        Finally
                            cn.Close()
                        End Try



                        Try
                            cn.Open()
                            With cmd
                                .Connection = cn
                                .CommandTimeout = 0
                                .CommandText = "select * from Armazem where Setor = '" & "B5" & "'"
                                .CommandType = CommandType.Text
                            End With
                            mr = cmd.ExecuteReader
                            While mr.Read
                                Estado = mr!Estado
                                If Estado = 2 Then
                                    Codigo = mr!Codigo_carga
                                End If
                            End While
                            If Estado = 2 Then
                                PictureBox13.BackColor = Color.Red
                                PictureBox13.Enabled = True
                                ToolTip13.SetToolTip(PictureBox13, "Carga: " + Codigo.ToString + " Clique para ir para controle carga") 'Comentário flutuante
                                B5 = Codigo
                            ElseIf Estado = 1 Then
                                PictureBox13.Enabled = False
                                PictureBox13.BackColor = Color.Lime
                            End If
                            cn.Close()
                        Catch ex As Exception
                            MsgBox("Falha na gestão de dados, tente reiniciar a operação. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
                        Finally
                            cn.Close()
                        End Try



                        Try
                            cn.Open()
                            With cmd
                                .Connection = cn
                                .CommandTimeout = 0
                                .CommandText = "select * from Armazem where Setor = '" & "B6" & "'"
                                .CommandType = CommandType.Text
                            End With
                            mr = cmd.ExecuteReader
                            While mr.Read
                                Estado = mr!Estado
                                If Estado = 2 Then
                                    Codigo = mr!Codigo_carga
                                End If
                            End While
                            If Estado = 2 Then
                                PictureBox14.BackColor = Color.Red
                                PictureBox14.Enabled = True
                                ToolTip14.SetToolTip(PictureBox14, "Carga: " + Codigo.ToString + " Clique para ir para controle carga") 'Comentário flutuante
                                B6 = Codigo
                            ElseIf Estado = 1 Then
                                PictureBox14.Enabled = False
                                PictureBox14.BackColor = Color.Lime
                            End If
                            cn.Close()
                        Catch ex As Exception
                            MsgBox("Falha na gestão de dados, tente reiniciar a operação. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
                        Finally
                            cn.Close()
                        End Try



                        Try
                            cn.Open()
                            With cmd
                                .Connection = cn
                                .CommandTimeout = 0
                                .CommandText = "select * from Armazem where Setor = '" & "B7" & "'"
                                .CommandType = CommandType.Text
                            End With
                            mr = cmd.ExecuteReader
                            While mr.Read
                                Estado = mr!Estado
                                If Estado = 2 Then
                                    Codigo = mr!Codigo_carga
                                End If
                            End While
                            If Estado = 2 Then
                                PictureBox15.BackColor = Color.Red
                                PictureBox15.Enabled = True
                                ToolTip15.SetToolTip(PictureBox15, "Carga: " + Codigo.ToString + " Clique para ir para controle carga") 'Comentário flutuante
                                B7 = Codigo
                            ElseIf Estado = 1 Then
                                PictureBox15.Enabled = False
                                PictureBox15.BackColor = Color.Lime
                            End If
                            cn.Close()
                        Catch ex As Exception
                            MsgBox("Falha na gestão de dados, tente reiniciar a operação. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
                        Finally
                            cn.Close()
                        End Try



                        Try
                            cn.Open()
                            With cmd
                                .Connection = cn
                                .CommandTimeout = 0
                                .CommandText = "select * from Armazem where Setor = '" & "B8" & "'"
                                .CommandType = CommandType.Text
                            End With
                            mr = cmd.ExecuteReader
                            While mr.Read
                                Estado = mr!Estado
                                If Estado = 2 Then
                                    Codigo = mr!Codigo_carga
                                End If
                            End While
                            If Estado = 2 Then
                                PictureBox16.BackColor = Color.Red
                                PictureBox16.Enabled = True
                                ToolTip16.SetToolTip(PictureBox16, "Carga: " + Codigo.ToString + " Clique para ir para controle carga") 'Comentário flutuante
                                B8 = Codigo
                            ElseIf Estado = 1 Then
                                PictureBox16.Enabled = False
                                PictureBox16.BackColor = Color.Lime
                            End If
                            cn.Close()
                        Catch ex As Exception
                            MsgBox("Falha na gestão de dados, tente reiniciar a operação. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
                        Finally
                            cn.Close()
                        End Try



                        Try
                            cn.Open()
                            With cmd
                                .Connection = cn
                                .CommandTimeout = 0
                                .CommandText = "select * from Armazem where Setor = '" & "C1" & "'"
                                .CommandType = CommandType.Text
                            End With
                            mr = cmd.ExecuteReader
                            While mr.Read
                                Estado = mr!Estado
                                If Estado = 2 Then
                                    Codigo = mr!Codigo_carga
                                End If
                            End While
                            If Estado = 2 Then
                                PictureBox17.BackColor = Color.Red
                                PictureBox17.Enabled = True
                                ToolTip17.SetToolTip(PictureBox17, "Carga: " + Codigo.ToString + " Clique para ir para controle carga") 'Comentário flutuante
                                C1 = Codigo
                            ElseIf Estado = 1 Then
                                PictureBox17.Enabled = False
                                PictureBox17.BackColor = Color.Lime
                            End If
                            cn.Close()
                        Catch ex As Exception
                            MsgBox("Falha na gestão de dados, tente reiniciar a operação. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
                        Finally
                            cn.Close()
                        End Try



                        Try
                            cn.Open()
                            With cmd
                                .Connection = cn
                                .CommandTimeout = 0
                                .CommandText = "select * from Armazem where Setor = '" & "C2" & "'"
                                .CommandType = CommandType.Text
                            End With
                            mr = cmd.ExecuteReader
                            While mr.Read
                                Estado = mr!Estado
                                If Estado = 2 Then
                                    Codigo = mr!Codigo_carga
                                End If
                            End While
                            If Estado = 2 Then
                                PictureBox18.BackColor = Color.Red
                                PictureBox18.Enabled = True
                                ToolTip18.SetToolTip(PictureBox18, "Carga: " + Codigo.ToString + " Clique para ir para controle carga") 'Comentário flutuante
                                C2 = Codigo
                            ElseIf Estado = 1 Then
                                PictureBox18.Enabled = False
                                PictureBox18.BackColor = Color.Lime
                            End If
                            cn.Close()
                        Catch ex As Exception
                            MsgBox("Falha na gestão de dados, tente reiniciar a operação. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
                        Finally
                            cn.Close()
                        End Try



                        Try
                            cn.Open()
                            With cmd
                                .Connection = cn
                                .CommandTimeout = 0
                                .CommandText = "select * from Armazem where Setor = '" & "C3" & "'"
                                .CommandType = CommandType.Text
                            End With
                            mr = cmd.ExecuteReader
                            While mr.Read
                                Estado = mr!Estado
                                If Estado = 2 Then
                                    Codigo = mr!Codigo_carga
                                End If
                            End While
                            If Estado = 2 Then
                                PictureBox19.BackColor = Color.Red
                                PictureBox19.Enabled = True
                                ToolTip19.SetToolTip(PictureBox19, "Carga: " + Codigo.ToString + " Clique para ir para controle carga") 'Comentário flutuante
                                C3 = Codigo
                            ElseIf Estado = 1 Then
                                PictureBox19.Enabled = False
                                PictureBox19.BackColor = Color.Lime
                            End If
                            cn.Close()
                        Catch ex As Exception
                            MsgBox("Falha na gestão de dados, tente reiniciar a operação. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
                        Finally
                            cn.Close()
                        End Try



                        Try
                            cn.Open()
                            With cmd
                                .Connection = cn
                                .CommandTimeout = 0
                                .CommandText = "select * from Armazem where Setor = '" & "C4" & "'"
                                .CommandType = CommandType.Text
                            End With
                            mr = cmd.ExecuteReader
                            While mr.Read
                                Estado = mr!Estado
                                If Estado = 2 Then
                                    Codigo = mr!Codigo_carga
                                End If
                            End While
                            If Estado = 2 Then
                                PictureBox20.BackColor = Color.Red
                                PictureBox20.Enabled = True
                                ToolTip20.SetToolTip(PictureBox20, "Carga: " + Codigo.ToString + " Clique para ir para controle carga") 'Comentário flutuante
                                C4 = Codigo
                            ElseIf Estado = 1 Then
                                PictureBox20.Enabled = False
                                PictureBox20.BackColor = Color.Lime
                            End If
                            cn.Close()
                        Catch ex As Exception
                            MsgBox("Falha na gestão de dados, tente reiniciar a operação. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
                        Finally
                            cn.Close()
                        End Try



                        Try
                            cn.Open()
                            With cmd
                                .Connection = cn
                                .CommandTimeout = 0
                                .CommandText = "select * from Armazem where Setor = '" & "C5" & "'"
                                .CommandType = CommandType.Text
                            End With
                            mr = cmd.ExecuteReader
                            While mr.Read
                                Estado = mr!Estado
                                If Estado = 2 Then
                                    Codigo = mr!Codigo_carga
                                End If
                            End While
                            If Estado = 2 Then
                                PictureBox21.BackColor = Color.Red
                                PictureBox21.Enabled = True
                                ToolTip21.SetToolTip(PictureBox21, "Carga: " + Codigo.ToString + " Clique para ir para controle carga") 'Comentário flutuante
                                C5 = Codigo
                            ElseIf Estado = 1 Then
                                PictureBox21.Enabled = False
                                PictureBox21.BackColor = Color.Lime
                            End If
                            cn.Close()
                        Catch ex As Exception
                            MsgBox("Falha na gestão de dados, tente reiniciar a operação. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
                        Finally
                            cn.Close()
                        End Try



                        Try
                            cn.Open()
                            With cmd
                                .Connection = cn
                                .CommandTimeout = 0
                                .CommandText = "select * from Armazem where Setor = '" & "C6" & "'"
                                .CommandType = CommandType.Text
                            End With
                            mr = cmd.ExecuteReader
                            While mr.Read
                                Estado = mr!Estado
                                If Estado = 2 Then
                                    Codigo = mr!Codigo_carga
                                End If
                            End While
                            If Estado = 2 Then
                                PictureBox22.BackColor = Color.Red
                                PictureBox22.Enabled = True
                                ToolTip22.SetToolTip(PictureBox22, "Carga: " + Codigo.ToString + " Clique para ir para controle carga") 'Comentário flutuante
                                C6 = Codigo
                            ElseIf Estado = 1 Then
                                PictureBox22.Enabled = False
                                PictureBox22.BackColor = Color.Lime
                            End If
                            cn.Close()
                        Catch ex As Exception
                            MsgBox("Falha na gestão de dados, tente reiniciar a operação. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
                        Finally
                            cn.Close()
                        End Try



                        Try
                            cn.Open()
                            With cmd
                                .Connection = cn
                                .CommandTimeout = 0
                                .CommandText = "select * from Armazem where Setor = '" & "C7" & "'"
                                .CommandType = CommandType.Text
                            End With
                            mr = cmd.ExecuteReader
                            While mr.Read
                                Estado = mr!Estado
                                If Estado = 2 Then
                                    Codigo = mr!Codigo_carga
                                End If
                            End While
                            If Estado = 2 Then
                                PictureBox23.BackColor = Color.Red
                                PictureBox23.Enabled = True
                                ToolTip23.SetToolTip(PictureBox23, "Carga: " + Codigo.ToString + " Clique para ir para controle carga") 'Comentário flutuante
                                C7 = Codigo
                            ElseIf Estado = 1 Then
                                PictureBox23.Enabled = False
                                PictureBox23.BackColor = Color.Lime
                            End If
                            cn.Close()
                        Catch ex As Exception
                            MsgBox("Falha na gestão de dados, tente reiniciar a operação. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
                        Finally
                            cn.Close()
                        End Try



                        Try
                            cn.Open()
                            With cmd
                                .Connection = cn
                                .CommandTimeout = 0
                                .CommandText = "select * from Armazem where Setor = '" & "C8" & "'"
                                .CommandType = CommandType.Text
                            End With
                            mr = cmd.ExecuteReader
                            While mr.Read
                                Estado = mr!Estado
                                If Estado = 2 Then
                                    Codigo = mr!Codigo_carga
                                End If
                            End While
                            If Estado = 2 Then
                                PictureBox24.BackColor = Color.Red
                                PictureBox24.Enabled = True
                                ToolTip24.SetToolTip(PictureBox24, "Carga: " + Codigo.ToString + " Clique para ir para controle carga") 'Comentário flutuante
                                C8 = Codigo
                            ElseIf Estado = 1 Then
                                PictureBox24.Enabled = False
                                PictureBox24.BackColor = Color.Lime
                            End If
                            cn.Close()
                        Catch ex As Exception
                            MsgBox("Falha na gestão de dados, tente reiniciar a operação. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
                        Finally
                            cn.Close()
                        End Try



                        Try
                            cn.Open()
                            With cmd
                                .Connection = cn
                                .CommandTimeout = 0
                                .CommandText = "select * from Armazem where Setor = '" & "D1" & "'"
                                .CommandType = CommandType.Text
                            End With
                            mr = cmd.ExecuteReader
                            While mr.Read
                                Estado = mr!Estado
                                If Estado = 2 Then
                                    Codigo = mr!Codigo_carga
                                End If
                            End While
                            If Estado = 2 Then
                                PictureBox25.BackColor = Color.Red
                                PictureBox25.Enabled = True
                                ToolTip25.SetToolTip(PictureBox25, "Carga: " + Codigo.ToString + " Clique para ir para controle carga") 'Comentário flutuante
                                D1 = Codigo
                            ElseIf Estado = 1 Then
                                PictureBox25.Enabled = False
                                PictureBox25.BackColor = Color.Lime
                            End If
                            cn.Close()
                        Catch ex As Exception
                            MsgBox("Falha na gestão de dados, tente reiniciar a operação. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
                        Finally
                            cn.Close()
                        End Try



                        Try
                            cn.Open()
                            With cmd
                                .Connection = cn
                                .CommandTimeout = 0
                                .CommandText = "select * from Armazem where Setor = '" & "D2" & "'"
                                .CommandType = CommandType.Text
                            End With
                            mr = cmd.ExecuteReader
                            While mr.Read
                                Estado = mr!Estado
                                If Estado = 2 Then
                                    Codigo = mr!Codigo_carga
                                End If
                            End While
                            If Estado = 2 Then
                                PictureBox26.BackColor = Color.Red
                                PictureBox26.Enabled = True
                                ToolTip26.SetToolTip(PictureBox26, "Carga: " + Codigo.ToString + " Clique para ir para controle carga") 'Comentário flutuante
                                D1 = Codigo
                            ElseIf Estado = 1 Then
                                PictureBox26.Enabled = False
                                PictureBox26.BackColor = Color.Lime
                            End If
                            cn.Close()
                        Catch ex As Exception
                            MsgBox("Falha na gestão de dados, tente reiniciar a operação. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
                        Finally
                            cn.Close()
                        End Try


                        Try
                            cn.Open()
                            With cmd
                                .Connection = cn
                                .CommandTimeout = 0
                                .CommandText = "select * from Armazem where Setor = '" & "D3" & "'"
                                .CommandType = CommandType.Text
                            End With
                            mr = cmd.ExecuteReader
                            While mr.Read
                                Estado = mr!Estado
                                If Estado = 2 Then
                                    Codigo = mr!Codigo_carga
                                End If
                            End While
                            If Estado = 2 Then
                                PictureBox27.BackColor = Color.Red
                                PictureBox27.Enabled = True
                                ToolTip27.SetToolTip(PictureBox27, "Carga: " + Codigo.ToString + " Clique para ir para controle carga") 'Comentário flutuante
                                D3 = Codigo
                            ElseIf Estado = 1 Then
                                PictureBox27.Enabled = False
                                PictureBox27.BackColor = Color.Lime
                            End If
                            cn.Close()
                        Catch ex As Exception
                            MsgBox("Falha na gestão de dados, tente reiniciar a operação. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
                        Finally
                            cn.Close()
                        End Try


                        Try
                            cn.Open()
                            With cmd
                                .Connection = cn
                                .CommandTimeout = 0
                                .CommandText = "select * from Armazem where Setor = '" & "D4" & "'"
                                .CommandType = CommandType.Text
                            End With
                            mr = cmd.ExecuteReader
                            While mr.Read
                                Estado = mr!Estado
                                If Estado = 2 Then
                                    Codigo = mr!Codigo_carga
                                End If
                            End While
                            If Estado = 2 Then
                                PictureBox28.BackColor = Color.Red
                                PictureBox28.Enabled = True
                                ToolTip28.SetToolTip(PictureBox28, "Carga: " + Codigo.ToString + " Clique para ir para controle carga") 'Comentário flutuante
                                D4 = Codigo
                            ElseIf Estado = 1 Then
                                PictureBox28.Enabled = False
                                PictureBox28.BackColor = Color.Lime
                            End If
                            cn.Close()
                        Catch ex As Exception
                            MsgBox("Falha na gestão de dados, tente reiniciar a operação. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
                        Finally
                            cn.Close()
                        End Try



                        Try
                            cn.Open()
                            With cmd
                                .Connection = cn
                                .CommandTimeout = 0
                                .CommandText = "select * from Armazem where Setor = '" & "D5" & "'"
                                .CommandType = CommandType.Text
                            End With
                            mr = cmd.ExecuteReader
                            While mr.Read
                                Estado = mr!Estado
                                If Estado = 2 Then
                                    Codigo = mr!Codigo_carga
                                End If
                            End While
                            If Estado = 2 Then
                                PictureBox29.BackColor = Color.Red
                                PictureBox29.Enabled = True
                                ToolTip29.SetToolTip(PictureBox29, "Carga: " + Codigo.ToString + " Clique para ir para controle carga") 'Comentário flutuante
                                D5 = Codigo
                            ElseIf Estado = 1 Then
                                PictureBox29.Enabled = False
                                PictureBox29.BackColor = Color.Lime
                            End If
                            cn.Close()
                        Catch ex As Exception
                            MsgBox("Falha na gestão de dados, tente reiniciar a operação. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
                        Finally
                            cn.Close()
                        End Try

                        Try
                            cn.Open()
                            With cmd
                                .Connection = cn
                                .CommandTimeout = 0
                                .CommandText = "select * from Armazem where Setor = '" & "D6" & "'"
                                .CommandType = CommandType.Text
                            End With
                            mr = cmd.ExecuteReader
                            While mr.Read
                                Estado = mr!Estado
                                If Estado = 2 Then
                                    Codigo = mr!Codigo_carga
                                End If
                            End While
                            If Estado = 2 Then
                                PictureBox30.BackColor = Color.Red
                                PictureBox30.Enabled = True
                                ToolTip30.SetToolTip(PictureBox30, "Carga: " + Codigo.ToString + " Clique para ir para controle carga") 'Comentário flutuante
                                D6 = Codigo
                            ElseIf Estado = 1 Then
                                PictureBox30.Enabled = False
                                PictureBox30.BackColor = Color.Lime
                            End If
                            cn.Close()
                        Catch ex As Exception
                            MsgBox("Falha na gestão de dados, tente reiniciar a operação. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
                        Finally
                            cn.Close()
                        End Try



                        Try
                            cn.Open()
                            With cmd
                                .Connection = cn
                                .CommandTimeout = 0
                                .CommandText = "select * from Armazem where Setor = '" & "D7" & "'"
                                .CommandType = CommandType.Text
                            End With
                            mr = cmd.ExecuteReader
                            While mr.Read
                                Estado = mr!Estado
                                If Estado = 2 Then
                                    Codigo = mr!Codigo_carga
                                End If
                            End While
                            If Estado = 2 Then
                                PictureBox31.BackColor = Color.Red
                                PictureBox31.Enabled = True
                                ToolTip31.SetToolTip(PictureBox31, "Carga: " + Codigo.ToString + " Clique para ir para controle carga") 'Comentário flutuante
                                D7 = Codigo
                            ElseIf Estado = 1 Then
                                PictureBox31.Enabled = False
                                PictureBox31.BackColor = Color.Lime
                            End If
                            cn.Close()
                        Catch ex As Exception
                            MsgBox("Falha na gestão de dados, tente reiniciar a operação. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
                        Finally
                            cn.Close()
                        End Try

                        Try
                            cn.Open()
                            With cmd
                                .Connection = cn
                                .CommandTimeout = 0
                                .CommandText = "select * from Armazem where Setor = '" & "D8" & "'"
                                .CommandType = CommandType.Text
                            End With
                            mr = cmd.ExecuteReader
                            While mr.Read
                                Estado = mr!Estado
                                If Estado = 2 Then
                                    Codigo = mr!Codigo_carga
                                End If
                            End While
                            If Estado = 2 Then
                                PictureBox32.BackColor = Color.Red
                                PictureBox32.Enabled = True
                                ToolTip32.SetToolTip(PictureBox32, "Carga: " + Codigo.ToString + " Clique para ir para controle carga") 'Comentário flutuante
                                D8 = Codigo
                            ElseIf Estado = 1 Then
                                PictureBox32.Enabled = False
                                PictureBox32.BackColor = Color.Lime
                            End If
                            cn.Close()
                        Catch ex As Exception
                            MsgBox("Falha na gestão de dados, tente reiniciar a operação. Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
                        Finally
                            cn.Close()
                        End Try
                    Case Windows.Forms.DialogResult.No
                        Me.Close()
                End Select


            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                cn.Close()
            End Try

        Else
            TextBox1.BackColor = Color.Red
        End If
    End Sub
End Class