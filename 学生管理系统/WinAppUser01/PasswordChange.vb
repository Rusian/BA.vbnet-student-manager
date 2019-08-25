Imports StudentModel
Imports StudentBLL
Public Class PasswordChange
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim strSQL As String
        Dim commonmanager As New CommonManager
        Dim ret1 As Boolean
        Dim ret2 As Boolean
        Dim strOPassword As String
        Dim strNFPassword As String
        Dim strNSPassword As String

        '获取用户的旧密码
        strOPassword = txtOPassword.Text.Trim()
        '获取用户的新密码
        strNFPassword = txtNFPassword.Text.Trim()
        '获取用户的二次输入密码
        strNSPassword = txtNSpassword.Text.Trim()

        '判断用户的旧密码符合账户表中的密码
        ret1 = commonmanager.JudgeUser(frmLogin.strUID, strOPassword, frmLogin.strURole)
        If ret1 = True Then
            If strNFPassword = strNSPassword Then
                '调用修改用户密码的方法
                ret2 = commonmanager.UpdatePassword(frmLogin.strUID, strNFPassword)
            Else
                MessageBox.Show("二次输入密码不一致，请重新输入！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Else
            MessageBox.Show("旧密码，用户信息不匹配，请重新输入！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        If ret2 = True Then
            MessageBox.Show("密码修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
        Else
            MessageBox.Show("密码修改失败！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtOPassword.Text = ""
            txtNFPassword.Text = ""
            txtNSpassword.Text = ""

        End If
    End Sub



    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class