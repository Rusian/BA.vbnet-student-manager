Imports System
Imports System.IO
Imports StudentBLL
Public Class frmMain
 

    Private Sub lblPerson_Click(sender As Object, e As EventArgs) Handles lblPerson.Click
        Dim frmpersoncenter As New frmPersonCenter
        Dim ret As DialogResult

        ret = frmpersoncenter.ShowDialog()
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

        Me.Close()

    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim ret As DialogResult
        ret = MessageBox.Show("你是否真的要退出系统？", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If ret = Windows.Forms.DialogResult.Yes Then
            Me.Dispose()
        Else
            e.Cancel = True
        End If

    End Sub

    Private Sub frmMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        '释放所有资源
        Application.Exit()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel2.Text = Now.ToString
    End Sub




    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim studentmanger As New StudentManger
        Dim strUserName As String
        strUserName = frmLogin.strUName
        If strUserName = String.Empty Then

            MessageBox.Show("您的信息不完善！请到个人中心完善个人信息！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            lblUName.Text = strUserName
        End If


    End Sub

    Private Sub lblServe_Click(sender As Object, e As EventArgs) Handles lblServe.Click
        PasswordChange.ShowDialog()
    End Sub

    Private Sub lblCourse_Click(sender As Object, e As EventArgs) Handles lblCourse.Click
        frmCourseCenter.ShowDialog()
    End Sub

    Private Sub lblGrade_Click(sender As Object, e As EventArgs) Handles lblGrade.Click
        frmSearchGrade.ShowDialog()
    End Sub
End Class