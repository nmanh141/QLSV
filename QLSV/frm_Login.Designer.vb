<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Login
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
        label1 = New Label()
        txtUsername = New TextBox()
        btnLogin = New Button()
        txtPassword = New TextBox()
        Password = New Label()
        btnCancel = New Button()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        label1.ForeColor = SystemColors.ControlLightLight
        label1.Location = New Point(170, 151)
        label1.Name = "label1"
        label1.Size = New Size(84, 20)
        label1.TabIndex = 0
        label1.Text = "Username:"
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(276, 148)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(176, 27)
        txtUsername.TabIndex = 1
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.LightSeaGreen
        btnLogin.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(190, 295)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(114, 29)
        btnLogin.TabIndex = 2
        btnLogin.Text = "&Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(276, 212)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(176, 27)
        txtPassword.TabIndex = 4
        ' 
        ' Password
        ' 
        Password.AutoSize = True
        Password.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Password.ForeColor = SystemColors.ControlLightLight
        Password.Location = New Point(170, 215)
        Password.Name = "Password"
        Password.Size = New Size(80, 20)
        Password.TabIndex = 3
        Password.Text = "Password:"
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.LightSeaGreen
        btnCancel.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnCancel.ForeColor = Color.White
        btnCancel.Location = New Point(328, 295)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(114, 29)
        btnCancel.TabIndex = 5
        btnCancel.Text = "&Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Showcard Gothic", 10.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Snow
        Label2.Location = New Point(88, 46)
        Label2.Name = "Label2"
        Label2.Size = New Size(444, 23)
        Label2.TabIndex = 6
        Label2.Text = "STUDENT INFORMATION MANAGEMENT SYSTEM"
        ' 
        ' frm_Login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSeaGreen
        ClientSize = New Size(603, 366)
        Controls.Add(Label2)
        Controls.Add(btnCancel)
        Controls.Add(txtPassword)
        Controls.Add(Password)
        Controls.Add(btnLogin)
        Controls.Add(txtUsername)
        Controls.Add(label1)
        Name = "frm_Login"
        Text = "frm_Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents label1 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Password As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label2 As Label
End Class
