<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudentInfoAdd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStudentInfoAdd))
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.PictureBoxInfo = New System.Windows.Forms.PictureBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.cmbCity = New System.Windows.Forms.ComboBox()
        Me.lblSheng = New System.Windows.Forms.Label()
        Me.cmbSheng = New System.Windows.Forms.ComboBox()
        Me.lblPlace = New System.Windows.Forms.Label()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.cmbDay = New System.Windows.Forms.ComboBox()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.cmbMonth = New System.Windows.Forms.ComboBox()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.rdbWoman = New System.Windows.Forms.RadioButton()
        Me.rdbMan = New System.Windows.Forms.RadioButton()
        Me.lblSex = New System.Windows.Forms.Label()
        Me.lblBirth = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblDept = New System.Windows.Forms.Label()
        Me.cmbDeptName = New System.Windows.Forms.ComboBox()
        Me.lblUName = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PictureBoxInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbl1.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbl1.Location = New System.Drawing.Point(315, 89)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(44, 60)
        Me.lbl1.TabIndex = 87
        Me.lbl1.Text = "可选择" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " 上传" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " 照片"
        '
        'PictureBoxInfo
        '
        Me.PictureBoxInfo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxInfo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PictureBoxInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxInfo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxInfo.Location = New System.Drawing.Point(285, 54)
        Me.PictureBoxInfo.Name = "PictureBoxInfo"
        Me.PictureBoxInfo.Size = New System.Drawing.Size(97, 123)
        Me.PictureBoxInfo.TabIndex = 86
        Me.PictureBoxInfo.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("楷体", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(212, 426)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 26)
        Me.btnCancel.TabIndex = 85
        Me.btnCancel.Text = "取消"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOK.Font = New System.Drawing.Font("楷体", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnOK.Location = New System.Drawing.Point(84, 426)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 26)
        Me.btnOK.TabIndex = 84
        Me.btnOK.Text = "提交"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblCity.Location = New System.Drawing.Point(366, 252)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(21, 14)
        Me.lblCity.TabIndex = 83
        Me.lblCity.Text = "市"
        '
        'cmbCity
        '
        Me.cmbCity.FormattingEnabled = True
        Me.cmbCity.Location = New System.Drawing.Point(273, 250)
        Me.cmbCity.Name = "cmbCity"
        Me.cmbCity.Size = New System.Drawing.Size(87, 20)
        Me.cmbCity.TabIndex = 82
        '
        'lblSheng
        '
        Me.lblSheng.AutoSize = True
        Me.lblSheng.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblSheng.Location = New System.Drawing.Point(246, 254)
        Me.lblSheng.Name = "lblSheng"
        Me.lblSheng.Size = New System.Drawing.Size(21, 14)
        Me.lblSheng.TabIndex = 81
        Me.lblSheng.Text = "省"
        '
        'cmbSheng
        '
        Me.cmbSheng.FormattingEnabled = True
        Me.cmbSheng.Items.AddRange(New Object() {"江苏", "浙江", "山东"})
        Me.cmbSheng.Location = New System.Drawing.Point(142, 251)
        Me.cmbSheng.Name = "cmbSheng"
        Me.cmbSheng.Size = New System.Drawing.Size(101, 20)
        Me.cmbSheng.TabIndex = 80
        '
        'lblPlace
        '
        Me.lblPlace.AutoSize = True
        Me.lblPlace.Font = New System.Drawing.Font("楷体", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblPlace.Location = New System.Drawing.Point(53, 252)
        Me.lblPlace.Name = "lblPlace"
        Me.lblPlace.Size = New System.Drawing.Size(49, 19)
        Me.lblPlace.TabIndex = 79
        Me.lblPlace.Text = "籍贯"
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblDay.Location = New System.Drawing.Point(365, 202)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(21, 14)
        Me.lblDay.TabIndex = 78
        Me.lblDay.Text = "日"
        '
        'cmbDay
        '
        Me.cmbDay.FormattingEnabled = True
        Me.cmbDay.Location = New System.Drawing.Point(307, 198)
        Me.cmbDay.Name = "cmbDay"
        Me.cmbDay.Size = New System.Drawing.Size(52, 20)
        Me.cmbDay.TabIndex = 77
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblMonth.Location = New System.Drawing.Point(280, 202)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(21, 14)
        Me.lblMonth.TabIndex = 76
        Me.lblMonth.Text = "月"
        '
        'cmbMonth
        '
        Me.cmbMonth.FormattingEnabled = True
        Me.cmbMonth.Location = New System.Drawing.Point(226, 199)
        Me.cmbMonth.Name = "cmbMonth"
        Me.cmbMonth.Size = New System.Drawing.Size(52, 20)
        Me.cmbMonth.TabIndex = 75
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblYear.Location = New System.Drawing.Point(208, 202)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(21, 14)
        Me.lblYear.TabIndex = 74
        Me.lblYear.Text = "年"
        '
        'cmbYear
        '
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Items.AddRange(New Object() {"2016", "2015", "2014", "2013", "2012", "2011", "2010", "2009", "2008", "2007", "2006", "2005", "2004", "2003", "2002", "2001", "2000", "1999", "1998", "1997", "1996", "1995", "1994", "1993"})
        Me.cmbYear.Location = New System.Drawing.Point(141, 199)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(61, 20)
        Me.cmbYear.TabIndex = 73
        '
        'rdbWoman
        '
        Me.rdbWoman.AutoSize = True
        Me.rdbWoman.Font = New System.Drawing.Font("宋体", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.rdbWoman.Location = New System.Drawing.Point(143, 147)
        Me.rdbWoman.Name = "rdbWoman"
        Me.rdbWoman.Size = New System.Drawing.Size(46, 23)
        Me.rdbWoman.TabIndex = 72
        Me.rdbWoman.TabStop = True
        Me.rdbWoman.Text = "女"
        Me.rdbWoman.UseVisualStyleBackColor = True
        '
        'rdbMan
        '
        Me.rdbMan.AutoSize = True
        Me.rdbMan.Font = New System.Drawing.Font("宋体", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.rdbMan.Location = New System.Drawing.Point(143, 106)
        Me.rdbMan.Name = "rdbMan"
        Me.rdbMan.Size = New System.Drawing.Size(46, 23)
        Me.rdbMan.TabIndex = 71
        Me.rdbMan.TabStop = True
        Me.rdbMan.Text = "男"
        Me.rdbMan.UseVisualStyleBackColor = True
        '
        'lblSex
        '
        Me.lblSex.AutoSize = True
        Me.lblSex.Font = New System.Drawing.Font("楷体", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblSex.Location = New System.Drawing.Point(53, 110)
        Me.lblSex.Name = "lblSex"
        Me.lblSex.Size = New System.Drawing.Size(49, 19)
        Me.lblSex.TabIndex = 70
        Me.lblSex.Text = "性别"
        '
        'lblBirth
        '
        Me.lblBirth.AutoSize = True
        Me.lblBirth.Font = New System.Drawing.Font("楷体", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblBirth.Location = New System.Drawing.Point(53, 199)
        Me.lblBirth.Name = "lblBirth"
        Me.lblBirth.Size = New System.Drawing.Size(49, 19)
        Me.lblBirth.TabIndex = 69
        Me.lblBirth.Text = "生日"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblName.Font = New System.Drawing.Font("楷体", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblName.Location = New System.Drawing.Point(53, 61)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(49, 19)
        Me.lblName.TabIndex = 68
        Me.lblName.Text = "姓名"
        '
        'lblDept
        '
        Me.lblDept.AutoSize = True
        Me.lblDept.Font = New System.Drawing.Font("楷体", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblDept.Location = New System.Drawing.Point(53, 296)
        Me.lblDept.Name = "lblDept"
        Me.lblDept.Size = New System.Drawing.Size(49, 19)
        Me.lblDept.TabIndex = 90
        Me.lblDept.Text = "系别"
        '
        'cmbDeptName
        '
        Me.cmbDeptName.FormattingEnabled = True
        Me.cmbDeptName.Items.AddRange(New Object() {"计算机信息工程学院", "电气与光电工程学院", "外国语学院"})
        Me.cmbDeptName.Location = New System.Drawing.Point(142, 299)
        Me.cmbDeptName.Name = "cmbDeptName"
        Me.cmbDeptName.Size = New System.Drawing.Size(184, 20)
        Me.cmbDeptName.TabIndex = 91
        '
        'lblUName
        '
        Me.lblUName.AutoSize = True
        Me.lblUName.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblUName.Location = New System.Drawing.Point(140, 63)
        Me.lblUName.Name = "lblUName"
        Me.lblUName.Size = New System.Drawing.Size(56, 16)
        Me.lblUName.TabIndex = 92
        Me.lblUName.Text = "Label1"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmStudentInfoAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(719, 532)
        Me.Controls.Add(Me.lblUName)
        Me.Controls.Add(Me.cmbDeptName)
        Me.Controls.Add(Me.lblDept)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.PictureBoxInfo)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.lblCity)
        Me.Controls.Add(Me.cmbCity)
        Me.Controls.Add(Me.lblSheng)
        Me.Controls.Add(Me.cmbSheng)
        Me.Controls.Add(Me.lblPlace)
        Me.Controls.Add(Me.lblDay)
        Me.Controls.Add(Me.cmbDay)
        Me.Controls.Add(Me.lblMonth)
        Me.Controls.Add(Me.cmbMonth)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.cmbYear)
        Me.Controls.Add(Me.rdbWoman)
        Me.Controls.Add(Me.rdbMan)
        Me.Controls.Add(Me.lblSex)
        Me.Controls.Add(Me.lblBirth)
        Me.Controls.Add(Me.lblName)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmStudentInfoAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "学生个人信息修改"
        CType(Me.PictureBoxInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl1 As Label
    Friend WithEvents PictureBoxInfo As PictureBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents lblCity As Label
    Friend WithEvents cmbCity As ComboBox
    Friend WithEvents lblSheng As Label
    Friend WithEvents cmbSheng As ComboBox
    Friend WithEvents lblPlace As Label
    Friend WithEvents lblDay As Label
    Friend WithEvents cmbDay As ComboBox
    Friend WithEvents lblMonth As Label
    Friend WithEvents cmbMonth As ComboBox
    Friend WithEvents lblYear As Label
    Friend WithEvents cmbYear As ComboBox
    Friend WithEvents rdbWoman As RadioButton
    Friend WithEvents rdbMan As RadioButton
    Friend WithEvents lblSex As Label
    Friend WithEvents lblBirth As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblDept As Label
    Friend WithEvents cmbDeptName As ComboBox
    Friend WithEvents lblUName As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
