Imports StudentModel
Imports StudentBLL
Public Class frmCourseCenter
    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click
        frmSelectCourse.ShowDialog()
    End Sub

    Private Sub ToolStripLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripLabel2.Click
        frmSearchCourse.ShowDialog()

    End Sub
End Class