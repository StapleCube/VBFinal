Public Class Course_Class

    Private m_CourseNumber As String
    Private m_CourseName As String
    Private m_day As String
    Private m_hours As String
    Private m_units As String
    Private m_RoomNumber As String
    Private m_TaFirstName As String
    Private m_TaLastName As String
    Private m_TaEmail As String

    Public Property CourseNumber() As String
        Get
            Return m_CourseNumber

        End Get
        Set(value As String)
            m_CourseNumber = value
        End Set
    End Property

    Public Property CourseName() As String
        Get
            Return m_CourseName
        End Get
        Set(value As String)
            m_CourseName = value
        End Set
    End Property

    Public Property day As String
        Get
            Return m_day
        End Get
        Set(value As String)
            m_day = value
        End Set
    End Property

    Public Property hours As String
        Get
            Return m_hours
        End Get
        Set(value As String)
            m_hours = value
        End Set
    End Property

    Public Property units As String
        Get
            Return m_units
        End Get
        Set(value As String)
            m_units = value
        End Set
    End Property

    Public Property roomnumber As String
        Get
            Return m_RoomNumber
        End Get
        Set(value As String)
            m_RoomNumber = value
        End Set
    End Property

    Public Property TaFirstName As String
        Get
            Return m_TaFirstName
        End Get
        Set(value As String)
            m_TaFirstName = value
        End Set
    End Property

    Public Property TaLastName As String
        Get
            Return m_TaLastName
        End Get
        Set(value As String)
            m_TaLastName = value
        End Set
    End Property

    Public Property TaEmail As String
        Get
            Return m_TaEmail
        End Get
        Set(value As String)
            m_TaEmail = value
        End Set
    End Property

End Class
