Imports DBAacess
Imports StudentModel

Public Class TeacherManager
    Public Function GetCourseByUID(ByVal strID As String) As DataTable
        Dim reader As New Reader
        Dim strSQL As String
        strSQL = "select 教师任课表.课程编号,教师任课表.课程名称,课程学分 from 教师任课表,主修课程表 where 教工号='" & strID & "' and 教师任课表.课程编号=主修课程表.课程编号"

        Return reader.Read(strSQL)
    End Function

    Public Function AddOneUser(ByVal strID As String, ByVal strName As String, ByVal strPassword As String, ByVal strRole As String) As Boolean
        Dim strSQL As String

        Dim writer As New Writer
        Dim ret As Integer

        '生成SQL语句

        '调用数据库访问层里面的记录更新操作
        strSQL = "insert into 账号表(账号,姓名,密码,身份)values('" & strID & "','" & strName & "','" & strPassword & "','" & strRole & "')"
        ret = writer.Write(strSQL)
        If ret > 0 Then
            Return True
        Else
            Return False
        End If
    End Function


    Public Function AddOneStudent(ByVal strID As String, ByVal strName As String, ByVal strDeptno As String) As Boolean
        Dim strSQL As String

        Dim writer As New Writer
        Dim ret As Integer
        '生成SQL语句

        '调用数据库访问层里面的记录更新操作

        strSQL = "insert into 学生信息表(学号,姓名,系部编号)values('" & strID & "','" & strName & "','" & strDeptno & "')"

        ret = writer.Write(strSQL)

        If ret > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function GetGradeByUID(ByVal strID As String) As DataTable
        Dim reader As New Reader
        Dim strSQL As String
        strSQL = "select 成绩表.学号,学生信息表.姓名,成绩表.课程名称,成绩表.成绩 from 成绩表,教师任课表,学生信息表 where 教师任课表.教工号='" & strID & "' and 成绩表.课程编号=教师任课表.课程编号  and 成绩表.学号=学生信息表.学号 "

        Return reader.Read(strSQL)
    End Function
End Class
