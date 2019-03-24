Public Class Login

    Private Sub txtPassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPassword.TextChanged
        txtPassword.PasswordChar = "*"
    End Sub
    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Version of ACCESS, source of data from database SKDB.mdb
        sProvider = "Provider=Microsoft.ACE.OLEDB.12.0;"
        sSource = "Data Source = " & Application.StartupPath & "\SKDB.mdb"

        'Connection to the database with the use of source path and version
        con.ConnectionString = sProvider & sSource
        con.Open()

        Me.FieldsHelp.SetToolTip(Me.txtUsername, "Enter you username! Must be under the limit of 15 characters.")
        Me.FieldsHelp.SetToolTip(Me.txtPassword, "Enter you password! Must be under the limit of 15 characters.")
        Me.FieldsHelp.SetToolTip(Me.btnLogin, "Click here to log in!")
        Me.FieldsHelp.SetToolTip(Me.lblRegister, "Click here to register!")
        Me.FieldsHelp.SetToolTip(Me.btnExit, "Click here to exit!")
    End Sub
    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Dim sName As String = txtUsername.Text
        Dim sPass As String = txtPassword.Text

        sSQL = "Select * From UserBase Where Username = '" & txtUsername.Text & "' And Password = '" & txtPassword.Text & "'"
        da = New OleDb.OleDbDataAdapter(sSQL, con)
        da.Fill(dsData, "UserBase")

        If dsData.Tables("UserBase").Rows.Count <> 0 Then
            MaximizeBox = True
            MinimizeBox = True
            MsgBox("Welcome! " + sName + ", " + vbNewLine + _
                   "Login Successful", MsgBoxStyle.OkOnly, _
                   "Welcome " + sName)
            Me.Hide()
            GameForm.Show()
        Else
            MaximizeBox = False
            MinimizeBox = False
            attempt = attempt + 1
            txtUsername.Text = ""
            txtPassword.Text = ""
            MsgBox("Oops, " & sName & "!" + vbNewLine + vbNewLine + _
                   "The username or password provided " + vbNewLine + _
                   "is incorrect!" + vbNewLine + _
                   "Please try again", MsgBoxStyle.Exclamation, "Invalid")
        End If

        If attempt = 3 Then
            MsgBox("The account is now blocked! ", MsgBoxStyle.Critical, "Come back later!")
            Me.Close()
        End If

        dsData.Clear()

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub lblRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblRegister.Click
        Register.Show()
    End Sub
End Class
