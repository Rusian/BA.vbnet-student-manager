Imports StudentModel
Imports StudentBLL

Public Class frmSelectCourse
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim strCID As String
        Dim strName As String
        Dim strScore As String
        Dim intScore As Integer
        Dim strTeacher As String
        Dim strSID As String

        Dim scr As New SelectCourseRecord
        Dim ret As Boolean
        Dim studentManager As New StudentManger

        strSID = frmLogin.strUID
        If rdbStory.Checked Then
            strCID = rdbStory.Text.Trim()
            strName = lblStory.Text.Trim()
            strScore = Label6.Text.Trim()
            strTeacher = Label7.Text.Trim()
        Else
            If rdbMusic.Checked Then
                strCID = rdbMusic.Text.Trim()
                strName = lblMusic.Text.Trim()
                strScore = Label13.Text.Trim()

                strTeacher = Label14.Text.Trim()
            Else
                strCID = rdbPS.Text.Trim()
                strName = lblPS.Text.Trim()
                strScore = Label16.Text.Trim()

                strTeacher = Label17.Text.Trim()
            End If
        End If
        intScore = CType(strScore, Integer)
        '把获取到的选课记录封装到选课记录类里面
        scr.ID = strSID
        scr.CID = strCID
        scr.CName = strName
        scr.Credit = intScore
        scr.TName = strTeacher

        ret = studentManager.AddOneCourseRecord(scr)
        If ret = True Then
            MessageBox.Show("学生选课成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show("学生选课失败！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub
End Class