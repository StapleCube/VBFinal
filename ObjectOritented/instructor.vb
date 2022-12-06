Public Class instructor
    Inherits Person

    Private m_officenumber

    Public Property OfficePhoneNumber() As String
        Get
            Return m_officenumber
        End Get
        Set(value As String)
            m_officenumber = value
        End Set
    End Property



End Class
