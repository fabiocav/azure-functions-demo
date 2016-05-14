
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

public static async Task Run(dynamic payload, TraceWriter log)
{
    log.Info($"{payload.issue.user.login} edited issue {payload.issue.number} ({payload.issue.title})");
    
    if (payload.action == "opened")
    {
        using (var client = new HttpClient())
        {
            client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("azure-functions", "1.0"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Environment.GetEnvironmentVariable("GITHUB_CREDENTIALS"));
        
            var content = new StringContent("[\"processed-by-function\"]", Encoding.UTF8, "application/json");
            await client.PostAsync($"{payload.issue.url}/labels", content);
        }
    }
}
