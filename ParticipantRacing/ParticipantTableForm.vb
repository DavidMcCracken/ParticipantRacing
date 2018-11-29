Public Class ParticipantTableForm
    Private Sub TblParticipantBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TblParticipantBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblParticipantBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._HW3_PROJ_13_BOULDER_2003_versionDataSet)

    End Sub

    Private Sub ParticipantTableForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_HW3_PROJ_13_BOULDER_2003_versionDataSet.tblParticipant' table. You can move, or remove it, as needed.
        Me.TblParticipantTableAdapter.Fill(Me._HW3_PROJ_13_BOULDER_2003_versionDataSet.tblParticipant)

    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class