Module Module1

    Public Sub fundotextbox(ByRef tela As Control)
        '(Tipo Object porque iremos trabalhar com todos oscampos do Form, podendo ser
        '       Label,Button, TextBox, ComboBox e outros)
        '       Masqueremos apenas do tipo TextBox
        Dim Objeto As Control
        'Usaremos For Each para passarmos por todos oscontrols do objeto atual
        For Each Objeto In tela.Controls
            'Verifica se o Campo é um GroupBox, TabPage ou Panel
            'Se for então precisa fazer a função para os campos que estão dentro dele também...
            'Chamaremos novamente a função mas passando por referencia
            '      OGroupBox, TabPage ou Panel atual
            If TypeOf Objeto Is System.Windows.Forms.GroupBox Or
                    TypeOf Objeto Is System.Windows.Forms.TabPage Or
                    TypeOf Objeto Is System.Windows.Forms.Panel Then
                fundotextbox(Objeto)
            End If
            'Se for uma TextBox então adicionaremos a função de GotFocus (para alterar a cor)
            '    e LostFocus (para voltar a cor normal)
            If TypeOf Objeto Is System.Windows.Forms.TextBox Then
                ' Se a cor de fundo estiver branco (padrão da textbox) ' Or TypeOf Objeto Is System.Windows.Forms.MaskedTextBox
                '   Pois podemos definir uma outra cor de fundo para uma textbox e
                '   não vamosfazer o efeito nessa textbox
                If Objeto.BackColor.ToArgb = -1 Or Objeto.BackColor = Color.White Then
                    'Vamos incluir 2 eventos, o GotFocus(quando receber o focus então mudade cor)
                    '   e o lostfocus (quando perder o focus então voltar ao normal)
                    AddHandler Objeto.GotFocus, AddressOf Text_GotFocus
                    AddHandler Objeto.LostFocus, AddressOf Text_LostFocus
                End If

                'ElseIf TypeOf Objeto Is System.Windows.Forms.MaskedTextBox Then
                '    ' Se a cor de fundo estiver branco (padrão da textbox)
                '    '   Pois podemos definir uma outra cor de fundo para uma textbox e
                '    '   não vamos fazer o efeito nessa textbox
                '    If Objeto.BackColor.ToArgb = -1 Or Objeto.BackColor = Color.White Then
                '        'Vamos incluir 2 eventos, o GotFocus(quando receber o focus então muda de cor)
                '        '   e olostfocus (quando perder o focus então voltar ao normal)
                '        AddHandler Objeto.GotFocus, AddressOf Text_GotFocus
                '        AddHandler Objeto.LostFocus, AddressOf Text_LostFocus
                '    End If
            End If
        Next
    End Sub
    Public Sub Text_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        'If TypeOf Objeto Is System.Windows.Forms.TextBox Then
        Dim Text As TextBox = sender
        Text.BackColor = Color.Lime
        'ElseIf TypeOf Objeto Is System.Windows.Forms.MaskedTextBox Then
        '    Dim Text As MaskedTextBox = sender
        '    Text.BackColor = Color.Lime
        'End If
    End Sub
    Public Sub Text_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        'If TypeOf Objeto Is System.Windows.Forms.TextBox Then
        Dim Text As TextBox = sender
        Text.BackColor = Color.White
        'ElseIf TypeOf Objeto Is System.Windows.Forms.MaskedTextBox Then
        'Dim Text As MaskedTextBox = sender
        'Text.BackColor = Color.White
        'End If
    End Sub
End Module
