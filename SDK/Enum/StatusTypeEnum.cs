using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Enum
{
    // 主要在线状态
    public enum StatusTypeEnum
    {
        // 在线
        Online = 11,
        // 离开
        Away = 31,
        // 隐身
        Invisible = 41,
        // 忙碌
        Busy = 50,
        // Q我吧
        TalkToMe = 60,
        // 请勿打扰
        DoNotDisturb = 70
    }
}
