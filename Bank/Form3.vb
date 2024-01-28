Public Class Form3

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = h.name
        TextBox2.Text = h.AccNo
        TextBox3.Text = Now

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        d.AccNo = TextBox2.Text
        d.Date = TextBox3.Text
        d.Branch = TextBox4.Text
        d.OrderNo = TextBox5.Text
        d.Amount = TextBox6.Text
        d.Notes = TextBox7.Text
        d.By = TextBox8.Text

        d.AddNewDiposits()
        MsgBox("تمت عميلة الايداع بنجاح", MsgBoxStyle.Information, "ايداع")

        For Each t As Control In GroupBox2.Controls
            If TypeOf t Is TextBox Then t.Text = ""
        Next
        Me.Close()

    End Sub
End Class