using System;
using System.Net;
using Newtonsoft.Json;

namespace DDBLSharp
{
    public class DDBL
    {
        public string Token { get; set; }
        public long BotId { get; set; }
        public void PostStats(int ServerCount)
        {
            WebClient client = new WebClient();
            client.Headers.Add("Authorization", Token);
            client.Headers.Add("content-type", "application/json");

            var data = JsonConvert.SerializeObject(new { server_count = ServerCount.ToString() });

            try
            {
                client.UploadString(new Uri("https://divinediscordbots.com/bot/" + BotId + "/stats"), "POST", data);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[SUCCESS] Divine Discord Bot API: Server Count Posted");
                Console.ResetColor();
            }
            catch (WebException e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(String.Format("[ERROR: {0}] Divine Discord Bot API: {1}", e.Status, e.Message));
                Console.ResetColor();
            }
            finally
            {
                client?.Dispose();
            }
        }
    }
}
