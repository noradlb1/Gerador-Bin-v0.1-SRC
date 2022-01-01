Imports System.IO

Public Class Form1

    Sub New()
        bin = New Char(&H10 - 1) {}
        InitializeComponent()
    End Sub

    Private bin As Char()

    Private Sub btn_Gerar_Click(sender As Object, e As EventArgs) Handles btn_Gerar.Click
        Try
            If ND_BIN.Value < 30 Or ND_BIN.Value = Nothing Then
                Exit Sub
            End If
            ND_BIN.Enabled = False
            ND_Quantidades.Enabled = False
            btn_Gerar.Enabled = False
            Dim num4 As Integer
            Dim ch As Char = ND_BIN.Text.Chars(0)
            Dim ch2 As Char = ND_BIN.Text.Chars(0)
            Dim ch3 As Char = ND_BIN.Text.Chars(0)
            If (((Convert.ToDouble(ch.ToString) = 4) Or (Convert.ToDouble(ch2.ToString) = 5)) Or (Convert.ToDouble(ch3.ToString) = 6)) Then
                num4 = 15
            Else
                ch3 = ND_BIN.Text.Chars(0)
                If (Convert.ToDouble(ch3.ToString) = 3) Then
                    num4 = 14
                End If
            End If
            Dim numArray As Integer() = New Integer((num4 + 1) - 1) {}
            Dim num As Integer = Integer.Parse(ND_Quantidades.Value)
            Dim num2 As Integer = 1
            If (B_Progress.Value = 100) Then
                B_Progress.Value = 0
            End If
            B_Progress.Value = 20
            Dim num21 As Integer = num4
            Dim i As Integer = 0
            Do While (i <= num21)
                bin(i) = "x"c
                i += 1
            Loop
            B_Progress.Value = 30
            Dim num22 As Integer = (ND_BIN.Text.Length - 1)
            Dim j As Integer = 0
            Do While (j <= num22)
                ch3 = ND_BIN.Text.Chars(j)
                bin(j) = Convert.ToChar(ch3.ToString)
                j += 1
            Loop
            If (ND_BIN.Text = "") Then
                B_Progress.Value = 50
                MsgBox("ADICIONE UMA BIN VALIDA", MsgBoxStyle.Critical, "ERROR")
            Else
                ch3 = ND_BIN.Text.Chars(0)
                ch2 = ND_BIN.Text.Chars(0)
                ch = ND_BIN.Text.Chars(0)
                Dim ch4 As Char = ND_BIN.Text.Chars(0)
                If ((((Convert.ToDouble(ch3.ToString) = 4) Or (Convert.ToDouble(ch2.ToString) = 5)) Or (Convert.ToDouble(ch.ToString) = 3)) Or (Convert.ToDouble(ch4.ToString) = 6)) Then
                    B_Progress.Value = 50
                    TXT_INFOCC.Text = ""
                    Do While (num2 <= num)
                        Application.DoEvents() 'EVITAR TRAVAMENTO
                        Dim num23 As Integer = num4
                        Dim k As Integer = 0
                        Do While (k <= num23)
                            If ((Convert.ToString(bin(k)) = "x") Or (Convert.ToString(bin(k)) = "X")) Then
                                VBMath.Randomize()
                                numArray(k) = CInt(Math.Round(CDbl((Conversion.Int(CSng((VBMath.Rnd * 9.0!))) + 0.0!))))
                            Else
                                numArray(k) = Conversion.Val(bin(k))
                            End If
                            k += 1
                        Loop
                        Dim expression As Integer = 0
                        Dim num24 As Integer = num4
                        Dim m As Integer = 0
                        Do While (m <= num24)
                            expression = (expression + numArray(m))
                            m += 1
                        Loop
                        Dim numArray2 As Integer() = New Integer((num4 + 1) - 1) {}
                        If ((Conversion.Val(expression) Mod 10) = numArray(num4)) Then
                            Dim num25 As Integer = num4
                            Dim n As Integer = 0
                            Do While (n <= num25)
                                If ((n Mod 2) = 0) Then
                                    numArray2(n) = (numArray(n) * 2)
                                Else
                                    numArray2(n) = numArray(n)
                                End If
                                n += 1
                            Loop
                            Dim num26 As Integer = num4
                            Dim num12 As Integer = 0
                            Do While (num12 <= num26)
                                If (numArray2(num12) = 10) Then
                                    numArray2(num12) = 1
                                ElseIf (numArray2(num12) = 12) Then
                                    numArray2(num12) = 3
                                ElseIf (numArray2(num12) = 14) Then
                                    numArray2(num12) = 5
                                ElseIf (numArray2(num12) = &H10) Then
                                    numArray2(num12) = 7
                                ElseIf (numArray2(num12) = &H12) Then
                                    numArray2(num12) = 9
                                ElseIf (numArray2(num12) = 20) Then
                                    numArray2(num12) = 2
                                End If
                                num12 += 1
                            Loop
                            If (num2 = 1) Then
                                B_Progress.Value = 80
                            End If
                            Dim num10 As Integer = 0
                            Dim num27 As Integer = num4
                            Dim num13 As Integer = 0
                            Do While (num13 <= num27)
                                num10 = (num10 + numArray2(num13))
                                num13 += 1
                            Loop
                            If ((Conversion.Val(num10) Mod 10) = 0) Then
                                Dim num15 As Integer
                                Dim num14 As Integer = CInt(Math.Round(CDbl((Conversion.Int(CSng((VBMath.Rnd * 880.0!))) + 100.0!))))
                                Dim num16 As Integer = CInt(Math.Round(CDbl((Conversion.Int(CSng((VBMath.Rnd * 11.0!))) + 1.0!))))
                                If (num16 = &H1C) Then
                                    num15 = CInt(Math.Round(CDbl((Conversion.Int(CSng((VBMath.Rnd * 27.0!))) + 1.0!))))
                                Else
                                    num15 = CInt(Math.Round(CDbl((Conversion.Int(CSng((VBMath.Rnd * 29.0!))) + 1.0!))))
                                End If
                                Dim num17 As Integer = CInt(Math.Round(CDbl((Conversion.Int(CSng((VBMath.Rnd * 3.0!))) + 16.0!))))

                                Dim num28 As Integer = num4
                                Dim num18 As Integer = 0
                                Do While (num18 <= num28)
                                    TXT_INFOCC.Text = (TXT_INFOCC.Text & Convert.ToString(numArray(num18)))
                                    num18 += 1
                                Loop

                                If num16 >= 10 Then
                                    If CK_CVV.Checked Then
                                        TXT_INFOCC.Text = String.Concat(New String() {TXT_INFOCC.Text, "|", Convert.ToString(num16), "|20", Convert.ToString(num17), "|", Convert.ToString(num14)})
                                    Else
                                        TXT_INFOCC.Text = String.Concat(New String() {TXT_INFOCC.Text, "|", Convert.ToString(num16), "|20", Convert.ToString(num17)})
                                    End If
                                Else
                                    Dim IY As String = 0 & Convert.ToString(num16)
                                    If CK_CVV.Checked Then
                                        TXT_INFOCC.Text = String.Concat(New String() {TXT_INFOCC.Text, "|", IY, "|20", Convert.ToString(num17), "|", Convert.ToString(num14)})
                                    Else
                                        TXT_INFOCC.Text = String.Concat(New String() {TXT_INFOCC.Text, "|", IY, "|20", Convert.ToString(num17)})
                                    End If

                                End If

                                TXT_INFOCC.Text = (TXT_INFOCC.Text & ChrW(13) & ChrW(10))
                                num2 += 1

                            End If
                        End If
                    Loop

                    B_Progress.Value = 100
                    PictureBox1.Visible = True
                    ch4 = ND_BIN.Text.Chars(0)
                    If (Convert.ToDouble(ch4.ToString) = 4) Then
                        PictureBox1.Image = My.Resources.visa
                    Else
                        ch4 = ND_BIN.Text.Chars(0)
                        If (Convert.ToDouble(ch4.ToString) = 5) Then
                            PictureBox1.Image = My.Resources.mastercard
                        Else
                            ch4 = ND_BIN.Text.Chars(0)
                            If (Convert.ToDouble(ch4.ToString) = 3) Then
                                PictureBox1.Image = My.Resources.amex
                            Else
                                PictureBox1.Visible = False
                            End If
                        End If
                    End If
                Else
                    MsgBox("BIN NÃO EXISTE A NÃO SER {Visa, Mastercard, AmericanXpress, Crédimax}", MsgBoxStyle.Critical, "ERROR")
                End If
            End If

            ND_BIN.Enabled = True
            ND_Quantidades.Enabled = True
            btn_Gerar.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SalvarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalvarToolStripMenuItem.Click
        If TXT_INFOCC.Text = Nothing Then
            Exit Sub
        End If
        Dim I As New SaveFileDialog
        I.Title = "SALVA BIN"
        I.Filter = "ARQUIVOS TXT (*.txt)|*.txt|TODOS ARQUIVOS (*.*)|*.*"
        If I.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim U As New StreamWriter(I.FileName)
            U.Write(TXT_INFOCC.Text)
            U.Close()
            MsgBox(I.FileName, MsgBoxStyle.Information, "Informações")
        End If
    End Sub

End Class
