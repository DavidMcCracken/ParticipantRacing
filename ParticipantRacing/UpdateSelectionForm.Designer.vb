<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateSelectionForm
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
        Me.RadioButtonParticipant = New System.Windows.Forms.RadioButton()
        Me.RadioButtonRace = New System.Windows.Forms.RadioButton()
        Me.ButtonBack = New System.Windows.Forms.Button()
        Me.ButtonNext = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'RadioButtonParticipant
        '
        Me.RadioButtonParticipant.AutoSize = True
        Me.RadioButtonParticipant.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonParticipant.Location = New System.Drawing.Point(13, 13)
        Me.RadioButtonParticipant.Name = "RadioButtonParticipant"
        Me.RadioButtonParticipant.Size = New System.Drawing.Size(144, 17)
        Me.RadioButtonParticipant.TabIndex = 0
        Me.RadioButtonParticipant.TabStop = True
        Me.RadioButtonParticipant.Text = "Participant Database"
        Me.RadioButtonParticipant.UseVisualStyleBackColor = True
        '
        'RadioButtonRace
        '
        Me.RadioButtonRace.AutoSize = True
        Me.RadioButtonRace.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonRace.Location = New System.Drawing.Point(13, 37)
        Me.RadioButtonRace.Name = "RadioButtonRace"
        Me.RadioButtonRace.Size = New System.Drawing.Size(113, 17)
        Me.RadioButtonRace.TabIndex = 1
        Me.RadioButtonRace.TabStop = True
        Me.RadioButtonRace.Text = "Race Database"
        Me.RadioButtonRace.UseVisualStyleBackColor = True
        '
        'ButtonBack
        '
        Me.ButtonBack.Location = New System.Drawing.Point(13, 61)
        Me.ButtonBack.Name = "ButtonBack"
        Me.ButtonBack.Size = New System.Drawing.Size(75, 23)
        Me.ButtonBack.TabIndex = 2
        Me.ButtonBack.Text = "Back"
        Me.ButtonBack.UseVisualStyleBackColor = True
        '
        'ButtonNext
        '
        Me.ButtonNext.Location = New System.Drawing.Point(94, 61)
        Me.ButtonNext.Name = "ButtonNext"
        Me.ButtonNext.Size = New System.Drawing.Size(75, 23)
        Me.ButtonNext.TabIndex = 3
        Me.ButtonNext.Text = "Next"
        Me.ButtonNext.UseVisualStyleBackColor = True
        '
        'UpdateSelectionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonNext)
        Me.Controls.Add(Me.ButtonBack)
        Me.Controls.Add(Me.RadioButtonRace)
        Me.Controls.Add(Me.RadioButtonParticipant)
        Me.Name = "UpdateSelectionForm"
        Me.Text = "UpdateSelectionForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RadioButtonParticipant As RadioButton
    Friend WithEvents RadioButtonRace As RadioButton
    Friend WithEvents ButtonBack As Button
    Friend WithEvents ButtonNext As Button
End Class
