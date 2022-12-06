Public Class Student_Class
    Inherits Person

    Private m_numberofUnits

    Public Property units As String
        Get
            Return m_numberofUnits

        End Get
        Set(value As String)
            m_numberofUnits = value
        End Set
    End Property

End Class
