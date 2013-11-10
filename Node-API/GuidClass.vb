Public Class GuidClass
    Public Enum tree As UShort
        file = 0
        edit = 1
        view = 2
        more = 3
    End Enum
    Public menutree As tree 'Where the Menubutton should be
    Public text As String 'The text of the menubutton
    Public key As String 'The key of the Button: Note! Each button must have its own key because if there are to button (also from other plugins) it isn´t possible anymore which button is pressed.
    Public tooltip As String 'The tooltip of the menubutton
End Class
