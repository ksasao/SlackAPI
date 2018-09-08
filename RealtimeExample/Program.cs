using SlackAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealtimeExample
{
    class Program
    {
        static SlackSocketClient _socketClient;

        static void Main(string[] args)
        {
            // Legacy token is required for websocket client
            // https://api.slack.com/custom-integrations/legacy-tokens
            string accessTokenLegacy = "[Your Legacy Token]";

            _socketClient = new SlackSocketClient(accessTokenLegacy);
            _socketClient.OnMessageReceived += _socketClient_OnMessageReceived;

            _socketClient.Connect((connected) =>
            {
                Console.WriteLine("Connected.");
            });
            Console.ReadKey();
        }

        private static void _socketClient_OnMessageReceived(SlackAPI.WebSocketMessages.NewMessage obj)
        {
            string channel = obj.channel;
            string team = obj.team;
            DateTime date = obj.ts;
            Console.WriteLine(obj.RawMessage);

            string username = obj?.username ?? obj.user;
            string text = obj?.text ?? obj?.attachments[0].fallback ?? "";
            Console.WriteLine($"{date} {username}: {text}");
        }
    }
}
