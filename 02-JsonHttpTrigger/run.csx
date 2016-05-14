// Sample using a JObject input argument

#r "Newtonsoft.Json"

using System.Net;
using Newtonsoft.Json.Linq;

public static HttpResponseMessage Run(JObject req, TraceWriter log)
{
    log.Info($"C# HTTP trigger function processed a request.");

    // Get name from request body
    string name = req["name"]?.ToString() ?? "from Azure Functions";

    return new HttpResponseMessage(HttpStatusCode.OK)
    {
        Content = new StringContent($"Hello {name}")
    };
}