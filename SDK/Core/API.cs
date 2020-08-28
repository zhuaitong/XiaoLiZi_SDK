using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using SDK.Enum;
using SDK.Model;

namespace SDK.Core
{
    public class API
    {
        public static string pluginkey { get; set; }
        public static string jsonstr { get; set; }

        delegate string SendPivateMsg(string pkey, long ThisQQ, long SenderQQ, IntPtr MessageContent, ref long MessageRandom, ref uint MessageReq);
        delegate string OutputLog(string pkey, IntPtr message, int text_color, int background_color);
        delegate string SendGroupMsg(string pkey, long thisQQ, long groupQQ, IntPtr msgcontent, bool anonymous);
        delegate string Recviceimage(string pkey, string guid, long thisQQ, long groupQQ);
        delegate int GetFriendlist(string pkey, long thisQQ, ref FriendDataList[] friendInfos);
        delegate int GetGrouplist(string pkey, long thisQQ, ref GroupDataList[] GroupInfos);
        delegate int GroupMemberlist(string pkey, long thisQQ, long groupNumber, ref GroupMemberDataList[] GroupInfos);

        /// <summary>
        /// 输出日志
        /// </summary>
        /// <param name="message"></param>
        /// <param name="text_color"></param>
        /// <param name="background_color"></param>
        /// <returns></returns>
        public string OutLog(string message, int text_color= 16711680, int background_color= 16777215)
        {
            string ret = string.Empty;
            int privateMsgAddress = int.Parse(JObject.Parse(jsonstr).SelectToken("输出日志").ToString());
            IntPtr intPtr = new IntPtr(privateMsgAddress);
            OutputLog outputLog = (OutputLog)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(OutputLog));
            ret = outputLog(pluginkey, Marshal.StringToHGlobalAnsi(message), text_color, background_color);
            return ret;
        }
        /// <summary>
        /// 输出日志1
        /// </summary>
        /// <param name="message"></param>
        /// <param name="text_color"></param>
        /// <param name="background_color"></param>
        /// <returns></returns>
        public string OutLog1(string message, Color text_color, Color background_color)
        {
            return OutLog(message, Colr2Int(text_color), Colr2Int(background_color));
        }

        private int Colr2Int(Color color)
        {
            //RGB函数计算公式:    颜色值    ＝    (65536    *    Blue)    +    (256    *    Green)    +    (Red)
            return (65536 * color.B) + (256 * color.G) + color.R;
        }

