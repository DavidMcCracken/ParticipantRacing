Public Class UpdateRaceForm
    Private Sub TblRaceBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TblRaceBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblRaceBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._HW3_PROJ_13_BOULDER_2003_versionDataSet)

    End Sub

    Private Sub UpdateRaceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_HW3_PROJ_13_BOULDER_2003_versionDataSet.tblRace' table. You can move, or remove it, as needed.
        Me.TblRaceTableAdapter.Fill(Me._HW3_PROJ_13_BOULDER_2003_versionDataSet.tblRace)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim NewRaceRow As _HW3_PROJ_13_BOULDER_2003_versionDataSet.tblRaceRow
        NewRaceRow = _HW3_PROJ_13_BOULDER_2003_versionDataSet.tblRace.NewtblRaceRow
        NewRaceRow.RaceDate = TextBox1.Text
        _HW3_PROJ_13_BOULDER_2003_versionDataSet.tblRace.Rows.Add(NewRaceRow)
        Me.Validate()
        Me.TblRaceBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._HW3_PROJ_13_BOULDER_2003_versionDataSet)
        TextBox1.Text = ""


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim NewRaceRow As _HW3_PROJ_13_BOULDER_2003_versionDataSet.tblRaceRow
        NewRaceRow = _HW3_PROJ_13_BOULDER_2003_versionDataSet.tblRace.FindByRaceDate(TextBox2.Text)
        NewRaceRow.RaceDate = TextBox4.Text
        Me.Validate()
        Me.TblRaceBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._HW3_PROJ_13_BOULDER_2003_versionDataSet)
        TextBox2.Text = ""
        TextBox4.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim NewRaceRow As _HW3_PROJ_13_BOULDER_2003_versionDataSet.tblRaceRow
        NewRaceRow = _HW3_PROJ_13_BOULDER_2003_versionDataSet.tblRace.FindByRaceDate(TextBox3.Text)
        NewRaceRow.Delete()
        Me.Validate()
        Me.TblRaceBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._HW3_PROJ_13_BOULDER_2003_versionDataSet)
        TextBox3.Text = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        UpdateSelectionForm.Show()
    End Sub
End Class