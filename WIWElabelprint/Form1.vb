Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Icon = My.Resources.wiwelogo_41v_icon
    End Sub

    Private Sub ButtonDatabaseArch_Click(sender As Object, e As EventArgs) Handles ButtonDatabaseArch.Click

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
End Class
