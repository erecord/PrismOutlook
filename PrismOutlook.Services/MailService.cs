﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using PrismOutlook.Business;
using PrismOutlook.Services.Interfaces;

namespace PrismOutlook.Services
{
    public class MailService : IMailService
    {
        static readonly List<MailMessage> InboxItems = new List<MailMessage>
        {
            new MailMessage
            {
                Id = 1,
                From = "test1@example.com",
                To = new ObservableCollection<string>{"recipient1@example.com", "recipient1@example.com" },
                Subject = "This is a test email 1",
                Body = "This is the body of an email 1",
                DateSent = DateTime.Now
            },
            new MailMessage
            {
                Id = 1,
                From = "test2@example.com",
                To = new ObservableCollection<string>{"recipient3@example.com", "recipient1@example.com" },
                Subject = "This is a test email 2",
                Body = "This is the body of an email 2",
                DateSent = DateTime.Now.AddDays(-5)
            },
            new MailMessage
            {
                Id = 1,
                From = "test1@example.com",
                To = new ObservableCollection<string>{"recipient1@example.com", "recipient2@example.com" },
                Subject = "This is a test email 3",
                Body = "This is the body of an email 3",
                DateSent = DateTime.Now.AddDays(-1)
            },
        };

        private static readonly List<MailMessage> SentItems = new List<MailMessage>
        {
        };

        private static readonly List<MailMessage> DeletedItems = new List<MailMessage>
        {
        };

        public IList<MailMessage> GetInboxItems()
        {
            return InboxItems;
        }

        public IList<MailMessage> GetSentItems()
        {
            return SentItems;
        }

        public IList<MailMessage> GetDeletedItems()
        {
            return DeletedItems;
        }
    }
}
