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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.sidepanel = New System.Windows.Forms.Panel()
        Me.playagain = New Guna.UI2.WinForms.Guna2Button()
        Me.label0 = New System.Windows.Forms.Label()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.start = New Guna.UI2.WinForms.Guna2Button()
        Me.logopanel = New System.Windows.Forms.Panel()
        Me.logo = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.penghitungwaktu = New System.Windows.Forms.Label()
        Me.circle1 = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.circle2 = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.circle3 = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.circle4 = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.circle5 = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.circle6 = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.waktuanda = New System.Windows.Forms.Label()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer6 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer7 = New System.Windows.Forms.Timer(Me.components)
        Me.sidepanel.SuspendLayout()
        Me.logopanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'sidepanel
        '
        Me.sidepanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.sidepanel.Controls.Add(Me.playagain)
        Me.sidepanel.Controls.Add(Me.label0)
        Me.sidepanel.Controls.Add(Me.Guna2Button1)
        Me.sidepanel.Controls.Add(Me.start)
        Me.sidepanel.Controls.Add(Me.logopanel)
        Me.sidepanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.sidepanel.Location = New System.Drawing.Point(0, 0)
        Me.sidepanel.Name = "sidepanel"
        Me.sidepanel.Size = New System.Drawing.Size(348, 695)
        Me.sidepanel.TabIndex = 7
        '
        'playagain
        '
        Me.playagain.CheckedState.Parent = Me.playagain
        Me.playagain.CustomImages.Parent = Me.playagain
        Me.playagain.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.playagain.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.playagain.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.playagain.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.playagain.DisabledState.Parent = Me.playagain
        Me.playagain.FillColor = System.Drawing.Color.Gainsboro
        Me.playagain.Font = New System.Drawing.Font("Open Sans", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.playagain.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.playagain.HoverState.Parent = Me.playagain
        Me.playagain.Location = New System.Drawing.Point(12, 570)
        Me.playagain.Name = "playagain"
        Me.playagain.ShadowDecoration.BorderRadius = 9
        Me.playagain.ShadowDecoration.Parent = Me.playagain
        Me.playagain.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(10)
        Me.playagain.Size = New System.Drawing.Size(321, 45)
        Me.playagain.TabIndex = 6
        Me.playagain.Text = "PLAY AGAIN"
        '
        'label0
        '
        Me.label0.Font = New System.Drawing.Font("Open Sans SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label0.ForeColor = System.Drawing.Color.White
        Me.label0.Location = New System.Drawing.Point(0, 269)
        Me.label0.Name = "label0"
        Me.label0.Size = New System.Drawing.Size(348, 98)
        Me.label0.TabIndex = 5
        Me.label0.Text = "Klik START untuk memulai."
        Me.label0.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Guna2Button1
        '
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.DisabledState.Parent = Me.Guna2Button1
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Open Sans", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(12, 623)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.BorderRadius = 9
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(10)
        Me.Guna2Button1.Size = New System.Drawing.Size(321, 45)
        Me.Guna2Button1.TabIndex = 4
        Me.Guna2Button1.Text = "EXIT"
        '
        'start
        '
        Me.start.CheckedState.Parent = Me.start
        Me.start.CustomImages.Parent = Me.start
        Me.start.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.start.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.start.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.start.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.start.DisabledState.Parent = Me.start
        Me.start.FillColor = System.Drawing.Color.Gainsboro
        Me.start.Font = New System.Drawing.Font("Open Sans", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.start.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.start.HoverState.Parent = Me.start
        Me.start.Location = New System.Drawing.Point(12, 570)
        Me.start.Name = "start"
        Me.start.ShadowDecoration.BorderRadius = 9
        Me.start.ShadowDecoration.Parent = Me.start
        Me.start.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(10)
        Me.start.Size = New System.Drawing.Size(321, 45)
        Me.start.TabIndex = 4
        Me.start.Text = "START"
        '
        'logopanel
        '
        Me.logopanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.logopanel.Controls.Add(Me.logo)
        Me.logopanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.logopanel.Location = New System.Drawing.Point(0, 0)
        Me.logopanel.Name = "logopanel"
        Me.logopanel.Size = New System.Drawing.Size(348, 61)
        Me.logopanel.TabIndex = 2
        '
        'logo
        '
        Me.logo.Dock = System.Windows.Forms.DockStyle.Top
        Me.logo.Image = CType(resources.GetObject("logo.Image"), System.Drawing.Image)
        Me.logo.Location = New System.Drawing.Point(0, 0)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(348, 61)
        Me.logo.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.penghitungwaktu)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(348, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(856, 61)
        Me.Panel1.TabIndex = 14
        '
        'penghitungwaktu
        '
        Me.penghitungwaktu.Font = New System.Drawing.Font("Open Sans", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.penghitungwaktu.Location = New System.Drawing.Point(6, 10)
        Me.penghitungwaktu.Name = "penghitungwaktu"
        Me.penghitungwaktu.Size = New System.Drawing.Size(847, 41)
        Me.penghitungwaktu.TabIndex = 1
        Me.penghitungwaktu.Text = "0"
        Me.penghitungwaktu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'circle1
        '
        Me.circle1.BackColor = System.Drawing.Color.Transparent
        Me.circle1.CheckedState.Parent = Me.circle1
        Me.circle1.CustomImages.Parent = Me.circle1
        Me.circle1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.circle1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.circle1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.circle1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.circle1.DisabledState.Parent = Me.circle1
        Me.circle1.FillColor = System.Drawing.Color.Black
        Me.circle1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.circle1.ForeColor = System.Drawing.Color.White
        Me.circle1.HoverState.Parent = Me.circle1
        Me.circle1.Location = New System.Drawing.Point(506, 210)
        Me.circle1.Name = "circle1"
        Me.circle1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.circle1.ShadowDecoration.Parent = Me.circle1
        Me.circle1.Size = New System.Drawing.Size(100, 100)
        Me.circle1.TabIndex = 15
        '
        'circle2
        '
        Me.circle2.BackColor = System.Drawing.Color.Transparent
        Me.circle2.CheckedState.Parent = Me.circle2
        Me.circle2.CustomImages.Parent = Me.circle2
        Me.circle2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.circle2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.circle2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.circle2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.circle2.DisabledState.Parent = Me.circle2
        Me.circle2.FillColor = System.Drawing.Color.Black
        Me.circle2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.circle2.ForeColor = System.Drawing.Color.White
        Me.circle2.HoverState.Parent = Me.circle2
        Me.circle2.Location = New System.Drawing.Point(652, 210)
        Me.circle2.Name = "circle2"
        Me.circle2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.circle2.ShadowDecoration.Parent = Me.circle2
        Me.circle2.Size = New System.Drawing.Size(100, 100)
        Me.circle2.TabIndex = 15
        '
        'circle3
        '
        Me.circle3.BackColor = System.Drawing.Color.Transparent
        Me.circle3.CheckedState.Parent = Me.circle3
        Me.circle3.CustomImages.Parent = Me.circle3
        Me.circle3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.circle3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.circle3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.circle3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.circle3.DisabledState.Parent = Me.circle3
        Me.circle3.FillColor = System.Drawing.Color.Black
        Me.circle3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.circle3.ForeColor = System.Drawing.Color.White
        Me.circle3.HoverState.Parent = Me.circle3
        Me.circle3.Location = New System.Drawing.Point(798, 210)
        Me.circle3.Name = "circle3"
        Me.circle3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.circle3.ShadowDecoration.Parent = Me.circle3
        Me.circle3.Size = New System.Drawing.Size(100, 100)
        Me.circle3.TabIndex = 15
        '
        'circle4
        '
        Me.circle4.BackColor = System.Drawing.Color.Transparent
        Me.circle4.CheckedState.Parent = Me.circle4
        Me.circle4.CustomImages.Parent = Me.circle4
        Me.circle4.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.circle4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.circle4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.circle4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.circle4.DisabledState.Parent = Me.circle4
        Me.circle4.FillColor = System.Drawing.Color.Black
        Me.circle4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.circle4.ForeColor = System.Drawing.Color.White
        Me.circle4.HoverState.Parent = Me.circle4
        Me.circle4.Location = New System.Drawing.Point(944, 210)
        Me.circle4.Name = "circle4"
        Me.circle4.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.circle4.ShadowDecoration.Parent = Me.circle4
        Me.circle4.Size = New System.Drawing.Size(100, 100)
        Me.circle4.TabIndex = 15
        '
        'circle5
        '
        Me.circle5.BackColor = System.Drawing.Color.Transparent
        Me.circle5.CheckedState.Parent = Me.circle5
        Me.circle5.CustomImages.Parent = Me.circle5
        Me.circle5.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.circle5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.circle5.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.circle5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.circle5.DisabledState.Parent = Me.circle5
        Me.circle5.FillColor = System.Drawing.Color.Black
        Me.circle5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.circle5.ForeColor = System.Drawing.Color.White
        Me.circle5.HoverState.Parent = Me.circle5
        Me.circle5.Location = New System.Drawing.Point(652, 351)
        Me.circle5.Name = "circle5"
        Me.circle5.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.circle5.ShadowDecoration.Parent = Me.circle5
        Me.circle5.Size = New System.Drawing.Size(100, 100)
        Me.circle5.TabIndex = 15
        '
        'circle6
        '
        Me.circle6.BackColor = System.Drawing.Color.Transparent
        Me.circle6.CheckedState.Parent = Me.circle6
        Me.circle6.CustomImages.Parent = Me.circle6
        Me.circle6.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.circle6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.circle6.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.circle6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.circle6.DisabledState.Parent = Me.circle6
        Me.circle6.FillColor = System.Drawing.Color.Black
        Me.circle6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.circle6.ForeColor = System.Drawing.Color.White
        Me.circle6.HoverState.Parent = Me.circle6
        Me.circle6.Location = New System.Drawing.Point(798, 351)
        Me.circle6.Name = "circle6"
        Me.circle6.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.circle6.ShadowDecoration.Parent = Me.circle6
        Me.circle6.Size = New System.Drawing.Size(100, 100)
        Me.circle6.TabIndex = 15
        '
        'waktuanda
        '
        Me.waktuanda.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.waktuanda.Location = New System.Drawing.Point(348, 64)
        Me.waktuanda.Name = "waktuanda"
        Me.waktuanda.Size = New System.Drawing.Size(856, 39)
        Me.waktuanda.TabIndex = 17
        Me.waktuanda.Text = "Waktu Anda"
        Me.waktuanda.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Timer3
        '
        '
        'Timer4
        '
        '
        'Timer5
        '
        '
        'Timer6
        '
        '
        'Timer7
        '
        Me.Timer7.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1204, 695)
        Me.Controls.Add(Me.waktuanda)
        Me.Controls.Add(Me.circle4)
        Me.Controls.Add(Me.circle6)
        Me.Controls.Add(Me.circle5)
        Me.Controls.Add(Me.circle3)
        Me.Controls.Add(Me.circle2)
        Me.Controls.Add(Me.circle1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.sidepanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.sidepanel.ResumeLayout(False)
        Me.logopanel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents sidepanel As Panel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents start As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents logopanel As Panel
    Friend WithEvents logo As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents penghitungwaktu As Label
    Friend WithEvents circle1 As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents circle2 As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents circle3 As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents circle4 As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents circle5 As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents circle6 As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents label0 As Label
    Friend WithEvents waktuanda As Label
    Friend WithEvents playagain As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Timer4 As Timer
    Friend WithEvents Timer5 As Timer
    Friend WithEvents Timer6 As Timer
    Friend WithEvents Timer7 As Timer
End Class
