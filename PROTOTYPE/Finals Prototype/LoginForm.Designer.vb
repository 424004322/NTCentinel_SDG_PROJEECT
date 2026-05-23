<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        btnLogin = New Button()
        lblUserName = New Label()
        txtUserName = New TextBox()
        lblPassword = New Label()
        txtPassword = New TextBox()
        SuspendLayout()
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.FromArgb(CByte(227), CByte(223), CByte(185))
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Franklin Gothic Medium", 9.75F)
        btnLogin.ForeColor = Color.FromArgb(CByte(45), CByte(38), CByte(124))
        btnLogin.Location = New Point(81, 128)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(100, 30)
        btnLogin.TabIndex = 0
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' lblUserName
        ' 
        lblUserName.AutoSize = True
        lblUserName.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblUserName.ForeColor = Color.FromArgb(CByte(45), CByte(38), CByte(124))
        lblUserName.Location = New Point(81, 37)
        lblUserName.Name = "lblUserName"
        lblUserName.Size = New Size(64, 15)
        lblUserName.TabIndex = 1
        lblUserName.Text = "Username"
        ' 
        ' txtUserName
        ' 
        txtUserName.BackColor = Color.FromArgb(CByte(227), CByte(223), CByte(185))
        txtUserName.Location = New Point(81, 55)
        txtUserName.Name = "txtUserName"
        txtUserName.Size = New Size(100, 23)
        txtUserName.TabIndex = 2
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblPassword.ForeColor = Color.FromArgb(CByte(45), CByte(38), CByte(124))
        lblPassword.Location = New Point(81, 81)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(59, 15)
        lblPassword.TabIndex = 3
        lblPassword.Text = "Password"
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.FromArgb(CByte(227), CByte(223), CByte(185))
        txtPassword.Location = New Point(81, 99)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(100, 23)
        txtPassword.TabIndex = 4
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(227), CByte(223), CByte(185))
        ClientSize = New Size(251, 195)
        Controls.Add(txtPassword)
        Controls.Add(lblPassword)
        Controls.Add(txtUserName)
        Controls.Add(lblUserName)
        Controls.Add(btnLogin)
        ForeColor = SystemColors.ControlText
        Name = "LoginForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "LoginForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnLogin As Button
    Friend WithEvents lblUserName As Label
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtPassword As TextBox
End Class
