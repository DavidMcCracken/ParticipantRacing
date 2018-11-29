<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.QueryRadioButton1 = New System.Windows.Forms.RadioButton()
        Me.QueryRadioButton2 = New System.Windows.Forms.RadioButton()
        Me.ViewButton = New System.Windows.Forms.Button()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(466, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome to our Database Viewer Select an option to view below"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Cursor = System.Windows.Forms.Cursors.Default
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(15, 56)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(153, 17)
        Me.RadioButton1.TabIndex = 1
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "View Participant Table"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(15, 79)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(122, 17)
        Me.RadioButton2.TabIndex = 2
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "View Race Table"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'QueryRadioButton1
        '
        Me.QueryRadioButton1.AutoSize = True
        Me.QueryRadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QueryRadioButton1.Location = New System.Drawing.Point(15, 102)
        Me.QueryRadioButton1.Name = "QueryRadioButton1"
        Me.QueryRadioButton1.Size = New System.Drawing.Size(174, 17)
        Me.QueryRadioButton1.TabIndex = 4
        Me.QueryRadioButton1.TabStop = True
        Me.QueryRadioButton1.Text = "View Elite Runtimes Query"
        Me.QueryRadioButton1.UseVisualStyleBackColor = True
        '
        'QueryRadioButton2
        '
        Me.QueryRadioButton2.AutoSize = True
        Me.QueryRadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QueryRadioButton2.Location = New System.Drawing.Point(15, 125)
        Me.QueryRadioButton2.Name = "QueryRadioButton2"
        Me.QueryRadioButton2.Size = New System.Drawing.Size(204, 17)
        Me.QueryRadioButton2.TabIndex = 5
        Me.QueryRadioButton2.TabStop = True
        Me.QueryRadioButton2.Text = "VIew Groups By PR Time Query"
        Me.QueryRadioButton2.UseVisualStyleBackColor = True
        '
        'ViewButton
        '
        Me.ViewButton.Location = New System.Drawing.Point(15, 171)
        Me.ViewButton.Name = "ViewButton"
        Me.ViewButton.Size = New System.Drawing.Size(179, 23)
        Me.ViewButton.TabIndex = 12
        Me.ViewButton.Text = "Next"
        Me.ViewButton.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.Location = New System.Drawing.Point(15, 148)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(108, 17)
        Me.RadioButton3.TabIndex = 13
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Update Tables"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.IEE506_HW4_RACE_FORMS.My.Resources.Resources.database
        Me.PictureBox1.Location = New System.Drawing.Point(351, 50)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(114, 92)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.ViewButton)
        Me.Controls.Add(Me.QueryRadioButton2)
        Me.Controls.Add(Me.QueryRadioButton1)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents QueryRadioButton1 As RadioButton
    Friend WithEvents QueryRadioButton2 As RadioButton
    Friend WithEvents ViewButton As Button
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
End Class
