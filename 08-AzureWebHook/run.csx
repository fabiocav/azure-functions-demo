#r "Newtonsoft.Json"
#r "Microsoft.AspNet.WebHooks.Receivers.Azure"

using System;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Microsoft.AspNet.WebHooks;

public static void Run(AzureAlertNotification payload, TraceWriter log)
{
    log.Info(payload.Status);
}