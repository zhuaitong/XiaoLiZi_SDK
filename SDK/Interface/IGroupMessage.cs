﻿using SDK.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Interface
{
    public interface IGroupMessage
    {
        void ReceviceGroupMsg(GroupMessageEvent e);
    }
}