Imports System
Imports System.IO
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports StudentModel
Imports StudentBLL
Public Class frmStudentInfoAdd
    Private Sub frmStudentInfoAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblName.BackColor = Color.Transparent
        lblPlace.BackColor = Color.Transparent
        lblSex.BackColor = Color.Transparent
        lblSheng.BackColor = Color.Transparent
        lblDay.BackColor = Color.Transparent
        lblDept.BackColor = Color.Transparent
        lblMonth.BackColor = Color.Transparent
        lblYear.BackColor = Color.Transparent
        lblCity.BackColor = Color.Transparent
        lblBirth.BackColor = Color.Transparent
        lblUName.BackColor = Color.Transparent
        rdbWoman.BackColor = Color.Transparent
        rdbMan.BackColor = Color.Transparent

    End Sub



    Private Sub cmbYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbYear.SelectedIndexChanged
        Dim i As Integer
        '=========对月份下拉框进行对应的城市加载===================
        '清除月列表中现有的月份
        cmbMonth.Items.Clear()
        cmbMonth.Text = ""
        ''加载新的可选项
        For i = 1 To 9
            cmbMonth.Items.Add("0" + i.ToString())
        Next i
        For i = 10 To 12
                cmbMonth.Items.Add(i.ToString())
            Next i

            '=========对日份下拉框进行对应的城市加载===================
            '清除月列表中现有的日份
            cmbDay.Items.Clear()
        cmbDay.Text = ""
        '加载新的可选项

        For i = 1 To 9
            cmbDay.Items.Add("0" + i.ToString())
        Next i
        For i = 10 To 31
            cmbDay.Items.Add(i.ToString())
        Next i


    End Sub
    Private Sub cmbSheng_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSheng.SelectedIndexChanged
        Dim strSelectedSheng As String

        '=========对市下拉框进行对应的城市加载===================
        '清除城市列表中现有城市
        cmbCity.Items.Clear()
        cmbCity.Text = ""
        '加载选择的省所对应的城市
        '获取当前选择的省份
        strSelectedSheng = cmbSheng.Text.Trim()
        '根据不同的省份加载不同的城市

        If strSelectedSheng.Equals("江苏") Then
            cmbCity.Items.Add("南京")
            cmbCity.Items.Add("无锡")
            cmbCity.Items.Add("徐州")
            cmbCity.Items.Add("常州")
            cmbCity.Items.Add("苏州")
            cmbCity.Items.Add("南通")
            cmbCity.Items.Add("连云港")
            cmbCity.Items.Add("淮安")
            cmbCity.Items.Add("盐城")
            cmbCity.Items.Add("扬州")
            cmbCity.Items.Add("镇江")
            cmbCity.Items.Add("泰州")
            cmbCity.Items.Add("宿迁")
        ElseIf strSelectedSheng.Equals("山东") Then
            cmbCity.Items.Add("济南")
            cmbCity.Items.Add("烟台")
            cmbCity.Items.Add("青岛")
            cmbCity.Items.Add("日照")
        ElseIf strSelectedSheng.Equals("浙江") Then
            cmbCity.Items.Add("杭州")
            cmbCity.Items.Add("嘉兴")
            cmbCity.Items.Add("宁波")
        End If
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim strID As String
        Dim strName As String
        Dim strSex As String
        Dim strBirthDate As String
        Dim strBirthYear As String
        Dim intBirthYear As Integer
        Dim intAge As Integer
        Dim strAddress As String
        Dim strDeptName As String
        Dim strDeptNo As String

        Dim st As New Student
        Dim ret As Boolean
        Dim studentManager As New StudentManger

        '从主界面获取学生信息


        If rdbMan.Checked Then
            strSex = "男"
        Else
            strSex = "女"
        End If
        strBirthDate = cmbYear.Text.Trim() + cmbMonth.Text.Trim + cmbDay.Text.Trim()
        strBirthYear = cmbYear.Text.Trim()
        intBirthYear = CType(strBirthYear, Integer)
        intAge = 2016 - intBirthYear
        strAddress = cmbSheng.Text.Trim() + cmbCity.Text.Trim()
        strDeptName = cmbDeptName.Text.Trim()

        '调用将系别转换为系部编号的方法
        strDeptNo = studentManager.GetDeptNoByDeptName(strDeptName)
        '把用户输入的学生信息封装到学生类里面

        st.BirthDate = strBirthDate
        st.Age = intAge
        st.Sex = strSex
        st.Address = strAddress
        st.DeptNo = strDeptNo

        strID = frmLogin.strUID
        '调用添加学生的方法
        ret = studentManager.UpdateStudentInfo(st, strID)
        If ret = True Then
            MessageBox.Show("个人信息修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show("个人信息修改失败！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If
    End Sub

    Private Sub lbl1_Click(sender As Object, e As EventArgs) Handles lbl1.Click
        '打开文件
        OpenFileDialog1.Filter = "图片文件|*.jpg;*.gif"
        Dim ret As DialogResult
        ret = OpenFileDialog1.ShowDialog()
        If ret = DialogResult.OK Then
            PictureBoxInfo.Image = Image.FromFile(OpenFileDialog1.FileName)
            lbl1.Visible = False
        End If
    End Sub



    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub


End Class