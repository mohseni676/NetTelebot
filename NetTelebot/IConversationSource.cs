﻿using System;

namespace NetTelebot
{
    /// <summary>
    /// This interface is used to specify the source of the conversation in an incoming message. It can be a UserInfo or a GroupChatInfo.
    /// </summary>
    public interface IConversationSource
    {
        /// <summary>
        /// Unique identifier of the group chat or user.
        /// </summary>
        int Id { get; set; }
    }
}
