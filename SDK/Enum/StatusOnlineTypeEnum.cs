using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Enum
{
    // 详细在线状态
    public enum StatusOnlineTypeEnum
    {
        // 普通在线
        Normal = 0,
        // 我的电量
        Battery = 1000,
        // 信号弱
        WeakSignal = 1011,
        // 睡觉中
        Sleeping = 1016,
        // 游戏中
        Gaming = 1017,
        // 学习中
        Studying = 1018,
        // 吃饭中
        Eating = 1019,
        // 煲剧中
        WatchingTVSeries = 1021,
        // 度假中
        OnVacation = 1022,
        // 在线学习
        OnlineStudying = 1024,
        // 在家旅游
        TravelAtHome = 1025,
        // TiMi中
        TiMiing = 1027,
        // 我在听歌
        ListeningToMusic = 1028,
        // 熬夜中
        StayingUpLate = 1032,
        // 打球中
        PlayingBall = 1050,
        // 恋爱中
        FallInLove = 1051,
        // 我没事(实际上有事)
        ImOK = 1052
    }

}
