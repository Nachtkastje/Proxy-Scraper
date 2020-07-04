<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.httpradio = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.socks4radio = New System.Windows.Forms.RadioButton()
        Me.socks5radio = New System.Windows.Forms.RadioButton()
        Me.ScrapeButton = New System.Windows.Forms.Button()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.TimeoutLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'httpradio
        '
        Me.httpradio.AutoSize = True
        Me.httpradio.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.httpradio.ForeColor = System.Drawing.Color.Black
        Me.httpradio.Location = New System.Drawing.Point(284, 38)
        Me.httpradio.Name = "httpradio"
        Me.httpradio.Size = New System.Drawing.Size(87, 22)
        Me.httpradio.TabIndex = 0
        Me.httpradio.TabStop = True
        Me.httpradio.Text = "HTTP(S)"
        Me.httpradio.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(280, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Choose type:"
        '
        'socks4radio
        '
        Me.socks4radio.AutoSize = True
        Me.socks4radio.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.socks4radio.ForeColor = System.Drawing.Color.Black
        Me.socks4radio.Location = New System.Drawing.Point(284, 61)
        Me.socks4radio.Name = "socks4radio"
        Me.socks4radio.Size = New System.Drawing.Size(83, 22)
        Me.socks4radio.TabIndex = 2
        Me.socks4radio.TabStop = True
        Me.socks4radio.Text = "Socks 4"
        Me.socks4radio.UseVisualStyleBackColor = True
        '
        'socks5radio
        '
        Me.socks5radio.AutoSize = True
        Me.socks5radio.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.socks5radio.ForeColor = System.Drawing.Color.Black
        Me.socks5radio.Location = New System.Drawing.Point(284, 84)
        Me.socks5radio.Name = "socks5radio"
        Me.socks5radio.Size = New System.Drawing.Size(83, 22)
        Me.socks5radio.TabIndex = 3
        Me.socks5radio.TabStop = True
        Me.socks5radio.Text = "Socks 5"
        Me.socks5radio.UseVisualStyleBackColor = True
        '
        'ScrapeButton
        '
        Me.ScrapeButton.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScrapeButton.Location = New System.Drawing.Point(284, 186)
        Me.ScrapeButton.Name = "ScrapeButton"
        Me.ScrapeButton.Size = New System.Drawing.Size(267, 32)
        Me.ScrapeButton.TabIndex = 4
        Me.ScrapeButton.Text = "Start"
        Me.ScrapeButton.UseVisualStyleBackColor = True
        '
        'TrackBar1
        '
        Me.TrackBar1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TrackBar1.Location = New System.Drawing.Point(284, 135)
        Me.TrackBar1.Maximum = 10000
        Me.TrackBar1.Minimum = 1
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(267, 45)
        Me.TrackBar1.TabIndex = 5
        Me.TrackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        Me.TrackBar1.Value = 10000
        '
        'TimeoutLabel
        '
        Me.TimeoutLabel.AutoSize = True
        Me.TimeoutLabel.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold)
        Me.TimeoutLabel.ForeColor = System.Drawing.Color.Black
        Me.TimeoutLabel.Location = New System.Drawing.Point(439, 88)
        Me.TimeoutLabel.Name = "TimeoutLabel"
        Me.TimeoutLabel.Size = New System.Drawing.Size(65, 44)
        Me.TimeoutLabel.TabIndex = 6
        Me.TimeoutLabel.Text = "" & Global.Microsoft.VisualBasic.ChrW(10) & "10000" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(1, 186)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(260, 32)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Proxies are automatically saved in a .txt file" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Proxy Scraper by EatMyHitzz" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(280, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 22)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Choose timeout:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(976, 9)
        Me.Panel1.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Proxy_Scraper.My.Resources.Resources.internet
        Me.PictureBox1.Location = New System.Drawing.Point(1, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(122, 95)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(2, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 22)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Proxy Scraper"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 226)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ScrapeButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TimeoutLabel)
        Me.Controls.Add(Me.socks4radio)
        Me.Controls.Add(Me.socks5radio)
        Me.Controls.Add(Me.httpradio)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proxy Scraper by EatMyHitzz"
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents httpradio As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents socks4radio As RadioButton
    Friend WithEvents socks5radio As RadioButton
    Friend WithEvents ScrapeButton As Button
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents TimeoutLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
End Class
