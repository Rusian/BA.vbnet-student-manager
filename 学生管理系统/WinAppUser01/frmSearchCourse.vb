Imports System
Imports System.IO
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports StudentModel
Imports StudentBLL
Public Class frmSearchCourse
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim dt As New DataTable
        Dim studentmanager As New StudentManger

        dt = studentmanager.GetMajorCourseByUID(frmLogin.strUID)

        '把查询结果在表格中显示出来
        DataGridView1.DataSource = dt
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        Dim dt As New DataTable
        Dim studentmanager As New StudentManger

        dt = studentmanager.GetElectiveCourseByUID(frmLogin.strUID)
        '把查询结果在表格中显示出来
        DataGridView2.DataSource = dt
    End Sub

    Private Sub frmSearchCourse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.BackColor = Color.Transparent
        Label19.BackColor = Color.Transparent

        Dim dt1 As New DataTable
        Dim studentmanager As New StudentManger
        Dim dt2 As New DataTable
        dt1 = studentmanager.GetMajorCourseByUID(frmLogin.strUID)

        '把查询结果在表格中显示出来
        DataGridView1.DataSource = dt1


        dt2 = studentmanager.GetElectiveCourseByUID(frmLogin.strUID)
        '把查询结果在表格中显示出来
        DataGridView2.DataSource = dt2
    End Sub
End Class