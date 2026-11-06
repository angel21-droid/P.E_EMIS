Imports System.Data.SqlClient

Public Class LOGS

    Dim lblID As Object

    ' 1. LOAD USERS INTO THE GRID
    Private Sub LOGS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadUsers()
    End Sub

    Private Sub LoadUsers()
        Try
            ' FIX: Use the global function for consistency
            Using con As SqlConnection = getConnection()
                con.Open()
                Dim sql As String = "SELECT AdID, uname As [Username], passw As [Password], role As [Role] FROM tbl_users"
                Dim da As New SqlDataAdapter(sql, con)
                Dim dt As New DataTable()
                da.Fill(dt)

                dgvUsers.DataSource = dt

                ' UI Cleanup
                dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                dgvUsers.RowHeadersVisible = False
            End Using
        Catch ex As Exception
            MsgBox("Error loading users: " & ex.Message)
        End Try
    End Sub

    ' 2. SELECT USER FROM GRID TO TEXTBOXES
    Private Sub dgvUsers_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvUsers.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvUsers.Rows(e.RowIndex)
            txtUsername.Text = row.Cells("Username").Value.ToString()
            txtPassword.Text = row.Cells("Password").Value.ToString()
            cmbRole.Text = row.Cells("Role").Value.ToString()

            ' This is important! It tracks the ID for the Update/Delete logic
            lblUID.Text = row.Cells("AdID").Value.ToString()
        End If
    End Sub

    ' 3. UPDATE BUTTON LOGIC
    Private Sub btnUp_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnUp.Click
        If txtUsername.Text = "" Or lblUID.Text = "" Then
            MsgBox("Please select a user from the list first.", MsgBoxStyle.Exclamation)
            Return
        End If

        Try
            Using con As SqlConnection = getConnection()
                con.Open()
                ' We use AdID to find the row, but we don't change the AdID itself
                Dim sql As String = "UPDATE tbl_users SET uname=@u, passw=@p, role=@r WHERE AdID=@id"
                Using cmd As New SqlCommand(sql, con)
                    cmd.Parameters.AddWithValue("@u", txtUsername.Text.Trim())
                    cmd.Parameters.AddWithValue("@p", txtPassword.Text.Trim())
                    cmd.Parameters.AddWithValue("@r", cmbRole.Text)
                    cmd.Parameters.AddWithValue("@id", lblUID.Text)

                    cmd.ExecuteNonQuery()
                    MsgBox("User information updated!", MsgBoxStyle.Information)
                    LoadUsers()
                    ClearFields()
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Update Error: " & ex.Message)
        End Try
    End Sub

    ' 4. DELETE BUTTON LOGIC
    Private Sub btnDel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDel.Click
        If lblID.Text = "" Then
            MsgBox("Please select a user to delete.", MsgBoxStyle.Exclamation)
            Return
        End If

        If MsgBox("Delete this user permanently?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
            Try
                Using con As SqlConnection = modGlobal.getConnection()
                    con.Open()
                    Dim sql As String = "DELETE FROM tbl_users WHERE AdID=@id"
                    Using cmd As New SqlCommand(sql, con)
                        cmd.Parameters.AddWithValue("@id", lblUID.Text)
                        cmd.ExecuteNonQuery()
                        MsgBox("User deleted.")
                        LoadUsers()
                        ClearFields()
                    End Using
                End Using
            Catch ex As Exception
                MsgBox("Delete Error: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub ClearFields()
        txtUsername.Clear()
        txtPassword.Clear()
        cmbRole.SelectedIndex = -1
        lblUID.Text = ""
    End Sub
End Class
