Public Class RaceTableForm
    Private Sub TblRaceBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TblRaceBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblRaceBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._HW3_PROJ_13_BOULDER_2003_versionDataSet)

    End Sub

    Private Sub RaceTableForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_HW3_PROJ_13_BOULDER_2003_versionDataSet.tblRace' table. You can move, or remove it, as needed.
        Me.TblRaceTableAdapter.Fill(Me._HW3_PROJ_13_BOULDER_2003_versionDataSet.tblRace)

    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class