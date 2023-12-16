using System.Text.Json.Serialization;
using System.Text.Json;

namespace ChatGPT_Conversation_History_Parser.Conversation
{
    internal class Content
    {
        [JsonPropertyName("content_type")]
        public string? ContentType { get; set; }

        [JsonPropertyName("parts")]
        public List<JsonElement>? Parts { get; set; }
    }
}
