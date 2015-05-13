<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Einstellungen = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Server = New System.Windows.Forms.TabPage()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.hhhh = New System.Windows.Forms.TabControl()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Einstellungen.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Server.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hhhh.SuspendLayout()
        Me.SuspendLayout()
        '
        'Einstellungen
        '
        Me.Einstellungen.BackgroundImage = CType(resources.GetObject("Einstellungen.BackgroundImage"), System.Drawing.Image)
        Me.Einstellungen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Einstellungen.Controls.Add(Me.PictureBox1)
        Me.Einstellungen.Controls.Add(Me.Label4)
        Me.Einstellungen.Controls.Add(Me.TextBox3)
        Me.Einstellungen.Controls.Add(Me.Label2)
        Me.Einstellungen.Controls.Add(Me.TextBox2)
        Me.Einstellungen.Controls.Add(Me.TextBox1)
        Me.Einstellungen.Controls.Add(Me.Label1)
        Me.Einstellungen.Location = New System.Drawing.Point(4, 31)
        Me.Einstellungen.Name = "Einstellungen"
        Me.Einstellungen.Padding = New System.Windows.Forms.Padding(3)
        Me.Einstellungen.Size = New System.Drawing.Size(779, 436)
        Me.Einstellungen.TabIndex = 1
        Me.Einstellungen.Text = "Einstellungen"
        Me.Einstellungen.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(249, 225)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(400, 200)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(28, 218)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "CPU Kerne (1-8)"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Location = New System.Drawing.Point(31, 254)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(80, 22)
        Me.TextBox3.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(28, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Zusätzliche Parameter :"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Location = New System.Drawing.Point(31, 175)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(431, 22)
        Me.TextBox2.TabIndex = 5
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Location = New System.Drawing.Point(30, 96)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(432, 22)
        Me.TextBox1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(27, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(329, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Arma 3 Pfad (Wird Automatisch eingetragen):"
        '
        'Server
        '
        Me.Server.BackColor = System.Drawing.Color.Transparent
        Me.Server.BackgroundImage = CType(resources.GetObject("Server.BackgroundImage"), System.Drawing.Image)
        Me.Server.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Server.Controls.Add(Me.WebBrowser1)
        Me.Server.Controls.Add(Me.PictureBox4)
        Me.Server.Controls.Add(Me.Label5)
        Me.Server.Controls.Add(Me.Button1)
        Me.Server.Controls.Add(Me.ListBox1)
        Me.Server.Controls.Add(Me.PictureBox3)
        Me.Server.Controls.Add(Me.LinkLabel3)
        Me.Server.Controls.Add(Me.LinkLabel2)
        Me.Server.Controls.Add(Me.LinkLabel1)
        Me.Server.Controls.Add(Me.PictureBox2)
        Me.Server.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Server.ImageIndex = 0
        Me.Server.Location = New System.Drawing.Point(4, 31)
        Me.Server.Name = "Server"
        Me.Server.Padding = New System.Windows.Forms.Padding(3)
        Me.Server.Size = New System.Drawing.Size(779, 436)
        Me.Server.TabIndex = 0
        Me.Server.Text = "Server "
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(19, 256)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScrollBarsEnabled = False
        Me.WebBrowser1.Size = New System.Drawing.Size(450, 56)
        Me.WebBrowser1.TabIndex = 16
        Me.WebBrowser1.Url = New System.Uri("http://leschi.bplaced.com/tick.html", System.UriKind.Absolute)
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(475, 130)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(301, 153)
        Me.PictureBox4.TabIndex = 15
        Me.PictureBox4.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(22, 403)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(382, 18)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Programmiert von  Leopold Pöchinger © 2015 (leschi)"
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial Black", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(22, 56)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 38)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Verbinden"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.OliveDrab
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 18
        Me.ListBox1.Items.AddRange(New Object() {"Square-Knights.com/Root/Suchen/Cop/Medic/Armee" & Global.Microsoft.VisualBasic.ChrW(9) & "Altis-Life", " ", "Event Arma 3 Server", " ", "TeamSpeak 3"})
        Me.ListBox1.Location = New System.Drawing.Point(168, 34)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(550, 90)
        Me.ListBox1.TabIndex = 11
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(645, 368)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 10
        Me.PictureBox3.TabStop = False
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.LinkColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LinkLabel3.Location = New System.Drawing.Point(667, 365)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(51, 18)
        Me.LinkLabel3.TabIndex = 9
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Twitch"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.LinkColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LinkLabel2.Location = New System.Drawing.Point(667, 403)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(53, 18)
        Me.LinkLabel2.TabIndex = 8
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Forum"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(667, 384)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(86, 18)
        Me.LinkLabel1.TabIndex = 7
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Homepage"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(19, 130)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(450, 120)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'hhhh
        '
        Me.hhhh.AccessibleName = ""
        Me.hhhh.Controls.Add(Me.Server)
        Me.hhhh.Controls.Add(Me.Einstellungen)
        Me.hhhh.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hhhh.Location = New System.Drawing.Point(-4, 23)
        Me.hhhh.Name = "hhhh"
        Me.hhhh.SelectedIndex = 0
        Me.hhhh.Size = New System.Drawing.Size(787, 471)
        Me.hhhh.TabIndex = 6
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(695, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(35, 35)
        Me.Button4.TabIndex = 7
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(741, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(35, 35)
        Me.Button5.TabIndex = 8
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 20)
        Me.Label3.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OliveDrab
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(776, 489)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.hhhh)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Square Knights Launcher"
        Me.Einstellungen.ResumeLayout(False)
        Me.Einstellungen.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Server.ResumeLayout(False)
        Me.Server.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hhhh.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Einstellungen As System.Windows.Forms.TabPage
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Server As System.Windows.Forms.TabPage
    Friend WithEvents hhhh As System.Windows.Forms.TabControl
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser

End Class
