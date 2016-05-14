// Sample using a JObject input argument and a JObject return value

#r "Newtonsoft.Json"

using Newtonsoft.Json.Linq;

public static JObject Run(JObject req, TraceWriter log)
{
    log.Info($"C# HTTP trigger function processed a request.");

    // Get name from request body
    string name = req["name"]?.ToString() ?? "from Azure Functions";

    return new JObject()
    {
        { "greeting", $"Hello {name}" }
    };
}