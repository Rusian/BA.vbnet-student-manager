<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.lblPassWord = New System.Windows.Forms.Label()
        Me.txtPassWord = New System.Windows.Forms.TextBox()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.rdbStudent = New System.Windows.Forms.RadioButton()
        Me.rdbTeacher = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label3.Location = New System.Drawing.Point(70, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(251, 12)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "_________________________________________"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(190, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 27)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "LOGIN"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("宋体", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label1.Location = New System.Drawing.Point(174, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 24)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "/"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.lblUser.Font = New System.Drawing.Font("微软雅黑", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblUser.Location = New System.Drawing.Point(84, 59)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(96, 28)
        Me.lblUser.TabIndex = 4
        Me.lblUser.Text = "用户登录"
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblUserName.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblUserName.Image = CType(resources.GetObject("lblUserName.Image"), System.Drawing.Image)
        Me.lblUserName.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblUserName.Location = New System.Drawing.Point(102, 108)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(77, 21)
        Me.lblUserName.TabIndex = 8
        Me.lblUserName.Text = "   用户名:"
        '
        'lblPassWord
        '
        Me.lblPassWord.AutoSize = True
        Me.lblPassWord.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblPassWord.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblPassWord.Image = CType(resources.GetObject("lblPassWord.Image"), System.Drawing.Image)
        Me.lblPassWord.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblPassWord.Location = New System.Drawing.Point(102, 141)
        Me.lblPassWord.Name = "lblPassWord"
        Me.lblPassWord.Size = New System.Drawing.Size(76, 21)
        Me.lblPassWord.TabIndex = 9
        Me.lblPassWord.Text = "   密   码:"
        '
        'txtPassWord
        '
        Me.txtPassWord.Location = New System.Drawing.Point(178, 141)
        Me.txtPassWord.Name = "txtPassWord"
        Me.txtPassWord.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassWord.Size = New System.Drawing.Size(109, 21)
        Me.txtPassWord.TabIndex = 11
        '
        'txtUserID
        '
        Me.txtUserID.Location = New System.Drawing.Point(178, 108)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(109, 21)
        Me.txtUserID.TabIndex = 10
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOK.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnOK.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnOK.Location = New System.Drawing.Point(89, 219)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 14
        Me.btnOK.Text = "登  录"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnCancel.Location = New System.Drawing.Point(223, 219)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 15
        Me.btnCancel.Text = "重  置"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'rdbStudent
        '
        Me.rdbStudent.AutoSize = True
        Me.rdbStudent.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.rdbStudent.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.rdbStudent.Location = New System.Drawing.Point(118, 179)
        Me.rdbStudent.Name = "rdbStudent"
        Me.rdbStudent.Size = New System.Drawing.Size(60, 25)
        Me.rdbStudent.TabIndex = 16
        Me.rdbStudent.TabStop = True
        Me.rdbStudent.Text = "学生"
        Me.rdbStudent.UseVisualStyleBackColor = True
        '
        'rdbTeacher
        '
        Me.rdbTeacher.AutoSize = True
        Me.rdbTeacher.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.rdbTeacher.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.rdbTeacher.Location = New System.Drawing.Point(208, 179)
        Me.rdbTeacher.Name = "rdbTeacher"
        Me.rdbTeacher.Size = New System.Drawing.Size(60, 25)
        Me.rdbTeacher.TabIndex = 17
        Me.rdbTeacher.TabStop = True
        Me.rdbTeacher.Text = "教师"
        Me.rdbTeacher.UseVisualStyleBackColor = True
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(424, 287)
        Me.Controls.Add(Me.rdbTeacher)
        Me.Controls.Add(Me.rdbStudent)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtUserID)
        Me.Controls.Add(Me.txtPassWord)
        Me.Controls.Add(Me.lblPassWord)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblUser)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLogin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents lblPassWord As System.Windows.Forms.Label
    Friend WithEvents txtPassWord As System.Windows.Forms.TextBox
    Friend WithEvents txtUserID As System.Windows.Forms.TextBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents rdbStudent As RadioButton
    Friend WithEvents rdbTeacher As RadioButton
End Class
