using System.Text.Json.Serialization;


namespace ChatGPT_Conversation_History_Parser.Conversation
{
    internal class MappingObject
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("message")]
        public Message? Message { get; set; }

        [JsonPropertyName("parent")]
        public string? Parent { get; set; }

        [JsonPropertyName("children")]
        public List<string>? Children { get; set; }
    }
}
