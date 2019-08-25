Imports System
Imports System.Data
Imports System.Data.OleDb
Public Class Reader
    Public Function Read(ByVal strSQL As String) As DataTable


        '数据库的链接
        Dim conn As New OleDbConnection '生成一条路径
        conn.ConnectionString = "Provider=Microsoft.ACE.Oledb.12.0;Data Source=D:\R.Study.UnderGraduate\程序设计实训——学生管理系统\学生管理系统.accdb" '连接字符串
        conn.Open()
        '封装SQL语句
        Dim cmd As New OleDbCommand
        cmd.Connection = conn
        cmd.CommandText = strSQL
        '把封装后的Command语句装入DataAdapter对象
        Dim da As New OleDbDataAdapter
        da.SelectCommand = cmd
        '执行SQL语句并获取查询记录
        Dim ds As New DataSet
        da.Fill(ds, "查询结果")
        '关闭数据库
        conn.Close()
        '返回查询记录集
        Return ds.Tables(0)

    End Function
End Class
