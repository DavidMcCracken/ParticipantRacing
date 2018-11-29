Public Class GroupsByPRTimeQueryForm
    Private Sub GroupsByPRTimeQueryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_HW3_PROJ_13_BOULDER_2003_versionDataSet._Query2__GroupByPRTime_Max1000' table. You can move, or remove it, as needed.
        Me.Query2__GroupByPRTime_Max1000TableAdapter.Fill(Me._HW3_PROJ_13_BOULDER_2003_versionDataSet._Query2__GroupByPRTime_Max1000)

    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class