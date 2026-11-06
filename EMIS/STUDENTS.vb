Imports System.Data.SqlClient

Public Class frmStudents

    Private Sub frmStudents_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        LoadStudents()
        LoadGradeLevels()
    End Sub

    '==========================================
    ' LOAD GRADE LEVELS INTO COMBOBOX
    '==========================================
    Private Sub LoadGradeLevels()
        cboGradeLevel.Items.Clear()
        cboGradeLevel.Items.Add("Grade 7")
        cboGradeLevel.Items.Add("Grade 8")
        cboGradeLevel.Items.Add("Grade 9")
        cboGradeLevel.Items.Add("Grade 10")
        cboGradeLevel.Items.Add("Grade 11")
        cboGradeLevel.Items.Add("Grade 12")
        cboGradeLevel.SelectedIndex = 0
    End Sub

    '==========================================
    ' LOAD STUDENTS INTO DATAGRIDVIEW
    '==========================================
    Private Sub LoadStudents()
        Try
            Dim con As SqlConnection = GetConnection()
            con.Open()

            Dim sql As String = "SELECT StudentID, StudentLRN, FirstName, LastName, " &
                                "GradeLevel, Section, DateAdded FROM tbl_Students " &
                                "ORDER BY LastName ASC"

            Dim da As New SqlDataAdapter(sql, con)
            Dim dt As New DataTable()
            da.Fill(dt)

            dgvStudents.DataSource = dt

            ' Rename column headers
            dgvStudents.Columns("StudentID").Visible = False
            dgvStudents.Columns("StudentLRN").HeaderText = "LRN"
            dgvStudents.Columns("FirstName").HeaderText = "First Name"
            dgvStudents.Columns("LastName").HeaderText = "Last Name"
            dgvStudents.Columns("GradeLevel").HeaderText = "Grade Level"
            dgvStudents.Columns("Section").HeaderText = "Section"
            dgvStudents.Columns("DateAdded").HeaderText = "Date Added"

            ' Style the grid
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvStudents.ReadOnly = True
            dgvStudents.AllowUserToAddRows = False
            dgvStudents.RowHeadersVisible = False

            con.Close()

        Catch ex As Exception
            MsgBox("Error loading students: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    '==========================================
    ' CLEAR FIELDS
    '==========================================
    Private Sub ClearFields()
        txtStudentLRN.Text = ""
        txtFirstName.Text = ""
        txtLastName.Text = ""
        cboGradeLevel.SelectedIndex = 0
        txtSection.Text = ""
        txtSearchStudent.Text = ""
        btnAddStudent.Enabled = True
        dgvStudents.ClearSelection()
    End Sub

    '==========================================
    ' VALIDATE FIELDS
    '==========================================
    Private Function ValidateFields() As Boolean
        If txtStudentLRN.Text.Trim = "" Then
            MsgBox("Please enter Student LRN.", MsgBoxStyle.Exclamation, "Validation")
            txtStudentLRN.Focus()
            Return False
        End If

        If txtFirstName.Text.Trim = "" Then
            MsgBox("Please enter First Name.", MsgBoxStyle.Exclamation, "Validation")
            txtFirstName.Focus()
            Return False
        End If

        If txtLastName.Text.Trim = "" Then
            MsgBox("Please enter Last Name.", MsgBoxStyle.Exclamation, "Validation")
            txtLastName.Focus()
            Return False
        End If

        If txtSection.Text.Trim = "" Then
            MsgBox("Please enter Section.", MsgBoxStyle.Exclamation, "Validation")
            txtSection.Focus()
            Return False
        End If

        Return True
    End Function

    '==========================================
    ' CHECK IF LRN ALREADY EXISTS
    '==========================================
    Private Function LRN_Exists(ByVal lrn As String, Optional ByVal excludeID As Integer = 0) As Boolean
        Try
            Dim con As SqlConnection = getConnection()
            con.Open()

            Dim sql As String = "SELECT COUNT(*) FROM tbl_Students WHERE StudentLRN = @LRN AND StudentID <> @ID"
            Dim cmd As New SqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@LRN", lrn)
            cmd.Parameters.AddWithValue("@ID", excludeID)

            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            con.Close()

            Return count > 0

        Catch ex As Exception
            MsgBox("Error checking LRN: " & ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    '==========================================
    ' ADD STUDENT BUTTON
    '==========================================
    Private Sub btnAddStudent_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddStudent.Click
        ' Validation: Ensure required fields aren't empty
        If txtStudentLRN.Text.Trim = "" Or txtFirstName.Text.Trim = "" Or txtLastName.Text.Trim = "" Or cboGradeLevel.SelectedIndex = -1 Then
            MsgBox("Please fill in all required fields (LRN, Names, and Grade Level).", MsgBoxStyle.Exclamation, "Missing Info")
            Return
        End If

        ' Check if LRN already exists
        If LRNExists(txtStudentLRN.Text.Trim, 0) Then
            MsgBox("A student with this LRN already exists.", MsgBoxStyle.Critical, "Duplicate LRN")
            Return
        End If

        Try
            Using con As SqlConnection = GetConnection()
                con.Open()
                Dim sql As String = "INSERT INTO tbl_Students (StudentLRN, FirstName, LastName, GradeLevel, Section, DateAdded) " &
                                    "VALUES (@LRN, @FN, @LN, @GL, @S, @Date)"
                Using cmd As New SqlCommand(sql, con)
                    cmd.Parameters.AddWithValue("@LRN", txtStudentLRN.Text.Trim)
                    cmd.Parameters.AddWithValue("@FN", txtFirstName.Text.Trim)
                    cmd.Parameters.AddWithValue("@LN", txtLastName.Text.Trim)
                    cmd.Parameters.AddWithValue("@GL", cboGradeLevel.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@S", txtSection.Text.Trim)
                    cmd.Parameters.AddWithValue("@Date", DateTime.Now)

                    cmd.ExecuteNonQuery()
                    MsgBox("Student registered successfully!", MsgBoxStyle.Information, "Success")

                    ClearFields()
                    LoadStudents() ' Refresh the grid
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error adding student: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    '==========================================
    ' UPDATE STUDENT BUTTON
    '==========================================
    Private Sub btnUpdateStudent_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateStudent.Click
        If dgvStudents.SelectedRows.Count = 0 Then
            MsgBox("Please select a student from the list to update.", MsgBoxStyle.Exclamation)
            Return
        End If

        Dim studentID As Integer = Convert.ToInt32(dgvStudents.SelectedRows(0).Cells("StudentID").Value)

        ' Check if LRN already exists for another student
        If LRNExists(txtStudentLRN.Text.Trim, studentID) Then
            MsgBox("Another student with this LRN already exists.", MsgBoxStyle.Exclamation, "Duplicate LRN")
            Return
        End If

        If MsgBox("Are you sure you want to update this student?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.No Then Return

        Try
            Using con As SqlConnection = GetConnection()
                con.Open()
                Dim sql As String = "UPDATE tbl_Students SET StudentLRN = @LRN, FirstName = @FirstName, " &
                                    "LastName = @LastName, GradeLevel = @GradeLevel, Section = @Section " &
                                    "WHERE StudentID = @ID"

                Using cmd As New SqlCommand(sql, con)
                    cmd.Parameters.AddWithValue("@LRN", txtStudentLRN.Text.Trim)
                    cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim)
                    cmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim)
                    cmd.Parameters.AddWithValue("@GradeLevel", cboGradeLevel.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@Section", txtSection.Text.Trim)
                    cmd.Parameters.AddWithValue("@ID", studentID)

                    cmd.ExecuteNonQuery()
                    MsgBox("Student updated successfully!", MsgBoxStyle.Information)

                    ClearFields()
                    LoadStudents()
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error updating student: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    '==========================================
    ' DELETE STUDENT BUTTON
    '==========================================
    Private Sub btnDeleteStudent_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteStudent.Click
        If dgvStudents.SelectedRows.Count = 0 Then
            MsgBox("Please select a student to delete.", MsgBoxStyle.Exclamation)
            Return
        End If

        If MsgBox("Are you sure you want to delete this student? This cannot be undone.", MsgBoxStyle.YesNo + MsgBoxStyle.Critical) = MsgBoxResult.No Then Return

        Dim studentID As Integer = Convert.ToInt32(dgvStudents.SelectedRows(0).Cells("StudentID").Value)

        Try
            Using con As SqlConnection = GetConnection()
                con.Open()
                Dim sql As String = "DELETE FROM tbl_Students WHERE StudentID = @ID"
                Using cmd As New SqlCommand(sql, con)
                    cmd.Parameters.AddWithValue("@ID", studentID)
                    cmd.ExecuteNonQuery()
                    MsgBox("Student deleted successfully!", MsgBoxStyle.Information)

                    ClearFields()
                    LoadStudents()
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error deleting student: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    '==========================================
    ' HELPER FUNCTION: PREVENT DUPLICATE LRN
    '==========================================
    Private Function LRNExists(ByVal lrn As String, ByVal currentID As Integer) As Boolean
        Dim exists As Boolean = False
        Try
            Using con As SqlConnection = GetConnection()
                con.Open()
                ' Checks if LRN exists, but ignores the current student's ID (for updates)
                Dim sql As String = "SELECT COUNT(*) FROM tbl_Students WHERE StudentLRN = @LRN AND StudentID <> @ID"
                Using cmd As New SqlCommand(sql, con)
                    cmd.Parameters.AddWithValue("@LRN", lrn)
                    cmd.Parameters.AddWithValue("@ID", currentID)
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    If count > 0 Then exists = True
                End Using
            End Using
        Catch ex As Exception
            ' If there's a DB error, we return false but show a message
            MsgBox("Validation Error: " & ex.Message)
        End Try
        Return exists
    End Function

    Private Sub dgvStudents_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvStudents.CellClick
        Try
            ' This ensures the code only runs if you click a row, not the header text
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow = dgvStudents.Rows(e.RowIndex)

                ' Fill the Textboxes using the actual Database Column Names
                txtStudentLRN.Text = row.Cells("StudentLRN").Value.ToString()
                txtFirstName.Text = row.Cells("FirstName").Value.ToString()
                txtLastName.Text = row.Cells("LastName").Value.ToString()
                txtSection.Text = row.Cells("Section").Value.ToString()

                ' Set the ComboBox (Grade Level)
                ' We use .Text so it matches the string "Grade 7", "Grade 8", etc.
                cboGradeLevel.Text = row.Cells("GradeLevel").Value.ToString()

                ' Disable the Add button so you don't accidentally create a duplicate
                ' while you are in "Edit Mode"
                btnAddStudent.Enabled = False
            End If
        Catch ex As Exception
            ' If there is a typo in a column name, this will tell you which one
            MsgBox("Error selecting student: " & ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub
End Class