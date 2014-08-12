Imports ClassLibrary1
Imports System.Runtime.Remoting
Imports System.Runtime.Remoting.Channels
Imports System.Runtime.Remoting.Channels.Tcp

Public Class Service1

    Protected Overrides Sub OnStart(ByVal args() As String)
        RemotingConfiguration.Configure(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile, False)

        ChannelServices.RegisterChannel(New TcpServerChannel(8085), True)
        RemotingConfiguration.RegisterWellKnownServiceType(
            GetType(Server), GetType(Server).Name, WellKnownObjectMode.SingleCall)
    End Sub

    Protected Overrides Sub OnStop()
    End Sub

End Class
