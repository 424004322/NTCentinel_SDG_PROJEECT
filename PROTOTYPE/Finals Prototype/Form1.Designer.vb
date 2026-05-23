<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblStudentID = New Label()
        txtStudentID = New TextBox()
        lblStudentName = New Label()
        txtStudentName = New TextBox()
        lblViolation = New Label()
        cboViolation = New ComboBox()
        btnSubmit = New Button()
        pcBox = New PictureBox()
        lbReciept = New ListBox()
        btnSearch = New Button()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        CType(pcBox, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblStudentID
        ' 
        lblStudentID.AutoSize = True
        lblStudentID.BackColor = Color.FromArgb(CByte(227), CByte(223), CByte(185))
        lblStudentID.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStudentID.ForeColor = Color.FromArgb(CByte(45), CByte(38), CByte(124))
        lblStudentID.Location = New Point(159, 24)
        lblStudentID.Name = "lblStudentID"
        lblStudentID.Size = New Size(71, 15)
        lblStudentID.TabIndex = 0
        lblStudentID.Text = "Student ID:"
        ' 
        ' txtStudentID
        ' 
        txtStudentID.BackColor = Color.FromArgb(CByte(227), CByte(223), CByte(185))
        txtStudentID.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtStudentID.Location = New Point(159, 51)
        txtStudentID.Multiline = True
        txtStudentID.Name = "txtStudentID"
        txtStudentID.Size = New Size(185, 32)
        txtStudentID.TabIndex = 1
        ' 
        ' lblStudentName
        ' 
        lblStudentName.AutoSize = True
        lblStudentName.BackColor = Color.Transparent
        lblStudentName.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStudentName.ForeColor = Color.FromArgb(CByte(45), CByte(38), CByte(124))
        lblStudentName.Location = New Point(18, 144)
        lblStudentName.Name = "lblStudentName"
        lblStudentName.Size = New Size(88, 15)
        lblStudentName.TabIndex = 2
        lblStudentName.Text = "Student Name"
        ' 
        ' txtStudentName
        ' 
        txtStudentName.BackColor = Color.FromArgb(CByte(227), CByte(223), CByte(185))
        txtStudentName.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtStudentName.Location = New Point(18, 153)
        txtStudentName.Multiline = True
        txtStudentName.Name = "txtStudentName"
        txtStudentName.ReadOnly = True
        txtStudentName.Size = New Size(326, 41)
        txtStudentName.TabIndex = 3
        ' 
        ' lblViolation
        ' 
        lblViolation.AutoSize = True
        lblViolation.BackColor = Color.Transparent
        lblViolation.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblViolation.ForeColor = Color.FromArgb(CByte(45), CByte(38), CByte(124))
        lblViolation.Location = New Point(18, 207)
        lblViolation.Name = "lblViolation"
        lblViolation.Size = New Size(56, 15)
        lblViolation.TabIndex = 4
        lblViolation.Text = "Violation"
        ' 
        ' cboViolation
        ' 
        cboViolation.BackColor = Color.FromArgb(CByte(227), CByte(223), CByte(185))
        cboViolation.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cboViolation.FormattingEnabled = True
        cboViolation.Items.AddRange(New Object() {"No ID", "Improper Uniform", "Prohibited Substance"})
        cboViolation.Location = New Point(18, 216)
        cboViolation.Name = "cboViolation"
        cboViolation.Size = New Size(326, 33)
        cboViolation.TabIndex = 5
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.FromArgb(CByte(227), CByte(223), CByte(185))
        btnSubmit.FlatStyle = FlatStyle.Flat
        btnSubmit.Font = New Font("Franklin Gothic Medium", 9.75F)
        btnSubmit.ForeColor = Color.FromArgb(CByte(45), CByte(38), CByte(124))
        btnSubmit.Location = New Point(18, 255)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(326, 44)
        btnSubmit.TabIndex = 10
        btnSubmit.Text = "SUBMIT"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' pcBox
        ' 
        pcBox.Location = New Point(18, 305)
        pcBox.Name = "pcBox"
        pcBox.Size = New Size(326, 161)
        pcBox.SizeMode = PictureBoxSizeMode.StretchImage
        pcBox.TabIndex = 11
        pcBox.TabStop = False
        ' 
        ' lbReciept
        ' 
        lbReciept.BackColor = Color.FromArgb(CByte(227), CByte(223), CByte(185))
        lbReciept.Font = New Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbReciept.ForeColor = Color.FromArgb(CByte(45), CByte(38), CByte(124))
        lbReciept.FormattingEnabled = True
        lbReciept.Location = New Point(350, 12)
        lbReciept.Name = "lbReciept"
        lbReciept.Size = New Size(336, 284)
        lbReciept.TabIndex = 12
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.FromArgb(CByte(227), CByte(223), CByte(185))
        btnSearch.BackgroundImageLayout = ImageLayout.None
        btnSearch.FlatStyle = FlatStyle.Popup
        btnSearch.Font = New Font("Franklin Gothic Medium", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSearch.ForeColor = Color.FromArgb(CByte(45), CByte(38), CByte(124))
        btnSearch.Location = New Point(159, 89)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(185, 45)
        btnSearch.TabIndex = 14
        btnSearch.Text = "SEARCH"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.NTCENTINEL_LOGO
        PictureBox1.Location = New Point(-52, -30)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(256, 206)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 15
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.NTCENTINEL_BANNER
        PictureBox2.Location = New Point(350, 305)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(336, 161)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 16
        PictureBox2.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(227), CByte(223), CByte(185))
        ClientSize = New Size(702, 482)
        Controls.Add(lblViolation)
        Controls.Add(lblStudentName)
        Controls.Add(PictureBox2)
        Controls.Add(btnSearch)
        Controls.Add(lbReciept)
        Controls.Add(pcBox)
        Controls.Add(btnSubmit)
        Controls.Add(cboViolation)
        Controls.Add(txtStudentName)
        Controls.Add(txtStudentID)
        Controls.Add(lblStudentID)
        Controls.Add(PictureBox1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Student Records - NTCentinel v1.0"
        CType(pcBox, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblStudentID As Label
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents lblStudentName As Label
    Friend WithEvents txtStudentName As TextBox
    Friend WithEvents lblViolation As Label
    Friend WithEvents cboViolation As ComboBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents pcBox As PictureBox
    Friend WithEvents lbReciept As ListBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel

End Class
