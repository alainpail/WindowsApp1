Imports System.IO.Ports
Module ModuleCOM
    Dim iden As Integer
    Dim sp As String
    Dim recu As String = ""
    Dim attendu As String = ""
    Function id(ByVal x As Integer)
        If iden = Nothing Then
            iden = x
        End If
        Return iden
    End Function

    Function detectPort() As String
        ' scanne tous les ports COm existants de la machine et renvoie le port sur lequel est connecté le PSOCK
        For Each sp In My.Computer.Ports.SerialPortNames

            Using PortSerie As IO.Ports.SerialPort = My.Computer.Ports.OpenSerialPort(sp)
                PortSerie.WriteLine("")
            End Using

            recu = ReceiveSerialData(sp)

            If recu = attendu Then
                Exit For
            End If

        Next
        Return sp
    End Function


    Function ReceiveSerialData(ByVal sp As String) As String
        ' Receive strings from a serial port.
        Dim returnStr As String = ""

        Dim com1 As IO.Ports.SerialPort = Nothing
        Try
            com1 = My.Computer.Ports.OpenSerialPort(sp)
            com1.ReadTimeout = 10000
            Do
                Dim Incoming As String = com1.ReadLine()
                If Incoming Is Nothing Then
                    Exit Do
                Else
                    returnStr &= Incoming & vbCrLf
                End If
            Loop
        Catch ex As TimeoutException
            returnStr = "Error: Serial Port read timed out."
        Finally
            If com1 IsNot Nothing Then com1.Close()
        End Try

        Return returnStr
    End Function





End Module
