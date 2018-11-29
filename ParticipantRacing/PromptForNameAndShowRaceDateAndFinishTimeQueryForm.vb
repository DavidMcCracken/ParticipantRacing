Public Class PromptForNameAndShowRaceDateAndFinishTimeQueryForm
    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs) Handles FillToolStripButton.Click
        Try
            Me.PromptForNameQueryTableAdapter.Fill(Me._HW3_PROJ_13_BOULDER_2003_versionDataSet.PromptForNameQuery, ParticipantNameToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class