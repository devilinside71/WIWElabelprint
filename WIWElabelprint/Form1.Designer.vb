<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonMain = New System.Windows.Forms.Button()
        Me.TextBoxID = New System.Windows.Forms.TextBox()
        Me.TextBoxLog = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonPrinterTest = New System.Windows.Forms.Button()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonDatabaseArch = New System.Windows.Forms.Button()
        Me.NumericUpDownQty = New System.Windows.Forms.NumericUpDown()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.NumericUpDownQty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonMain, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxID, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxLog, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.64384!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.21918!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(616, 365)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.WIWElabelprint.My.Resources.Resources.SM_kicsi
        Me.PictureBox1.Location = New System.Drawing.Point(465, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(148, 73)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ButtonMain
        '
        Me.ButtonMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ButtonMain.Location = New System.Drawing.Point(3, 258)
        Me.ButtonMain.Name = "ButtonMain"
        Me.ButtonMain.Size = New System.Drawing.Size(456, 104)
        Me.ButtonMain.TabIndex = 1
        Me.ButtonMain.Text = "Beolvas és Nyomtat"
        Me.ButtonMain.UseVisualStyleBackColor = True
        '
        'TextBoxID
        '
        Me.TextBoxID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxID.Font = New System.Drawing.Font("Courier New", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TextBoxID.Location = New System.Drawing.Point(3, 3)
        Me.TextBoxID.Name = "TextBoxID"
        Me.TextBoxID.Size = New System.Drawing.Size(456, 44)
        Me.TextBoxID.TabIndex = 2
        '
        'TextBoxLog
        '
        Me.TextBoxLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxLog.Font = New System.Drawing.Font("Courier New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TextBoxLog.Location = New System.Drawing.Point(3, 82)
        Me.TextBoxLog.Multiline = True
        Me.TextBoxLog.Name = "TextBoxLog"
        Me.TextBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBoxLog.Size = New System.Drawing.Size(456, 170)
        Me.TextBoxLog.TabIndex = 3
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.ButtonPrinterTest, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(465, 258)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(148, 100)
        Me.TableLayoutPanel2.TabIndex = 4
        '
        'ButtonPrinterTest
        '
        Me.ButtonPrinterTest.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonPrinterTest.Location = New System.Drawing.Point(3, 3)
        Me.ButtonPrinterTest.Name = "ButtonPrinterTest"
        Me.ButtonPrinterTest.Size = New System.Drawing.Size(142, 44)
        Me.ButtonPrinterTest.TabIndex = 0
        Me.ButtonPrinterTest.Text = "Nyomtató teszt"
        Me.ButtonPrinterTest.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.ButtonDatabaseArch, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.NumericUpDownQty, 0, 2)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(465, 82)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(148, 170)
        Me.TableLayoutPanel3.TabIndex = 5
        '
        'ButtonDatabaseArch
        '
        Me.ButtonDatabaseArch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonDatabaseArch.Location = New System.Drawing.Point(3, 3)
        Me.ButtonDatabaseArch.Name = "ButtonDatabaseArch"
        Me.ButtonDatabaseArch.Size = New System.Drawing.Size(142, 50)
        Me.ButtonDatabaseArch.TabIndex = 0
        Me.ButtonDatabaseArch.Text = "Adatbázis archiválása"
        Me.ButtonDatabaseArch.UseVisualStyleBackColor = True
        '
        'NumericUpDownQty
        '
        Me.NumericUpDownQty.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NumericUpDownQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.NumericUpDownQty.Location = New System.Drawing.Point(3, 115)
        Me.NumericUpDownQty.Name = "NumericUpDownQty"
        Me.NumericUpDownQty.Size = New System.Drawing.Size(142, 47)
        Me.NumericUpDownQty.TabIndex = 1
        Me.NumericUpDownQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumericUpDownQty.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 365)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Form1"
        Me.Text = "WIWE Eszköz-azonosító nyomtató"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.NumericUpDownQty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ButtonMain As Button
    Friend WithEvents TextBoxID As TextBox
    Friend WithEvents TextBoxLog As TextBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents ButtonPrinterTest As Button
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents ButtonDatabaseArch As Button
    Friend WithEvents NumericUpDownQty As NumericUpDown
End Class
