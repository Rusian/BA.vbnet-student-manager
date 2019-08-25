Imports DBAacess
Imports StudentModel

Public Class StudentManger



    ''' <summary>
    ''' 根据系部名称获取系部编号
    ''' </summary>
    ''' <param name="strDeptName">系部名称</param>
    ''' <returns>系部编号</returns>
    Public Function GetDeptNoByDeptName(ByVal strDeptName As String) As String
        Dim reader As New Reader
        Dim dt As New DataTable
        Dim strSQL As String
        Dim strDeptNo As String
        Dim ret As Integer

        '生成SQL语句，到系部信息表中查找系部编号
        strSQL = "select 系部编号 from 系部信息表 where 系部名称='" & strDeptName & "'"

        dt = reader.Read(strSQL)
        ret = dt.DefaultView.Count

        If ret > 0 Then
            strDeptNo = dt.Rows(0)(0)
            Return strDeptNo
        Else
            Return String.Empty

        End If

    End Function

    ''' <summary>
    ''' 根据学号获得学生信息
    ''' </summary>
    ''' <param name="strID">学号</param>
    ''' <returns>学生信息</returns>
    Public Function GetStudentInfoByUID(ByVal strID As String) As DataTable
        Dim reader As New Reader
        Dim strSQL As String
        strSQL = "select 性别,出生日期,籍贯,系部名称 from 学生信息表,系部信息表 where 学号='" & strID & "' and  学生信息表.系部编号=系部信息表.系部编号"

        Return reader.Read(strSQL)
    End Function

    ''' <summary>
    ''' 修改学生个人信息
    ''' </summary>
    ''' <param name="st">学生信息</param>
    ''' <returns>执行结果（True/False）</returns>
    ''' <remarks></remarks>
    Public Function UpdateStudentInfo(ByVal st As Student, ByVal strID As String) As Boolean
        Dim strSQL As String
        Dim writer As New Writer
        Dim ret As Integer
        '生成SQL语句
        strSQL = "update 学生信息表 set 性别='" & st.Sex & "',出生日期='" & st.BirthDate & "',年龄='" & st.Age & "',籍贯='" & st.Address & "',系部编号='" & st.DeptNo & "'  where 学号='" & strID & "'"
        '调用数据库访问层里面的记录更新操作
        ret = writer.Write(strSQL)

        If ret > 0 Then
            Return True
        Else
            Return False
        End If

    End Function
    ''' <summary>
    ''' 根据学号获得主修课程表
    ''' </summary>
    ''' <param name="strID">学号</param>
    ''' <returns>主修课程表</returns>
    Public Function GetMajorCourseByUID(ByVal strID As String) As DataTable
        Dim reader As New Reader
        Dim strSQL As String
        strSQL = "select 课程编号,课程名称,课程学分,任课教师 from 主修课程表,学生信息表 where 学生信息表.学号='" & strID & " ' and 主修课程表.系部编号= 学生信息表.系部编号"

        Return reader.Read(strSQL)
    End Function
    ''' <summary>
    ''' 根据学号获得选修课程表
    ''' </summary>
    ''' <param name="strID"></param>
    ''' <returns></returns>
    Public Function GetElectiveCourseByUID(ByVal strID As String) As DataTable
        Dim reader As New Reader
        Dim strSQL As String
        strSQL = "select 课程编号,课程名称,课程学分,任课教师 from 学生选课表  where 学号='" & strID & " '"

        Return reader.Read(strSQL)
    End Function

    Public Function GetGradeByUID(ByVal strID As String) As DataTable
        Dim reader As New Reader
        Dim strSQL As String
        strSQL = "select 成绩表.课程编号,成绩表.课程名称,成绩,教师姓名 from 成绩表,教师任课表,教师信息表 where 学号='" & strID & "' and 成绩表.课程编号=教师任课表.课程编号 and 教师任课表.教工号=教师信息表.教工号"

        Return reader.Read(strSQL)
    End Function
    ''' <summary>
    ''' 根据选课信息添加课程表
    ''' </summary>
    ''' <param name="scr"></param>
    ''' <returns></returns>
    Public Function AddOneCourseRecord(ByVal scr As SelectCourseRecord) As Boolean
        Dim strSQL As String
        Dim writer As New Writer
        Dim ret As Integer
        '生成SQL语句

        '调用数据库访问层里面的记录更新操作
        strSQL = "insert into 学生选课表(学号,课程编号,课程名称,课程学分,任课教师)values('" & scr.ID & "','" & scr.CID & "','" & scr.CName & "'," & scr.Credit & ",'" & scr.TName & "') "

        ret = writer.Write(strSQL)

        If ret > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

End Class
