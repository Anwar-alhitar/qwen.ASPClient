using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace qwen.ASPClient.QwenClient.Models.Response
{
    public class QwenResponse
    {
        [JsonPropertyName("choices")]
        public List<QwenChoice> Choices { get; set; }
    }

    public class QwenChoice
    {
        [JsonPropertyName("message")]
        public QwenMessage Message { get; set; }
    }

    public class QwenMessage
    {
        [JsonPropertyName("content")]
        public string Content { get; set; }
    }
}
