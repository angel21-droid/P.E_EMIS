Imports System.Data.SqlClient

Public Class frmLogin

    Private Sub frmLogin_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' Clear fields on load
        txtUsername.Text = ""
        txtPassword.Text = ""
        lblErrors.Visible = False
        btnLogin.BackColor = Color.FromArgb(21, 95, 165)
        btnLogin.ForeColor = Color.White
        btnLogin.FlatStyle = FlatStyle.Flat
    End Sub
    Private Sub frmLogin_Activated(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Activated
        txtUsername.Text = ""
        txtPassword.Text = ""

        lblError.Visible = False
        txtUsername.Focus()
    End Sub

    Private Sub btnLogin_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()
        Dim role As String = If(cmbRole.SelectedItem IsNot Nothing, cmbRole.SelectedItem.ToString(), "")

        ' 1. Basic Validation
        If username = "" Or password = "" Or role = "" Then
            lblErrors.Text = "Please fill in all fields."
            lblErrors.Visible = True
            Return
        End If

        Try
            Using con As SqlConnection = GetConnection()
                con.Open()

                ' 2. Check if ANY users exist in the database
                Dim checkEmptySql As String = "SELECT COUNT(*) FROM tbl_users"
                Dim totalUsers As Integer
                Using cmdCheck As New SqlCommand(checkEmptySql, con)
                    totalUsers = Convert.ToInt32(cmdCheck.ExecuteScalar())
                End Using

                ' 4. Normal Database Login
                Dim sql As String = "SELECT COUNT(*) FROM tbl_users WHERE uname = @user AND passw = @pass AND role = @role"
                Using cmd As New SqlCommand(sql, con)
                    cmd.Parameters.AddWithValue("@user", username)
                    cmd.Parameters.AddWithValue("@pass", password)
                    cmd.Parameters.AddWithValue("@role", role)

                    Dim userExists As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    If userExists > 0 Then
                        LoginSuccess(role)
                    Else
                        MsgBox("Invalid Credentials. Please check your username, password, and role.", MsgBoxStyle.Critical, "Login Failed")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Database Error: " & ex.Message)
        End Try
    End Sub

    ' Helper method to keep code clean
    Private Sub LoginSuccess(ByVal role As String)
        ' Set your global variable here so frmMain knows the role
        ' modGlobal.CurrentUserRole = role 

        Dim main As New frmMain()
        main.Show()
        Me.Hide()
    End Sub

    ' Allow pressing Enter key to login
    Private Sub txtPassword_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin_Click(sender, e)
        End If
    End Sub

    Private Sub txtUsername_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtUsername.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtPassword.Focus()
        End If
    End Sub

   Private Sub btnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNew.Click
        ' 1. Get details from the textboxes
        Dim newUser As String = txtUsername.Text.Trim()
        Dim newPass As String = txtPassword.Text.Trim()
        Dim newRole As String = ""

        ' 2. Check if a role is selected (Validation must happen BEFORE the Try block)
        If cmbRole.SelectedItem IsNot Nothing Then
            newRole = cmbRole.SelectedItem.ToString()
        Else
            MsgBox("Please select a Role first!", MsgBoxStyle.Exclamation)
            Return
        End If

        ' 3. Validate that fields aren't empty
        If newUser = "" Or newPass = "" Then
            MsgBox("Please enter a Username and Password to register.", MsgBoxStyle.Exclamation)
            Return
        End If

        ' 4. Insert into Database
        Try
            Using con As SqlConnection = GetConnection()
                con.Open()

                ' --- GET THE NEXT ID MANUALLY ---
                ' This solves the "AdID doesn't allow null" error
                Dim nextID As Integer = 1
                Dim cmdGetID As New SqlCommand("SELECT ISNULL(MAX(AdID), 0) + 1 FROM tbl_users", con)
                nextID = Convert.ToInt32(cmdGetID.ExecuteScalar())

                ' --- INSERT DATA ---
                ' We include AdID in the column list and the values
                Dim sql As String = "INSERT INTO tbl_users (AdID, uname, passw, role) VALUES (@id, @u, @p, @r)"

                Using cmd As New SqlCommand(sql, con)
                    cmd.Parameters.AddWithValue("@id", nextID)
                    cmd.Parameters.AddWithValue("@u", newUser)
                    cmd.Parameters.AddWithValue("@p", newPass)
                    cmd.Parameters.AddWithValue("@r", newRole)

                    cmd.ExecuteNonQuery()
                    MsgBox("User Registered Successfully with ID: " & nextID & ". You can now click Login.", MsgBoxStyle.Information)

                    ' Optional: Clear fields after success
                    txtUsername.Clear()
                    txtPassword.Clear()
                    cmbRole.SelectedIndex = -1
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Registration Error: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class