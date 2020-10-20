using System;
using System.Collections.Generic;
using System.Text;

namespace Step_307
{
    //Making a custon exception that will inherit from the already made Exception class
    public class ZeroOrLessException : Exception
    {
        public ZeroOrLessException()
            : base() { }
        public ZeroOrLessException(string message)
            : base(message) { }
    }
}
