﻿namespace QQ_piracy
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using QQ_piracy.Manager.Request;

    public partial class ChatForm : Form
    {
        public int FriendId;     // 当前聊天的好友号码
        public string NickName;  // 当前聊天的好友昵称
        public string SelfnickName;  // 当前聊天的好友昵称
        public int FaceId;       // 当前聊天的好友头像Id
        public MainForm MainForm;

        private ChatByReceiveReqeust chatReceiveRequest;
        private SendByChatRequest chatSendRequest;

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatForm"/> class.
        /// 加载界面
        /// </summary>
        public ChatForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 初始化主界面
        /// </summary>
        private void ChatForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;    // 更换窗体边框
            this.ShowInTaskbar = true;                     // 显示任务栏
            this.Icon = new Icon("1.ico");

            chatSendRequest = new SendByChatRequest(this);
            chatReceiveRequest = new ChatByReceiveReqeust(this);

            // 设置窗体标题
            this.Text = "         " + NickName + " (" + FriendId + ")";

            // 读取所有的未读消息，显示在窗体中
            ShowMessage();
        }

        /// <summary>
        /// 向服务器发送请求给好友发消息
        /// </summary>
        private void sendButton_Click(object sender, EventArgs e)
        {
            // 不能发送空消息
            if (tbMessage.Text.Trim() == "")
            {
                MessageBox.Show("不能发送空消息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (tbMessage.Text.Trim().Length > 120)
            {
                MessageBox.Show("消息内容过长，请分为几条发送！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            { // 发送消息，向服务器发送请求
                int result = -1; // 表示操作数据库的结果

                try
                {
                    MySqlCommand cmd = new MySqlCommand("insert into messages  set fromuserid=@fromuserid,touserid=@touserid,message=@message,sendtime=@sendtime,messagetype=1,messagestate=0", DBHelper.Connect());
                    cmd.Parameters.AddWithValue("fromuserid", UserHelper.loginId);
                    cmd.Parameters.AddWithValue("touserid", FriendId);
                    cmd.Parameters.AddWithValue("message", tbMessage.Text);
                    DateTime datetime = DateTime.Now;
                    cmd.Parameters.AddWithValue("sendtime", datetime);

                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    DBHelper.Connect().Close();
                }
                if (result != 1)
                {
                    MessageBox.Show("服务器出现意外错误！", "抱歉", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                messageLabel.Text += string.Format("\r\n{0}  {1}\r\n  {2}", SelfnickName, DateTime.Now, tbMessage.Text);
                tbMessage.Text = "";  // 输入消息清空
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("QQ秀功能暂未开通", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void sorry_Click(object sender, EventArgs e)
        {
            MessageBox.Show("该功能暂未开通", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // 关闭窗体
        private void gbButton_Click(object sender, EventArgs e)
        {
            this.Close();

            this.Dispose();               // 释放资源
        }

        /// <summary>
        /// 读取所有的未读消息，显示在窗体中
        /// </summary>
        private void ShowMessage()
        {
            string messageIdsString = "";  // 消息的Id组成的字符串
            string message;         // 消息内容
            string messageTime;     // 消息发出的时间

            try
            {
                MySqlCommand cmd = new MySqlCommand("select msgid,message,sendtime from messages where fromuserid=@fromuserid and touserid=@touserid and messagetype=1 and messagestate=0",DBHelper.Connect());
                cmd.Parameters.AddWithValue("fromuserid", FriendId);
                cmd.Parameters.AddWithValue("touserid", UserHelper.loginId);
                MySqlDataReader reader = cmd.ExecuteReader();

                // 循环将消息添加到窗体上
                while (reader.Read())
                {
                    messageIdsString += Convert.ToString(reader["msgid"]) + "_";
                    message = Convert.ToString(reader["message"]);
                    messageTime = Convert.ToDateTime(reader["sendtime"]).ToString(); 

                    messageLabel.Text += string.Format("\r\n{0}  {1}\r\n  {2}", NickName, messageTime, message);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                DBHelper.Connect().Close();
            }
            // 把显示出的消息置为已读
            if (messageIdsString.Length > 1)
            {
                messageIdsString.Remove(messageIdsString.Length - 1);
                SetMessageRead(messageIdsString, '_');
            }
        }

        /// <summary>
        /// 把显示出的消息置为已读
        /// </summary>        
        private void SetMessageRead(string messageIdsString, char separator)
        {
            string[] messageIds = messageIdsString.Split(separator);     // 分割出每个消息Id
            try
            {
                foreach (string id in messageIds)
                {
                    if (id != "")
                    {
                        MySqlCommand cmd = new MySqlCommand("update messages set messagestate=1 where msgid=@id", DBHelper.Connect());
                        cmd.Parameters.AddWithValue("id", id);
                        int result = cmd.ExecuteNonQuery();  // 执行命令
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                DBHelper.Connect().Close();
            }
        }

        private void ChatForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.ChatForms.Remove(FriendId);
        }

        private void showmsg_Tick(object sender, EventArgs e)
        {
            ShowMessage();
        }
    }
}
