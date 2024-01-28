Public Class Form5

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AxDataGrid1.DataSource = h.AllCustomers

    End Sub
End Class