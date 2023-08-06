using TwitchLib.Client.Models;
using TwitchLib.Client;
using TwitchLib.Communication.Models;
using TwitchLib.Communication.Clients;
using TwitchLib.Client.Events;
using TwitchPopup;

namespace TwitchXIV
{
    internal class BG3Client
    {
        public static TwitchClient Client;

        public static void DoConnect()
        {
            ConnectionCredentials credentials = new ConnectionCredentials(Main.TwitchUsername, Main.TwitchOAuth);
            var clientOptions = new ClientOptions
            {
                MessagesAllowedInPeriod = 750,
                ThrottlingPeriod = TimeSpan.FromSeconds(30)
            };
            WebSocketClient customClient = new WebSocketClient(clientOptions);
            Client = new TwitchClient(customClient);
            Client.Initialize(credentials, Main.TwitchChannel);
            Client.OnJoinedChannel += Client_OnJoinedChannel;
            Client.OnLeftChannel += Client_OnLeftChannel;

            Configuration.Save();

            //BG3Client.OnWhisperReceived += Client_OnWhisperReceived;
            //BG3Client.OnNewSubscriber += Client_OnNewSubscriber;
            //BG3Client.OnConnected += Client_OnConnected;
            Client.Connect();
        }

        public static void Client_OnJoinedChannel(object sender, OnJoinedChannelArgs e)
        {
            //Form1.lblConnected.Text = "Yes";
        }

        public static void Client_OnLeftChannel(object sender, OnLeftChannelArgs e)
        {
            //Form1.lblConnected.Text = "No (Left channel)";
        }
    }
}
