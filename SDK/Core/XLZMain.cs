using SDK.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using Unity;
using SDK.Interface;

namespace SDK.Core
{
    public class XLZMain
    {

        public delegate int RecvicePrivateMsg(IntPtr intPtr);
        public delegate int RecviceGroupMesg(IntPtr intPtr);
        public delegate int RotbotAppEnable();

        public static int RecvicetGroupMessage(IntPtr intPtr)
        {
            GroupMessageEvent data = new GroupMessageEvent();
            data = (GroupMessageEvent)Marshal.PtrToStructure(intPtr, typeof(GroupMessageEvent));
            //string txt = Marshal.PtrToStringAnsi(data.MessageContent);
            if (Common.unityContainer.IsRegistered<IGroupMessage>())
            {
                Common.unityContainer.Resolve<IGroupMessage>().ReceviceGroupMsg(data);
            }
            return 1;
        }

        public static int RecvicetPrivateMessage(IntPtr intPtr)
        {
            PrivateMessageEvent data = new PrivateMessageEvent();
            data = (PrivateMessageEvent)Marshal.PtrToStructure(intPtr, typeof(PrivateMessageEvent));
            string content = Marshal.PtrToStringAnsi(data.MessageContent);
            if (Common.unityContainer.IsRegistered<IRecvicetPrivateMessage>())
            {
                Common.unityContainer.Resolve<IRecvicetPrivateMessage>().RecvicetPrivateMsg(data);
            }
            return 1;
        }

        public static int AppEnable()
        {
            //AppEnableEvent appEnableEvent =(AppEnableEvent) Marshal.PtrToStructure(intPtr,typeof(AppEnableEvent));
            if (Common.unityContainer.IsRegistered<IAppEnableEvent>())
            {
                Common.unityContainer.Resolve<IAppEnableEvent>().AppEnableEvent();
            }
            
            return 1;
        }

        public static IntPtr GetNewIntptr()
        {
            Guid guid = new Guid(Guid.NewGuid().ToString("B"));
            byte[] array = guid.ToByteArray();
            IntPtr intPtr = Marshal.AllocHGlobal(array.Length);
            return intPtr;
        }

        public static string SendPriMessage(long robot, long qq, string msg,long Random, int Req)
        {
            return "";
        }
    }
}
