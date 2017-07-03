Public Class Loro
    Private _memoria As Queue(Of String)
    Private _edad As Short
    Private _fechanac As Date
    Private _nombre As String
    Sub New()
        _memoria = New Queue(Of String)
        _edad = 0
        _fechanac = Nothing
        _nombre = ""
    End Sub
End Class
