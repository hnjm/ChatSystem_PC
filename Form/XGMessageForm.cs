﻿namespace QQ_piracy
{
    using System;
    using System.Windows.Forms;
    using QQ_piracy.Helper;
    using QQ_piracy.Manager.Request;

    public partial class XGMessageForm : Form
    {
        public int IsModify = 0; // 用于回调异步标识

        private PersonalInfoForm personalInfoForm;

        private ModifyRequest modifyRequest;

        private string[] stars = DataListHelper.StarList;
        private string[] bloodTypes = DataListHelper.BloodTypeList;

        public XGMessageForm(PersonalInfoForm personalInfoForm)
        {
            InitializeComponent();
            this.personalInfoForm = personalInfoForm;

            // 给按钮添加事件
            this.tbNick.Click += Button_Click;
            this.tbAge.Click += Button_Click;
            this.tbname.Click += Button_Click;
            this.star.Click += Button_Click;
            this.bloodtype.Click += Button_Click;
            this.cbsex.Click += Button_Click;
        }

        /// <summary>
        /// 对修改信息做出响应
        /// </summary>
        public void ResponseModify()
        {
            if (IsModify == 1)
            {
                IsModify = 0;
                UserHelper.NickName = tbNick.Text;
                UserHelper.Sex = cbsex.Text;
                UserHelper.Age = int.Parse(tbAge.Text);
                UserHelper.Name = tbname.Text;
                UserHelper.StarId = star.SelectedIndex;
                UserHelper.BloodTypeId = bloodtype.SelectedIndex;

                modifyRequest.Close();

                this.Close();                 // 关闭窗体

                this.Dispose();               // 释放资源

                personalInfoForm.PersonalInfoForm_Load(null, null);
            }
            else if (IsModify == 2)
            {
                IsModify = 0;
                MessageBox.Show("服务器未响应", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// 修改信息请求
        /// <summary>
        private void save_Click(object sender, EventArgs e)
        {
            if (ValidataInput())
            {
                try
                {
                    int dataId = UserHelper.DataId;
                    string nickName = tbNick.Text;
                    string sex = cbsex.Text;
                    int age = int.Parse(tbAge.Text);
                    string name = tbname.Text;
                    int starid = star.SelectedIndex;
                    int bloodtypeid = bloodtype.SelectedIndex;
                    string data = dataId + "," + nickName + "," + sex + "," + age + "," + name + "," + starid + "," + bloodtypeid;
                    modifyRequest.SendRequest(data);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "操作失败，请检查您的网络！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        /// <summary>
        /// 主界面加载
        /// </summary>
        private void XGMessageForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;    // 修改窗体边框

            modifyRequest = new ModifyRequest(this);

            SyncTimer.Start();

            save.Enabled = false;                          // 信息未变动不能修改
            cbsex.Items.Add("男");
            cbsex.Items.Add("女");

            int starId = UserHelper.StarId;             // 星座Id
            int bloodTypeId = UserHelper.BloodTypeId;        // 血型Id
            int faceId = UserHelper.FaceId;              // 头像Id
            int friendshipPolicyId = UserHelper.FriendshipPolicyId;  // 添加好友策略Id

            this.tbNick.Text = UserHelper.NickName; // 昵称

            if (UserHelper.Sex != null)
            {
                this.cbsex.Text = UserHelper.Sex == "男" ? "男" : "女"; // 性别
            }

            if (UserHelper.Name != null)
            {
                this.tbname.Text = UserHelper.Name; // 真实姓名
            }

            this.tbAge.Text = UserHelper.Age.ToString();   // 年龄

            // 处理星座
            FillStarsComboBox(starId);

            // 处理血型
            FillBloodTypesComboBox(bloodTypeId);
        }

        /// <summary>
        /// 读取星座信息
        /// </summary>
        private void FillStarsComboBox(int currentStarId)
        {
            // 将星座数组中的星座添加到星座组合框中
            for (int i = 0; i < stars.Length; i++)
            {
                star.Items.Add(stars[i]);
                if (currentStarId == i)
                {
                    star.SelectedIndex = i;
                }
            }
        }

        /// <summary>
        /// 读取血型信息
        /// </summary>
        private void FillBloodTypesComboBox(int currentBloodTypeId)
        {
            // 将血型数组中的血型添加到血型组合框中
            for (int i = 0; i < bloodTypes.Length; i++)
            {
                bloodtype.Items.Add(bloodTypes[i]);
                if (currentBloodTypeId == i)
                {
                    bloodtype.SelectedIndex = i;
                }
            }
        }

        /// <summary>
        /// 关闭按钮
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            modifyRequest.Close();

            this.Close();                 // 关闭窗体

            this.Dispose();               // 释放资源
        }

        // 用于验证用户填写的信息是否正确
        private bool ValidataInput()
        {
            if (tbNick.Text.Length > 15)
            {
                MessageBox.Show("输入的昵称不能超过15个字符", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbNick.Focus();
                return false;
            }

            if (!int.TryParse(tbAge.Text.Trim(), out int i) || tbAge.Text.Length > 3)
            {
                MessageBox.Show("年龄只能是整数并且不能超过3位数", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbNick.Focus();
                return false;
            }

            if (tbNick.Text.Length > 30)
            {
                MessageBox.Show("输入的姓名不能超过30个字符", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbname.Focus();
                return false;
            }

            return true;
        }

        private void Button_Click(object sender, System.EventArgs e)
        {
            save.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            save.Enabled = true;
        }

        /// <summary>
        /// 修改界面退出，个人信息界面才能操作
        /// </summary>
        private void XGMessageForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            modifyRequest.Close();
            personalInfoForm.Enabled = true;
        }

        private void SyncTimer_Tick(object sender, EventArgs e)
        {
            ResponseModify();
        }
    }
}
