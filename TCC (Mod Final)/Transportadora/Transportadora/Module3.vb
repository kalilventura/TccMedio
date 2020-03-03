Module Module3
    Function FU_ValidaCPF(CPF As String) As Integer
        '
        Dim soma As Integer
        Dim Resto As Integer
        Dim i As Integer
        CPF = Replace(CPF, ".", "")
        CPF = Replace(CPF, "-", "")
        CPF = Replace(CPF, "/", "")
        'Valida argumento
        If Len(CPF) <> 11 Then
            FU_ValidaCPF = False
            Exit Function
        End If
        soma = 0
        For i = 1 To 9
            soma = soma + Val(Mid$(CPF, i, 1)) * (11 - i)
        Next i
        Resto = 11 - (soma - (Int(soma / 11) * 11))
        If Resto = 10 Or Resto = 11 Then Resto = 0
        If Resto <> Val(Mid$(CPF, 10, 1)) Then
            FU_ValidaCPF = False
            Exit Function
        End If
        soma = 0
        For i = 1 To 10
            soma = soma + Val(Mid$(CPF, i, 1)) * (12 - i)
        Next i
        Resto = 11 - (soma - (Int(soma / 11) * 11))
        If Resto = 10 Or Resto = 11 Then Resto = 0
        If Resto <> Val(Mid$(CPF, 11, 1)) Then
            FU_ValidaCPF = False
            Exit Function
        End If
        FU_ValidaCPF = True
    End Function

    Function ValidaCNPJ(ByVal CGC As String) As Boolean
        Dim RecebeCNPJ, Numero(14), soma, resultado1, resultado2
        RecebeCNPJ = CGC
        If Len(RecebeCNPJ) <> 14 Then
            ValidaCNPJ = False
        ElseIf RecebeCNPJ = "00000000000000" Then
            ValidaCNPJ = False
        ElseIf RecebeCNPJ = "11111111111111" Then
            ValidaCNPJ = False
        ElseIf RecebeCNPJ = "22222222222222" Then
            ValidaCNPJ = False
        ElseIf RecebeCNPJ = "33333333333333" Then
            ValidaCNPJ = False
        ElseIf RecebeCNPJ = "44444444444444" Then
            ValidaCNPJ = False
        ElseIf RecebeCNPJ = "55555555555555" Then
            ValidaCNPJ = False
        ElseIf RecebeCNPJ = "66666666666666" Then
            ValidaCNPJ = False
        ElseIf RecebeCNPJ = "77777777777777" Then
            ValidaCNPJ = False
        ElseIf RecebeCNPJ = "88888888888888" Then
            ValidaCNPJ = False
        ElseIf RecebeCNPJ = "99999999999999" Then
            ValidaCNPJ = False
        Else
            Numero(1) = CInt(Mid(RecebeCNPJ, 1, 1))
            Numero(2) = CInt(Mid(RecebeCNPJ, 2, 1))
            Numero(3) = CInt(Mid(RecebeCNPJ, 3, 1))
            Numero(4) = CInt(Mid(RecebeCNPJ, 4, 1))
            Numero(5) = CInt(Mid(RecebeCNPJ, 5, 1))
            Numero(6) = CInt(Mid(RecebeCNPJ, 6, 1))
            Numero(7) = CInt(Mid(RecebeCNPJ, 7, 1))
            Numero(8) = CInt(Mid(RecebeCNPJ, 8, 1))
            Numero(9) = CInt(Mid(RecebeCNPJ, 9, 1))
            Numero(10) = CInt(Mid(RecebeCNPJ, 10, 1))
            Numero(11) = CInt(Mid(RecebeCNPJ, 11, 1))
            Numero(12) = CInt(Mid(RecebeCNPJ, 12, 1))
            Numero(13) = CInt(Mid(RecebeCNPJ, 13, 1))
            Numero(14) = CInt(Mid(RecebeCNPJ, 14, 1))
            soma = Numero(1) * 5 + Numero(2) * 4 + Numero(3) * 3 + Numero(4) * 2 + Numero(5) * 9 + Numero(6) * 8 + Numero(7) * 7 + Numero(8) * 6 + Numero(9) * 5 + Numero(10) * 4 + Numero(11) * 3 + Numero(12) * 2
            soma = soma - (11 * (Int(soma / 11)))
            If soma = 0 Or soma = 1 Then
                resultado1 = 0
            Else
                resultado1 = 11 - soma
            End If
            If resultado1 = Numero(13) Then
                soma = Numero(1) * 6 + Numero(2) * 5 + Numero(3) * 4 + Numero(4) * 3 + Numero(5) * 2 + Numero(6) * 9 + Numero(7) * 8 + Numero(8) * 7 + Numero(9) * 6 + Numero(10) * 5 + Numero(11) * 4 + Numero(12) * 3 + Numero(13) * 2
                soma = soma - (11 * (Int(soma / 11)))
                If soma = 0 Or soma = 1 Then
                    resultado2 = 0
                Else
                    resultado2 = 11 - soma
                End If
                If resultado2 = Numero(14) Then
                    ValidaCNPJ = True
                Else
                    ValidaCNPJ = False
                End If
            Else
                ValidaCNPJ = False
            End If
        End If
    End Function

    'Public Function CalculaCGC(Numero As String) As String

    '    Dim I As Integer
    '    Dim prod As Integer
    '    Dim mult As Integer
    '    Dim digito As Integer

    '    If Not IsNumeric(Numero) Then
    '        CalculaCGC = ""
    '        Exit Function
    '    End If

    '    mult = 2
    '    For I = Len(Numero) To 1 Step -1
    '        prod = prod + Val(Mid(Numero, I, 1)) * mult
    '        mult = IIf(mult = 9, 2, mult + 1)
    '    Next

    '    digito = 11 - Int(prod Mod 11)
    '    digito = IIf(digito = 10 Or digito = 11, 0, digito)

    '    CalculaCGC = Trim(Str(digito))

    'End Function
    'Public Function ValidaCGC(CGC As String) As Boolean
    '    If CalculaCGC(Left(CGC, 12)) <> Mid(CGC, 13, 1) Then
    '        ValidaCGC = False
    '        Exit Function
    '    End If

    '    If CalculaCGC(Left(CGC, 13)) <> Mid(CGC, 14, 1) Then
    '        ValidaCGC = False
    '        Exit Function
    '    End If

    '    ValidaCGC = True

    'End Function

End Module
