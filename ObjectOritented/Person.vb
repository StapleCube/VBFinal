Public MustInherit Class Person

    Private m_FirstName As String
    Private m_LastName As String
    Private m_email As String



    Public Property FistName() As String
        Get
            Return m_firstName
        End Get
        Set(value As String)
            m_firstName = value
        End Set
    End Property

    Public Property LastName() As String
        Get
            Return m_lastName
        End Get
        Set(value As String)
            m_lastName = value
        End Set
    End Property

    Public Property email() As String
        Get
            Return m_email
        End Get
        Set(value As String)
            m_email = value
        End Set
    End Property





End Class


