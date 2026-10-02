using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace DLL
{
    public interface ISmtpClientWrapper
    {
        void Send(MailMessage message);   
    }
}

//