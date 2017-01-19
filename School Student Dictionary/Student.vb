Public Class Student
    Private _firstName As String
    Private _lastName As String
    Private _averageGrade As String

#Region "constructors"
    Public Sub New()
        'default constructor'
        _firstName = ""
        _lastName = ""
        _averageGrade = ""
    End Sub

    Public Sub New(ByVal firstName As String, ByVal lastName As String, ByVal averageGrade As String)
        Me._firstName = firstName
        Me._lastName = lastName
        Me._averageGrade = averageGrade
    End Sub
#End Region

#Region "properties"
    Public Property FirstName As String
        Get
            Return _firstName
        End Get
        Set(value As String)
            _firstName = value
        End Set
    End Property
    Public Property LastName As String
        Get
            Return _lastName
        End Get
        Set(value As String)
            _lastName = value
        End Set
    End Property
    Public Property AverageGrade As String
        Get
            Return _averageGrade
        End Get
        Set(value As String)
            _averageGrade = value
        End Set
    End Property
#End Region


End Class
