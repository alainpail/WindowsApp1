Public Class Form2
    Dim iden As Integer
    Dim Err As Boolean

    Private Sub btn4AI_Click(sender As Object, e As EventArgs) Handles btn4AI.Click
        Me.Hide()
        Carte4ai.Show()
    End Sub
    Private Sub btn4AO_Click(sender As Object, e As EventArgs) Handles btn4AO.Click
        Me.Hide()
        Carte_4AO.Show()
    End Sub
    Private Sub btn4DO_Click(sender As Object, e As EventArgs) Handles btn4DO.Click
        Me.Hide()
        Carte_4DO.Show()
    End Sub

    'Private Sub SerialPort1_DataReceived(sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
    '    iden = SerialPort1.ReadLine
    '    If iden = 1 Then
    '        Carte4ai.Show()
    '        Me.Hide()
    '    ElseIf iden = 2 Then
    '        Carte_4AO.Show()
    '        Me.Hide()
    '    ElseIf iden = 3 Then
    '        Carte_4DO.Show()
    '        Me.Hide()
    '    Else Err = 0
    '    End If
    'End Sub
End Class