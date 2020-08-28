using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Enum
{
    // 事件类型
    public enum EventTypeEnum
    {
        // 好友事件_被好友删除
        Friend_Removed = 15,
        // 好友事件_签名变更
        Friend_SignatureChanged = 16,
        // 好友事件_昵称改变
        Friend_NameChanged = 17,
        // 好友事件_某人撤回事件
        Friend_UserUndid = 18,
        // 好友事件_有新好友
        Friend_NewFriend = 19,
        // 好友事件_好友请求
        Friend_FriendRequest = 20,
        // 好友事件_对方同意了您的好友请求
        Friend_FriendRequestAccepted = 21,
        // 好友事件_对方拒绝了您的好友请求
        Friend_FriendRequestRefused = 22,
        // 好友事件_资料卡点赞
        Friend_InformationLiked = 23,
        // 好友事件_签名点赞
        Friend_SignatureLiked = 24,
        // 好友事件_签名回复
        Friend_SignatureReplied = 25,
        // 好友事件_个性标签点赞
        Friend_TagLiked = 26,
        // 好友事件_随心贴回复
        Friend_StickerLiked = 27,
        // 好友事件_随心贴增添
        Friend_StickerAdded = 28,

        // 空间事件_与我相关
        QZone_Related = 30,

        // 框架事件_登录成功
        This_SignInSuccess = 32,

        // 群事件_我被邀请加入群
        Group_Invited = 1,
        // 群事件_某人加入了群
        Group_MemberJoined = 2,
        // 群事件_某人申请加群
        Group_MemberVerifying = 3,
        // 群事件_群被解散
        Group_GroupDissolved = 4,
        // 群事件_某人退出了群
        Group_MemberQuit = 5,
        // 群事件_某人被踢出群
        Group_MemberKicked = 6,
        // 群事件_某人被禁言
        Group_MemberShutUp = 7,
        // 群事件_某人撤回事件
        Group_MemberUndid = 8,
        // 群事件_某人被取消管理
        Group_AdministratorTook = 9,
        // 群事件_某人被赋予管理
        Group_AdministratorGave = 10,
        // 群事件_开启全员禁言
        Group_EnableAllShutUp = 11,
        // 群事件_关闭全员禁言
        Group_DisableAllShutUp = 12,
        // 群事件_开启匿名聊天
        Group_EnableAnonymous = 13,
        // 群事件_关闭匿名聊天
        Group_DisableAnonymous = 14,
        // 群事件_开启坦白说
        Group_EnableChatFrankly = 15,
        // 群事件_关闭坦白说
        Group_DisableChatFrankly = 16,
        // 群事件_允许群临时会话
        Group_AllowGroupTemporary = 17,
        // 群事件_禁止群临时会话
        Group_ForbidGroupTemporary = 18,
        // 群事件_允许发起新的群聊
        Group_AllowCreateGroup = 19,
        // 群事件_禁止发起新的群聊
        Group_ForbidCreateGroup = 20,
        // 群事件_允许上传群文件
        Group_AllowUploadFile = 21,
        // 群事件_禁止上传群文件
        Group_ForbidUploadFile = 22,
        // 群事件_允许上传相册
        Group_AllowUploadPicture = 23,
        // 群事件_禁止上传相册
        Group_ForbidUploadPicture = 24,
        // 群事件_某人被邀请入群
        Group_MemberInvited = 25,
        // 群事件_展示成员群头衔
        Group_ShowMemberTitle = 27,
        // 群事件_隐藏成员群头衔
        Group_HideMemberTitle = 28,
        // 群事件_某人被解除禁言
        Group_MemberNotShutUp = 29
    }
}
