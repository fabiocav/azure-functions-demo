// Sample using a POCO input argument

#r "Newtonsoft.Json"

using Newtonsoft.Json.Linq;

public static JObject Run(Payload req)
{
    return new JObject()
    {
        { "requestId", req.Id },
        { "result", req.Value }
    };
}

public class Payload
{
    public string Id { get; set; }
    public string Value { get; set; }
}