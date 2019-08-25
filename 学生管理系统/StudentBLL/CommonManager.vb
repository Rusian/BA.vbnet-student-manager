Imports DBAacess
Imports StudentModel
Public Class CommonManager
    ''' <summary>
    ''' 根据账号和密码判断用户是否合法
    ''' </summary>
    ''' <param name="strID">账号</param>
    ''' <param name="strPassWord">密码</param>
    ''' <returns>是否存在（存在：True；不存在：False）</returns>
    ''' <remarks></remarks>
    Public Function JudgeUser(ByVal strID As String, ByVal strPassWord As String, ByVal strRole As String) As Boolean
        Dim strSQL As String
        Dim reader As New Reader
        Dim dt As New DataTable
        Dim ret As Integer

        '生成SQL语句，到数据库中查找账号与密码是否一致
        strSQL = "select * from 账号表 where 账号='" & strID & "'and 密码='" & strPassWord & "' and 身份 ='" & strRole & "'"
        '判断账号和密码是否合法
        '引用数据读的方法
        dt = reader.Read(strSQL)
        ret = dt.DefaultView.Count
        If ret > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    ''' <summary>
    ''' 根据账号获取用户名字
    ''' </summary>
    ''' <param name="strID">账号</param>
    ''' <returns>是否存在（存在：返回strname；不存在：False）</returns>
    ''' <remarks></remarks>
    Public Function GetUNameByUID(ByVal strID As String) As String
        Dim reader As New Reader
        Dim dt As New DataTable
        Dim strSQL As String
        Dim ret As Integer
        Dim strUserName As String = String.Empty

        '生成SQL语句，到数据库中查找学号是否一致
        strSQL = "select 姓名 from 账号表 where 账号='" & strID & "'"
        '判断学号是否存在and'引用数据读的方法

        dt = reader.Read(strSQL)
        ret = dt.DefaultView.Count

        If ret > 0 Then
            strUserName = dt.Rows(0)(0)
            Return strUserName
        Else
            Return String.Empty
        End If

    End Function

    Public Function UpdatePassword(ByVal strID As String, ByVal strPassword As String) As Boolean
        Dim strSQL As String
        Dim writer As New Writer
        Dim ret As Integer
        '生成SQL语句
        strSQL = "update 账号表  set 密码= '" & strPassword & "' where 账号='" & strID & "'"
        '调用数据库访问层里面的记录更新操作
        ret = writer.Write(strSQL)

        If ret > 0 Then
            Return True
        Else
            Return False
        End If

    End Function
End Class
