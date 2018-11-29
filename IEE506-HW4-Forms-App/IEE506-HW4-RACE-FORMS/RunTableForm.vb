Public Class RunTableForm
    Private Sub TblRunBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TblRunBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblRunBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._HW3_PROJ_13_BOULDER_2003_versionDataSet)

    End Sub

    Private Sub RunTableForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_HW3_PROJ_13_BOULDER_2003_versionDataSet.tblRun' table. You can move, or remove it, as needed.
        Me.TblRunTableAdapter.Fill(Me._HW3_PROJ_13_BOULDER_2003_versionDataSet.tblRun)

    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class