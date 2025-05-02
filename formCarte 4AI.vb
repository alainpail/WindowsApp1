Public Class Carte4ai
    Private Sub Btnretour_Click(sender As Object, e As EventArgs) Handles btnretour.Click

        Me.Visible = False
        formmenu.Visible = True

    End Sub
    Private Sub Carte_4AI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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


    Private Sub Btntemperature_Click(sender As Object, e As EventArgs) Handles btntemperature.Click

        TimerTest.Enabled = False
        If formmenu.demonstration = True Then
            If TVTemp.Checked = True Then

                formmenu.carte.Recupresultdemo("Température", 0)

            Else

                If Voie1Temp.Checked = True Then

                    formmenu.carte.Recupresultdemo("Température", 1)

                End If

                If Voie2temp.Checked = True Then

                    formmenu.carte.Recupresultdemo("Température", 2)

                End If

                If Voie3Temp.Checked = True Then

                    formmenu.carte.Recupresultdemo("Température", 3)

                End If

                If Voie4Temp.Checked = True Then

                    formmenu.carte.Recupresultdemo("Température", 4)

                End If

            End If
        Else
            If TVTemp.Checked = True Then

                formmenu.carte.Recupresult("Température", 0, "", SerialPort1.PortName)

            Else

                If Voie1Temp.Checked = True Then

                    formmenu.carte.Recupresult("Température", 1, "", SerialPort1.PortName)

                End If

                If Voie2temp.Checked = True Then

                    formmenu.carte.Recupresult("Température", 2, "", SerialPort1.PortName)

                End If

                If Voie3Temp.Checked = True Then

                    formmenu.carte.Recupresult("Température", 3, "", SerialPort1.PortName)

                End If

                If Voie4Temp.Checked = True Then

                    formmenu.carte.Recupresult("Température", 4, "", SerialPort1.PortName)

                End If

            End If
        End If


        Me.Visible = False
        formresultats.Visible = True

    End Sub

    Private Sub BtnTension_Click(sender As Object, e As EventArgs) Handles BtnTension.Click

        TimerTest.Enabled = False
        Dim Valtension As Integer = TextBoxTension.Text

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

                formmenu.carte.Recupresult("Tension", 0, Valtension, SerialPort1.PortName)

            Else

                If Voie1Tension.Checked = True Then

                    formmenu.carte.Recupresult("Tension", 1, Valtension, SerialPort1.PortName)

                End If

                If Voie2Tension.Checked = True Then

                    formmenu.carte.Recupresult("Tension", 2, Valtension, SerialPort1.PortName)

                End If

                If Voie3Tension.Checked = True Then

                    formmenu.carte.Recupresult("Tension", 3, Valtension, SerialPort1.PortName)

                End If

                If Voie4Tension.Checked = True Then

                    formmenu.carte.Recupresult("Tension", 4, Valtension, SerialPort1.PortName)

                End If

            End If

        End If



        Me.Visible = False
        formresultats.Visible = True

    End Sub

    Private Sub Btncourant_Click(sender As Object, e As EventArgs) Handles btncourant.Click

        TimerTest.Enabled = False
        Dim valCourant As Integer = TextBoxCourant.Text

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

                formmenu.carte.Recupresult("Courant", 0, valCourant, SerialPort1.PortName)

            Else

                If Voie1Courant.Checked = True Then

                    formmenu.carte.Recupresult("Courant", 1, valCourant, SerialPort1.PortName)

                End If

                If Voie2Courant.Checked = True Then

                    formmenu.carte.Recupresult("Courant", 2, valCourant, SerialPort1.PortName)

                End If

                If Voie3Courant.Checked = True Then

                    formmenu.carte.Recupresult("Courant", 3, valCourant, SerialPort1.PortName)

                End If

                If Voie4Courant.Checked = True Then

                    formmenu.carte.Recupresult("Courant", 4, valCourant, SerialPort1.PortName)

                End If

            End If

        End If


        Me.Visible = False
        formresultats.Visible = True

    End Sub

    Private Sub BtnResistance_Click(sender As Object, e As EventArgs) Handles BtnResistance.Click

        TimerTest.Enabled = False
        Dim valrésistance As Integer = TextBoxRES.Text
        If formmenu.demonstration = True Then

            If TVRES.Checked = True Then

                formmenu.carte.Recupresultdemo("Résistance", 0)

            Else

                If Voie1RES.Checked = True Then

                    formmenu.carte.Recupresultdemo("Résistance", 1)

                End If

                If Voie2RES.Checked = True Then

                    formmenu.carte.Recupresultdemo("Résistance", 2)

                End If

                If Voie3RES.Checked = True Then

                    formmenu.carte.Recupresultdemo("Résistance", 3)

                End If

                If Voie4RES.Checked = True Then

                    formmenu.carte.Recupresultdemo("Résistance", 4)

                End If

            End If

        Else

            If TVRES.Checked = True Then

                formmenu.carte.Recupresult("Résistance", 0, valrésistance, SerialPort1.PortName)

            Else

                If Voie1RES.Checked = True Then

                    formmenu.carte.Recupresult("Résistance", 1, valrésistance, SerialPort1.PortName)

                End If

                If Voie2RES.Checked = True Then

                    formmenu.carte.Recupresult("Résistance", 2, valrésistance, SerialPort1.PortName)

                End If

                If Voie3RES.Checked = True Then

                    formmenu.carte.Recupresult("Résistance", 3, valrésistance, SerialPort1.PortName)

                End If

                If Voie4RES.Checked = True Then

                    formmenu.carte.Recupresult("Résistance", 4, valrésistance, SerialPort1.PortName)

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


    Private Sub TVTemp_CheckedChanged(sender As Object, e As EventArgs) Handles TVTemp.CheckedChanged
        If TVTemp.Checked = True Then
            Voie1Temp.Checked = True
            Voie2temp.Checked = True
            Voie3Temp.Checked = True
            Voie4Temp.Checked = True
        Else
            Voie1Temp.Checked = False
            Voie2temp.Checked = False
            Voie3Temp.Checked = False
            Voie4Temp.Checked = False
        End If
    End Sub


    Private Sub TVTension_CheckedChanged(sender As Object, e As EventArgs) Handles TVTension.CheckedChanged
        If TVTension.Checked = True Then
            Voie1Tension.Checked = True
            Voie2Tension.Checked = True
            Voie3Tension.Checked = True
            Voie4Tension.Checked = True
        Else
            Voie1Tension.Checked = False
            Voie2Tension.Checked = False
            Voie3Tension.Checked = False
            Voie4Tension.Checked = False
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

    Private Sub TVRES_CheckedChanged(sender As Object, e As EventArgs) Handles TVRES.CheckedChanged
        If TVRES.Checked = True Then
            Voie1RES.Checked = True
            Voie2RES.Checked = True
            Voie3RES.Checked = True
            Voie4RES.Checked = True
        Else
            Voie1RES.Checked = False
            Voie2RES.Checked = False
            Voie3RES.Checked = False
            Voie4RES.Checked = False
        End If
    End Sub

End Class