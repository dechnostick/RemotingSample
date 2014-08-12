Imports ClassLibrary1
Imports System.IO

Public Class Server
    Inherits MarshalByRefObject
    Implements IRefObj

    Public Function Calc(str As String) As String Implements IRefObj.Calc
        Process.Start("Calc")
        Return str & ":" & DateTime.Now.ToString
    End Function
End Class
