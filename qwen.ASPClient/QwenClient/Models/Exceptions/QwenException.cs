using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qwen.ASPClient.QwenClient.Models.Exceptions
{
    public class QwenException : Exception
    {
        public QwenException(string message) : base(message) { }
    }
}
