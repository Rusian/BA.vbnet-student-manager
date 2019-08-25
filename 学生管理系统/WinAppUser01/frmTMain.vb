Public Class frmTMain
    Private Sub lblManger_Click(sender As Object, e As EventArgs) Handles lblManger.Click

        frmTSearchCourse.Show()
    End Sub

    Private Sub lblCourse_Click(sender As Object, e As EventArgs) Handles lblCourse.Click
        frmSearchClass.Show()
    End Sub

    Private Sub lblPerson_Click(sender As Object, e As EventArgs) Handles lblPerson.Click
        frmAddStudent.Show()
    End Sub

    Private Sub lblServe_Click(sender As Object, e As EventArgs) Handles lblServe.Click
        PasswordChange.ShowDialog()
    End Sub

    Private Sub frmTMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strUserName As String
        strUserName = frmLogin.strUName
        If strUserName = String.Empty Then

            MessageBox.Show("您的信息不完善！请到个人中心完善个人信息！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            lblUName.Text = strUserName
        End If
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

        Me.Close()
    End Sub

    Private Sub frmTMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim ret As DialogResult
        ret = MessageBox.Show("你是否真的要退出系统？", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If ret = Windows.Forms.DialogResult.Yes Then
            Me.Dispose()
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub frmTMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        '释放所有资源
        Application.Exit()
    End Sub
End Class