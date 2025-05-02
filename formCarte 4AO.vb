Public Class Carte_4AO
    Private Sub Btnretour_Click(sender As Object, e As EventArgs) Handles btnretour.Click

        Me.Visible = False
        formmenu.Visible = True

    End Sub
    Private Sub Carte_4AO_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim versionapp As String

        Try

            versionapp = My.Application.Deployment.CurrentVersion.ToString

        Catch ex As Exception
            versionapp = My.Application.Info.Version.ToString
        End Try

        Label2.Text = "v" & versionapp

        If formmenu.demonstration = True Then
            TimerTest.Enabled = False
        Else
            If FormSplash.port.TestPortCom(FormSplash.port.GetPortCom) = False Then

                MessageBox.Show("ERREUR, le PSOC n'a pas été trouvé,vérifiez si il est connecté")
                Label1.Text = "COM"
                TimerTest.Enabled = True

            Else

                SerialPort1.PortName = FormSplash.port.GetPortCom
                Label1.Text = SerialPort1.PortName
                TimerTest.Enabled = True

            End If

        End If

    End Sub

    Private Sub BtnTension_Click(sender As Object, e As EventArgs) Handles btnTension.Click

        TimerTest.Enabled = False

        If formmenu.demonstration = True Then

            If TVTension.Checked = True Then

                formmenu.carte.Recupresultdemo("Tension", 0)

            Else

                If Voie1Tension.Checked = True Then

                    formmenu.carte.Recupresultdemo("Tension", 1)

                End If

                If Voie2Tension.Checked = True Then

                    formmenu.carte.Recupresultdemo("Tension", 2)

                End If

                If Voie3Tension.Checked = True Then

                    formmenu.carte.Recupresultdemo("Tension", 3)

                End If

                If Voie4Tension.Checked = True Then

                    formmenu.carte.Recupresultdemo("Tension", 4)

                End If

            End If

        Else

            If TVTension.Checked = True Then

                formmenu.carte.Recupresult("Tension", 0, "", SerialPort1.PortName)

            Else

                If Voie1Tension.Checked = True Then

                    formmenu.carte.Recupresult("Tension", 1, "", SerialPort1.PortName)

                End If

                If Voie2Tension.Checked = True Then

                    formmenu.carte.Recupresult("Tension", 2, "", SerialPort1.PortName)

                End If

                If Voie3Tension.Checked = True Then

                    formmenu.carte.Recupresult("Tension", 3, "", SerialPort1.PortName)

                End If

                If Voie4Tension.Checked = True Then

                    formmenu.carte.Recupresult("Tension", 4, "", SerialPort1.PortName)

                End If

            End If

        End If



        Me.Visible = False
        formresultats.Visible = True

    End Sub

    Private Sub Btncourant_Click(sender As Object, e As EventArgs) Handles btnCourant.Click

        TimerTest.Enabled = False

        If formmenu.demonstration = True Then

            If TVCourant.Checked = True Then

                formmenu.carte.Recupresultdemo("Courant", 0)

            Else

                If Voie1Courant.Checked = True Then

                    formmenu.carte.Recupresultdemo("Courant", 1)

                End If

                If Voie2Courant.Checked = True Then

                    formmenu.carte.Recupresultdemo("Courant", 2)

                End If

                If Voie3Courant.Checked = True Then

                    formmenu.carte.Recupresultdemo("Courant", 3)

                End If

                If Voie4Courant.Checked = True Then

                    formmenu.carte.Recupresultdemo("Courant", 4)

                End If

            End If

        Else

            If TVCourant.Checked = True Then

                formmenu.carte.Recupresult("Courant", 0, "", SerialPort1.PortName)

            Else

                If Voie1Courant.Checked = True Then

                    formmenu.carte.Recupresult("Courant", 1, "", SerialPort1.PortName)

                End If

                If Voie2Courant.Checked = True Then

                    formmenu.carte.Recupresult("Courant", 2, "", SerialPort1.PortName)

                End If

                If Voie3Courant.Checked = True Then

                    formmenu.carte.Recupresult("Courant", 3, "", SerialPort1.PortName)

                End If

                If Voie4Courant.Checked = True Then

                    formmenu.carte.Recupresult("Courant", 4, "", SerialPort1.PortName)

                End If

            End If

        End If

        Me.Visible = False
        formresultats.Visible = True

    End Sub

    Private Sub TimerTest_Tick(sender As Object, e As EventArgs) Handles TimerTest.Tick

        If FormSplash.port.TestPortCom(FormSplash.port.GetPortCom) = False Then

            MessageBox.Show("ERREUR, le PSOC n'a pas été trouvé,vérifiez si il est connecté au port com:")
            Label1.Text = "COM"

        Else

            SerialPort1.PortName = FormSplash.port.GetPortCom
            Label1.Text = SerialPort1.PortName

        End If

    End Sub

    Private Sub TVTension_CheckedChanged(sender As Object, e As EventArgs) Handles TVTension.CheckedChanged
        If TVTension.Checked = True Then
            Voie1Tension.Checked = True
            Voie2Tension.Checked = True
            Voie3Tension.Checked = True
            Voie4Tension.Checked = True
        Else
            Voie1Tension.Checked = True
            Voie2Tension.Checked = True
            Voie3Tension.Checked = True
            Voie4Tension.Checked = True
        End If
    End Sub


    Private Sub TVCourant_CheckedChanged(sender As Object, e As EventArgs) Handles TVCourant.CheckedChanged
        If TVCourant.Checked = True Then
            Voie1Courant.Checked = True
            Voie2Courant.Checked = True
            Voie3Courant.Checked = True
            Voie4Courant.Checked = True
        Else
            Voie1Courant.Checked = False
            Voie2Courant.Checked = False
            Voie3Courant.Checked = False
            Voie4Courant.Checked = False
        End If
    End Sub



End Class