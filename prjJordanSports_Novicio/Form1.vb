Public Class Form1
    Private Sub BtnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim wholesalary As Decimal = Val(txtYs.Text)
        Dim weeksalary As Decimal = wholesalary / 52
        Dim biweeklysalary As Decimal = wholesalary / 26
        txtW.Text = FormatCurrency(weeksalary, 2)
        txtBw.Text = FormatCurrency(biweeklysalary, 2)


    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtBw.Clear()
        txtW.Clear()
        txtYs.Clear()
        txtYs.Focus()
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        btnCalc.Hide()
        btnClear.Hide()
        btnPrint.Hide()
        PrintForm1.Print()
        btnCalc.Show()
        btnClear.Show()
        btnPrint.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub lblWeekly_Click(sender As Object, e As EventArgs) Handles lblWeekly.Click

    End Sub

    Private Sub lblBw_Click(sender As Object, e As EventArgs) Handles lblBw.Click

    End Sub

    Private Sub txtYs_TextChanged(sender As Object, e As EventArgs) Handles txtYs.TextChanged

    End Sub

    Private Sub txtBw_TextChanged(sender As Object, e As EventArgs) Handles txtBw.TextChanged

    End Sub

    Private Sub txtW_TextChanged(sender As Object, e As EventArgs) Handles txtW.TextChanged

    End Sub

    Private Sub lblYs_Click(sender As Object, e As EventArgs) Handles lblYs.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
