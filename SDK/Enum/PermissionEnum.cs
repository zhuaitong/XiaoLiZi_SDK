﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Enum
{
    //const std::unordered_map<std::string, eint> FreeGiftMap =
    //        {
    // 367: 告白话筒, 299: 卡布奇诺, 302: 猫咪手表, 280: 牵你的手, 281: 可爱猫咪, 284: 神秘面具, 285: 甜wink, 286: 我超忙的, 289: 快乐肥宅水, 290: 幸运手链, 313: 坚强, 307: 绒绒手套, 312: 爱心口罩, 308: 彩虹糖果
    //        }

    // 某些API中可能会用
    // 权限（有感叹号的是危险权限！）
    public enum PermissionEnum
    {
        // 输出日志
        OutputLog = 0,
        // 发送好友消息
        SendFriendMessage = 1,
        // 发送群消息
        SendGroupMessage = 2,
        // 发送群临时消息
        SendGroupTemporaryMessage = 3,
        // 添加好友
        AddFriend = 4,
        // 添加群
        AddGroup = 5,
        // 删除好友！
        RemoveFriend = 6,
        // 置屏蔽好友！
        SetBlockFriend = 7,
        // 置特别关心好友
        SetSpecialFriend = 8,
        // 发送好友json消息
        SendFriendJSONMessage = 11,
        // 发送群json消息
        SendGroupJSONMessage = 12,
        // 上传好友图片
        UploadFriendPicture = 13,
        // 上传群图片
        UploadGroupPicture = 14,
        // 上传好友语音
        UploadFriendAudio = 15,
        // 上传群语音
        UploadGroupAudio = 16,
        // 上传头像！
        UploadAvatar = 17,
        // 设置群名片
        SetGroupMemberNickname = 18,
        // 取昵称_从缓存
        GetNameFromCache = 19,
        // 强制取昵称
        GetNameForce = 20,
        // 获取skey！
        GetSKey = 21,
        // 获取pskey！
        GetPSKey = 22,
        // 获取clientkey！
        GetClientKey = 23,
        // 取框架QQ
        GetThisQQ = 24,
        // 取好友列表
        GetFriendList = 25,
        // 取群列表
        GetGroupList = 26,
        // 取群成员列表
        GetGroupMemberList = 27,
        // 设置管理员
        SetAdministrator = 28,
        // 取管理层列表
        GetAdministratorList = 29,
        // 取群名片
        GetGroupMemberNickname = 30,
        // 取个性签名
        GetSignature = 31,
        // 修改昵称！
        SetName = 32,
        // 修改个性签名！
        SetSignature = 33,
        // 删除群成员
        KickGroupMember = 34,
        // 禁言群成员
        BanGroupMember = 35,
        // 退群！
        QuitGroup = 36,
        // 解散群！
        DissolveGroup = 37,
        // 上传群头像
        UploadGroupAvatar = 38,
        // 全员禁言
        BanAll = 39,
        // 群权限_发起新的群聊
        Group_Create = 40,
        // 群权限_发起临时会话
        Group_CreateTemporary = 41,
        // 群权限_上传文件
        Group_UploadFile = 42,
        // 群权限_上传相册
        Group_UploadPicture = 43,
        // 群权限_邀请好友加群
        Group_InviteFriend = 44,
        // 群权限_匿名聊天
        Group_Anonymous = 45,
        // 群权限_坦白说
        Group_ChatFrankly = 46,
        // 群权限_新成员查看历史消息
        Group_NewMemberReadChatHistory = 47,
        // 群权限_邀请方式设置
        Group_SetInviteMethod = 48,
        // 撤回消息_群聊
        Undo_Group = 49,
        // 撤回消息_私聊本身
        Undo_Private = 50,
        // 设置位置共享
        SetLocationShare = 51,
        // 上报当前位置
        ReportCurrentLocation = 52,
        // 是否被禁言
        IsShutUp = 53,
        // 处理好友验证事件
        ProcessFriendVerification = 54,
        // 处理群验证事件
        ProcessGroupVerification = 55,
        // 查看转发聊天记录内容
        ReadForwardedChatHistory = 56,
        // 上传群文件
        UploadGroupFile = 57,
        // 创建群文件夹
        CreateGroupFolder = 58,
        // 设置在线状态
        SetStatus = 59,
        // QQ点赞！
        QQLike = 60,
        // 取图片下载地址
        GetImageDownloadLink = 61,
        // 查询好友信息
        QueryFriendInformation = 63,
        // 查询群信息
        QueryGroupInformation = 64,
        // 框架重启！
        Reboot = 65,
        // 群文件转发至群
        GroupFileForwardToGroup = 66,
        // 群文件转发至好友
        GroupFileForwardToFriend = 67,
        // 好友文件转发至好友
        FriendFileForwardToFriend = 68,
        // 置群消息接收
        SetGroupMessageReceive = 69,
        // 取群名称_从缓存
        GetGroupNameFromCache = 70,
        // 发送免费礼物
        SendFreeGift = 71,
        // 取好友在线状态
        GetFriendStatus = 72,
        // 取QQ钱包个人信息！
        GetQQWalletPersonalInformation = 73,
        // 获取订单详情
        GetOrderDetail = 74,
        // 提交支付验证码
        SubmitPaymentCaptcha = 75,
        // 分享音乐
        ShareMusic = 77,
        // 更改群聊消息内容！
        ModifyGroupMessageContent = 78,
        // 更改私聊消息内容！
        ModifyPrivateMessageContent = 79,
        // 群聊口令红包
        GroupPasswordRedEnvelope = 80,
        // 群聊拼手气红包
        GroupRandomRedEnvelope = 81,
        // 群聊普通红包
        GroupNormalRedEnvelope = 82,
        // 群聊画图红包
        GroupDrawRedEnvelope = 83,
        // 群聊语音红包
        GroupAudioRedEnvelope = 84,
        // 群聊接龙红包
        GroupFollowRedEnvelope = 85,
        // 群聊专属红包
        GroupExclusiveRedEnvelope = 86,
        // 好友口令红包
        FriendPasswordRedEnvelope = 87,
        // 好友普通红包
        FriendNormalRedEnvelope = 88,
        // 好友画图红包
        FriendDrawRedEnvelope = 89,
        // 好友语音红包
        FriendAudioRedEnvelope = 90,
        // 好友接龙红包
        FriendFollowRedEnvelope = 91,
    }
}
