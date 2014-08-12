Imports ClassLibrary1
Imports System.Runtime.Remoting.Channels.Tcp
Imports System.Runtime.Remoting.Channels
Imports System.Runtime.Remoting

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ChannelServices.RegisterChannel(New TcpServerChannel(8085), True)
        RemotingConfiguration.RegisterWellKnownServiceType(
            GetType(Server), GetType(Server).Name, WellKnownObjectMode.SingleCall)
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
