Imports System
Imports System.Data
Imports System.Data.OleDb
Public Class Writer
    '方法
    ''' <summary>
    ''' 数据库更新操作
    ''' </summary>
    ''' <param name="strSQL">SQL语句</param>
    ''' <returns>影响数据表的记录条数</returns>
    ''' <remarks></remarks>
    Public Function Write(ByVal strSQL As String) As Integer
        '数据库的连接
        '封装SQL命令
        '执行SQL命令
        '断开连接
        '返回影响数据表的记录行数

        '数据库的连接
        Dim conn As New OleDbConnection
        conn.ConnectionString = "Provider=Microsoft.ACE.Oledb.12.0;Data Source=D:\R.Study.UnderGraduate\程序设计实训——学生管理系统\学生管理系统.accdb" '连接字符串
        conn.Open()
        '封装SQL命令
        Dim cmd As New OleDbCommand
        cmd.Connection = conn
        cmd.CommandText = strSQL
        Dim ret As Integer
        ret = cmd.ExecuteNonQuery()
        '关闭数据库的连接
        conn.Close()
        Return ret
    End Function

End Class
