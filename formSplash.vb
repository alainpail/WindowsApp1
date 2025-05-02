Public Class FormSplash
    Public port As New ClassPortCom

    Private Sub FormSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim versionapp As String

        Try
            versionapp = My.Application.Deployment.CurrentVersion.ToString
        Catch ex As Exception
            versionapp = My.Application.Info.Version.ToString
        End Try

        Label1.Text = "v" & versionapp

        TimerSplash.Enabled = True 'lancement du timer

        'detection du Port COM
        If port.DetectPortCom() = "" Then

            MessageBox.Show("ERREUR, le PSOC n'a pas été trouvé,vérifiez si il est connecté")

        Else

            SerialPort.PortName = port.GetPortCom
            MessageBox.Show("Le PSOC est connecté au port :" & port.GetPortCom)

        End If

    End Sub

    Private Sub TimerSplash_Tick(sender As Object, e As EventArgs) Handles TimerSplash.Tick
        'lorsque le timer atteint 0,le formsplash se ferme et ouvre la page menu

        TimerSplash.Enabled = False
        formmenu.Visible = True
        Me.Close()

    End Sub


End Class