using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Mail;
using System.Net.Mail;
using DDL;

namespace DDL
{
    public class SmtpClientWrapper : ISmtpClientWrapper
    {
        private readonly SmtpClient _smtp;

        public SmtpClientWrapper(SmtpClient smtp)
        {
            this._smtp = smtp;
        }

        public void Send(MailMessage message)
        {
            _smtp.Send(message);
        }
    }
}