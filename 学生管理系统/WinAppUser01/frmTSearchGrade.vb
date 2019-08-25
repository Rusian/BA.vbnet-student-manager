Imports System
Imports System.IO
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports StudentModel
Imports StudentBLL
Public Class frmTSearchCourse
    Private Sub frmTSearchCourse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        Dim teacherManger As New TeacherManager

        dt = teacherManger.GetGradeByUID(frmLogin.strUID)

        '把查询结果在表格中显示出来
        DataGridView1.DataSource = dt
    End Sub
End Class