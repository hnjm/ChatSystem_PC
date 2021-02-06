﻿namespace QQ_piracy
{
    using System;
    using System.Data;
    using System.Windows.Forms;
    using QQ_piracy.Manager.Request;

    public partial class SearchFriendForm : Form
    {
        private DataSet dataSet;  // 数据集

        private SearchFriendRequest searchFriendRequest;
        private AddFriendRequest addFriendRequest;

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchFriendForm"/> class.
        /// 搜索好友的界面初始化
        /// </summary>
        public SearchFriendForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 查找好友的数据响应
        /// </summary>
        public void ResponseSearch(bool isSearch, DataSet dataSet)
        {
            if (isSearch)
            {
                // 重新填充DataSet
                dataSet.Tables[0].Clear();
                this.dataSet = dataSet;
                dgvBasicResult.DataSource = dataSet.Tables[0];
            }
            else
            {
                MessageBox.Show("服务器无法响应，请稍后重试", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void ResponseAddFriend(bool isAdd, string result)
        {
            if (isAdd)
            {
                MessageBox.Show("添加好友成功：已发送好友请求", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("添加好友失败：" + result, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// 主界面加载
        /// </summary>
        private void SearchFriendForm_Load(object sender, EventArgs e)
        {
            searchFriendRequest = new SearchFriendRequest(this);
            addFriendRequest = new AddFriendRequest(this);

            dataSet = new DataSet("❀");

            // 指定DataGridView的数据源
            dgvBasicResult.DataSource = dataSet.Tables[0];
            dataSet.Tables[0].Clear();
        }

        /// <summary>
        /// 搜索按钮点击发送请求给服务器
        /// </summary>
        private void searchButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbSearch.Text.Trim()))
            {
                // 搜索栏非空就按昵称和id查找
                BasicallySearch();
            }
            else if (!string.IsNullOrEmpty(cboAge.Text) || !string.IsNullOrEmpty(cboSex.Text))
            {
                // 搜索栏为空，但是age和sex不为空
                AdvancedSearch();
            }
            else
            {
                // 全都没选择，随机推荐
                RandomSearch();
            }
        }

        /// <summary>
        /// 基本查找
        /// </summary>
        private void BasicallySearch()
        {
            if (tbSearch.Text.Trim() != "")
            {
                try
                {
                    string nickName = tbSearch.Text.Trim();
                    int friendId = 0;
                    int.TryParse(tbSearch.Text.Trim(), out friendId);
                    string data = friendId + "," + nickName + ",,";
                    searchFriendRequest.SendRequest(data);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("连接服务器失败，请检查您的网络", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                btnAdd.Visible = true;  // “加为好友”按钮可见
            }
        }

        /// <summary>
        /// 高级查找
        /// </summary>
        private void AdvancedSearch()
        {
            string ageCondition = "";  // 年龄条件
            string sexCondition = cboSex.Text;  // 性别条件

            // 确定年龄的范围
            switch (cboAge.SelectedIndex)
            {
                case 1:
                    ageCondition = " Age>=0 AND Age<18";
                    break;
                case 2:
                    ageCondition = " Age>=18 AND Age<22";
                    break;
                case 3:
                    ageCondition = " Age>=23 AND Age<26";
                    break;
                case 4:
                    ageCondition = " Age>=27 AND Age<35";
                    break;
                case 5:
                    ageCondition = " Age>=35 AND Age<50";
                    break;
                case 6:
                    ageCondition = " Age>=50";
                    break;
                default:
                    ageCondition = "";
                    break;
            }

            try
            {
                string data = ",," + ageCondition + "," + sexCondition;
                searchFriendRequest.SendRequest(data);
            }
            catch (Exception)
            {
                MessageBox.Show("连接服务器错误，请检查您的网络", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            btnAdd.Visible = true;
        }

        /// <summary>
        /// 随机查找
        /// </summary>
        private void RandomSearch()
        {
            try
            {
                string data = ",,,";
                searchFriendRequest.SendRequest(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show("连接服务器错误，请检查您的网络", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            btnAdd.Visible = true;  // “加为好友”按钮可见
        }

        /// <summary>
        /// 点击添加好友按钮，发送或者直接添加
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int friendId = GetSelectedFriendId();  // 获得选中的好友的Id

            try
            {
                int id = UserHelper.LoginId;
                string data = id + "," + friendId;
                addFriendRequest.SendRequest(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show("连接服务器错误，请检查您的网络", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// 获得选中的好友的Id
        /// </summary>
        private int GetSelectedFriendId()
        {
            int friendId = -1;  // 好友的号码

            // 没有选中任何一行
            if (dgvBasicResult.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择一个好友！", "操作", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // 确保第一个单元格有值
            else if (dgvBasicResult.SelectedRows[0].Cells[0] != null)
            {
                // 获得DataGridView中选中的行的第一个单元格的值
                friendId = int.Parse(dgvBasicResult.SelectedRows[0].Cells[0].Value.ToString());
            }

            return friendId;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            addFriendRequest.Close();
            searchFriendRequest.Close();
            this.Dispose();
            this.Close();
        }
    }
}
