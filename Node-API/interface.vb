Public Interface mainInteface

    Sub wasContentAdded(ByVal Value As Decimal, ByVal index As Integer, ByVal Description As String, ByVal CostCenter As String, ByVal creationDate As String) 'This will be called if a row was added
    Sub OnLoading() 'This will be called at the startup of node
    Sub LogAdd(ByVal log As String) 'This will be called if something is add to the log
    Property wasLoaded As Boolean 'This should contains if the OnLoading Sub was called or not
    Property GuidClasses As List(Of GuidClass) 'This will only be called once to inizilize the menubuttons
    Sub wasButtonClicked(ByVal key As String) 'This will be called if an MenuButton of this or an other plugin is clicked. The key value is to keep apart of the different Buttons.

End Interface
