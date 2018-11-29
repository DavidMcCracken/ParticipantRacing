Public Class UpdateForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim CheckLoginInformation As _HW3_PROJ_13_BOULDER_2003_versionDataSet.tblLoginInformationRow
        Try
            CheckLoginInformation = _HW3_PROJ_13_BOULDER_2003_versionDataSet.tblLoginInformation.FindByUsername(TextBox1.Text)
            LabelTest.Text = CheckLoginInformation.Password
            Dim encryption As New Encryption
            Dim encrypted As String
            encrypted = encryption.SimpleCrypt(TextBox2.Text)
            If LabelTest.Text = encrypted Then
                Me.Close()
                UpdateSelectionForm.Show()
            End If
            LabelTest.Text = "Username is in the database, but password is incorrect!"
        Catch ex As Exception
            LabelTest.Text = "The username does not exist on the database, please contact the admin if you are supposed to be in database"

        End Try




    End Sub

    Private Sub TblLoginInformationBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblLoginInformationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._HW3_PROJ_13_BOULDER_2003_versionDataSet)

    End Sub

    Private Sub TblLoginInformationBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles TblLoginInformationBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblLoginInformationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._HW3_PROJ_13_BOULDER_2003_versionDataSet)

    End Sub

    Private Sub UpdateForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_HW3_PROJ_13_BOULDER_2003_versionDataSet.tblLoginInformation' table. You can move, or remove it, as needed.
        Me.TblLoginInformationTableAdapter.Fill(Me._HW3_PROJ_13_BOULDER_2003_versionDataSet.tblLoginInformation)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class