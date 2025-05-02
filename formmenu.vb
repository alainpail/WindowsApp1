Public Class formmenu

    Public carte As New Classcarte
    Public demonstration As Boolean = False
    Private Sub Formmenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim versionapp As String

        modedemo.Visible = False
        Me.Width = 788

        Try
            versionapp = My.Application.Deployment.CurrentVersion.ToString
        Catch ex As Exception
            versionapp = My.Application.Info.Version.ToString
        End Try

        Label5.Text = "v" & versionapp

        'test du port COM

        If FormSplash.port.TestPortCom(FormSplash.port.GetPortCom) = False Then
            MessageBox.Show("ERREUR, le PSOC n'a pas été trouvé,vérifiez si il est connecté")
            Label1.Text = "COM"
            TimerTest.Enabled = False
        Else
            SerialPort1.PortName = FormSplash.port.GetPortCom
            Label1.Text = SerialPort1.PortName
            TimerTest.Enabled = True
        End If

    End Sub

    Private Sub btniden_Click(sender As Object, e As EventArgs) Handles btniden.Click
        'identification de la carte

        Select Case carte.IdentificationCarte(SerialPort1.PortName)

            Case "Carte 4AI"

                TimerTest.Enabled = False
                Me.Visible = False
                Carte4ai.Visible = True

            Case "Carte 4AO"

                TimerTest.Enabled = False
                Me.Visible = False
                Carte_4AO.Visible = True

            Case "Carte 4DO"

                TimerTest.Enabled = False
                Me.Visible = False
                Carte_4DO.Visible = True

            Case ""

                MessageBox.Show("ERREUR, la Carte n'a pas été détectée ou n'est pas reconnue")

        End Select

    End Sub

    Private Sub TimerTest_Tick(sender As Object, e As EventArgs) Handles TimerTest.Tick

        'test de L'Etat du PSOC
        If FormSplash.port.DetectPortCom() = "" Then

            MessageBox.Show("ERREUR, le PSOC n'a pas été trouvé,vérifiez si il est connecté au port com:")
            Label1.Text = "COM"

        Else

            SerialPort1.PortName = FormSplash.port.GetPortCom
            Label1.Text = SerialPort1.PortName

        End If

    End Sub

    Private Sub BtnReconnexion_Click(sender As Object, e As EventArgs) Handles BtnReconnexion.Click
        'tentative de connexion avec le PSOC

        If FormSplash.port.DetectPortCom() = "" Then

            MessageBox.Show("ERREUR, le PSOC n'a pas été trouvé,vérifiez si il est connecté")
            Label1.Text = "COM"
            TimerTest.Enabled = False

        Else

            SerialPort1.PortName = FormSplash.port.GetPortCom
            Label1.Text = SerialPort1.PortName
            MessageBox.Show("Le PSOC est connecté au port :" & FormSplash.port.GetPortCom)
            TimerTest.Enabled = True

        End If

    End Sub

    Private Sub demo_CheckedChanged(sender As Object, e As EventArgs) Handles demo.CheckedChanged

        If demo.Checked = True Then

            demonstration = True
            Me.Width = 1052
            modedemo.Visible = True

        Else
            demonstration = False
            Me.Width = 788
            modedemo.Visible = False

        End If

    End Sub

    Private Sub btndemo_Click(sender As Object, e As EventArgs) Handles btndemo.Click

        If CB_4AI.Checked = True Then

            carte.SetCarte("4AI")
            Me.Visible = False
            Carte4ai.Visible = True

        ElseIf CB_4AO.Checked = True Then

            carte.SetCarte("4AO")
            Me.Visible = False
            Carte_4AO.Visible = True

        ElseIf CB_4DO.Checked = True Then

            carte.SetCarte("4DO")
            Me.Visible = False
            Carte_4DO.Visible = True

        End If

    End Sub

    Private Sub CB_4AI_CheckedChanged(sender As Object, e As EventArgs) Handles CB_4AI.CheckedChanged

        If CB_4AI.Checked = True Then

            CB_4AO.Checked = False
            CB_4DO.Checked = False

        End If

    End Sub

    Private Sub CB_4AO_CheckedChanged(sender As Object, e As EventArgs) Handles CB_4AO.CheckedChanged

        If CB_4AO.Checked = True Then

            CB_4AI.Checked = False
            CB_4DO.Checked = False

        End If

    End Sub

    Private Sub CB_4DO_CheckedChanged(sender As Object, e As EventArgs) Handles CB_4DO.CheckedChanged

        If CB_4DO.Checked = True Then

            CB_4AI.Checked = False
            CB_4AO.Checked = False

        End If

    End Sub

End Class