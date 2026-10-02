using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace DDL
{
    public interface ISmtpClientWrapper
    {
        void Send(MailMessage message);   
    }
}

//