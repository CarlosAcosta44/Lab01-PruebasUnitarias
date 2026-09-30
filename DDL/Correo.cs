using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace DDL
{
    public class Correo : ICorreo
    {
        private readonly SmtpClient _smtp;

        public Correo()
        {
                _smtp = new SmtpClient("smtp.gmail.com") {
                Port = 465,
                Credentials = new System.Net.NetworkCredential("carlosacosta12007@gmail.com", "27dedicde2007"),
                EnableSsl = true,
            };
        }
        
        public void Enviar(IDocumento documento, string destinatario)
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("carlosacosta12007@gmail.com"); //Remitente
            mail.To.Add(destinatario); //Destinatario
            mail.Subject = "Mensaje de prueba"; //Asunto
            mail.Body = documento.GenerarDocumento(); //cuerpo del correo
            _smtp.Send(mail);
        }
    }
}