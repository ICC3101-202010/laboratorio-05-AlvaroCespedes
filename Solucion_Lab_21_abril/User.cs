using System;
using System.Collections.Generic;
using System.Text;

namespace Solucion_Lab_21_abril
{
    public class User
    {
        public delegate void EmailVerifiedEventHandler(object source, EmailVerifiedEventArgs args);
        public event EmailVerifiedEventHandler EmailVerified;
        protected virtual void OnEmailSent(string username, string email)
        {
            if (EmailVerified != null)
            {
                EmailVerified(this, new EmailVerifiedEventArgs() { Username = username, Email = email } );
            }
        }
    }
}
