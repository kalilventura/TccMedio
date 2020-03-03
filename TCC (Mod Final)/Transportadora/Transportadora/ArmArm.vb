Imports System.Data.SqlClient

Public Class ArmArm
    Dim Estado As String
    Dim Codigo As String
    Dim cn As New SqlConnection
    Dim cmd As New SqlCommand
    Dim mr As SqlDataReader
    Dim A1, A2, A3, A4, A5, A6, A7, A8, B1, B2, B3, B4, B5, B6, B7, B8, C1, C2, C3, C4, C5, C6, C7, C8, D1, D2, D3, D4, D5, D6, D7, D8 As String
    Private Sub VoltarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VoltarToolStripMenuItem.Click
        Me.Hide()
    End Sub

    Private Sub ArmArm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
                PictureBox1.Enabled = False

                A1 = Codigo
            ElseIf Estado = 1 Then
                PictureBox1.Enabled = True
                PictureBox1.BackColor = Color.Lime
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox("Falha ao carregar formulário, reinicie-o! Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
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
                PictureBox2.Enabled = False

                A2 = Codigo
            ElseIf Estado = 1 Then
                PictureBox2.Enabled = True
                PictureBox2.BackColor = Color.Lime
            End If
            cn.Close()


        Catch ex As Exception
            MsgBox("Falha ao carregar formulário, reinicie-o! Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
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
                PictureBox3.Enabled = False

                A3 = Codigo
            ElseIf Estado = 1 Then
                PictureBox3.Enabled = True
                PictureBox3.BackColor = Color.Lime
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox("Falha ao carregar formulário, reinicie-o! Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
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
                PictureBox4.Enabled = False

                A4 = Codigo
            ElseIf Estado = 1 Then
                PictureBox4.Enabled = True
                PictureBox4.BackColor = Color.Lime
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox("Falha ao carregar formulário, reinicie-o! Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
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
                PictureBox5.Enabled = False

                A5 = Codigo
            ElseIf Estado = 1 Then
                PictureBox5.Enabled = True
                PictureBox5.BackColor = Color.Lime
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox("Falha ao carregar formulário, reinicie-o! Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
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
                PictureBox6.Enabled = False

                A6 = Codigo
            ElseIf Estado = 1 Then
                PictureBox6.Enabled = True
                PictureBox6.BackColor = Color.Lime
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox("Falha ao carregar formulário, reinicie-o! Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
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
                PictureBox7.Enabled = False

                A7 = Codigo
            ElseIf Estado = 1 Then
                PictureBox7.Enabled = True
                PictureBox7.BackColor = Color.Lime
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox("Falha ao carregar formulário, reinicie-o! Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
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
                PictureBox8.Enabled = False

                A8 = Codigo
            ElseIf Estado = 1 Then
                PictureBox8.Enabled = True
                PictureBox8.BackColor = Color.Lime
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox("Falha ao carregar formulário, reinicie-o! Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
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
                PictureBox9.Enabled = False

                B1 = Codigo
            ElseIf Estado = 1 Then
                PictureBox9.Enabled = True
                PictureBox9.BackColor = Color.Lime
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox("Falha ao carregar formulário, reinicie-o! Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
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
                PictureBox10.Enabled = False

                B2 = Codigo
            ElseIf Estado = 1 Then
                PictureBox10.Enabled = True
                PictureBox10.BackColor = Color.Lime
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox("Falha ao carregar formulário, reinicie-o! Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
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
                PictureBox11.Enabled = False

                B3 = Codigo
            ElseIf Estado = 1 Then
                PictureBox11.Enabled = True
                PictureBox11.BackColor = Color.Lime
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox("Falha ao carregar formulário, reinicie-o! Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
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
                PictureBox12.Enabled = False

                B4 = Codigo
            ElseIf Estado = 1 Then
                PictureBox12.Enabled = True
                PictureBox12.BackColor = Color.Lime
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox("Falha ao carregar formulário, reinicie-o! Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
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
                PictureBox13.Enabled = False

                B5 = Codigo
            ElseIf Estado = 1 Then
                PictureBox13.Enabled = True
                PictureBox13.BackColor = Color.Lime
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox("Falha ao carregar formulário, reinicie-o! Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
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
                PictureBox14.Enabled = False

                B6 = Codigo
            ElseIf Estado = 1 Then
                PictureBox14.Enabled = True
                PictureBox14.BackColor = Color.Lime
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox("Falha ao carregar formulário, reinicie-o! Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
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
                PictureBox15.Enabled = False

                B7 = Codigo
            ElseIf Estado = 1 Then
                PictureBox15.Enabled = True
                PictureBox15.BackColor = Color.Lime
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox("Falha ao carregar formulário, reinicie-o! Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
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
                PictureBox16.Enabled = False

                B8 = Codigo
            ElseIf Estado = 1 Then
                PictureBox16.Enabled = True
                PictureBox16.BackColor = Color.Lime
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox("Falha ao carregar formulário, reinicie-o! Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
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
                PictureBox17.Enabled = False

                C1 = Codigo
            ElseIf Estado = 1 Then
                PictureBox17.Enabled = True
                PictureBox17.BackColor = Color.Lime
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox("Falha ao carregar formulário, reinicie-o! Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
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
                PictureBox18.Enabled = False

                C2 = Codigo
            ElseIf Estado = 1 Then
                PictureBox18.Enabled = True
                PictureBox18.BackColor = Color.Lime
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox("Falha ao carregar formulário, reinicie-o! Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
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
                PictureBox19.Enabled = False

                C3 = Codigo
            ElseIf Estado = 1 Then
                PictureBox19.Enabled = True
                PictureBox19.BackColor = Color.Lime
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox("Falha ao carregar formulário, reinicie-o! Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
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
                PictureBox20.Enabled = False

                C4 = Codigo
            ElseIf Estado = 1 Then
                PictureBox20.Enabled = True
                PictureBox20.BackColor = Color.Lime
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox("Falha ao carregar formulário, reinicie-o! Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
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
                PictureBox21.Enabled = False

                C5 = Codigo
            ElseIf Estado = 1 Then
                PictureBox21.Enabled = True
                PictureBox21.BackColor = Color.Lime
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox("Falha ao carregar formulário, reinicie-o! Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
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
                PictureBox22.Enabled = False

                C6 = Codigo
            ElseIf Estado = 1 Then
                PictureBox22.Enabled = True
                PictureBox22.BackColor = Color.Lime
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox("Falha ao carregar formulário, reinicie-o! Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
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
                PictureBox23.Enabled = False

                C7 = Codigo
            ElseIf Estado = 1 Then
                PictureBox23.Enabled = True
                PictureBox23.BackColor = Color.Lime
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox("Falha ao carregar formulário, reinicie-o! Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
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
                PictureBox24.Enabled = False

                C8 = Codigo
            ElseIf Estado = 1 Then
                PictureBox24.Enabled = True
                PictureBox24.BackColor = Color.Lime
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox("Falha ao carregar formulário, reinicie-o! Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
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
                PictureBox25.Enabled = False

                D1 = Codigo
            ElseIf Estado = 1 Then
                PictureBox25.Enabled = True
                PictureBox25.BackColor = Color.Lime
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox("Falha ao carregar formulário, reinicie-o! Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
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
                PictureBox26.Enabled = False

                D1 = Codigo
            ElseIf Estado = 1 Then
                PictureBox26.Enabled = True
                PictureBox26.BackColor = Color.Lime
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox("Falha ao carregar formulário, reinicie-o! Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
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
                PictureBox27.Enabled = False

                D3 = Codigo
            ElseIf Estado = 1 Then
                PictureBox27.Enabled = True
                PictureBox27.BackColor = Color.Lime
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox("Falha ao carregar formulário, reinicie-o! Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
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
                PictureBox28.Enabled = False

                D4 = Codigo
            ElseIf Estado = 1 Then
                PictureBox28.Enabled = True
                PictureBox28.BackColor = Color.Lime
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox("Falha ao carregar formulário, reinicie-o! Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
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
                PictureBox29.Enabled = False

                D5 = Codigo
            ElseIf Estado = 1 Then
                PictureBox29.Enabled = True
                PictureBox29.BackColor = Color.Lime
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox("Falha ao carregar formulário, reinicie-o! Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
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
                PictureBox30.Enabled = False

                D6 = Codigo
            ElseIf Estado = 1 Then
                PictureBox30.Enabled = True
                PictureBox30.BackColor = Color.Lime
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox("Falha ao carregar formulário, reinicie-o! Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
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
                PictureBox31.Enabled = False

                D7 = Codigo
            ElseIf Estado = 1 Then
                PictureBox31.Enabled = True
                PictureBox31.BackColor = Color.Lime
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox("Falha ao carregar formulário, reinicie-o! Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
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
                PictureBox32.Enabled = False

                D8 = Codigo
            ElseIf Estado = 1 Then
                PictureBox32.Enabled = True
                PictureBox32.BackColor = Color.Lime
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox("Falha ao carregar formulário, reinicie-o! Se o erro persistir consulte o suporte", MsgBoxStyle.Information, "Transportadora Eagles")
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Dim Resultado As DialogResult
        Resultado = MessageBox.Show("Confirmar escolha?", "Transportadora Eagles", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        Select Case Resultado
            Case Windows.Forms.DialogResult.Yes
                Me.Close()
            Case Windows.Forms.DialogResult.No

        End Select
        ArmVenda2.PictureBox1.BackgroundImage = Transportadora.My.Resources.Resources.A1
        ArmVenda2.Label3.Text = "A1"
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        ArmVenda2.Label3.Text = "A2"
        Dim Resultado As DialogResult
        Resultado = MessageBox.Show("Confirmar escolha?", "Transportadora Eagles", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        Select Case Resultado
            Case Windows.Forms.DialogResult.Yes
                Me.Close()
            Case Windows.Forms.DialogResult.No

        End Select
        ArmVenda2.PictureBox1.BackgroundImage = Transportadora.My.Resources.Resources.A2
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        ArmVenda2.PictureBox1.BackgroundImage = Transportadora.My.Resources.Resources.A3
        ArmVenda2.Label3.Text = "A3"
        Dim Resultado As DialogResult
        Resultado = MessageBox.Show("Confirmar escolha?", "Transportadora Eagles", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        Select Case Resultado
            Case Windows.Forms.DialogResult.Yes
                Me.Close()
            Case Windows.Forms.DialogResult.No

        End Select
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        ArmVenda2.PictureBox1.BackgroundImage = Transportadora.My.Resources.Resources.A4
        ArmVenda2.Label3.Text = "A4"
        Dim Resultado As DialogResult
        Resultado = MessageBox.Show("Confirmar escolha?", "Transportadora Eagles", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        Select Case Resultado
            Case Windows.Forms.DialogResult.Yes
                Me.Close()
            Case Windows.Forms.DialogResult.No

        End Select
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        ArmVenda2.PictureBox1.BackgroundImage = Transportadora.My.Resources.Resources.A5
        ArmVenda2.Label3.Text = "A5"
        Dim Resultado As DialogResult
        Resultado = MessageBox.Show("Confirmar escolha?", "Transportadora Eagles", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        Select Case Resultado
            Case Windows.Forms.DialogResult.Yes
                Me.Close()
            Case Windows.Forms.DialogResult.No

        End Select
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        ArmVenda2.PictureBox1.BackgroundImage = Transportadora.My.Resources.Resources.A6
        ArmVenda2.Label3.Text = "A6"
        Dim Resultado As DialogResult
        Resultado = MessageBox.Show("Confirmar escolha?", "Transportadora Eagles", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        Select Case Resultado
            Case Windows.Forms.DialogResult.Yes
                Me.Close()
            Case Windows.Forms.DialogResult.No

        End Select
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        ArmVenda2.PictureBox1.BackgroundImage = Transportadora.My.Resources.Resources.A7
        ArmVenda2.Label3.Text = "A7"
        Dim Resultado As DialogResult
        Resultado = MessageBox.Show("Confirmar escolha?", "Transportadora Eagles", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        Select Case Resultado
            Case Windows.Forms.DialogResult.Yes
                Me.Close()
            Case Windows.Forms.DialogResult.No

        End Select
    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        ArmVenda2.PictureBox1.BackgroundImage = Transportadora.My.Resources.Resources.A8
        ArmVenda2.Label3.Text = "A8"
        Dim Resultado As DialogResult
        Resultado = MessageBox.Show("Confirmar escolha?", "Transportadora Eagles", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        Select Case Resultado
            Case Windows.Forms.DialogResult.Yes
                Me.Close()
            Case Windows.Forms.DialogResult.No

        End Select
    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        ArmVenda2.PictureBox1.BackgroundImage = Transportadora.My.Resources.Resources.B1
        ArmVenda2.Label3.Text = "B1"
        Dim Resultado As DialogResult
        Resultado = MessageBox.Show("Confirmar escolha?", "Transportadora Eagles", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        Select Case Resultado
            Case Windows.Forms.DialogResult.Yes
                Me.Close()
            Case Windows.Forms.DialogResult.No

        End Select
    End Sub

    Private Sub PictureBox10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox10.Click
        ArmVenda2.PictureBox1.BackgroundImage = Transportadora.My.Resources.Resources.B2
        ArmVenda2.Label3.Text = "B2"
        Dim Resultado As DialogResult
        Resultado = MessageBox.Show("Confirmar escolha?", "Transportadora Eagles", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        Select Case Resultado
            Case Windows.Forms.DialogResult.Yes
                Me.Close()
            Case Windows.Forms.DialogResult.No

        End Select
    End Sub

    Private Sub PictureBox11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox11.Click
        ArmVenda2.PictureBox1.BackgroundImage = Transportadora.My.Resources.Resources.B3
        ArmVenda2.Label3.Text = "B3"
        Dim Resultado As DialogResult
        Resultado = MessageBox.Show("Confirmar escolha?", "Transportadora Eagles", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        Select Case Resultado
            Case Windows.Forms.DialogResult.Yes
                Me.Close()
            Case Windows.Forms.DialogResult.No

        End Select
    End Sub

    Private Sub PictureBox12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox12.Click
        ArmVenda2.PictureBox1.BackgroundImage = Transportadora.My.Resources.Resources.B4
        ArmVenda2.Label3.Text = "B4"
        Dim Resultado As DialogResult
        Resultado = MessageBox.Show("Confirmar escolha?", "Transportadora Eagles", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        Select Case Resultado
            Case Windows.Forms.DialogResult.Yes
                Me.Close()
            Case Windows.Forms.DialogResult.No

        End Select
    End Sub

    Private Sub PictureBox13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox13.Click
        ArmVenda2.PictureBox1.BackgroundImage = Transportadora.My.Resources.Resources.B5
        ArmVenda2.Label3.Text = "B5"
        Dim Resultado As DialogResult
        Resultado = MessageBox.Show("Confirmar escolha?", "Transportadora Eagles", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        Select Case Resultado
            Case Windows.Forms.DialogResult.Yes
                Me.Close()
            Case Windows.Forms.DialogResult.No

        End Select
    End Sub

    Private Sub PictureBox14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox14.Click
        ArmVenda2.PictureBox1.BackgroundImage = Transportadora.My.Resources.Resources.B6
        ArmVenda2.Label3.Text = "B6"
        Dim Resultado As DialogResult
        Resultado = MessageBox.Show("Confirmar escolha?", "Transportadora Eagles", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        Select Case Resultado
            Case Windows.Forms.DialogResult.Yes
                Me.Close()
            Case Windows.Forms.DialogResult.No

        End Select
    End Sub

    Private Sub PictureBox15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox15.Click
        ArmVenda2.PictureBox1.BackgroundImage = Transportadora.My.Resources.Resources.B7
        ArmVenda2.Label3.Text = "B7"
        Dim Resultado As DialogResult
        Resultado = MessageBox.Show("Confirmar escolha?", "Transportadora Eagles", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        Select Case Resultado
            Case Windows.Forms.DialogResult.Yes
                Me.Close()
            Case Windows.Forms.DialogResult.No

        End Select
    End Sub

    Private Sub PictureBox16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox16.Click
        ArmVenda2.PictureBox1.BackgroundImage = Transportadora.My.Resources.Resources.B8
        ArmVenda2.Label3.Text = "B8"
        Dim Resultado As DialogResult
        Resultado = MessageBox.Show("Confirmar escolha?", "Transportadora Eagles", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        Select Case Resultado
            Case Windows.Forms.DialogResult.Yes
                Me.Close()
            Case Windows.Forms.DialogResult.No

        End Select
    End Sub

    Private Sub PictureBox17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox17.Click
        ArmVenda2.PictureBox1.BackgroundImage = Transportadora.My.Resources.Resources.C1
        ArmVenda2.Label3.Text = "C1"
        Dim Resultado As DialogResult
        Resultado = MessageBox.Show("Confirmar escolha?", "Transportadora Eagles", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        Select Case Resultado
            Case Windows.Forms.DialogResult.Yes
                Me.Close()
            Case Windows.Forms.DialogResult.No

        End Select
    End Sub

    Private Sub PictureBox18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox18.Click
        ArmVenda2.PictureBox1.BackgroundImage = Transportadora.My.Resources.Resources.C2
        ArmVenda2.Label3.Text = "C2"
        Dim Resultado As DialogResult
        Resultado = MessageBox.Show("Confirmar escolha?", "Transportadora Eagles", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        Select Case Resultado
            Case Windows.Forms.DialogResult.Yes
                Me.Close()
            Case Windows.Forms.DialogResult.No

        End Select
    End Sub

    Private Sub PictureBox19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox19.Click
        ArmVenda2.PictureBox1.BackgroundImage = Transportadora.My.Resources.Resources.C3
        ArmVenda2.Label3.Text = "C3"
        Dim Resultado As DialogResult
        Resultado = MessageBox.Show("Confirmar escolha?", "Transportadora Eagles", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        Select Case Resultado
            Case Windows.Forms.DialogResult.Yes
                Me.Close()
            Case Windows.Forms.DialogResult.No

        End Select
    End Sub

    Private Sub PictureBox20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox20.Click
        ArmVenda2.PictureBox1.BackgroundImage = Transportadora.My.Resources.Resources.C4
        ArmVenda2.Label3.Text = "C4"
        Dim Resultado As DialogResult
        Resultado = MessageBox.Show("Confirmar escolha?", "Transportadora Eagles", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        Select Case Resultado
            Case Windows.Forms.DialogResult.Yes
                Me.Close()
            Case Windows.Forms.DialogResult.No

        End Select
    End Sub

    Private Sub PictureBox21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox21.Click
        ArmVenda2.PictureBox1.BackgroundImage = Transportadora.My.Resources.Resources.C5
        ArmVenda2.Label3.Text = "C5"
        Dim Resultado As DialogResult
        Resultado = MessageBox.Show("Confirmar escolha?", "Transportadora Eagles", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        Select Case Resultado
            Case Windows.Forms.DialogResult.Yes
                Me.Close()
            Case Windows.Forms.DialogResult.No

        End Select
    End Sub

    Private Sub PictureBox22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox22.Click
        ArmVenda2.PictureBox1.BackgroundImage = Transportadora.My.Resources.Resources.C6
        ArmVenda2.Label3.Text = "C6"
        Dim Resultado As DialogResult
        Resultado = MessageBox.Show("Confirmar escolha?", "Transportadora Eagles", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        Select Case Resultado
            Case Windows.Forms.DialogResult.Yes
                Me.Close()
            Case Windows.Forms.DialogResult.No

        End Select
    End Sub

    Private Sub PictureBox23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox23.Click
        ArmVenda2.PictureBox1.BackgroundImage = Transportadora.My.Resources.Resources.C7
        ArmVenda2.Label3.Text = "C7"
        Dim Resultado As DialogResult
        Resultado = MessageBox.Show("Confirmar escolha?", "Transportadora Eagles", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        Select Case Resultado
            Case Windows.Forms.DialogResult.Yes
                Me.Close()
            Case Windows.Forms.DialogResult.No

        End Select
    End Sub

    Private Sub PictureBox24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox24.Click
        ArmVenda2.PictureBox1.BackgroundImage = Transportadora.My.Resources.Resources.C8
        ArmVenda2.Label3.Text = "C8"
        Dim Resultado As DialogResult
        Resultado = MessageBox.Show("Confirmar escolha?", "Transportadora Eagles", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        Select Case Resultado
            Case Windows.Forms.DialogResult.Yes
                Me.Close()
            Case Windows.Forms.DialogResult.No

        End Select
    End Sub

    Private Sub PictureBox25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox25.Click
        ArmVenda2.PictureBox1.BackgroundImage = Transportadora.My.Resources.Resources.D1
        ArmVenda2.Label3.Text = "D1"
        Dim Resultado As DialogResult
        Resultado = MessageBox.Show("Confirmar escolha?", "Transportadora Eagles", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        Select Case Resultado
            Case Windows.Forms.DialogResult.Yes
                Me.Close()
            Case Windows.Forms.DialogResult.No

        End Select
    End Sub

    Private Sub PictureBox26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox26.Click
        ArmVenda2.PictureBox1.BackgroundImage = Transportadora.My.Resources.Resources.D2
        ArmVenda2.Label3.Text = "D2"
        Dim Resultado As DialogResult
        Resultado = MessageBox.Show("Confirmar escolha?", "Transportadora Eagles", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        Select Case Resultado
            Case Windows.Forms.DialogResult.Yes
                Me.Close()
            Case Windows.Forms.DialogResult.No

        End Select
    End Sub

    Private Sub PictureBox27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox27.Click
        ArmVenda2.PictureBox1.BackgroundImage = Transportadora.My.Resources.Resources.D3
        ArmVenda2.Label3.Text = "D3"
        Dim Resultado As DialogResult
        Resultado = MessageBox.Show("Confirmar escolha?", "Transportadora Eagles", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        Select Case Resultado
            Case Windows.Forms.DialogResult.Yes
                Me.Close()
            Case Windows.Forms.DialogResult.No

        End Select
    End Sub

    Private Sub PictureBox28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox28.Click
        ArmVenda2.PictureBox1.BackgroundImage = Transportadora.My.Resources.Resources.D4
        ArmVenda2.Label3.Text = "D4"
        Dim Resultado As DialogResult
        Resultado = MessageBox.Show("Confirmar escolha?", "Transportadora Eagles", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        Select Case Resultado
            Case Windows.Forms.DialogResult.Yes
                Me.Close()
            Case Windows.Forms.DialogResult.No

        End Select
    End Sub

    Private Sub PictureBox29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox29.Click
        ArmVenda2.PictureBox1.BackgroundImage = Transportadora.My.Resources.Resources.D5
        ArmVenda2.Label3.Text = "D5"
        Dim Resultado As DialogResult
        Resultado = MessageBox.Show("Confirmar escolha?", "Transportadora Eagles", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        Select Case Resultado
            Case Windows.Forms.DialogResult.Yes
                Me.Close()
            Case Windows.Forms.DialogResult.No

        End Select
    End Sub

    Private Sub PictureBox30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox30.Click
        ArmVenda2.PictureBox1.BackgroundImage = Transportadora.My.Resources.Resources.D6
        ArmVenda2.Label3.Text = "D6"
        Dim Resultado As DialogResult
        Resultado = MessageBox.Show("Confirmar escolha?", "Transportadora Eagles", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        Select Case Resultado
            Case Windows.Forms.DialogResult.Yes
                Me.Close()
            Case Windows.Forms.DialogResult.No

        End Select
    End Sub

    Private Sub PictureBox31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox31.Click
        ArmVenda2.PictureBox1.BackgroundImage = Transportadora.My.Resources.Resources.D7
        ArmVenda2.Label3.Text = "D7"
        Dim Resultado As DialogResult
        Resultado = MessageBox.Show("Confirmar escolha?", "Transportadora Eagles", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        Select Case Resultado
            Case Windows.Forms.DialogResult.Yes
                Me.Close()
            Case Windows.Forms.DialogResult.No

        End Select
    End Sub

    Private Sub PictureBox32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox32.Click
        ArmVenda2.PictureBox1.BackgroundImage = Transportadora.My.Resources.Resources.D8
        ArmVenda2.Label3.Text = "D8"
        Dim Resultado As DialogResult
        Resultado = MessageBox.Show("Confirmar escolha?", "Transportadora Eagles", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        Select Case Resultado
            Case Windows.Forms.DialogResult.Yes
                Me.Close()
            Case Windows.Forms.DialogResult.No

        End Select
    End Sub
End Class