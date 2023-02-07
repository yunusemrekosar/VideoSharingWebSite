using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WebSite.Application.Exeptions
{
    public class CostomException : Exception
    {
        public CostomException()
        {
        }

        public CostomException(string? message) : base(message)
        {
        }

        public CostomException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected CostomException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
