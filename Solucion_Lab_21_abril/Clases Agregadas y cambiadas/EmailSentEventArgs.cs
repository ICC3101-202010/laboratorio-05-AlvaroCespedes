using System;
using System.Collections.Generic;
using System.Text;

namespace Solucion_Lab_21_abril
{
    public class EmailSentEventArgs : EventArgs
    {
        public string Email { get; set; }

        public string Username { get; set; }

    }
}
