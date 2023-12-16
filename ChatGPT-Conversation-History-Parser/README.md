# ChatGPT Conversation History Parser (.NET Core)

This project allows parsing conversation histories from ChatGPT in .Net Core. It reads JSON files containing conversation data and outputs the conversation title, along with all text exchanges formatted with the role, timestamp, and message content.

This is more a general purpose development utility to expand with enable other functionality like storing conversations in a database or generating embeddings to query, or outputting to a web app for modification, etc.

If you don't need to do anything programmatic with your conversation history, I'd recommend just using the chat.html file contained in the export described below, which will display the conversation history in a nice format. It'll be simpler.

# Getting Started

Export your conversations from the ChatGPT website. OpenAI will email you a link to a downloadable zip file with your conversation history. Just download and decompress the zip file, and you'll find a JSON file named conversations.json. This is the file you'll need to parse, and you can either place it in the root directory of this project or modify the file path in the Program.cs file to point to your JSON file.

# Prerequisites

What things you need to install the software and how to install them:

- .NET Core 3.1 or later

# Installing

A step-by-step series of examples that tell you how to get a development environment running:

1. Clone the repository to your local machine:
   git clone https://github.com/kevindenham/ChatGPT-Conversation-History-Parser.git

2. Navigate to the cloned directory.

3. Place your ChatGPT conversation history JSON file in the root directory and rename it to conversations.json, or modify the file path in the Program.cs to point to your JSON file.

4. Run the program:
   dotnet run

# Usage

After running the program, it will output the conversation titles and messages to the console. Each message will display the role (e.g., user, assistant), a human-friendly timestamp, and the message content. Multimedia objects (e.g., images, videos) are not currently supported, deal.

# Plans

- Converting to a Nuget package for easier use in other projects.
- Support for storing conversations in a database, optionally as embeddings to query and retrieve.
- Support for pointing at a directory of multiple unzipped conversation exports, crawling for conversation.json and combining them into the same list.
- Support for downloading from a URL, unzipping and extracting conversation.json

# License

None, go nuts.

# Acknowledgments

- OpenAI - for eventually allowing us to export our data.
- ChatGPT-4 - for saving me a lot of typing.