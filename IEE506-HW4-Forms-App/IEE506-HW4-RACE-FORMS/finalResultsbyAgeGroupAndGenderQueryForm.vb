Public Class finalResultsbyAgeGroupAndGenderQueryForm
    Private Sub finalResultsbyAgeGroupAndGenderQueryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_HW3_PROJ_13_BOULDER_2003_versionDataSet._Query3_FinalResults' table. You can move, or remove it, as needed.
        Me.Query3_FinalResultsTableAdapter.Fill(Me._HW3_PROJ_13_BOULDER_2003_versionDataSet._Query3_FinalResults)

    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class