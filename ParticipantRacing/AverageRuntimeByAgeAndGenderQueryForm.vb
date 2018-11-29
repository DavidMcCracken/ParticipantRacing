Public Class AverageRuntimeByAgeAndGenderQueryForm
    Private Sub AverageRuntimeByAgeAndGenderQueryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_HW3_PROJ_13_BOULDER_2003_versionDataSet._Query4_average_running_times_by_age_and_gender' table. You can move, or remove it, as needed.
        Me.Query4_average_running_times_by_age_and_genderTableAdapter.Fill(Me._HW3_PROJ_13_BOULDER_2003_versionDataSet._Query4_average_running_times_by_age_and_gender)

    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class