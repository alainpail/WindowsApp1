Public Class Classcarte

    Private iden As String

    Private MT0 As String
    Private MT1 As String = "" 'résultat température voie 1
    Private MT2 As String = "" 'résultat température voie 2
    Private MT3 As String = "" 'résultat température voie 3
    Private MT4 As String = "" 'résultat température voie 4

    Private MR0 As String
    Private MR1 As String = "" 'résultat resistance voie 1
    Private MR2 As String = "" 'résultat resistance voie 2
    Private MR3 As String = "" 'résultat resistance voie 3
    Private MR4 As String = "" 'résultat resistance voie 4


    Private MU0 As String
    Private MU1 As String = "" 'résultat tension voie 1
    Private MU2 As String = "" 'résultat tension voie 2
    Private MU3 As String = "" 'résultat tension voie 3
    Private MU4 As String = "" 'résultat tension voie 4

    Private MI0 As String
    Private MI1 As String = "" 'résultat courant voie 1
    Private MI2 As String = "" 'résultat courant voie 2
    Private MI3 As String = "" 'résultat courant voie 3
    Private MI4 As String = "" 'résultat courant voie 4

    Public Function GetCarte() As String
        Return iden
    End Function

    Public Function SetCarte(cartedemo As String)
        iden = cartedemo
    End Function

    Public Function GetResult(ByVal Test As String, ByVal voie As Integer) As String
        'Renvoi les résultats souhaitées
        Select Case Test
            Case "Tension"
                Select Case voie
                    Case 1
                        Return MU1
                    Case 2
                        Return MU2
                    Case 3
                        Return MU3
                    Case 4
                        Return MU4
                End Select
            Case "Courant"
                Select Case voie
                    Case 1
                        Return MI1
                    Case 2
                        Return MI2
                    Case 3
                        Return MI3
                    Case 4
                        Return MI4
                End Select
            Case "Temperature"
                Select Case voie
                    Case 1
                        Return MT1
                    Case 2
                        Return MT2
                    Case 3
                        Return MT3
                    Case 4
                        Return MT4
                End Select
            Case "Resistance"
                Select Case voie
                    Case 1
                        Return MR1
                    Case 2
                        Return MR2
                    Case 3
                        Return MR3
                    Case 4
                        Return MR4
                End Select
        End Select
    End Function

    Function IdentificationCarte(numPort As String) As String
        'RECO-> (ChrW(&H52) & ChrW(&H45) & ChrW(&H43) & ChrW(&H4F))
        Dim Reponse As String = ""

        iden = FormSplash.port.EnvoieDatas((ChrW(&H52) & ChrW(&H45) & ChrW(&H43) & ChrW(&H4F)), numPort, 1000)

        Select Case iden
            Case "4AI"
                Reponse = "Carte 4AI "
            Case "4AO"
                Reponse = "Carte 4AO "
            Case "4DO"
                Reponse = "Carte 4DO "
            Case ""
                Reponse = ""
        End Select
        Return Reponse
    End Function

    Function Recupresult(ByVal test As String, ByVal voie As Integer, val As Integer, numPort As String)
        'envoie la requete de test correspondant a la carte et au voie
        'reçois les résultats des test
        Select Case iden
            Case "4AI"
                Select Case test
                    Case "Température"
                        Select Case voie
                            Case 0 'Toutes les voies selectionnée
                                MT0 = FormSplash.port.EnvoieDatas("MT0", numPort, 10000)
                                MT1 = MT0
                                MT2 = MT0
                                MT3 = MT0
                                MT4 = MT0
                            Case 1 'Voie 1 selectionnée
                                MT1 = FormSplash.port.EnvoieDatas("MT1", numPort, 5000)
                            Case 2 'Voie 2 selectionnée
                                MT2 = FormSplash.port.EnvoieDatas("MT2", numPort, 5000)
                            Case 3 'Voie 3 selectionnée
                                MT3 = FormSplash.port.EnvoieDatas("MT3", numPort, 5000)
                            Case 4 'Voie 4 selectionnée
                                MT4 = FormSplash.port.EnvoieDatas("MT4", numPort, 5000)
                        End Select
                    Case "Tension"
                        Select Case voie
                            Case 0
                                MU0 = FormSplash.port.EnvoieDatas("MU0", numPort, 10000)
                                MU1 = MU0
                                MU2 = MU0
                                MU3 = MU0
                                MU4 = MU0
                            Case 1
                                MU1 = FormSplash.port.EnvoieDatas("MU1", numPort, 5000)
                            Case 2
                                MU2 = FormSplash.port.EnvoieDatas("MU2", numPort, 5000)
                            Case 3
                                MU3 = FormSplash.port.EnvoieDatas("MU3", numPort, 5000)
                            Case 4
                                MU4 = FormSplash.port.EnvoieDatas("MU4", numPort, 5000)
                        End Select
                    Case "Courant"
                        Select Case voie
                            Case 0
                                MI0 = FormSplash.port.EnvoieDatas("MI0" & val, numPort, 10000)
                                MI1 = MI0
                                MI2 = MI0
                                MI3 = MI0
                                MI4 = MI0
                            Case 1
                                MI1 = FormSplash.port.EnvoieDatas("MI1" & val, numPort, 5000)
                            Case 2
                                MI2 = FormSplash.port.EnvoieDatas("MI2" & val, numPort, 5000)
                            Case 3
                                MI3 = FormSplash.port.EnvoieDatas("MI3" & val, numPort, 5000)
                            Case 4
                                MI4 = FormSplash.port.EnvoieDatas("MI4" & val, numPort, 5000)
                        End Select
                    Case "Résistance"
                        Select Case voie
                            Case 0
                                MR0 = FormSplash.port.EnvoieDatas("MR0" & val, numPort, 10000)
                                MR1 = MR0
                                MR2 = MR0
                                MR3 = MR0
                                MR4 = MR0
                            Case 1
                                MR1 = FormSplash.port.EnvoieDatas("MR1" & val, numPort, 5000)
                            Case 2
                                MR2 = FormSplash.port.EnvoieDatas("MR2" & val, numPort, 5000)
                            Case 3
                                MR3 = FormSplash.port.EnvoieDatas("MR3" & val, numPort, 5000)
                            Case 4
                                MR4 = FormSplash.port.EnvoieDatas("MR4" & val, numPort, 5000)
                        End Select
                End Select
            Case "4AO"
                Select Case test
                    Case "Tension"
                        Select Case voie
                            Case 0
                                MU0 = FormSplash.port.EnvoieDatas("MU0", numPort, 10000)
                                MU1 = MU0
                                MU2 = MU0
                                MU3 = MU0
                                MU4 = MU0
                            Case 1
                                MU1 = FormSplash.port.EnvoieDatas("MU1", numPort, 5000)
                            Case 2
                                MU2 = FormSplash.port.EnvoieDatas("MU2", numPort, 5000)
                            Case 3
                                MU3 = FormSplash.port.EnvoieDatas("MU3", numPort, 5000)
                            Case 4
                                MU4 = FormSplash.port.EnvoieDatas("MU4", numPort, 5000)
                        End Select
                    Case "Courant"
                        Select Case voie
                            Case 0
                                MI0 = FormSplash.port.EnvoieDatas("MI0", numPort, 10000)
                                MI1 = MI0
                                MI2 = MI0
                                MI3 = MI0
                                MI4 = MI0
                            Case 1
                                MI1 = FormSplash.port.EnvoieDatas("MI1", numPort, 5000)
                            Case 2
                                MI2 = FormSplash.port.EnvoieDatas("MI2", numPort, 5000)
                            Case 3
                                MI3 = FormSplash.port.EnvoieDatas("MI3", numPort, 5000)
                            Case 4
                                MI4 = FormSplash.port.EnvoieDatas("MI4", numPort, 5000)
                        End Select
                End Select
            Case "4DO"
                Select Case test
                    Case "Tension"
                        Select Case voie
                            Case 0
                                MU0 = FormSplash.port.EnvoieDatas("MU0", numPort, 10000)
                                MU1 = MU0
                                MU2 = MU0
                                MU3 = MU0
                                MU4 = MU0
                            Case 1
                                MU1 = FormSplash.port.EnvoieDatas("MU1", numPort, 5000)
                            Case 2
                                MU2 = FormSplash.port.EnvoieDatas("MU2", numPort, 5000)
                            Case 3
                                MU3 = FormSplash.port.EnvoieDatas("MU3", numPort, 5000)
                            Case 4
                                MU4 = FormSplash.port.EnvoieDatas("MU4", numPort, 5000)
                        End Select
                    Case "Courant"
                        Select Case voie
                            Case 0
                                MI0 = FormSplash.port.EnvoieDatas("MI1", numPort, 10000)
                                MI1 = MI0
                                MI2 = MI0
                                MI3 = MI0
                                MI4 = MI0
                            Case 1
                                MI1 = FormSplash.port.EnvoieDatas("MI1", numPort, 5000)
                            Case 2
                                MI2 = FormSplash.port.EnvoieDatas("MI2", numPort, 5000)
                            Case 3
                                MI3 = FormSplash.port.EnvoieDatas("MI3", numPort, 5000)
                            Case 4
                                MI4 = FormSplash.port.EnvoieDatas("MI4", numPort, 5000)
                        End Select
                End Select
        End Select
    End Function

    Function Recupresultdemo(ByVal test As String, ByVal voie As Integer)
        'envoie la requete de test correspondant a la carte et au voie
        'reçois les résultats des test
        Select Case iden
            Case "4AI"
                Select Case test
                    Case "Température"
                        Select Case voie
                            Case 0 'Toutes les voies selectionnée
                                MT0 = resultat()
                                MT1 = MT0
                                MT2 = MT0
                                MT3 = MT0
                                MT4 = MT0
                            Case 1 'Voie 1 selectionnée
                                MT1 = resultat()
                            Case 2 'Voie 2 selectionnée
                                MT2 = resultat()
                            Case 3 'Voie 3 selectionnée
                                MT3 = resultat()
                            Case 4 'Voie 4 selectionnée
                                MT4 = resultat()
                        End Select
                    Case "Tension"
                        Select Case voie
                            Case 0
                                MU0 = resultat()
                                MU1 = MU0
                                MU2 = MU0
                                MU3 = MU0
                                MU4 = MU0
                            Case 1
                                MU1 = resultat()
                            Case 2
                                MU2 = resultat()
                            Case 3
                                MU3 = resultat()
                            Case 4
                                MU4 = resultat()
                        End Select
                    Case "Courant"
                        Select Case voie
                            Case 0
                                MI0 = resultat()
                                MI1 = MI0
                                MI2 = MI0
                                MI3 = MI0
                                MI4 = MI0
                            Case 1
                                MI1 = resultat()
                            Case 2
                                MI2 = resultat()
                            Case 3
                                MI3 = resultat()
                            Case 4
                                MI4 = resultat()
                        End Select
                    Case "Résistance"
                        Select Case voie
                            Case 0
                                MR0 = resultat()
                                MR1 = MR0
                                MR2 = MR0
                                MR3 = MR0
                                MR4 = MR0
                            Case 1
                                MR1 = resultat()
                            Case 2
                                MR2 = resultat()
                            Case 3
                                MR3 = resultat()
                            Case 4
                                MR4 = resultat()
                        End Select
                End Select
            Case "4AO"
                Select Case test
                    Case "Tension"
                        Select Case voie
                            Case 0
                                MU0 = resultat()
                                MU1 = MU0
                                MU2 = MU0
                                MU3 = MU0
                                MU4 = MU0
                            Case 1
                                MU1 = resultat()
                            Case 2
                                MU2 = resultat()
                            Case 3
                                MU3 = resultat()
                            Case 4
                                MU4 = resultat()
                        End Select
                    Case "Courant"
                        Select Case voie
                            Case 0
                                MI0 = resultat()
                                MI1 = MI0
                                MI2 = MI0
                                MI3 = MI0
                                MI4 = MI0
                            Case 1

                                MI1 = resultat()
                            Case 2

                                MI2 = resultat()
                            Case 3

                                MI3 = resultat()
                            Case 4

                                MI4 = resultat()
                        End Select
                End Select
            Case "4DO"
                Select Case test
                    Case "Tension"
                        Select Case voie
                            Case 0
                                MU0 = resultat()
                                MU1 = MU0
                                MU2 = MU0
                                MU3 = MU0
                                MU4 = MU0
                            Case 1
                                MU1 = resultat()
                            Case 2
                                MU2 = resultat()
                            Case 3
                                MU3 = resultat()
                            Case 4
                                MU4 = resultat()
                        End Select
                    Case "Courant"
                        Select Case voie
                            Case 0
                                MI0 = resultat()
                                MI1 = MI0
                                MI2 = MI0
                                MI3 = MI0
                                MI4 = MI0
                            Case 1
                                MI1 = resultat()
                            Case 2
                                MI2 = resultat()
                            Case 3
                                MI3 = resultat()
                            Case 4
                                MI4 = resultat()
                        End Select
                End Select
        End Select
    End Function
    Function resultat()
        Dim result As String
        Dim valrandom As Integer = CInt(Math.Floor((1 - 0 + 1) * Rnd()))
        Select Case valrandom
            Case 0
                result = "HS"
            Case 1
                result = "OK"
        End Select
        Return result
    End Function

End Class
