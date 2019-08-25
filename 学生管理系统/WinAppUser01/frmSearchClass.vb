Imports System
Imports System.IO
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports StudentModel
Imports StudentBLL
Public Class frmSearchClass

    Private Sub frmSearchClass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.BackColor = Color.Transparent

        Dim dt As New DataTable
        Dim teachermanager As New TeacherManager

        dt = teachermanager.GetCourseByUID(frmLogin.strUID)

        '把查询结果在表格中显示出来
        DataGridView1.DataSource = dt
    End Sub
End Class