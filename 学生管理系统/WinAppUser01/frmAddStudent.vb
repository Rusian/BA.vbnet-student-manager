Imports StudentModel
Imports StudentBLL

Public Class frmAddStudent
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim strID As String
        Dim strName As String
        Dim strDeptName As String
        Dim strDeptNo As String
        Dim strPassword As String
        Dim strRole As String
        Dim ret1 As Boolean
        Dim ret2 As Boolean
        Dim studentManager As New StudentManger
        Dim teachermanager As New TeacherManager
        strID = txtID.Text.Trim()
        strName = txtName.Text.Trim()
        strDeptName = cmbDeptName.Text.Trim()
        strPassword = strID
        strRole = "学生"

        '调用将系别转换为系部编号的方法
        strDeptNo = studentManager.GetDeptNoByDeptName(strDeptName)

        ret1 = teachermanager.AddOneUser(strID, strName, strPassword, strRole)
        ret2 = teachermanager.AddOneStudent(strID, strName, strDeptNo)
        If ret1 = True And ret2 = True Then
            MessageBox.Show("学生添加成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show("学生添加失败！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtID.Text = ""
            txtName.Text = ""
            cmbDeptName.Text = ""
        End If
    End Sub

    Private Sub frmAddStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label1.BackColor = Color.Transparent
        Label2.BackColor = Color.Transparent
        Label3.BackColor = Color.Transparent
        Label4.BackColor = Color.Transparent
        Button1.BackColor = Color.Transparent

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub txtID_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged

    End Sub
End Class