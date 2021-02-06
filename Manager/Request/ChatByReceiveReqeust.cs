﻿namespace QQ_piracy.Manager.Request
{
    using Common;

    class ChatByReceiveReqeust : BaseRequest
    {
        private ChatForm chatForm;

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatByReceiveReqeust"/> class.
        /// 构造函数，将form传递进来
        /// </summary>
        public ChatByReceiveReqeust(ChatForm chatForm)
        {
            this.chatForm = chatForm;
            Init();
        }

        /// <summary>
        /// 设置requestCode和ActionCode
        /// </summary>
        public override void Init()
        {
            requestCode = RequestCode.Message;
            actionCode = ActionCode.ChatByReceive;
            base.Init();
        }

        /// <summary>
        /// 对服务器传递的消息响应
        /// </summary>
        public override void OnResponse(string data)
        {
            string[] strs = data.Split(',');
            ReturnCode returnCode = (ReturnCode)int.Parse(strs[0]);
            if (returnCode == ReturnCode.Fail)
            {
                chatForm.ResponseReceive(false, 0, "");
            }
            else
            {
                string message = strs[1];
                long ticks = long.Parse(strs[2]);
                chatForm.ResponseReceive(true, ticks, message);
            }
        }

        /// <summary>
        /// 发送请求给服务器
        /// </summary>
        public override void SendRequest(string data)
        {
            ManagerController.SendRequest(requestCode, actionCode, data);
        }
    }
}
