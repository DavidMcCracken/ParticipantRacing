Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ViewButton_Click(sender As Object, e As EventArgs) Handles ViewButton.Click
        Me.Hide()
        If RadioButton1.Checked Then
            ParticipantTableForm.Show()
        ElseIf RadioButton2.Checked Then
            RaceTableForm.Show()
        ElseIf QueryRadioButton1.Checked Then
            EliteRuntimesQueryForm.Show()
        ElseIf QueryRadioButton2.Checked Then
            GroupsByPRTimeQueryForm.Show()
        ElseIf RadioButton3.Checked Then
            UpdateForm.Show()
        End If
    End Sub
End Class
