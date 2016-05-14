#r "Newtonsoft.Json"
#r "Microsoft.AspNet.WebHooks.Receivers.Azure"

using System;
using Microsoft.AspNet.WebHooks;

public static void Run(AzureAlertNotification payload, TraceWriter log)
{
    log.Info(payload.Status);
}
