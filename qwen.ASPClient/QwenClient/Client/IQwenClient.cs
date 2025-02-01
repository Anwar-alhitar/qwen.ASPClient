using qwen.ASPClient.QwenClient.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qwen.ASPClient.QwenClient.Client
{
    public interface IQwenClient
    {
        public Task<QwenResponse> GenerateResponseAsync(string prompt);

    }
}
