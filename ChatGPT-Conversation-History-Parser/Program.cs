using ChatGPT_Conversation_History_Parser.Conversation;
using System.Text.Json;

namespace HCSS
{
    public class ChatGPT_Conversation_History_Parser
    {
        public static void Main()
        {
            // Replace 'conversations.json' with the actual file path
            string filePath = "conversations.json";
            string jsonString = File.ReadAllText(filePath);
            Conversation[]? rootObjects = JsonSerializer.Deserialize<Conversation[]>(jsonString);

            if (rootObjects != null)
                foreach (Conversation rootObject in rootObjects)
                {
                    Console.WriteLine($"### {rootObject.Title} ###\n") ;

                    if (rootObject.Mapping != null)
                    {
                        foreach (var entry in rootObject.Mapping)
                        {
                            var message = entry.Value.Message;
                            if (message != null && message.Content != null)
                            {
                                Console.WriteLine($"{message.Author?.Role ?? "Unknown"}");

                                if (message.CreateTime.HasValue)
                                {
                                    var timestamp = DateTimeOffset.FromUnixTimeSeconds((long)message.CreateTime.Value).ToLocalTime();
                                    Console.WriteLine($"{timestamp}");
                                }
                                else
                                {
                                    Console.WriteLine("Timestamp: Unknown");
                                }

                                if (message.Content.Parts != null)
                                    foreach (var part in message.Content.Parts)
                                    {
                                        if (part.ValueKind == JsonValueKind.String)
                                        {
                                            Console.WriteLine(part.GetString());
                                        }
                                        else if (part.ValueKind == JsonValueKind.Object)
                                        {
                                            // Handle the object case, or ignore if not needed
                                            Console.WriteLine("Found an object in parts.");
                                            Console.WriteLine(part.ToString());
                                        }
                                    }
                                Console.WriteLine(); 
                            }
                        }
                    }
                    Console.WriteLine("-------------------------------------------------\n"); // Separator for conversations
                }
        }
    }
}

