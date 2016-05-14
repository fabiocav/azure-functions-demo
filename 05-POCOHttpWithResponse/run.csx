// Sample using a POCO input argument and a POCO return value

#r "Newtonsoft.Json"

using Newtonsoft.Json.Linq;

public static Message Run(Message req)
{
    return new Message 
    {
        Content = "Pong!"
    };
}

public class Message
{
    public string Content { get; set; }
}