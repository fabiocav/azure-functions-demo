using System.Net;

public static object Run(string req, TraceWriter log)
{
    log.Info($"C# HTTP trigger function processed a request. {req}");

    return "Pong!";
}