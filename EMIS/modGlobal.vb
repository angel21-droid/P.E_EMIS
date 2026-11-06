Imports System.Data.SqlClient

Module modGlobal
    ' This stores the role (Admin/Staff) of the person who logged in
    Public CurrentUserRole As String = "ADMIN"
    Public Function getConnection() As SqlConnection
        Dim str As String = "Data Source=.\SQLEXPRESS;AttachDbFilename=C:\EMIS\EMIS\Database1.mdf;Integrated Security=True;User Instance=True"
        Return New SqlConnection(str)
    End Function
End Module
