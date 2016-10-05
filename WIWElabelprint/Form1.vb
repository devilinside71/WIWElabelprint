Imports System.IO

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Icon = My.Resources.wiwelogo_41v_icon
        Call ZebraPrint.LoadLabels()
        Call ZebraPrint.LoadPrinters()
    End Sub

    Private Sub ButtonDatabaseArch_Click(sender As Object, e As EventArgs) Handles ButtonDatabaseArch.Click
        Call ArchiveDatabase()

    End Sub

    Private Sub ButtonPrinterTest_Click(sender As Object, e As EventArgs) Handles ButtonPrinterTest.Click

    End Sub

    Private Sub ButtonMain_Click(sender As Object, e As EventArgs) Handles ButtonMain.Click
        'Read from clipboard or file
        Dim strRes As String
        Dim blnValidID As Boolean
        TextBoxID.BackColor = Color.White
        If My.Settings.Clipboard = True Then
            strRes = LoadID.GetIDfromClipboard
            TextBoxLog.Text = TextBoxLog.Text & vbCrLf & Now & " Vágólapról:" & vbCrLf & strRes
        Else
            strRes = LoadID.GetIDfromFile
            TextBoxLog.Text = TextBoxLog.Text & vbCrLf & Now & " Fájlból:" & vbCrLf & My.Settings.IDFilePath & vbCrLf & strRes
        End If
        TextBoxID.Text = strRes
        blnValidID = LoadID.IsWiwe(strRes)
        If blnValidID Then
            TextBoxLog.Text = TextBoxLog.Text & vbCrLf & "ID OK"
            TextBoxID.BackColor = Color.Green
        Else
            TextBoxLog.Text = TextBoxLog.Text & vbCrLf & "ÉRVÉNYTELEN ID"
            TextBoxID.BackColor = Color.Red
        End If

        TextBoxLog.Text = TextBoxLog.Text & vbCrLf & "-----------------------"
    End Sub
    ''' <summary>
    ''' Execute database and printing operations
    ''' </summary>
    ''' <param name="wiwe_name">WIWE device name</param>
    ''' <param name="wiwe_mac">WIWE BT MAC address</param>
    Private Sub ProcessNewWIWE(wiwe_name As String, wiwe_mac As String)
        Call InsertWIWEData("WIWEdevices.s3db", wiwe_mac, wiwe_name)
        Call PrintZPL(wiwe_mac, 1)
    End Sub
    ''' <summary>
    ''' Prints label.
    ''' Replaces variables with parameters
    ''' </summary>
    ''' <param name="device_mac">Device MAC address</param>
    ''' <param name="qty">Quantity of labels</param>
    Public Sub PrintZPL(device_mac As String, qty As Integer)
        Dim s As String
        Dim pd As New PrintDialog()
        Dim res

        s = ZebraPrint.labelcodes(0)
        s = s.Replace("VONALKOD", device_mac)
        s = s.Replace("LABELQTY", Trim(CStr(qty)))

        'Console.WriteLine(s)
        'Debug.Print(s)
        ' Open the printer dialog box, and then allow the user to select a printer.
        res = ZebraPrint.SendStringToPrinter(ZebraPrint.PrinterWinNames(0), s)

    End Sub
    Private Sub ArchiveDatabase()
        Dim timeStamp As String = DateTime.Now.ToString("yyyyMMddhhmmss")
        Dim dt As DateTime = DateTime.ParseExact(timeStamp, "yyyyMMddhhmmss", Nothing)
        Dim strTimeStamp As String
        Dim newFileName As String
        Dim path As String = Directory.GetCurrentDirectory()
        Dim res As Integer

        res = MessageBox.Show("A meglévő adatbázis archiválásra kerül. Üres adatbázist akarsz használni?", "FIGYELEM!", MessageBoxButtons.YesNoCancel)

        If res = DialogResult.Yes Or res = DialogResult.No Then

            strTimeStamp = dt.ToString
            strTimeStamp = strTimeStamp.Replace(".", "")
            strTimeStamp = strTimeStamp.Replace(":", "")
            strTimeStamp = strTimeStamp.Replace(" ", "_")

            newFileName = path & "\Archive\WIWEdevices_" & strTimeStamp & ".s3db"

            Console.WriteLine(newFileName)
            File.Copy("WIWEdevices.s3db", newFileName, True)
            If res = DialogResult.Yes Then
                File.Copy(path & "\Lib\WIWEdevices.s3db", path & "\WIWEdevices.s3db", True)
            End If

            Dim FILE_NAME As String = path & "\Archive\WIWEdevices_" & strTimeStamp & ".log"
            File.Create(FILE_NAME).Dispose()
            If System.IO.File.Exists(FILE_NAME) = True Then

                Dim objWriter As New System.IO.StreamWriter(FILE_NAME)

                objWriter.Write(TextBoxLog.Text)
                objWriter.Close()
                Debug.Print("LOG file archiválva")

            Else

                Debug.Print("LOG file hiányzik")

            End If
        End If
    End Sub


    Private Sub TextBoxID_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxID.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBoxID.SelectAll()
        End If

    End Sub


    Private Sub TextBoxLog_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxLog.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBoxLog.SelectAll()
        End If

    End Sub
End Class
