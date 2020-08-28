using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using SDK.Enum;

namespace SDK.Events
{
    [StructLayout(LayoutKind.Sequential,Pack =1)]
    public struct GroupMessageEvent
    {
        // 发送人QQ
        public long SenderQQ;
        // 框架QQ
        public long ThisQQ;
        // 消息Req
        public int MessageReq;
        // 消息接收时间
        public int MessageReceiveTime;
        // 消息群号
        public long MessageGroupQQ;
        // 消息来源群名（貌似失效了）etext SourceGroupName = nullptr;
        public IntPtr SourceGroupName;
        // 发送人群名片 没有名片则为空白etext SenderNickname = nullptr;
        public IntPtr SenderNickname;
        // 消息发送时间
        public int MessageSendTime;
        // 消息Random
        public long MessageRandom;
        // 消息分片序列
        public int MessageClip;
        // 消息分片数量
        public int MessageClipCount;
        // 消息分片标识
        public long MessageClipID;
        // 消息类型
        public MessageTypeEnum MessageType;
        // 发送人群头衔 etext SenderTitle = nullptr;
        public IntPtr SenderTitle;
        // 消息内容 etext MessageContent = nullptr;
        public IntPtr MessageContent;
        // 回复对象消息内容 如果是回复消息 etext ReplyMessageContent = nullptr;
        public IntPtr ReplyMessageContent;
        // 发送者气泡ID
        public int BubbleID;
        // 框架QQ匿名Id，用于区分别人和自己(当天从未使用过匿名则为0)
        public int ThisQQAnonymousID;
        // 保留参数，请勿使用
        public int reserved_;
        // 文件Id
        public IntPtr FileID;
        // 文件Md5
        public IntPtr FileMD5;
        // 文件名
        public IntPtr FileName;
        // 文件大小
        public long FileSize;
        // 消息AppID
        public int MessageAppID;
    }
}
