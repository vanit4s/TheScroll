Public Class Register

    Private Sub Register_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Me.FieldsHelp.SetToolTip(Me.txtUsername, "Enter you username! Must be under the limit of 15 characters!")
        Me.FieldsHelp.SetToolTip(Me.txtPassword, "Enter you password! Must be under the limit of 15 characters!")
        Me.FieldsHelp.SetToolTip(Me.btnSubmit, "Click here to register!")
        Me.FieldsHelp.SetToolTip(Me.txtEmail, "Enter you eMail!")
        Me.FieldsHelp.SetToolTip(Me.txtPasswordRep, "Make sure to repeat your password here!")
        Me.FieldsHelp.SetToolTip(Me.txtAge, "Enter your age! You must be over the age of 12!")
    End Sub

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        Dim sUsername As String = txtUsername.Text
        Dim sPassword As String = txtPassword.Text
        Dim sPasswordRep As String = txtPasswordRep.Text
        Dim sEmail As String = txtEmail.Text
        Dim iAge As Integer = Val(txtAge.Text)

        Call Validation()

        'sSQL = "INSERT INTO UserBase ( `Username`, `Password`, `eMail`, `Age`)" & _
        '           "VALUES ('" & txtUsername.Text & "','" & txtPassword.Text & "','" & txtEmail.Text & "','" & Val(txtAge.Text)

        sSQL = "INSERT INTO UserBase (Username, Password, eMail, Age) VALUES (@Username,@Password,@eMail,@Age)"

        Using con = New OleDb.OleDbConnection(sProvider & sSource)
            Using cmd = New OleDb.OleDbCommand(sSQL, con)
                con.Open()
                cmd.Parameters.AddWithValue("@Username", sUsername)
                cmd.Parameters.AddWithValue("@Password", sPassword)
                cmd.Parameters.AddWithValue("@eMail", sEmail)
                cmd.Parameters.AddWithValue("@Age", iAge)
                cmd.ExecuteNonQuery()
            End Using
        End Using


        If dsData.Tables("UserBase").Rows.Count <> 0 Then
            MaximizeBox = True
            MinimizeBox = True
            MsgBox("Welcome! " + sUsername + ", " + vbNewLine + _
                   "Registration Successful", MsgBoxStyle.OkOnly)
            Me.Close()
            Login.Show()
        Else
            txtUsername.Text = ""
            txtPassword.Text = ""
            MsgBox("Try again!")
        End If


    End Sub

    Public Sub Validation()

        If txtUsername.Text.Length > 15 Or txtUsername.Text.Length <= 4 Then
            MsgBox("Your username is over the limit of 15 characters!")
            txtUsername.Text = ""
            txtPassword.Text = ""
            txtPasswordRep.Text = ""
            txtAge.Text = ""
        ElseIf txtPassword.Text.Length > 15 Then
            MsgBox("Your password is over the limit of 15 characters!")
            txtUsername.Text = ""
            txtPassword.Text = ""
            txtPasswordRep.Text = ""
            txtAge.Text = ""
        ElseIf txtPasswordRep.Text <> txtPassword.Text Then
            MsgBox("The passwords don't match!")
            txtUsername.Text = ""
            txtPassword.Text = ""
            txtPasswordRep.Text = ""
            txtAge.Text = ""
        ElseIf txtEmail.Text.Length > 20 Then
            MsgBox("Email adress is too long!")
            txtUsername.Text = ""
            txtPassword.Text = ""
            txtPasswordRep.Text = ""
            txtAge.Text = ""
        ElseIf Val(txtAge.Text) < 12 And Val(txtAge.Text) > 0 And Val(txtAge.Text) > 105 Then
            MsgBox("You've entered the wrong age, you must be over 12!")
            txtUsername.Text = ""
            txtPassword.Text = ""
            txtPasswordRep.Text = ""
            txtAge.Text = ""
        Else
            MsgBox("You haven't filled out the form!")
            txtUsername.Text = ""
            txtPassword.Text = ""
            txtPasswordRep.Text = ""
            txtAge.Text = ""
        End If

    End Sub

    Private Sub txtPassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPassword.TextChanged
        txtPassword.PasswordChar = "*"
    End Sub

    Private Sub txtPasswordRep_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPasswordRep.TextChanged
        txtPasswordRep.PasswordChar = "*"
    End Sub
End Class