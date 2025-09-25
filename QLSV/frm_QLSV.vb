Imports System.Data
Imports Microsoft.Data.SqlClient

Public Class frm_QLSV
    Private db As New clsDatabaseAccess()

    Private Sub frm_QLSV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadClassToCombo()
        LoadStudents()
        cboSearchType.Items.AddRange(New String() {"Mã sinh viên", "Tên sinh viên"})
        cboSearchType.SelectedIndex = 0
    End Sub

    ' Load danh sách lớp vào ComboBox
    Private Sub LoadClassToCombo()
        Dim dt As DataTable = db.GetDataTable("SELECT ClassID, ClassName FROM Class")
        cboClassFilter.DataSource = dt
        cboClassFilter.DisplayMember = "ClassName"
        cboClassFilter.ValueMember = "ClassID"
        cboClassFilter.SelectedIndex = -1
    End Sub

    ' Load danh sách sinh viên
    Private Sub LoadStudents(Optional classID As String = "")
        Dim sql As String = "
            SELECT s.StudentID, s.StudentName, s.Phone, s.Address, c.ClassName
            FROM Students s
            INNER JOIN Class c ON s.ClassID = c.ClassID"

        Dim dt As DataTable
        If Not String.IsNullOrEmpty(classID) Then
            sql &= " WHERE s.ClassID = @ClassID"
            dt = db.GetDataTable(sql, {New SqlParameter("@ClassID", classID)})
        Else
            dt = db.GetDataTable(sql)
        End If

        dgvStudents.DataSource = dt
    End Sub

    ' Lọc theo lớp
    Private Sub cboClassFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboClassFilter.SelectedIndexChanged
        If cboClassFilter.SelectedIndex >= 0 Then
            LoadStudents(cboClassFilter.SelectedValue.ToString())
        Else
            LoadStudents()
        End If
    End Sub

    ' Tìm kiếm
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchValue As String = txtSearch.Text.Trim()
        If searchValue = "" Then
            LoadStudents()
            Return
        End If

        Dim sql As String = "
            SELECT s.StudentID, s.StudentName, s.Phone, s.Address, c.ClassName
            FROM Students s
            INNER JOIN Class c ON s.ClassID = c.ClassID"

        If cboSearchType.SelectedIndex = 0 Then ' Mã sinh viên
            sql &= " WHERE s.StudentID LIKE @Value"
        Else ' Tên sinh viên
            sql &= " WHERE s.StudentName LIKE @Value"
        End If

        Dim dt As DataTable = db.GetDataTable(sql, {New SqlParameter("@Value", "%" & searchValue & "%")})
        dgvStudents.DataSource = dt
    End Sub

    ' Thêm sinh viên
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim frm As New frm_Student()
        frm.isEdit = False
        If frm.ShowDialog() = DialogResult.OK Then
            LoadStudents()
        End If
    End Sub

    ' Sửa sinh viên
    ' Sửa sinh viên
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgvStudents.CurrentRow IsNot Nothing Then
            Dim frm As New frm_Student()
            frm.isEdit = True

            frm.txtStudentID.Text = dgvStudents.CurrentRow.Cells("StudentID").Value.ToString()
            frm.txtStudentName.Text = dgvStudents.CurrentRow.Cells("StudentName").Value.ToString()
            frm.txtPhone.Text = dgvStudents.CurrentRow.Cells("Phone").Value.ToString()
            frm.txtAddress.Text = dgvStudents.CurrentRow.Cells("Address").Value.ToString()

            ' Lấy ClassID từ DB (cẩn trọng với DBNull / Nothing)
            Dim obj = db.ExecuteScalar("SELECT ClassID FROM Students WHERE StudentID=@ID", {New SqlParameter("@ID", frm.txtStudentID.Text)})
            Dim classID As String = If(obj Is Nothing OrElse obj Is DBNull.Value, String.Empty, obj.ToString())

            ' Truyền vào biến selectedClassID của form con — form con sẽ set SelectedValue trong Load
            frm.selectedClassID = classID

            If frm.ShowDialog() = DialogResult.OK Then
                LoadStudents()
            End If
        Else
            MessageBox.Show("Vui lòng chọn sinh viên cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


    ' Xóa sinh viên
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvStudents.CurrentRow IsNot Nothing Then
            Dim studentID As String = dgvStudents.CurrentRow.Cells("StudentID").Value.ToString()
            If MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                db.ExecuteNonQuery("DELETE FROM Students WHERE StudentID=@ID", {New SqlParameter("@ID", studentID)})
                LoadStudents()
            End If
        Else
            MessageBox.Show("Vui lòng chọn sinh viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click
        ResetFilters()
        LoadStudents()
    End Sub
    Private Sub ResetFilters()
        cboClassFilter.SelectedIndex = -1
        txtSearch.Clear()
        If cboSearchType.Items.Count > 0 Then
            cboSearchType.SelectedIndex = 0
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
