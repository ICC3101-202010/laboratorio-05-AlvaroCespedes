using System;
using System.Collections.Generic;
using System.Text;

namespace Solucion_Lab_21_abril
{
    public class EmailVerifiedEventArgs : EventArgs
    {
        public string Username { get; set; }
        public string Email { get; set; }
    }
}
