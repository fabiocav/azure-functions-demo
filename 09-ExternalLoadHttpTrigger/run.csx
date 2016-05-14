#load "payload.csx"

public static Payload Run(Payload req, TraceWriter log)
{
    log.Info($"Received request with payload ID: {req.Id}");
    req.Value = "Response";
    return req;
}