using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Model
{

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct GroupMemberDataList
    {
        public int count;
        public GroupMemberInfo pGroupMemberInfo;
    }

    [StructLayout(LayoutKind.Sequential,Pack =1)]
    public struct GroupMemberInfo
    {
        // 账号
        public IntPtr QQNumber;
        // 年龄
        public uint Age;
        // 性别
        public uint Gender;
        // 昵称
        public IntPtr Name;
        // 邮箱
        public IntPtr Email;
        // 名片
        public IntPtr Nickname;
        // 备注
        public IntPtr Note;
        // 头衔
        public IntPtr Title;
        // 手机号
        public IntPtr Phone;
        // 头衔到期时间
        public long TitleTimeout;
        // 禁言时间戳
        public long ShutUpTimestamp;
        // 加群时间
        public long JoinTime;
        // 发言时间
        public long ChatTime;
        // 群等级
        public long Level;
    }
}
