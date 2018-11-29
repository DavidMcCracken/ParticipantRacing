Public Class RaceResultsBasedOnDateOfRaceQueryForm
    Private Sub PromptForDateShowFinishOrderBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PromptForDateShowFinishOrderBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PromptForDateShowFinishOrderBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._HW3_PROJ_13_BOULDER_2003_versionDataSet)

    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs) Handles FillToolStripButton.Click
        Try
            Me.PromptForDateShowFinishOrderTableAdapter.Fill(Me._HW3_PROJ_13_BOULDER_2003_versionDataSet.PromptForDateShowFinishOrder, CType(RaceDateToolStripTextBox.Text, Date))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class