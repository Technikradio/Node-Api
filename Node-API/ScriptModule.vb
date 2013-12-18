Public Class ScriptModule
    Public Structure FunctionPair
        Public NameInScript As String 'The function name to call from lua
        Public NameInObject As String 'The functionname to call from .Net
        ''' <summary>
        ''' This initialize an new instance
        ''' </summary>
        ''' <param name="Script">This will be NameInScript</param>
        ''' <param name="Method">This will be NameInObject</param>
        ''' <remarks></remarks>
        Public Sub New(ByVal Script As String, ByVal Method As String)
            NameInObject = Method
            NameInScript = Script
        End Sub
    End Structure

    Public ScriptObject As Object 'The object which contains all the functions
    Public Functions As List(Of FunctionPair) 'The functions to register from the ScriptObject

    ''' <summary>
    ''' This initialize an new instance
    ''' </summary>
    ''' <param name="SO">This will be ScriptObject</param>
    ''' <param name="FPs">This will be Functions</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal SO As Object, ParamArray FPs As FunctionPair())
        ScriptObject = SO
        Functions.AddRange(FPs)
    End Sub

End Class

Public Class JsonDoc
    Public Dim StoredPlace As String 'The place where the plugin is stored
    Public Dim AllocRam As UInt64 'The given ram by node
    Public Dim IsAdminApp As Boolean 'Is true if node is executed as an admin app
    Public Dim AllowWrite As Boolean 'Is true if node allows the plugin to write into the file
End Class
