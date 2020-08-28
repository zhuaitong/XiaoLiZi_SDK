using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using SDK.Enum;

namespace SDK.Events
{
    //[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct PrivateMessageEvent  //128个字节0x80
    {
        //发送人QQ
        public long SenderQQ;
        //框架QQ
        public long ThisQQ;
        //消息Req
        public uint MessageReq;
        //消息Seq
        public long MessageSeq;
        //消息接收时间
        public uint MessageReceiveTime;
        //消息群号 当为群临时会话时可取
        public long MessageGroupQQ;
        //消息发送时间
        public uint MessageSendTime;
        //消息Random
        public long MessageRandom;
        //消息分片序列
        public uint MessageClip;
        //消息分片数量
        public uint MessageClipCount;
        //消息分片标识
        public long MessageClipID;
        //消息内容
        public IntPtr MessageContent;
        //气泡Id
        public uint BubbleID;
       // 消息类型
        public MessageTypeEnum MessageType;
        //消息子类型  
        public MessageSubTypeEnum MessageSubType;
        //消息子临时类型 0 群 1 讨论组 129 腾讯公众号 201 QQ咨询
        public MessageSubTypeEnum MessageSubTemporaryType;
        //红包类型
        public uint RedEnvelopeType;
        //[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        //会话token
        public IntPtr SessionToken;
        //来源事件QQ
        public long SourceEventQQ;
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        //来源事件QQ昵称
        public IntPtr SourceEventQQName;
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        //文件Id
        public IntPtr FileID;
        //[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        //文件Md5
        public IntPtr FileMD5;
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        //文件名
        public IntPtr FileName;
        //文件大小
        public long FileSize;
    }
}
