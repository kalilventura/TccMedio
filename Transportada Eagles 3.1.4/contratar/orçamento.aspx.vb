
Partial Class contratar_orçamento
    Inherits System.Web.UI.Page
    Dim FretePeso, FreteValor, MedidaA, MedidaL, MedidaC, QTD, Cubagem As Double

    Protected Sub LinkButton19_Click(sender As Object, e As System.EventArgs) Handles LinkButton19.Click
        FretePeso = 0
        FreteValor = 0
        Try
            If Convert.ToDouble(TextBox8.Text) > Convert.ToDouble(TextBox14.Text) Then
                FretePeso = (Convert.ToDouble(TextBox8.Text) * 0.34999999999999998)
                FreteValor = (Convert.ToDouble(TextBox9.Text) * 0.0050000000000000001)
                'Pedagio = (((Math.Ceiling(Convert.ToDouble(Venda2DadosCarga.TextBox1.Text))) / 100) * 2.5)
                'Imp = ((FretePeso + FreteValor + Pedagio) * 0.12)
                TextBox7.Text = FormatNumber((FretePeso + FreteValor), 2)
            Else
                FretePeso = (Convert.ToDouble(TextBox14.Text) * 0.34999999999999998)
                FreteValor = (Convert.ToDouble(TextBox9.Text) * 0.0050000000000000001)
                'Pedagio = (((Math.Ceiling(Convert.ToDouble(Venda2DadosCarga.TextBox1.Text))) / 100) * 2.5)
                'Imp = ((FretePeso + FreteValor + Pedagio) * 0.12)
                TextBox7.Text = FormatNumber((FretePeso + FreteValor), 2)
            End If
            Label10.Visible = True
            TextBox7.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Protected Sub TextBox13_TextChanged(sender As Object, e As System.EventArgs) Handles TextBox13.TextChanged
        If TextBox10.Text <> "" And TextBox11.Text <> "" And TextBox12.Text <> "" Then
            Try
                MedidaA = Convert.ToDouble(TextBox11.Text)
                MedidaL = Convert.ToDouble(TextBox13.Text)
                MedidaC = Convert.ToDouble(TextBox12.Text)
                QTD = Convert.ToInt32(TextBox10.Text)
                Cubagem = (MedidaA * MedidaC * MedidaL * QTD * 300)
                TextBox14.Text = Cubagem
                Label27.Visible = True
                TextBox14.Visible = True
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Protected Sub LinkButton20_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkButton20.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        TextBox12.Text = ""
        TextBox13.Text = ""
        TextBox14.Text = ""
        TextBox14.Visible = False
        Label27.Visible = False
        ListBox3.Text = "Selecione:"
        Label10.Visible = False
        TextBox7.Visible = False
    End Sub
End Class
