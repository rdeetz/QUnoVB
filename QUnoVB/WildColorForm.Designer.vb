<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WildColorForm
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
        Me.buttonOk = New System.Windows.Forms.Button()
        Me.buttonCancel = New System.Windows.Forms.Button()
        Me.listColors = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'buttonOk
        '
        Me.buttonOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonOk.Location = New System.Drawing.Point(206, 194)
        Me.buttonOk.Name = "buttonOk"
        Me.buttonOk.Size = New System.Drawing.Size(75, 23)
        Me.buttonOk.TabIndex = 1
        Me.buttonOk.Text = "OK"
        Me.buttonOk.UseVisualStyleBackColor = True
        '
        'buttonCancel
        '
        Me.buttonCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.buttonCancel.Location = New System.Drawing.Point(287, 194)
        Me.buttonCancel.Name = "buttonCancel"
        Me.buttonCancel.Size = New System.Drawing.Size(75, 23)
        Me.buttonCancel.TabIndex = 2
        Me.buttonCancel.Text = "Cancel"
        Me.buttonCancel.UseVisualStyleBackColor = True
        '
        'listColors
        '
        Me.listColors.FormattingEnabled = True
        Me.listColors.ItemHeight = 32
        Me.listColors.Items.AddRange(New Object() {"Red", "Blue", "Yellow", "Green"})
        Me.listColors.Location = New System.Drawing.Point(12, 12)
        Me.listColors.Name = "listColors"
        Me.listColors.Size = New System.Drawing.Size(350, 164)
        Me.listColors.TabIndex = 0
        '
        'WildColorForm
        '
        Me.AcceptButton = Me.buttonOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.buttonCancel
        Me.ClientSize = New System.Drawing.Size(374, 229)
        Me.Controls.Add(Me.listColors)
        Me.Controls.Add(Me.buttonOk)
        Me.Controls.Add(Me.buttonCancel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "WildColorForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Choose Wild Color"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents buttonOk As Button
    Friend WithEvents buttonCancel As Button
    Friend WithEvents listColors As ListBox
End Class
