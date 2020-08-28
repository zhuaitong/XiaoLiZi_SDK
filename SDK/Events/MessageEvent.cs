using SDK.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Events
{
    [StructLayout(LayoutKind.Sequential,Pack =1)]
    public struct MessageEvent
    {
        // 框架QQ
        public long ThisQQ;
        /// <summary>
        /// 消息群号
        /// </summary>
        public long SourceMessageGroupQQ;
        /// <summary>
        /// 操作QQ
        /// </summary>
        public long OperationEventQQ;
        //触发QQ
        public long SourceEventQQ;
        //消息Seq
        public long MessageSeq;
        //消息时间戳
        public uint MessageSendTime;
        //来源群名
        public IntPtr SourceGroupName;
        //操作QQ昵称
        public IntPtr OperationQQName;
        //触发QQ昵称
        public IntPtr SourceQQName;
        //消息内容
        public IntPtr MessageContent;
        // 消息类型
        public EventTypeEnum MessageType;
        //消息子类型  
        public uint MessageSubType;
    }
}
