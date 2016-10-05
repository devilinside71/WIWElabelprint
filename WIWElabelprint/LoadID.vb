Module LoadID


    Public Function GetIDfromClipboard() As String
        Dim strRes As String
        strRes = My.Computer.Clipboard.GetText
        Return strRes
    End Function
    Public Function GetIDfromFile() As String
        Dim strRes As String
        Dim objReader As New System.IO.StreamReader(My.Settings.IDFilePath)
        strRes = objReader.ReadLine()
        objReader.Close()
        Return strRes
    End Function

    ''' <summary>
    ''' Determine if device is a WIWE based on device name and chipset manufacturer
    ''' </summary>
    ''' <param name="device_nap">Chipset manufacturer NAP code</param>
    ''' <returns>True if device is a WIWE</returns>
    Public Function IsWiwe(device_nap As String) As Boolean
        'Ellenőrzi, hogy WIWE-e
        '1., WIWE a kezdete a névnek
        '2., B0B4 a BT chip gyártója
        Dim res As Boolean
        device_nap = Left(device_nap, 4)
        res = False
        If device_nap = "B0B4" Then
            res = True
        End If

        Return res
    End Function

End Module
