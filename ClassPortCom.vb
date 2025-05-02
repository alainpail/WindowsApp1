Imports System.IO.Ports

Public Class ClassPortCom
    Private PortSerie As New SerialPort

    Public Function GetPortCom() As String
        Return PortSerie.PortName 'affecté par la fonction DetectPortCom()
    End Function
    Private Function ConfigPort(numPort As String) As Boolean
        'tente de configurer le port passé en paramètre
        'laisse le port fermé
        'renvoi TRUE si port OK, FALSE sinon

        FermePort()

        PortSerie.PortName = numPort

        Try
            If (PortSerie.IsOpen) Then PortSerie.Close()

            With PortSerie
                .BaudRate = 57600 '9600 baud pour l'arduino et 57600 pour le PSOC
                .DataBits = 8
                .Parity = IO.Ports.Parity.None
                .StopBits = IO.Ports.StopBits.One
                .Handshake = IO.Ports.Handshake.None
            End With

            FermePort()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function
    Public Function DetectPortCom() As String
        'renvoi le port com sur lequel est connecté le PSOC
        ' si rien trouvé renvoi ""

        Dim portTrouve As String
        portTrouve = ""

        For Each PortCom In My.Computer.Ports.SerialPortNames

            If TestPortCom(PortCom) Then
                portTrouve = PortCom
                Exit For
            End If
        Next

        Return portTrouve

    End Function
    Public Function TestPortCom(ByVal portCom As String) As Boolean
        ' teste le port com passé en parmètre en espérant une réponse du PSOC
        ' renvoi true si PSoc trouvé, false sinon

        Dim reponse As Boolean
        reponse = False


        If ConfigPort(portCom) = True Then
            'PSOC -> (ChrW(&H50) & ChrW(&H53) & ChrW(&H4F) & ChrW(&H43))
            If EnvoieDatas((ChrW(&H50) & ChrW(&H53) & ChrW(&H4F) & ChrW(&H43)), portCom, 1000) = "OUI" Then reponse = True
        End If

            Return reponse

    End Function
    Public Function EnvoieDatas(strData As String, port As String, timer As Integer) As String
        ' envoi donnée au port com
        ' strData : données à envoyer
        ' renvoi la réponse, ou "" si pas de réponse ou problème
        ' Ferme le port
        ' configure le port
        ' envoi les données
        ' reçoit la réponse
        ' ferme le port
        ' retourne la réponse

        Dim returnStr As String = ""

        FermePort() 'appel de la fonction afin de s'assurer que le port com est bien fermé
        ConfigPort(port) 'configure le port COM

        PortSerie.Open()
        PortSerie.WriteLine(strData) 'envoi de la chaine de caractère
        PortSerie.WriteLine(ChrW(&H0))
        Try
            PortSerie.ReadTimeout = timer
            returnStr = PortSerie.ReadLine() 'lecture de la réponse
        Catch ex As TimeoutException
            returnStr = ""
        End Try

        FermePort()
        Return returnStr

    End Function
    Public Function FermePort() As Boolean

        Try
            'tente fermeture port :
            If (PortSerie.IsOpen = True) Then PortSerie.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

End Class
