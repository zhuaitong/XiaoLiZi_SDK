using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using SDK;
using SDK.Events;
using SDK.Interface;

namespace MsTool
{
    public class RecPrivateMsg : IRecvicetPrivateMessage
    {
        public void RecvicetPrivateMsg(PrivateMessageEvent e)
        {
            //Common.xlzAPI.OutLog("我输出的日志");
            //Common.xlzAPI.SendPrivateMessage(e.ThisQQ, e.SenderQQ, "欢迎使用小栗子SDK");
            //Common.xlzAPI.RecviceImage(Marshal.PtrToStringAnsi(e.MessageContent), e.ThisQQ, e.SenderQQ);
            //Common.xlzAPI.GetFriendList(e.ThisQQ);
            //Common.xlzAPI.Getgrouplist(e.ThisQQ);
            Common.xlzAPI.GetgroupMemberlist(e.ThisQQ, 535107725);
        }
    }
}
