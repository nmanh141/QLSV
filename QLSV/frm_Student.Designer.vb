<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Student
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
        Label1 = New Label()
        txtStudentID = New TextBox()
        Label3 = New Label()
        txtStudentName = New TextBox()
        Label4 = New Label()
        txtPhone = New TextBox()
        Label5 = New Label()
        txtAddress = New TextBox()
        Label6 = New Label()
        btnOK = New Button()
        btnCancel = New Button()
        Label2 = New Label()
        cbbClassID = New ComboBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(96, 164)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 20)
        Label1.TabIndex = 1
        Label1.Text = "Class ID:"
        ' 
        ' txtStudentID
        ' 
        txtStudentID.Location = New Point(464, 161)
        txtStudentID.Name = "txtStudentID"
        txtStudentID.Size = New Size(125, 27)
        txtStudentID.TabIndex = 0
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(376, 164)
        Label3.Name = "Label3"
        Label3.Size = New Size(82, 20)
        Label3.TabIndex = 1
        Label3.Text = "Student ID:"
        ' 
        ' txtStudentName
        ' 
        txtStudentName.Location = New Point(224, 205)
        txtStudentName.Name = "txtStudentName"
        txtStudentName.Size = New Size(125, 27)
        txtStudentName.TabIndex = 0
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(96, 209)
        Label4.Name = "Label4"
        Label4.Size = New Size(107, 20)
        Label4.TabIndex = 1
        Label4.Text = "Student Name:"
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(464, 205)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(125, 27)
        txtPhone.TabIndex = 0
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(376, 212)
        Label5.Name = "Label5"
        Label5.Size = New Size(53, 20)
        Label5.TabIndex = 1
        Label5.Text = "Phone:"
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(224, 260)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(125, 27)
        txtAddress.TabIndex = 0
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(96, 264)
        Label6.Name = "Label6"
        Label6.Size = New Size(65, 20)
        Label6.TabIndex = 1
        Label6.Text = "Address:"
        ' 
        ' btnOK
        ' 
        btnOK.Location = New Point(173, 350)
        btnOK.Name = "btnOK"
        btnOK.Size = New Size(125, 29)
        btnOK.TabIndex = 2
        btnOK.Text = "&OK"
        btnOK.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(365, 350)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(125, 29)
        btnCancel.TabIndex = 3
        btnCancel.Text = "&Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Showcard Gothic", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, 0)
        Label2.Location = New Point(211, 50)
        Label2.Name = "Label2"
        Label2.Size = New Size(261, 26)
        Label2.TabIndex = 4
        Label2.Text = "STUDENT INFORMATION"
        ' 
        ' cbbClassID
        ' 
        cbbClassID.FormattingEnabled = True
        cbbClassID.Location = New Point(224, 156)
        cbbClassID.Name = "cbbClassID"
        cbbClassID.Size = New Size(125, 28)
        cbbClassID.TabIndex = 5
        ' 
        ' frm_Student
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(721, 428)
        Controls.Add(cbbClassID)
        Controls.Add(Label2)
        Controls.Add(btnCancel)
        Controls.Add(btnOK)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(txtAddress)
        Controls.Add(txtPhone)
        Controls.Add(txtStudentName)
        Controls.Add(txtStudentID)
        Controls.Add(Label1)
        Name = "frm_Student"
        Text = "frm_Student"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtStudentName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnOK As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents cbbClassID As ComboBox
End Class
