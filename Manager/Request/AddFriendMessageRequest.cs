﻿namespace QQ_piracy.Manager.Request
{
    using Common;

    class AddFriendMessageRequest : BaseRequest
    {
        private RequestForm requestForm;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddFriendMessageRequest"/> class.
        /// 构造函数，将form传递进来
        /// </summary>
        public AddFriendMessageRequest(RequestForm requestForm)
        {
            this.requestForm = requestForm;
            Init();
        }

        /// <summary>
        /// 设置requestCode和ActionCode
        /// </summary>
        public override void Init()
        {
            requestCode = RequestCode.Message;
            actionCode = ActionCode.AddFriendMessageRequest;
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
                requestForm.ResponseRequest(false, "");
            }
            else
            {
                string nickName = strs[1];
                requestForm.ResponseRequest(true, nickName);
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
