Public Class UpdateSelectionForm
    Private Sub ButtonNext_Click(sender As Object, e As EventArgs) Handles ButtonNext.Click
        Me.Hide()
        If RadioButtonParticipant.Checked Then
            UpdateParticipantForm.Show()
        ElseIf RadioButtonRace.Checked Then
            UpdateRaceForm.Show()
        End If

    End Sub

    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class