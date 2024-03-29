﻿using BindOpen.Data;
using BindOpen.Messages.Contacts;

namespace BindOpen.Messages
{
    /// <summary>
    /// This class extends BindOpenHost.
    /// </summary>
    public static class BdoMessages
    {
        public static T NewContact<T>(string name = null)
            where T : IBdoContact, new()
        {
            return BdoData.New<T>();
        }

        public static BdoContact NewContact(string name = null)
        {
            return BdoData.New<BdoContact>()
                .WithName(name);
        }

        public static T NewMessage<T>(string subject = null, string body = null)
            where T : IBdoMessage, new()
        {
            var obj = BdoData.New<T>()
                .WithSubject(BdoData.NewDictionary(subject))
                .WithBody(BdoData.NewDictionary(body));

            return obj;
        }

        public static BdoMessage NewMessage(string subject = null, string body = null)
        {
            return NewMessage<BdoMessage>(subject, body);
        }

        public static BdoSendingMessage NewSendingMessage(string subject = null, string body = null)
        {
            return NewMessage<BdoSendingMessage>(subject, body);
        }

        public static BdoMessage NewSendingRequest()
        {
            return BdoData.New<BdoMessage>();
        }
    }
}
