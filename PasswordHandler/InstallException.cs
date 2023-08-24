using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PasswordHandler
{
    public class InstallException : Exception
    {
        public InstallException()
        {
        }

        public InstallException(string? message) : base(message)
        {
        }

        public InstallException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected InstallException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
