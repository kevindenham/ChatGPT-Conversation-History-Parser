using System.Text.Json.Serialization;

namespace ChatGPT_Conversation_History_Parser.Conversation
{
    internal class Conversation
    {
        [JsonPropertyName("title")]
        public string? Title { get; set; }

        [JsonPropertyName("create_time")]
        public double CreateTime { get; set; }

        [JsonPropertyName("update_time")]
        public double UpdateTime { get; set; }

        [JsonPropertyName("mapping")]
        public Dictionary<string, MappingObject>? Mapping { get; set; }

        // Other properties like moderation_results, current_node, etc.

        [JsonPropertyName("conversation_id")]
        public string? ConversationId { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}
