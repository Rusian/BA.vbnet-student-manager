Public Class Student
    '属性
    Private _ID As String = String.Empty
    Private _name As String = String.Empty
    Private _sex As String = String.Empty
    Private _birthday As String = String.Empty
    Private _age As Integer = 0
    Private _address As String = String.Empty
    Private _deptno As String = String.Empty
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
    ''' 姓名
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    ''' <summary>
    ''' 年龄
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks> 
    Public Property Age As String
        Get
            Return _age
        End Get
        Set(value As String)
            _age = value
        End Set
    End Property

    ''' <summary>
    ''' 性别
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Sex As String
        Get
            Return _sex
        End Get
        Set(value As String)
            _sex = value
        End Set
    End Property

    Public Property Address As String
        Get
            Return _address
        End Get
        Set(value As String)
            _address = value
        End Set
    End Property

    Public Property BirthDate As String
        Get
            Return _birthday
        End Get
        Set(value As String)
            _birthday = value
        End Set
    End Property

    Public Property DeptNo As String
        Get
            Return _deptno
        End Get
        Set(value As String)
            _deptno = value
        End Set
    End Property
End Class
