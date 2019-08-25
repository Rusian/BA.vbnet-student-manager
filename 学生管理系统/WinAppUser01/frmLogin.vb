Imports StudentBLL
Public Class frmLogin
    '公共变量 
    Public strUName As String
    Public strUID As String
    Public StrURole As String

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        Dim strPassWord As String
        Dim ret As Boolean
        Dim commonmanager As New CommonManager

        '获取用户者的ID账号
        strUID = txtUserID.Text.Trim()
        '获取用户者的ID密码
        strPassWord = txtPassWord.Text.Trim()
        '获取用户的身份
        If rdbStudent.Checked Then
            strURole = "学生"
        Else
            strURole = "教师"
        End If

        '判断用户者的合法性
        '将ID账号和密码送入StudentBLL进行判断

        ret = commonmanager.JudgeUser(strUID, strPassWord, strURole)

        If ret = True Then

            strUName = commonmanager.GetUNameByUID(strUID)
            If rdbStudent.Checked Then
                frmMain.ShowDialog()
            Else
                frmTMain.ShowDialog()
            End If
            Me.Hide()
        Else
            MessageBox.Show("您输入的账号或密码有误！请重新输入！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPassWord.Text = ""
        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        txtUserID.Text = ""
        txtPassWord.Text = ""


    End Sub


End Class