Imports ClassLibrary1
Imports System.Runtime.Remoting.Channels.Tcp
Imports System.Runtime.Remoting.Channels
Imports System.Runtime.Remoting

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ChannelServices.RegisterChannel(New TcpClientChannel, True)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        Dim obj As Object = Activator.GetObject(GetType(IRefObj), "tcp://localhost:8085/Server")
        Dim refObj As IRefObj = CType(obj, IRefObj)
        Button1.Text = refObj.Calc("Calc!")
    End Sub
End Class
