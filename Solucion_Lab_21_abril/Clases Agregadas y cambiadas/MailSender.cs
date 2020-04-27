using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Solucion_Lab_21_abril
{
    public class MailSender
    {
        //MailSender Debe reaccionar a 2 eventos. cuando el usuario se registra y el evento cuando se cambia la contraseña el usuario.
        public void OnRegistered(object source, RegisterEventArgs e)
        {
            Thread.Sleep(2000);
            Console.WriteLine($"\nCorreo enviado a {e.Email}: \n Gracias por registrarte, {e.Username}!\n Por favor, para poder verificar tu correo, has click en: {e.VerificationLink}\n");
            Thread.Sleep(2000);
        }

        public void OnPasswordChanged(object source, ChangePasswordEventArgs e)
        {
            Thread.Sleep(2000);
            Console.WriteLine($"\nCorreo enviado a {e.Email}:  \n {e.Username}, te notificamos que la contrasena de tu cuenta PlusCorp ha sido cambiada. \n");
            Thread.Sleep(2000);
        }
        public delegate void EmailSentEventHandler(object source, EmailSentEventArgs args);
        public event EmailSentEventHandler EmailSent;
        protected virtual void OnEmailSent(string username, string email)
        {
            if (EmailSent != null)
            {
                EmailSent(this, new EmailSentEventArgs() { Username = username, Email = email });
            }
        }
    }
}
