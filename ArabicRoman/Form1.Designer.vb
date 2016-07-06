<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ArabicRoman
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxValue = New System.Windows.Forms.TextBox()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonRetrieveArabic = New System.Windows.Forms.Button()
        Me.ButtonRoman = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(89, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Value"
        '
        'TextBoxValue
        '
        Me.TextBoxValue.Location = New System.Drawing.Point(78, 57)
        Me.TextBoxValue.Name = "TextBoxValue"
        Me.TextBoxValue.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxValue.TabIndex = 1
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(184, 49)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(75, 35)
        Me.ButtonSave.TabIndex = 2
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'ButtonRetrieveArabic
        '
        Me.ButtonRetrieveArabic.Location = New System.Drawing.Point(78, 106)
        Me.ButtonRetrieveArabic.Name = "ButtonRetrieveArabic"
        Me.ButtonRetrieveArabic.Size = New System.Drawing.Size(64, 35)
        Me.ButtonRetrieveArabic.TabIndex = 3
        Me.ButtonRetrieveArabic.Text = "Retrieve Arabic"
        Me.ButtonRetrieveArabic.UseVisualStyleBackColor = True
        Me.ButtonRetrieveArabic.Visible = False
        '
        'ButtonRoman
        '
        Me.ButtonRoman.Location = New System.Drawing.Point(164, 106)
        Me.ButtonRoman.Name = "ButtonRoman"
        Me.ButtonRoman.Size = New System.Drawing.Size(75, 35)
        Me.ButtonRoman.TabIndex = 5
        Me.ButtonRoman.Text = "Retrieve Roman"
        Me.ButtonRoman.UseVisualStyleBackColor = True
        Me.ButtonRoman.Visible = False
        '
        'ArabicRoman
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.ButtonRoman)
        Me.Controls.Add(Me.ButtonRetrieveArabic)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.TextBoxValue)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ArabicRoman"
        Me.Text = "Convert"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxValue As System.Windows.Forms.TextBox
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents ButtonRetrieveArabic As System.Windows.Forms.Button
    Friend WithEvents ButtonRoman As System.Windows.Forms.Button

End Class