        /// <summary>
        /// 发送好友消息
        /// </summary>
        /// <param name="ThisQQ"></param>
        /// <param name="SenderQQ"></param>
        /// <param name="MessageContent"></param>
        /// <param name="MessageRandom"></param>
        /// <param name="MessageReq"></param>
        /// <returns></returns>
        public string SendPrivateMessage(long ThisQQ, long SenderQQ, string MessageContent, long MessageRandom = 0, uint MessageReq = 0)
        {
            string ret = string.Empty;
            int MsgAddress = int.Parse(JObject.Parse(jsonstr).SelectToken("发送好友消息").ToString());
            IntPtr intPtr = new IntPtr(MsgAddress);
            SendPivateMsg sendmsg = (SendPivateMsg)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(SendPivateMsg));
            ret = sendmsg(pluginkey, ThisQQ, SenderQQ, Marshal.StringToHGlobalAnsi(MessageContent), ref MessageRandom, ref MessageReq);
            return ret;
        }
        /// <summary>
        /// 发送群消息
        /// </summary>
        /// <param name="thisQQ"></param>
        /// <param name="groupQQ"></param>
        /// <param name="msgcontent"></param>
        /// <param name="anonymous"></param>
        /// <returns></returns>
        public string SendGroupMessage(long thisQQ, long groupQQ, string msgcontent, bool anonymous = false)
        {
            string ret = string.Empty;
            int MsgAddress = int.Parse(JObject.Parse(jsonstr).SelectToken("发送群消息").ToString());
            IntPtr intPtr = new IntPtr(MsgAddress);
            SendGroupMsg sendmsg = (SendGroupMsg)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(SendGroupMsg));
            ret = sendmsg(pluginkey, thisQQ, groupQQ, Marshal.StringToHGlobalAnsi(msgcontent), anonymous);
            return ret;
        }
        /// <summary>
        /// 取图片下载地址
        /// </summary>
        /// <param name="msgcontent"></param>
        /// <param name="thisQQ"></param>
        /// <param name="groupQQ"></param>
        /// <returns>返回URL下载地址</returns>
        public string RecviceImage(string msgcontent, long thisQQ,long groupQQ)
        {
            string guid = GetGuidImage(msgcontent);
            if (string.IsNullOrEmpty(guid))
            {
                return string.Empty;
            }
            string ret = string.Empty;
            int MsgAddress = int.Parse(JObject.Parse(jsonstr).SelectToken("取图片下载地址").ToString());
            IntPtr intPtr = new IntPtr(MsgAddress);
            Recviceimage sendmsg = (Recviceimage)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(Recviceimage));
            ret = sendmsg(pluginkey, guid, thisQQ, groupQQ);
            return ret;
        }

        /// <summary>
        /// 获取guid
        /// </summary>
        /// <param name="msgcontent"></param>
        /// <returns></returns>
        private string GetGuidImage(string msgcontent)
        {
            if (msgcontent.Contains("[pic,hash="))
            {
                try
                {
                    string guid = Regex.Match(msgcontent, @"(\[pic,hash=)(.){32}").Value;
                    //string guid = Regex.Match(msgcontent, @"(\[pic,hash=)(.)+?(?=\])]").Value;
                    return guid + "]";
                }
                catch (Exception)
                {
                    return string.Empty;
                }
            }
            return string.Empty;
        }
        /// <summary>
        /// 取好友列表
        /// </summary>
        /// <param name="thisQQ"></param>
        /// <returns></returns>
        public List<FriendInfo> GetFriendList(long thisQQ)
        {
            List<FriendInfo> FriendList = new List<FriendInfo>();
            int MsgAddress = int.Parse(JObject.Parse(jsonstr).SelectToken("取好友列表").ToString());
            FriendDataList[] ptrArray = new FriendDataList[2048];
            GetFriendlist sendmsg = (GetFriendlist)Marshal.GetDelegateForFunctionPointer(new IntPtr(MsgAddress), typeof(GetFriendlist));
            int count = sendmsg(pluginkey, thisQQ, ref ptrArray);
            if (count > 0)
            {
                IntPtr ptr = Marshal.UnsafeAddrOfPinnedArrayElement(ptrArray, 0);
                for (int i = 0; i < count; i++)
                {
                    int size = Marshal.SizeOf(typeof(IntPtr));
                    //IntPtr StuctPtr = IntPtr.Add(ptr, size * count + size * i);
                    IntPtr StuctPtr = IntPtr.Add(ptr, size * 2 + size * i);
                    StuctPtr = Marshal.ReadIntPtr(StuctPtr);
                    FriendInfo info = (FriendInfo)Marshal.PtrToStructure(StuctPtr, typeof(FriendInfo));
                    Debug.WriteLine(info.QQNumber);
                    FriendList.Add(info);
                }
            }
            return FriendList;
        }

        /// <summary>
        /// 取群列表
        /// </summary>
        /// <param name="thisQQ"></param>
        /// <returns></returns>
        public List<GroupInfo> Getgrouplist(long thisQQ)
        {
            List<GroupInfo> list = new List<GroupInfo>();
            int MsgAddress = int.Parse(JObject.Parse(jsonstr).SelectToken("取群列表").ToString());
            GroupDataList[] ptrArray = new GroupDataList[1024];
            GetGrouplist sendmsg = (GetGrouplist)Marshal.GetDelegateForFunctionPointer(new IntPtr(MsgAddress), typeof(GetGrouplist));
            int count = sendmsg(pluginkey, thisQQ, ref ptrArray);
            if (count > 0)
            {
                IntPtr ptr = Marshal.UnsafeAddrOfPinnedArrayElement(ptrArray, 0);
                for (int i = 0; i < count; i++)
                {
                    int size = Marshal.SizeOf(typeof(IntPtr));
                    //IntPtr StuctPtr = IntPtr.Add(ptr, size * count + size * i);
                    IntPtr StuctPtr = IntPtr.Add(ptr, size * 2 + size * i);
                    StuctPtr = Marshal.ReadIntPtr(StuctPtr);
                    GroupInfo info = (GroupInfo)Marshal.PtrToStructure(StuctPtr, typeof(GroupInfo));
                    //Debug.WriteLine(info.QQNumber);
                    list.Add(info);
                }
            }
            return list;
        }
        /// <summary>
        /// 取群成员列表
        /// </summary>
        /// <param name="thisQQ"></param>
        /// <param name="gruopNumber"></param>
        /// <returns></returns>
        public List<GroupMemberInfo> GetgroupMemberlist(long thisQQ,long gruopNumber)
        {
            List<GroupMemberInfo> list = new List<GroupMemberInfo>();
            int MsgAddress = int.Parse(JObject.Parse(jsonstr).SelectToken("取群成员列表").ToString());
            GroupMemberDataList[] ptrArray = new GroupMemberDataList[6000];
            GroupMemberlist sendmsg = (GroupMemberlist)Marshal.GetDelegateForFunctionPointer(new IntPtr(MsgAddress), typeof(GroupMemberlist));
            int count = sendmsg(pluginkey, thisQQ, gruopNumber, ref ptrArray);
            if (count > 0)
            {
                IntPtr ptr = Marshal.UnsafeAddrOfPinnedArrayElement(ptrArray, 0);
                for (int i = 0; i < count; i++)
                {
                    int size = Marshal.SizeOf(typeof(IntPtr));
                    IntPtr StuctPtr = IntPtr.Add(ptr, size * 2 + size * i);
                    StuctPtr = Marshal.ReadIntPtr(StuctPtr);
                    GroupMemberInfo info = (GroupMemberInfo)Marshal.PtrToStructure(StuctPtr, typeof(GroupMemberInfo));
                    list.Add(info);
                }
            }
            return list;
        }


        //public static IntPtr GetNewIntptr()
        //{
        //    //GCHandle h = GCHandle.Alloc(o, GCHandleType.WeakTrackResurrection);
        //    //IntPtr addr = GCHandle.ToIntPtr(h);
        //    //int size = Marshal.SizeOf(typeof(IntPtr)) * ptrArray.Length;
        //    //IntPtr ptr = Marshal.AllocHGlobal(size);
        //    //Marshal.Copy(ptrArray, 0, ptr, ptrArray.Length);
        //    //var s = (FriendInfo)Marshal.PtrToStructure(ptr, typeof(FriendInfo));

        //    Guid guid = new Guid(Guid.NewGuid().ToString("B"));
        //    byte[] array = guid.ToByteArray();
        //    IntPtr intPtr = Marshal.AllocHGlobal(array.Length);
        //    return intPtr;
        //}
    }
    
}
