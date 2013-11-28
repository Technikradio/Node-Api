Public Interface mainInteface

    Sub wasContentAdded(ByVal Value As Decimal, ByVal index As Integer, ByVal Description As String, ByVal CostCenter As String, ByVal creationDate As String) 'This will be called if a row was added
    Sub OnLoading() 'This will be called at the startup of node
    Sub LogAdd(ByVal log As String) 'This will be called if something is add to the log
    Property wasLoaded As Boolean 'This should contains if the OnLoading Sub was called or not
    Property GuidClasses As List(Of GuidClass) 'This will only be called once to inizilize the menubuttons
    Sub wasButtonClicked(ByVal key As String) 'This will be called if an MenuButton of this or an other plugin is clicked. The key value is to keep apart of the different Buttons.
    Property SendToAdd As List(Of analogBorder) 'This contails all rows the plugin add Note: this will only be called every 0.1 seconds
    Property ProcessingSendToAdd As Boolean 'This is true if the client is working on the requests. Don´t add something if it is the case, else it would be deleated!
    Property ElapsedTime As UInt16 'This is the time the client is running stable. it will be updated while the client is processing the rows to add
    Property MessagesToLog As List(Of String) 'Things which will be shown at the log

End Interface
