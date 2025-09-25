Imports System.Data
Imports Microsoft.Data.SqlClient

Public Class clsDatabaseAccess
    Private connectionString As String =
    "Server=DAOMINHSON\SQLEXPRESS01;Database=QLSV;User Id=sa;Password=123456;Encrypt=False;TrustServerCertificate=True;"


    Private Function GetConnection() As SqlConnection
        Return New SqlConnection(connectionString)
    End Function

    Public Function GetDataTable(sql As String, Optional parameters As SqlParameter() = Nothing) As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As SqlConnection = GetConnection()
                conn.Open()
                Using cmd As New SqlCommand(sql, conn)
                    If parameters IsNot Nothing Then
                        cmd.Parameters.AddRange(parameters)
                    End If
                    Using da As New SqlDataAdapter(cmd)
                        da.Fill(dt)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Lỗi khi thực hiện truy vấn: " & ex.Message)
        End Try
        Return dt
    End Function

    Public Function ExecuteScalar(sql As String, Optional parameters As SqlParameter() = Nothing) As Object
        Dim result As Object = Nothing
        Try
            Using conn As SqlConnection = GetConnection()
                conn.Open()
                Using cmd As New SqlCommand(sql, conn)
                    If parameters IsNot Nothing Then
                        cmd.Parameters.AddRange(parameters)
                    End If
                    result = cmd.ExecuteScalar()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Lỗi khi thực hiện ExecuteScalar: " & ex.Message)
        End Try
        Return result
    End Function

    Public Sub ExecuteNonQuery(sql As String, Optional parameters As SqlParameter() = Nothing)
        Try
            Using conn As SqlConnection = GetConnection()
                conn.Open()
                Using cmd As New SqlCommand(sql, conn)
                    If parameters IsNot Nothing Then
                        cmd.Parameters.AddRange(parameters)
                    End If
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Lỗi khi thực hiện ExecuteNonQuery: " & ex.Message)
        End Try
    End Sub
End Class
