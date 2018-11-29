Public Class UpdateParticipantForm
    Private Sub UpdateParticipantForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_HW3_PROJ_13_BOULDER_2003_versionDataSet.tblParticipant' table. You can move, or remove it, as needed.
        Me.TblParticipantTableAdapter.Fill(Me._HW3_PROJ_13_BOULDER_2003_versionDataSet.tblParticipant)

    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        Dim NewParticipantRow As _HW3_PROJ_13_BOULDER_2003_versionDataSet.tblParticipantRow
        NewParticipantRow = _HW3_PROJ_13_BOULDER_2003_versionDataSet.tblParticipant.NewtblParticipantRow
        NewParticipantRow.SSN = TextBoxSSN.Text
        NewParticipantRow.ParticipantName = TextBoxParticipantName.Text
        NewParticipantRow.address = TextBoxAddress.Text
        NewParticipantRow.Birthday = TextBoxBirthday.Text
        NewParticipantRow.gender = TextBoxGender.Text
        NewParticipantRow.PRTime = TextBoxPRTime.Text
        _HW3_PROJ_13_BOULDER_2003_versionDataSet.tblParticipant.Rows.Add(NewParticipantRow)
        Me.Validate()
        Me.TblParticipantBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._HW3_PROJ_13_BOULDER_2003_versionDataSet)
        TextBoxSSN.Text = ""
        TextBoxParticipantName.Text = ""
        TextBoxAddress.Text = ""
        TextBoxBirthday.Text = ""
        TextBoxGender.Text = ""
        TextBoxPRTime.Text = ""



    End Sub

    Private Sub TblParticipantBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TblParticipantBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblParticipantBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._HW3_PROJ_13_BOULDER_2003_versionDataSet)

    End Sub

    Private Sub ButtonUpdatePR_Click(sender As Object, e As EventArgs) Handles ButtonUpdatePR.Click
        Dim UpdateParticipantRow As _HW3_PROJ_13_BOULDER_2003_versionDataSet.tblParticipantRow
        UpdateParticipantRow = _HW3_PROJ_13_BOULDER_2003_versionDataSet.tblParticipant.FindBySSN(TextBoxSSNUpdate.Text)
        UpdateParticipantRow.PRTime = TextBoxPRTimeUpdate.Text
        Me.Validate()
        Me.TblParticipantBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._HW3_PROJ_13_BOULDER_2003_versionDataSet)
        TextBoxSSNUpdate.Text = ""
        TextBoxPRTimeUpdate.Text = ""
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Dim DeleteParticipantRow As _HW3_PROJ_13_BOULDER_2003_versionDataSet.tblParticipantRow
        DeleteParticipantRow = _HW3_PROJ_13_BOULDER_2003_versionDataSet.tblParticipant.FindBySSN(TextBoxSSNDelete.Text)
        DeleteParticipantRow.Delete()
        Me.Validate()
        Me.TblParticipantBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._HW3_PROJ_13_BOULDER_2003_versionDataSet)
        TextBoxSSNDelete.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        UpdateSelectionForm.Show()
    End Sub
End Class