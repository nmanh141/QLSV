Imports Microsoft.Data.SqlClient

Public Class frm_Login
    Private db As New clsDatabaseAccess()

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        If username = "" OrElse password = "" Then
            MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Kiểm tra tài khoản trong DB
        Dim sql As String = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password"
        Dim parameters As SqlParameter() = {
            New SqlParameter("@Username", username),
            New SqlParameter("@Password", password)
        }

        Dim result As Object = db.ExecuteScalar(sql, parameters)

        If result IsNot Nothing AndAlso Convert.ToInt32(result) > 0 Then
            ' Đúng tài khoản -> Mở form QLSV
            MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim f As New frm_QLSV()
            f.Show()
            Me.Hide()
        Else
            MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class
