Public Class FrmBingo
    Dim Num As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnLanzB.Click

        Num = Int((75 * Rnd()) + 1)
        LblNumB.Text = Num
        If Num <= 15 Then
            LblLetra.Text = "B"
        ElseIf Num <= 30 Then
            LblLetra.Text = "I"
        ElseIf Num <= 45 Then
            LblLetra.Text = "N"
        ElseIf Num <= 60 Then
            LblLetra.Text = "G"
        ElseIf Num <= 75 Then
            LblLetra.Text = "O"
        End If
        LstBNum.Items.Add(LblLetra.Text & LblNumB.Text)

        If LblNumB.Text = BtnNum1.Text Then
            BtnNum1.BackColor = Color.Red
            BtnNum1.Font = New Font(BtnNum1.Font.Name, 16)
        End If
        If LblNumB.Text = BtnNum2.Text Then
            BtnNum2.BackColor = Color.Red
            BtnNum2.Font = New Font(BtnNum2.Font.Name, 16)
        End If
        If LblNumB.Text = BtnNum3.Text Then
            BtnNum3.BackColor = Color.Red
            BtnNum3.Font = New Font(BtnNum3.Font.Name, 16)
        End If
        If LblNumB.Text = BtnNum4.Text Then
            BtnNum4.BackColor = Color.Red
            BtnNum4.Font = New Font(BtnNum4.Font.Name, 16)
        End If
        If LblNumB.Text = BtnNum5.Text Then
            BtnNum5.BackColor = Color.Red
            BtnNum5.Font = New Font(BtnNum5.Font.Name, 16)
        End If
        If LblNumB.Text = BtnNum6.Text Then
            BtnNum6.BackColor = Color.Red
            BtnNum6.Font = New Font(BtnNum6.Font.Name, 16)
        End If
        If LblNumB.Text = BtnNum7.Text Then
            BtnNum7.BackColor = Color.Red
            BtnNum7.Font = New Font(BtnNum7.Font.Name, 16)
        End If
        If LblNumB.Text = BtnNum8.Text Then
            BtnNum8.BackColor = Color.Red
            BtnNum8.Font = New Font(BtnNum8.Font.Name, 16)
        End If
        If LblNumB.Text = BtnNum9.Text Then
            BtnNum9.BackColor = Color.Red
            BtnNum9.Font = New Font(BtnNum9.Font.Name, 16)
        End If
        If LblNumB.Text = BtnNum10.Text Then
            BtnNum10.BackColor = Color.Red
            BtnNum10.Font = New Font(BtnNum10.Font.Name, 16)
        End If
        If LblNumB.Text = BtnNum11.Text Then
            BtnNum11.BackColor = Color.Red
            BtnNum11.Font = New Font(BtnNum11.Font.Name, 16)
        End If
        If LblNumB.Text = BtnNum12.Text Then
            BtnNum12.BackColor = Color.Red
            BtnNum12.Font = New Font(BtnNum12.Font.Name, 16)
        End If
        If LblNumB.Text = BtnNum13.Text Then
            BtnNum13.BackColor = Color.Red
            BtnNum13.Font = New Font(BtnNum13.Font.Name, 16)
        End If
        If LblNumB.Text = BtnNum14.Text Then
            BtnNum14.BackColor = Color.Red
            BtnNum14.Font = New Font(BtnNum14.Font.Name, 16)
        End If
        If LblNumB.Text = BtnNum15.Text Then
            BtnNum15.BackColor = Color.Red
            BtnNum15.Font = New Font(BtnNum15.Font.Name, 16)
        End If
        If LblNumB.Text = BtnNum16.Text Then
            BtnNum16.BackColor = Color.Cyan
            BtnNum16.Font = New Font(BtnNum16.Font.Name, 16)
        End If
        If LblNumB.Text = BtnNum17.Text Then
            BtnNum17.BackColor = Color.Cyan
            BtnNum17.Font = New Font(BtnNum17.Font.Name, 16)
        End If
        If LblNumB.Text = BtnNum18.Text Then
            BtnNum18.BackColor = Color.Cyan
            BtnNum18.Font = New Font(BtnNum18.Font.Name, 16)
        End If
        If LblNumB.Text = BtnNum19.Text Then
            BtnNum19.BackColor = Color.Cyan
            BtnNum19.Font = New Font(BtnNum19.Font.Name, 16)
        End If
        If LblNumB.Text = BtnNum20.Text Then
            BtnNum20.BackColor = Color.Cyan
            BtnNum20.Font = New Font(BtnNum20.Font.Name, 16)
        End If
        If LblNumB.Text = BtnNum21.Text Then
            BtnNum21.BackColor = Color.Cyan
            BtnNum21.Font = New Font(BtnNum21.Font.Name, 16)
        End If
        If LblNumB.Text = BtnNum22.Text Then
            BtnNum22.BackColor = Color.Cyan
            BtnNum22.Font = New Font(BtnNum22.Font.Name, 16)
        End If
        If LblNumB.Text = BtnNum23.Text Then
            BtnNum23.BackColor = Color.Cyan
            BtnNum23.Font = New Font(BtnNum23.Font.Name, 16)
        End If
        If LblNumB.Text = BtnNum24.Text Then
            BtnNum24.BackColor = Color.Cyan
            BtnNum24.Font = New Font(BtnNum24.Font.Name, 16)
        End If
        If LblNumB.Text = BtnNum25.Text Then
            BtnNum25.BackColor = Color.Cyan
            BtnNum25.Font = New Font(BtnNum25.Font.Name, 16)
        End If
        If LblNumB.Text = BtnNum26.Text Then
            BtnNum26.BackColor = Color.Cyan
            BtnNum26.Font = New Font(BtnNum26.Font.Name, 16)
        End If
        If LblNumB.Text = BtnNum27.Text Then
            BtnNum27.BackColor = Color.Cyan
            BtnNum27.Font = New Font(BtnNum27.Font.Name, 16)
        End If
        If LblNumB.Text = BtnNum28.Text Then
            BtnNum28.BackColor = Color.Cyan
            BtnNum28.Font = New Font(BtnNum28.Font.Name, 16)
        End If
        If LblNumB.Text = BtnNum29.Text Then
            BtnNum29.BackColor = Color.Cyan
            BtnNum29.Font = New Font(BtnNum29.Font.Name, 16)
        End If
        If LblNumB.Text = BtnNum30.Text Then
            BtnNum30.BackColor = Color.Cyan
            BtnNum30.Font = New Font(BtnNum30.Font.Name, 16)
        End If
        If LblNumB.Text = BtnNum31.Text Then
            BtnNum31.BackColor = Color.Green
            BtnNum31.Font = New Font(BtnNum31.Font.Name, 16)
        End If
        If LblNumB.Text = BtnNum32.Text Then
            BtnNum32.BackColor = Color.Green
            BtnNum32.Font = New Font(BtnNum32.Font.Name, 16)
        End If
        If LblNumB.Text = BtnNum33.Text Then
            BtnNum33.BackColor = Color.Green
            BtnNum33.Font = New Font(BtnNum33.Font.Name, 16)
        End If
        If LblNumB.Text = BtnNum34.Text Then
            BtnNum34.BackColor = Color.Green
            BtnNum34.Font = New Font(BtnNum34.Font.Name, 16)
        End If
        If LblNumB.Text = BtnNum35.Text Then
            BtnNum35.BackColor = Color.Green
            BtnNum35.Font = New Font(BtnNum35.Font.Name, 16)
        End If
        If LblNumB.Text = BtnNum36.Text Then
            BtnNum36.BackColor = Color.Green
            BtnNum36.Font = New Font(BtnNum36.Font.Name, 16)
        End If
        If LblNumB.Text = BtnNum37.Text Then
            BtnNum37.BackColor = Color.Green
            BtnNum37.Font = New Font(BtnNum37.Font.Name, 16)
        End If
        If LblNumB.Text = BtnNum38.Text Then
            BtnNum38.BackColor = Color.Green
            BtnNum38.Font = New Font(BtnNum38.Font.Name, 16)
        End If
        If LblNumB.Text = BtnNum39.Text Then
            BtnNum39.BackColor = Color.Green
            BtnNum39.Font = New Font(BtnNum39.Font.Name, 16)
        End If
        If LblNumB.Text = BtnNum40.Text Then
            BtnNum40.BackColor = Color.Green
            BtnNum40.Font = New Font(BtnNum40.Font.Name, 16)
        End If
        If LblNumB.Text = BtnNum41.Text Then
            BtnNum41.BackColor = Color.Green
            BtnNum41.Font = New Font(BtnNum41.Font.Name, 16)
        End If
        If LblNumB.Text = BtnNum42.Text Then
            BtnNum42.BackColor = Color.Green
            BtnNum42.Font = New Font(BtnNum42.Font.Name, 16)
        End If
        If LblNumB.Text = BtnNum43.Text Then
            BtnNum43.BackColor = Color.Green
            BtnNum43.Font = New Font(BtnNum43.Font.Name, 16)
        End If
        If LblNumB.Text = BtnNum44.Text Then
            BtnNum44.BackColor = Color.Green
            BtnNum44.Font = New Font(BtnNum44.Font.Name, 16)
        End If
        If LblNumB.Text = BtnNum45.Text Then
            BtnNum45.BackColor = Color.Green
            BtnNum45.Font = New Font(BtnNum45.Font.Name, 16)
        End If
        If LblNumB.Text = BtnNum46.Text Then
            BtnNum46.BackColor = Color.OrangeRed
            BtnNum46.Font = New Font(BtnNum46.Font.Name, 16)
        End If
        If LblNumB.Text = BtnNum47.Text Then
            BtnNum47.BackColor = Color.OrangeRed
            BtnNum47.Font = New Font(BtnNum47.Font.Name, 16)
        End If
        If LblNumB.Text = BtnNum48.Text Then
            BtnNum48.BackColor = Color.OrangeRed
            BtnNum48.Font = New Font(BtnNum48.Font.Name, 16)
        End If
        If LblNumB.Text = BtnNum49.Text Then
            BtnNum49.BackColor = Color.OrangeRed
            BtnNum49.Font = New Font(BtnNum49.Font.Name, 16)
        End If
        If LblNumB.Text = BtnNum50.Text Then
            BtnNum50.BackColor = Color.OrangeRed
            BtnNum50.Font = New Font(BtnNum50.Font.Name, 16)
        End If
        If LblNumB.Text = BtnNum51.Text Then
            BtnNum51.BackColor = Color.OrangeRed
            BtnNum51.Font = New Font(BtnNum51.Font.Name, 16)
        End If
        If LblNumB.Text = BtnNum52.Text Then
            BtnNum52.BackColor = Color.OrangeRed
            BtnNum52.Font = New Font(BtnNum52.Font.Name, 16)
        End If
        If LblNumB.Text = BtnNum53.Text Then
            BtnNum53.BackColor = Color.OrangeRed
            BtnNum53.Font = New Font(BtnNum53.Font.Name, 16)
        End If
        If LblNumB.Text = BtnNum54.Text Then
            BtnNum54.BackColor = Color.OrangeRed
            BtnNum54.Font = New Font(BtnNum54.Font.Name, 16)
        End If
        If LblNumB.Text = BtnNum55.Text Then
            BtnNum55.BackColor = Color.OrangeRed
            BtnNum55.Font = New Font(BtnNum55.Font.Name, 16)
        End If
        If LblNumB.Text = BtnNum56.Text Then
            BtnNum56.BackColor = Color.OrangeRed
            BtnNum56.Font = New Font(BtnNum56.Font.Name, 16)
        End If
        If LblNumB.Text = BtnNum57.Text Then
            BtnNum57.BackColor = Color.OrangeRed
            BtnNum57.Font = New Font(BtnNum57.Font.Name, 16)
        End If
        If LblNumB.Text = BtnNum58.Text Then
            BtnNum58.BackColor = Color.OrangeRed
            BtnNum58.Font = New Font(BtnNum58.Font.Name, 16)
        End If
        If LblNumB.Text = BtnNum59.Text Then
            BtnNum59.BackColor = Color.OrangeRed
            BtnNum59.Font = New Font(BtnNum59.Font.Name, 16)
        End If
        If LblNumB.Text = BtnNum60.Text Then
            BtnNum60.BackColor = Color.OrangeRed
            BtnNum60.Font = New Font(BtnNum60.Font.Name, 16)
        End If
        If LblNumB.Text = BtnNum61.Text Then
            BtnNum61.BackColor = Color.MediumPurple
            BtnNum61.Font = New Font(BtnNum61.Font.Name, 16)
        End If
        If LblNumB.Text = BtnNum62.Text Then
            BtnNum62.BackColor = Color.MediumPurple
            BtnNum62.Font = New Font(BtnNum62.Font.Name, 16)
        End If
        If LblNumB.Text = BtnNum63.Text Then
            BtnNum63.BackColor = Color.MediumPurple
            BtnNum63.Font = New Font(BtnNum63.Font.Name, 16)
        End If
        If LblNumB.Text = BtnNum64.Text Then
            BtnNum64.BackColor = Color.MediumPurple
            BtnNum64.Font = New Font(BtnNum64.Font.Name, 16)
        End If
        If LblNumB.Text = BtnNum65.Text Then
            BtnNum65.BackColor = Color.MediumPurple
            BtnNum65.Font = New Font(BtnNum65.Font.Name, 16)
        End If
        If LblNumB.Text = BtnNum66.Text Then
            BtnNum66.BackColor = Color.MediumPurple
            BtnNum66.Font = New Font(BtnNum66.Font.Name, 16)
        End If
        If LblNumB.Text = BtnNum67.Text Then
            BtnNum67.BackColor = Color.MediumPurple
            BtnNum67.Font = New Font(BtnNum67.Font.Name, 16)
        End If
        If LblNumB.Text = BtnNum68.Text Then
            BtnNum68.BackColor = Color.MediumPurple
            BtnNum68.Font = New Font(BtnNum68.Font.Name, 16)
        End If
        If LblNumB.Text = BtnNum69.Text Then
            BtnNum69.BackColor = Color.MediumPurple
            BtnNum69.Font = New Font(BtnNum69.Font.Name, 16)
        End If
        If LblNumB.Text = BtnNum70.Text Then
            BtnNum70.BackColor = Color.MediumPurple
            BtnNum70.Font = New Font(BtnNum70.Font.Name, 16)
        End If
        If LblNumB.Text = BtnNum71.Text Then
            BtnNum71.BackColor = Color.MediumPurple
            BtnNum71.Font = New Font(BtnNum71.Font.Name, 16)
        End If
        If LblNumB.Text = BtnNum72.Text Then
            BtnNum72.BackColor = Color.MediumPurple
            BtnNum72.Font = New Font(BtnNum72.Font.Name, 16)
        End If
        If LblNumB.Text = BtnNum73.Text Then
            BtnNum73.BackColor = Color.MediumPurple
            BtnNum73.Font = New Font(BtnNum73.Font.Name, 16)
        End If
        If LblNumB.Text = BtnNum74.Text Then
            BtnNum74.BackColor = Color.MediumPurple
            BtnNum74.Font = New Font(BtnNum74.Font.Name, 16)
        End If
        If LblNumB.Text = BtnNum75.Text Then
            BtnNum75.BackColor = Color.MediumPurple
            BtnNum75.Font = New Font(BtnNum75.Font.Name, 16)
        End If


    End Sub

    Private Sub FrmBingo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
    End Sub

    Private Sub LstBNum_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstBNum.SelectedIndexChanged

    End Sub
End Class
