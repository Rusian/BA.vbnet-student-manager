Public Class SelectCourseRecord
    Private _ID As String = String.Empty
    Private _CID As String = String.Empty
    Private _cname As String = String.Empty
    Private _credit As Integer = 0
    Private _tname As String = String.Empty

    ''' <summary>
    ''' 学号
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ID As String
        Get
            Return _ID
        End Get
        Set(value As String)
            _ID = value
        End Set
    End Property
    ''' <summary>
    ''' 课程编号
    ''' </summary>
    ''' <returns></returns>
    Public Property CID As String
        Get
            Return _CID
        End Get
        Set(value As String)
            _CID = value
        End Set
    End Property

    ''' <summary>
    ''' 课程名称
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property CName As String
        Get
            Return _cname
        End Get
        Set(value As String)
            _cname = value
        End Set
    End Property

    ''' <summary>
    ''' 课程学分
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks> 
    Public Property Credit As String
        Get
            Return _credit
        End Get
        Set(value As String)
            _credit = value
        End Set
    End Property

    ''' <summary>
    ''' 任课教师
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property TName As String
        Get
            Return _tname
        End Get
        Set(value As String)
            _tname = value
        End Set
    End Property

End Class
