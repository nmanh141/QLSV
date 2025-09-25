Imports System.Data
Imports Microsoft.Data.SqlClient

Public Class frm_Student
    Public isEdit As Boolean = False
    ' biến nhận ClassID từ form cha
    Public selectedClassID As String = String.Empty

    Private db As New clsDatabaseAccess()

    Private Sub frm_Student_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadClassToCombo()
        cbbClassID.Focus()
        If isEdit Then
            txtStudentID.ReadOnly = True
            ' gán SelectedValue SAU khi combobox đã có DataSource
            If Not String.IsNullOrEmpty(selectedClassID) AndAlso cbbClassID.Items.Count > 0 Then
                Try
                    ' đảm bảo có item tương ứng trước khi gán
                    For Each drv As DataRowView In cbbClassID.Items
                        If drv("ClassID").ToString() = selectedClassID Then
                            cbbClassID.SelectedValue = selectedClassID
                            Exit For
                        End If
                    Next
                Catch ex As Exception
                    ' nếu có lỗi, bạn có thể log hoặc ignore
                End Try
            End If
        End If
    End Sub

    ' Hàm load dữ liệu lớp vào combobox
    Private Sub LoadClassToCombo()
        Dim dt As DataTable = db.GetDataTable("SELECT ClassID, ClassName FROM Class")
        cbbClassID.DataSource = dt
        cbbClassID.DisplayMember = "ClassName"
        cbbClassID.ValueMember = "ClassID"
        cbbClassID.SelectedIndex = -1
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim classID As String = If(cbbClassID.SelectedValue Is Nothing, String.Empty, cbbClassID.SelectedValue.ToString())
        Dim studentID As String = txtStudentID.Text.Trim()
        Dim name As String = txtStudentName.Text.Trim()
        Dim phone As String = txtPhone.Text.Trim()
        Dim address As String = txtAddress.Text.Trim()

        If String.IsNullOrEmpty(classID) OrElse String.IsNullOrEmpty(studentID) OrElse String.IsNullOrEmpty(name) Then
            MessageBox.Show("Vui lòng nhập đầy đủ thông tin bắt buộc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If isEdit Then
            ' Cập nhật sinh viên
            db.ExecuteNonQuery("
                UPDATE Students 
                SET ClassID=@ClassID, StudentName=@Name, Phone=@Phone, Address=@Address 
                WHERE StudentID=@StudentID",
                {
                    New SqlParameter("@ClassID", classID),
                    New SqlParameter("@Name", name),
                    New SqlParameter("@Phone", phone),
                    New SqlParameter("@Address", address),
                    New SqlParameter("@StudentID", studentID)
                })
        Else
            ' Thêm sinh viên mới
            db.ExecuteNonQuery("
                INSERT INTO Students (ClassID, StudentID, StudentName, Phone, Address) 
                VALUES (@ClassID, @StudentID, @Name, @Phone, @Address)",
                {
                    New SqlParameter("@ClassID", classID),
                    New SqlParameter("@StudentID", studentID),
                    New SqlParameter("@Name", name),
                    New SqlParameter("@Phone", phone),
                    New SqlParameter("@Address", address)
                })
        End If

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

End Class
