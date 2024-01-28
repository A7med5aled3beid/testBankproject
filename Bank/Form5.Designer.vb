<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.AxDataGrid1 = New AxMSDataGridLib.AxDataGrid()
        CType(Me.AxDataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxDataGrid1
        '
        Me.AxDataGrid1.DataSource = Nothing
        Me.AxDataGrid1.Location = New System.Drawing.Point(12, 12)
        Me.AxDataGrid1.Name = "AxDataGrid1"
        Me.AxDataGrid1.OcxState = CType(resources.GetObject("AxDataGrid1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxDataGrid1.Size = New System.Drawing.Size(1005, 421)
        Me.AxDataGrid1.TabIndex = 0
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1027, 445)
        Me.Controls.Add(Me.AxDataGrid1)
        Me.Name = "Form5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "All Customers"
        CType(Me.AxDataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AxDataGrid1 As AxMSDataGridLib.AxDataGrid
End Class
