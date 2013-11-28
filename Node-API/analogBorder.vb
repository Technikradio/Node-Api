
Public Class analogBorder
    Public DES As String 'DES = Description of the row
    Public VAL As Int64 'VAL = The value of the row
    Public NUM As Int64 'NUM = The index of the row
    Public KOS As String 'KOS = The costcentre of the row
    Public DAT As String 'DAT = The date of the row

    Public Sub New(ByVal __DES As String, ByVal __VAL As Integer, ByVal __NUM As Integer, ByVal __KOS As String, ByVal __DAT As String)
        DES = __DES
        VAL = __VAL
        NUM = __NUM
        KOS = __KOS
        DAT = __DAT
    End Sub
End Class
