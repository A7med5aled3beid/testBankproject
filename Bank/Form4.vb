Public Class Form4

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = h.AccNo
        TextBox3.Text = Now

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        w.AccNo = TextBox1.Text
        w.CheckNo = TextBox2.Text
        w.Date = TextBox3.Text
        w.Branch = TextBox4.Text
        w.OrderNo = TextBox5.Text
        w.Amount = TextBox6.Text
        w.Notes = TextBox7.Text
        w.By = TextBox8.Text

        w.AddNewWithdrawals()
        MsgBox("تمت عميلة السحب بنجاح", MsgBoxStyle.Information, "سحب")

        For Each t As Control In GroupBox2.Controls
            If TypeOf t Is TextBox Then t.Text = ""
        Next
        Me.Close()
    End Sub
End Class