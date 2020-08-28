using MsTool;
using SDK.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace RobotCore
{
    public static class RegisterCore
    {
        public static void Register(IUnityContainer unityContainer)
        {
            unityContainer.RegisterType<IRecvicetPrivateMessage, RecPrivateMsg>();
            unityContainer.RegisterType<IGroupMessage, RecGroupMsg>();
        }
    }
}
