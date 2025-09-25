<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_QLSV
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        dgvStudents = New DataGridView()
        btnAdd = New Button()
        btnEdit = New Button()
        btnDelete = New Button()
        btnSearch = New Button()
        txtSearch = New TextBox()
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        Label2 = New Label()
        cboClassFilter = New ComboBox()
        cboSearchType = New ComboBox()
        Label3 = New Label()
        btnReload = New Button()
        CType(dgvStudents, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvStudents
        ' 
        dgvStudents.BackgroundColor = SystemColors.ButtonFace
        dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvStudents.Location = New Point(112, 150)
        dgvStudents.MultiSelect = False
        dgvStudents.Name = "dgvStudents"
        dgvStudents.ReadOnly = True
        dgvStudents.RowHeadersWidth = 51
        dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvStudents.Size = New Size(681, 406)
        dgvStudents.TabIndex = 0
        ' 
        ' btnAdd
        ' 
        btnAdd.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnAdd.Location = New Point(835, 150)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(176, 29)
        btnAdd.TabIndex = 1
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnEdit.Location = New Point(835, 185)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(176, 29)
        btnEdit.TabIndex = 2
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnDelete.Location = New Point(835, 220)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(176, 29)
        btnDelete.TabIndex = 3
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnSearch
        ' 
        btnSearch.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnSearch.Location = New Point(699, 105)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(94, 29)
        btnSearch.TabIndex = 5
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(368, 106)
        txtSearch.Multiline = True
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(325, 29)
        txtSearch.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Red
        Label1.Location = New Point(283, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(512, 29)
        Label1.TabIndex = 6
        Label1.Text = "STUDENT INFORMATION MANAGEMENT"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(cboClassFilter)
        GroupBox1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        GroupBox1.Location = New Point(835, 326)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(215, 134)
        GroupBox1.TabIndex = 8
        GroupBox1.TabStop = False
        GroupBox1.Text = "Filter"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label2.Location = New Point(18, 39)
        Label2.Name = "Label2"
        Label2.Size = New Size(48, 20)
        Label2.TabIndex = 1
        Label2.Text = "Class:"
        ' 
        ' cboClassFilter
        ' 
        cboClassFilter.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cboClassFilter.FormattingEnabled = True
        cboClassFilter.Location = New Point(18, 76)
        cboClassFilter.Name = "cboClassFilter"
        cboClassFilter.Size = New Size(151, 28)
        cboClassFilter.TabIndex = 0
        ' 
        ' cboSearchType
        ' 
        cboSearchType.FormattingEnabled = True
        cboSearchType.Location = New Point(176, 106)
        cboSearchType.Name = "cboSearchType"
        cboSearchType.Size = New Size(167, 28)
        cboSearchType.TabIndex = 9
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label3.Location = New Point(110, 109)
        Label3.Name = "Label3"
        Label3.Size = New Size(63, 20)
        Label3.TabIndex = 10
        Label3.Text = "Search: "
        ' 
        ' btnReload
        ' 
        btnReload.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnReload.Location = New Point(835, 264)
        btnReload.Name = "btnReload"
        btnReload.Size = New Size(176, 29)
        btnReload.TabIndex = 11
        btnReload.Text = "Reload"
        btnReload.UseVisualStyleBackColor = True
        ' 
        ' frm_QLSV
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkTurquoise
        ClientSize = New Size(1259, 599)
        Controls.Add(btnReload)
        Controls.Add(Label3)
        Controls.Add(cboSearchType)
        Controls.Add(GroupBox1)
        Controls.Add(txtSearch)
        Controls.Add(Label1)
        Controls.Add(btnSearch)
        Controls.Add(btnDelete)
        Controls.Add(btnEdit)
        Controls.Add(btnAdd)
        Controls.Add(dgvStudents)
        Name = "frm_QLSV"
        Text = "FORM QLSV"
        CType(dgvStudents, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvStudents As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cboClassFilter As ComboBox
    Friend WithEvents cboSearchType As ComboBox
    Friend WithEvents Label3 As Label

    Private Sub dgvStudents_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStudents.CellContentClick

    End Sub

    Friend WithEvents btnReload As Button


End Class
