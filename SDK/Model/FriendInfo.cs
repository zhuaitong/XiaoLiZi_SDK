using SDK.Enum;
using SDK.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Model
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct FriendDataList
    {
        public int count;
        public FriendInfo pFriendInfo;
    }
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct FriendInfo
    {
        // 邮箱
        public IntPtr Email;
        // 账号
        public long QQNumber;
        // 昵称
        public IntPtr Name;
        // 备注
        public IntPtr Note;
        // 在线状态 只能使用[取好友列表]获取
        public IntPtr Status;
        // 赞数量 只能使用[查询好友信息]获取
        public uint Likes;
        // 签名 只能使用[查询好友信息]获取
        public IntPtr Signature;
        // 性别 255: 隐藏, 0: 男, 1: 女
        public uint Gender;
        // Q等级 只能使用[查询好友信息]获取
        public uint Level;
        // 年龄 只能使用[查询好友信息]获取
        public uint Age;
        // 国家 只能使用[查询好友信息]获取
        public IntPtr Nation;
        // 省份 只能使用[查询好友信息]获取
        public IntPtr Province;
        // 城市 只能使用[查询好友信息]获取
        public IntPtr City;
        // 服务列表 只能使用[查询好友信息]获取
        public ServiceInfo serviceInfo;
        // 连续在线天数 只能使用[查询好友信息]获取
        public uint ContinuousOnlineTime;
        // QQ达人 只能使用[查询好友信息]获取
        public IntPtr QQTalent;
        // 今日已赞 只能使用[查询好友信息]获取
        public uint LikesToday;
        // 今日可赞数 只能使用[查询好友信息]获取
        public uint LikesAvailableToday;
    }
   
}
