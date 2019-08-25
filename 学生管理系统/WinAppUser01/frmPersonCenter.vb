
Imports System
Imports System.IO
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports StudentModel
Imports StudentBLL
Public Class frmPersonCenter
    Private Sub ToolStripAdd_Click(sender As Object, e As EventArgs) Handles ToolStripAdd.Click
        frmStudentInfoAdd.Show()
        frmStudentInfoAdd.lblUName.Text = frmLogin.strUName
    End Sub

    Private Sub ToolStripSearch_Click(sender As Object, e As EventArgs) Handles ToolStripSearch.Click
        frmStudentInfoSearch.Show()
        frmStudentInfoSearch.lblID.Text = frmLogin.strUID
        frmStudentInfoSearch.lblName.Text = frmLogin.strUName

        Dim dt As New DataTable
        Dim studentmanager As New StudentManger
        dt = studentmanager.GetStudentInfoByUID(frmLogin.strUID)




        frmStudentInfoSearch.lblSex.Text = dt.Rows(0)("性别")
        frmStudentInfoSearch.lblBirth.Text = dt.Rows(0)("出生日期")

        frmStudentInfoSearch.lblAddress.Text = dt.Rows(0)("籍贯")
        frmStudentInfoSearch.lblDeptName.Text = dt.Rows(0)("系部名称")


    End Sub


End Class