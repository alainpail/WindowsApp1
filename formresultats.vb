Public Class formresultats
    Private Sub Formresultats_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim versionapp As String

        Try
            versionapp = My.Application.Deployment.CurrentVersion.ToString

        Catch ex As Exception
            versionapp = My.Application.Info.Version.ToString
        End Try

        Label36.Text = "v" & versionapp

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
                Label5.Text = formmenu.carte.GetCarte
            End If

        End If

        Select Case formmenu.carte.GetCarte()

            Case "4AI"
                Label5.Text = "Carte 4AI"
            Case "4AO"
                Label5.Text = "Carte 4AO"
            Case "4DO"
                Label5.Text = "Carte 4DO"
            Case ""
                MessageBox.Show("ERREUR, la Carte n'a pas été détectée ou n'est pas reconnue")

        End Select

    End Sub

    Private Sub Btnresult_Click(sender As Object, e As EventArgs) Handles Btnresult.Click

        Select Case formmenu.carte.GetCarte

            Case "4AI"

                resultat4AItemp1.Text = formmenu.carte.GetResult("Temperature", 1)
                resultat4AItemp2.Text = formmenu.carte.GetResult("Temperature", 2)
                resultat4AItemp3.Text = formmenu.carte.GetResult("Temperature", 3)
                resultat4AItemp4.Text = formmenu.carte.GetResult("Temperature", 4)

                result4AITension1.Text = formmenu.carte.GetResult("Tension", 1)
                result4AITension2.Text = formmenu.carte.GetResult("Tension", 2)
                result4AITension3.Text = formmenu.carte.GetResult("Tension", 3)
                result4AITension4.Text = formmenu.carte.GetResult("Tension", 4)

                result4AICourant1.Text = formmenu.carte.GetResult("Courant", 1)
                result4AICourant2.Text = formmenu.carte.GetResult("Courant", 2)
                result4AICourant3.Text = formmenu.carte.GetResult("Courant", 3)
                result4AICourant4.Text = formmenu.carte.GetResult("Courant", 4)

                result4AIRES1.Text = formmenu.carte.GetResult("Resistance", 1)
                result4AIRES2.Text = formmenu.carte.GetResult("Resistance", 2)
                result4AIRES3.Text = formmenu.carte.GetResult("Resistance", 3)
                result4AIRES4.Text = formmenu.carte.GetResult("Resistance", 4)

            Case "4AO"

                result4AOTension1.Text = formmenu.carte.GetResult("Tension", 1)
                result4AOTension2.Text = formmenu.carte.GetResult("Tension", 2)
                result4AOTension3.Text = formmenu.carte.GetResult("Tension", 3)
                result4AOTension4.Text = formmenu.carte.GetResult("Tension", 4)

                result4AOCourant1.Text = formmenu.carte.GetResult("Courant", 1)
                result4AOCourant2.Text = formmenu.carte.GetResult("Courant", 2)
                result4AOCourant3.Text = formmenu.carte.GetResult("Courant", 3)
                result4AOCourant4.Text = formmenu.carte.GetResult("Courant", 4)

            Case "4DO"

                result4DOTension1.Text = formmenu.carte.GetResult("Tension", 1)
                result4DOTension2.Text = formmenu.carte.GetResult("Tension", 2)
                result4DOTension3.Text = formmenu.carte.GetResult("Tension", 3)
                result4DOTension4.Text = formmenu.carte.GetResult("Tension", 4)

                result4DOCourant1.Text = formmenu.carte.GetResult("Courant", 1)
                result4DOCourant2.Text = formmenu.carte.GetResult("Courant", 2)
                result4DOCourant3.Text = formmenu.carte.GetResult("Courant", 3)
                result4DOCourant4.Text = formmenu.carte.GetResult("Courant", 3)

        End Select

    End Sub

    Private Sub Btnenregistrer_Click(sender As Object, e As EventArgs) Handles Btnenregistrer.Click

        Dim file As System.IO.StreamWriter
        Dim OpenFile As New OpenFileDialog
        'Dim datadujour As String=
        My.Computer.FileSystem.CreateDirectory("C:\SofrelTest\tests")
        file = My.Computer.FileSystem.OpenTextFileWriter("C:\SofrelTest\tests\test" & DateString & ".txt", True)

        Select Case formmenu.carte.GetCarte()

            Case "4AI"

                file.WriteLine("Résultats des tests sur la carte 4AI à " & Format(Now, "HH:mm:ss"))
                file.WriteLine("Température:")
                file.WriteLine("voie 1: " & formmenu.carte.GetResult("Temperature", 1))
                file.WriteLine("voie 2: " & formmenu.carte.GetResult("Temperature", 2))
                file.WriteLine("voie 3: " & formmenu.carte.GetResult("Temperature", 3))
                file.WriteLine("voie 4: " & formmenu.carte.GetResult("Temperature", 4))
                file.WriteLine("Courant:")
                file.WriteLine("voie 1: " & formmenu.carte.GetResult("Courant", 1))
                file.WriteLine("voie 2: " & formmenu.carte.GetResult("Courant", 2))
                file.WriteLine("voie 3: " & formmenu.carte.GetResult("Courant", 3))
                file.WriteLine("voie 4: " & formmenu.carte.GetResult("Courant", 4))
                file.WriteLine("Tension:")
                file.WriteLine("voie 1: " & formmenu.carte.GetResult("Tension", 1))
                file.WriteLine("voie 2: " & formmenu.carte.GetResult("Tension", 2))
                file.WriteLine("voie 3: " & formmenu.carte.GetResult("Tension", 3))
                file.WriteLine("voie 4: " & formmenu.carte.GetResult("Tension", 4))
                file.WriteLine("Résistance:")
                file.WriteLine("voie 1: " & formmenu.carte.GetResult("Resistance", 1))
                file.WriteLine("voie 2: " & formmenu.carte.GetResult("Resistance", 2))
                file.WriteLine("voie 3: " & formmenu.carte.GetResult("Resistance", 3))
                file.WriteLine("voie 4: " & formmenu.carte.GetResult("Resistance", 4))
                file.WriteLine("")

            Case "4AO"

                file.WriteLine("Résultats des tests sur la carte 4AO à " & Format(Now, "HH:mm:ss"))
                file.WriteLine("Courant:")
                file.WriteLine("voie 1: " & formmenu.carte.GetResult("Courant", 1))
                file.WriteLine("voie 2: " & formmenu.carte.GetResult("Courant", 2))
                file.WriteLine("voie 3: " & formmenu.carte.GetResult("Courant", 3))
                file.WriteLine("voie 4: " & formmenu.carte.GetResult("Courant", 4))
                file.WriteLine("Tension:")
                file.WriteLine("voie 1: " & formmenu.carte.GetResult("Tension", 1))
                file.WriteLine("voie 2: " & formmenu.carte.GetResult("Tension", 2))
                file.WriteLine("voie 3: " & formmenu.carte.GetResult("Tension", 3))
                file.WriteLine("voie 4: " & formmenu.carte.GetResult("Tension", 4))
                file.WriteLine("")

            Case "4DO"

                file.WriteLine("Résultats des tests sur la carte 4DO à " & Format(Now, "HH:mm:ss"))
                file.WriteLine("Courant:")
                file.WriteLine("voie 1:" & formmenu.carte.GetResult("Courant", 1))
                file.WriteLine("voie 2:" & formmenu.carte.GetResult("Courant", 2))
                file.WriteLine("voie 3:" & formmenu.carte.GetResult("Courant", 3))
                file.WriteLine("voie 4:" & formmenu.carte.GetResult("Courant", 4))
                file.WriteLine("Tension:")
                file.WriteLine("voie 1:" & formmenu.carte.GetResult("Tension", 1))
                file.WriteLine("voie 2:" & formmenu.carte.GetResult("Tension", 2))
                file.WriteLine("voie 3:" & formmenu.carte.GetResult("Tension", 3))
                file.WriteLine("voie 4:" & formmenu.carte.GetResult("Tension", 4))
                file.WriteLine("")

        End Select

        file.Close()

        OpenFile.InitialDirectory = "C:\SofrelTest\tests"
        OpenFile.FileName = ""
        OpenFile.Filter = "Fichier Text (*.txt)|*.txt|Tous Les Fichiers(*.*)|*.*"
        OpenFile.ShowDialog()
        Try
            Dim lire As New System.IO.StreamReader(OpenFile.FileName)
            lire.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BtnRetourTests_Click(sender As Object, e As EventArgs) Handles BtnRetourTests.Click

        Select Case formmenu.carte.GetCarte

            Case "4AI"

                Me.Close()
                Carte4ai.Visible = True

            Case "4AO"

                Me.Close()
                Carte_4AO.Visible = True

            Case "4DO"

                Me.Close()
                Carte_4DO.Visible = True

        End Select

    End Sub

    Private Sub Btnretourmenu_Click(sender As Object, e As EventArgs) Handles Btnretourmenu.Click

        Me.Close()
        formmenu.Visible = True

    End Sub

    Private Sub TimerTest_Tick(sender As Object, e As EventArgs) Handles TimerTest.Tick

        If FormSplash.port.DetectPortCom() = "" Then

            MessageBox.Show("ERREUR, le PSOC n'a pas été trouvé,vérifiez si il est connecté au port com:")
            Label1.Text = "COM"
            TimerTest.Enabled = False

        Else

            SerialPort1.PortName = FormSplash.port.GetPortCom
            Label1.Text = SerialPort1.PortName

        End If

    End Sub

    Private Sub Btnreconnexion_Click(sender As Object, e As EventArgs) Handles Btnreconnexion.Click

        If FormSplash.port.DetectPortCom() = "" Then

            MessageBox.Show("ERREUR, le PSOC n'a pas été trouvé,vérifiez si il est connecté")
            Label4.Text = "COM"

        Else

            MessageBox.Show("Le PSOC est connecté au port :" & FormSplash.port.GetPortCom)
            Label4.Text = FormSplash.port.GetPortCom

        End If
    End Sub

End Class