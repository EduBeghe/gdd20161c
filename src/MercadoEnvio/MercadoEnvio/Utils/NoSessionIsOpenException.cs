using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MercadoEnvio.Utils
{
    class NoSessionIsOpenException : Exception
    {

    // Constructors
    public NoSessionIsOpenException(string Message) : base(Message)
   {
   }

    public NoSessionIsOpenException()
    { }

    }
}
