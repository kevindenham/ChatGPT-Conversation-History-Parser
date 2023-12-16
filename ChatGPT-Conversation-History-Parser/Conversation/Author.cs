﻿using System.Text.Json.Serialization;

namespace ChatGPT_Conversation_History_Parser.Conversation
{
    internal class Author
    {
        [JsonPropertyName("role")]
        public string? Role { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("metadata")]
        public Dictionary<string, object>? Metadata { get; set; }
    }
}
