﻿using System.Text;

namespace NetTelebot.Type.Keyboard
{
    /// <summary>
    /// Upon receiving a message with this object, Telegram clients will display a reply interface to the user 
    /// (act as if the user has selected the bot‘s message and tapped ’Reply'). 
    /// </summary>
    public class ForceReplyMarkup : IReplyMarkup
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ForceReplyMarkup"/> class.
        /// </summary>
        public ForceReplyMarkup()
        {
            ForceReply = true;
        }

        /// <summary>
        /// Shows reply interface to the user, as if they manually selected the bot‘s message and tapped ’Reply'
        /// </summary>
        public bool ForceReply { get; private set; }

        /// <summary>
        /// Optional. Use this parameter if you want to force reply from specific users only. 
        /// Targets: 
        /// 1) users that are @mentioned in the text of the Message object; 
        /// 2) if the bot's message is a reply (has reply_to_message_id), sender of the original message.
        /// </summary>
        public bool? Selective { get; set; }


        /// <summary>
        /// Gets the json.
        /// </summary>
        /// <returns></returns>
        public string GetJson()
        {
            StringBuilder builder = new StringBuilder();

            builder.Append("{ \"force_reply\" : true ");
            if (Selective.HasValue)
            {
                builder.AppendFormat(", \"selective\" : {0} ", Selective.Value.ToString().ToLower());
            }
            builder.Append("}");

            return builder.ToString();
        }
    }
}
