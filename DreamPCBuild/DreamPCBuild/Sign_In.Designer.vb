<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sign_In
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
        Me.components = New System.ComponentModel.Container()
        Me.BtnSignIn = New Guna.UI2.WinForms.Guna2Button()
        Me.Admin_Sign_In = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SiginPanel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.SignUp = New Guna.UI2.WinForms.Guna2Button()
        Me.Signin = New Guna.UI2.WinForms.Guna2Button()
        Me.SignInPanel1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.SiginElipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.PasswordTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.EmailTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1.SuspendLayout()
        Me.SiginPanel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnSignIn
        '
        Me.BtnSignIn.BorderRadius = 10
        Me.BtnSignIn.CheckedState.Parent = Me.BtnSignIn
        Me.BtnSignIn.CustomImages.Parent = Me.BtnSignIn
        Me.BtnSignIn.FillColor = System.Drawing.Color.Black
        Me.BtnSignIn.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSignIn.ForeColor = System.Drawing.Color.White
        Me.BtnSignIn.HoverState.Parent = Me.BtnSignIn
        Me.BtnSignIn.Location = New System.Drawing.Point(648, 541)
        Me.BtnSignIn.Name = "BtnSignIn"
        Me.BtnSignIn.ShadowDecoration.Parent = Me.BtnSignIn
        Me.BtnSignIn.Size = New System.Drawing.Size(329, 41)
        Me.BtnSignIn.TabIndex = 0
        Me.BtnSignIn.Text = "Sign In"
        '
        'Admin_Sign_In
        '
        Me.Admin_Sign_In.BorderRadius = 70
        Me.Admin_Sign_In.TargetControl = Me
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.White
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Controls.Add(Me.PasswordTxt)
        Me.Guna2Panel1.Controls.Add(Me.EmailTxt)
        Me.Guna2Panel1.Controls.Add(Me.PictureBox1)
        Me.Guna2Panel1.Controls.Add(Me.BtnSignIn)
        Me.Guna2Panel1.Controls.Add(Me.SiginPanel2)
        Me.Guna2Panel1.Location = New System.Drawing.Point(72, 73)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(1067, 646)
        Me.Guna2Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(660, 496)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 24)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Forgot Password"
        '
        'SiginPanel2
        '
        Me.SiginPanel2.BackColor = System.Drawing.Color.Black
        Me.SiginPanel2.BorderThickness = 3
        Me.SiginPanel2.Controls.Add(Me.SignUp)
        Me.SiginPanel2.Controls.Add(Me.Signin)
        Me.SiginPanel2.Controls.Add(Me.Guna2PictureBox1)
        Me.SiginPanel2.CustomBorderColor = System.Drawing.Color.Black
        Me.SiginPanel2.Location = New System.Drawing.Point(1, -1)
        Me.SiginPanel2.Name = "SiginPanel2"
        Me.SiginPanel2.ShadowDecoration.Parent = Me.SiginPanel2
        Me.SiginPanel2.Size = New System.Drawing.Size(475, 653)
        Me.SiginPanel2.TabIndex = 3
        '
        'SignUp
        '
        Me.SignUp.BorderColor = System.Drawing.Color.White
        Me.SignUp.BorderRadius = 10
        Me.SignUp.CheckedState.Parent = Me.SignUp
        Me.SignUp.CustomImages.Parent = Me.SignUp
        Me.SignUp.FillColor = System.Drawing.Color.Black
        Me.SignUp.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SignUp.ForeColor = System.Drawing.Color.Gray
        Me.SignUp.HoverState.FillColor = System.Drawing.Color.Gray
        Me.SignUp.HoverState.Parent = Me.SignUp
        Me.SignUp.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.SignUp.ImageSize = New System.Drawing.Size(30, 30)
        Me.SignUp.Location = New System.Drawing.Point(330, 190)
        Me.SignUp.Name = "SignUp"
        Me.SignUp.ShadowDecoration.Parent = Me.SignUp
        Me.SignUp.Size = New System.Drawing.Size(156, 44)
        Me.SignUp.TabIndex = 3
        Me.SignUp.Text = "Sign Up"
        Me.SignUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Signin
        '
        Me.Signin.BorderColor = System.Drawing.Color.White
        Me.Signin.BorderRadius = 10
        Me.Signin.CheckedState.Parent = Me.Signin
        Me.Signin.CustomImages.Parent = Me.Signin
        Me.Signin.FillColor = System.Drawing.Color.White
        Me.Signin.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Signin.ForeColor = System.Drawing.Color.Black
        Me.Signin.HoverState.FillColor = System.Drawing.Color.Gray
        Me.Signin.HoverState.Parent = Me.Signin
        Me.Signin.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Signin.ImageSize = New System.Drawing.Size(30, 30)
        Me.Signin.Location = New System.Drawing.Point(333, 142)
        Me.Signin.Name = "Signin"
        Me.Signin.ShadowDecoration.Parent = Me.Signin
        Me.Signin.Size = New System.Drawing.Size(153, 44)
        Me.Signin.TabIndex = 2
        Me.Signin.Text = "Sign In"
        Me.Signin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'SignInPanel1
        '
        Me.SignInPanel1.BorderRadius = 70
        Me.SignInPanel1.TargetControl = Me.Guna2Panel1
        '
        'SiginElipse2
        '
        Me.SiginElipse2.BorderRadius = 70
        Me.SiginElipse2.TargetControl = Me.SiginPanel2
        '
        'Guna2Elipse2
        '
        Me.Guna2Elipse2.BorderRadius = 15
        '
        'PasswordTxt
        '
        Me.PasswordTxt.BorderColor = System.Drawing.Color.Black
        Me.PasswordTxt.BorderRadius = 12
        Me.PasswordTxt.BorderThickness = 2
        Me.PasswordTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PasswordTxt.DefaultText = "Password"
        Me.PasswordTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.PasswordTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.PasswordTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PasswordTxt.DisabledState.Parent = Me.PasswordTxt
        Me.PasswordTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PasswordTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PasswordTxt.FocusedState.Parent = Me.PasswordTxt
        Me.PasswordTxt.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PasswordTxt.HoverState.Parent = Me.PasswordTxt
        Me.PasswordTxt.IconLeft = Global.DreamPCBuild.My.Resources.Resources.password_icon
        Me.PasswordTxt.IconLeftSize = New System.Drawing.Size(30, 20)
        Me.PasswordTxt.IconRight = Global.DreamPCBuild.My.Resources.Resources.close_eye_poassword_icon
        Me.PasswordTxt.IconRightSize = New System.Drawing.Size(30, 20)
        Me.PasswordTxt.Location = New System.Drawing.Point(648, 446)
        Me.PasswordTxt.Margin = New System.Windows.Forms.Padding(4)
        Me.PasswordTxt.Name = "PasswordTxt"
        Me.PasswordTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PasswordTxt.PlaceholderText = ""
        Me.PasswordTxt.SelectedText = ""
        Me.PasswordTxt.SelectionStart = 8
        Me.PasswordTxt.ShadowDecoration.Parent = Me.PasswordTxt
        Me.PasswordTxt.Size = New System.Drawing.Size(329, 47)
        Me.PasswordTxt.TabIndex = 6
        '
        'EmailTxt
        '
        Me.EmailTxt.BorderColor = System.Drawing.Color.Black
        Me.EmailTxt.BorderRadius = 12
        Me.EmailTxt.BorderThickness = 2
        Me.EmailTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.EmailTxt.DefaultText = "Email"
        Me.EmailTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.EmailTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.EmailTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.EmailTxt.DisabledState.Parent = Me.EmailTxt
        Me.EmailTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.EmailTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.EmailTxt.FocusedState.Parent = Me.EmailTxt
        Me.EmailTxt.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.EmailTxt.HoverState.Parent = Me.EmailTxt
        Me.EmailTxt.IconLeft = Global.DreamPCBuild.My.Resources.Resources.email_icon
        Me.EmailTxt.IconLeftSize = New System.Drawing.Size(30, 20)
        Me.EmailTxt.Location = New System.Drawing.Point(648, 390)
        Me.EmailTxt.Margin = New System.Windows.Forms.Padding(4)
        Me.EmailTxt.Name = "EmailTxt"
        Me.EmailTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.EmailTxt.PlaceholderText = ""
        Me.EmailTxt.SelectedText = ""
        Me.EmailTxt.SelectionStart = 5
        Me.EmailTxt.ShadowDecoration.Parent = Me.EmailTxt
        Me.EmailTxt.Size = New System.Drawing.Size(329, 47)
        Me.EmailTxt.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.DreamPCBuild.My.Resources.Resources._10
        Me.PictureBox1.Location = New System.Drawing.Point(640, -47)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(345, 349)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = Global.DreamPCBuild.My.Resources.Resources._3
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(-119, 170)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(594, 652)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 1
        Me.Guna2PictureBox1.TabStop = False
        '
        'Guna2Button2
        '
        Me.Guna2Button2.BorderRadius = 10
        Me.Guna2Button2.CheckedState.Parent = Me.Guna2Button2
        Me.Guna2Button2.CustomImages.Parent = Me.Guna2Button2
        Me.Guna2Button2.FillColor = System.Drawing.Color.LightGray
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.HoverState.Parent = Me.Guna2Button2
        Me.Guna2Button2.Image = Global.DreamPCBuild.My.Resources.Resources.close
        Me.Guna2Button2.Location = New System.Drawing.Point(1112, 35)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.ShadowDecoration.Parent = Me.Guna2Button2
        Me.Guna2Button2.Size = New System.Drawing.Size(38, 35)
        Me.Guna2Button2.TabIndex = 1
        '
        'Sign_In
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1190, 782)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2Button2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Sign_In"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sign_In"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.SiginPanel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnSignIn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Admin_Sign_In As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents SiginPanel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents SignInPanel1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents SiginElipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Signin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents EmailTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PasswordTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents SignUp As Guna.UI2.WinForms.Guna2Button
End Class
