
Public Class Form2

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        If h.name = "" Then
            MsgBox("يجب استدعاء بيانات العميل", MsgBoxStyle.Critical, "ايقاف")
            Exit Sub
        End If
        Form3.ShowDialog()

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If h.name = "" Then
            MsgBox("يجب استدعاء بيانات العميل", MsgBoxStyle.Critical, "ايقاف")
            Exit Sub
        End If
        Form4.ShowDialog()

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If h.find(TextBox12.Text, ComboBox1.SelectedIndex) = False Then
            MsgBox("Customer Not Found", MsgBoxStyle.Critical, "Search")
            Exit Sub
        End If


        TextBox1.Text = h.name
        TextBox2.Text = h.AccNo
        TextBox3.Text = h.IDNo
        TextBox4.Text = h.branch
        TextBox5.Text = h.phone
        TextBox6.Text = h.mobile
        TextBox7.Text = h.Email
        TextBox8.Text = h.address
       
        TextBox9.Text = h.sDiposits
        TextBox10.Text = h.sWithdrawals
        TextBox11.Text = h.Balance
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Form5.ShowDialog()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        h.name = TextBox1.Text
        h.AccNo = TextBox2.Text
        h.IDNo = TextBox3.Text
        h.branch = TextBox4.Text
        h.phone = TextBox5.Text
        h.mobile = TextBox6.Text
        h.Email = TextBox7.Text
        h.address = TextBox8.Text
        h.AddNewCustomer()
        MsgBox("تم الحفظ", MsgBoxStyle.Information, "اضافة")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        h.name = TextBox1.Text
        h.AccNo = TextBox2.Text
        h.IDNo = TextBox3.Text
        h.branch = TextBox4.Text
        h.phone = TextBox5.Text
        h.mobile = TextBox6.Text
        h.Email = TextBox7.Text
        h.address = TextBox8.Text
        h.UpdateCustomer()
        MsgBox("تم التحديث ", MsgBoxStyle.Information, "تحديث")
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Form5.ShowDialog()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        For Each t As Control In Me.GroupBox1.Controls
            If TypeOf t Is TextBox Then t.Text = ""
        Next
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Then Exit Sub

        h.DeleteCustomer(TextBox1.Text)
        MsgBox("تم الحذف", MsgBoxStyle.Information, "حذف")

        For Each t As Control In Me.GroupBox1.Controls
            If TypeOf t Is TextBox Then t.Text = ""
        Next

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        End

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class