using System;
using System.Collections.Generic;
using System.Text;

namespace Solucion_Lab_21_abril
{
    public class User
    {

        public delegate void EmailVerifiedEventHandler(object source, EmailVerifiedEventArgs args);
        public event EmailVerifiedEventHandler EmailVerified;
        protected virtual void OnEmailVerified(string username, string email)
        {
            if (EmailVerified != null)
            {
                EmailVerified(this, new EmailVerifiedEventArgs() { Username = username, Email = email } );
            }
        }
        public void OnMailSent(object source, EmailSentEventArgs args)
        {
            Console.WriteLine("Usted desea verificar su email ?: ");
            Console.WriteLine("Favor de responder si o cualquier tecla en caso de no querer.");
            string respuesta = Console.ReadLine();
            
            if (respuesta == "si")
            {
                EmailVerified(new object(), new EmailVerifiedEventArgs());
            }
                
        }
    }
}
