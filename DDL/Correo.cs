using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;
using DDL;

namespace DDL
{
    public class Correo : ICorreo
    {
        private readonly ISmtpClientWrapper _smtp;

        public Correo(ISmtpClientWrapper smtp)
        {
            this._smtp = smtp;
        }

        public static Correo CrearConSmtpReal()
        {
            var smtp = new SmtpClient("smtp.gmail.com")
            {
                Port = 465,
                Credentials = new System.Net.NetworkCredential("usuario", "contraseña"),
                EnableSsl = true,
            };

            return new Correo(new SmtpClientWrapper(smtp));
        }

        public void Enviar(IDocumento documento, string destinatario)
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("vladimir.cortes.a@gmail.com"); //Remitente
            mail.To.Add(destinatario); //Destinatario
            mail.Subject = "Curso de Test Unitarios"; //Asunto
            mail.Body = documento.GenerarDocumento(); //Cuerpo del Correo
            _smtp.Send(mail);
        }
        
    }
}