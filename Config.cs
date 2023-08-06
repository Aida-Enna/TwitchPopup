using Newtonsoft.Json;
using TwitchXIV;

namespace TwitchPopup
{
    public class Configuration
    {
        public string ActivationKey { get; set; }
        public string FocusedWindow { get; set; }
        public string TwitchChannel { get; set; }
        public string TwitchOAuth { get; set; }
        public string TwitchUsername { get; set; }

        public static void Save()
        {
            Configuration config = new Configuration()
            {
                ActivationKey = Main.ActivationKey.ToString(),
                TwitchUsername = Main.TwitchUsername,
                TwitchChannel = Main.TwitchChannel,
                TwitchOAuth = Main.TwitchOAuth,
                FocusedWindow = Main.txtWindow.Text
            };

            File.WriteAllText("config.json", JsonConvert.SerializeObject(config, Formatting.Indented));
        }

        public static void Load()
        {
            if (File.Exists("config.json") == false) { Save(); }
            Configuration LoadedConfig = JsonConvert.DeserializeObject<Configuration>(File.ReadAllText("config.json"));
            if (!String.IsNullOrWhiteSpace(LoadedConfig.ActivationKey)) { Enum.TryParse(LoadedConfig.ActivationKey, out Main.ActivationKey); }
            if (!String.IsNullOrWhiteSpace(LoadedConfig.TwitchUsername)) { Main.TwitchUsername = LoadedConfig.TwitchUsername; }
            if (!String.IsNullOrWhiteSpace(LoadedConfig.TwitchChannel)) { Main.TwitchChannel = LoadedConfig.TwitchChannel; }
            if (!String.IsNullOrWhiteSpace(LoadedConfig.TwitchOAuth)) { Main.TwitchOAuth = LoadedConfig.TwitchOAuth; }
            if (!String.IsNullOrWhiteSpace(LoadedConfig.FocusedWindow)) { Main.txtWindow.Text = LoadedConfig.FocusedWindow; }
            if (!String.IsNullOrWhiteSpace(LoadedConfig.TwitchUsername) && !String.IsNullOrWhiteSpace(LoadedConfig.TwitchChannel) && !String.IsNullOrWhiteSpace(LoadedConfig.TwitchOAuth))
            {
                BG3Client.DoConnect();
                do
                {
                    Thread.Sleep(1000);
                } while (BG3Client.Client.IsConnected == false);
                do
                {
                    Thread.Sleep(1000);
                } while (BG3Client.Client.JoinedChannels.Count() == 0);
                Main.lblConnected.Text = "Connected!";
            }
            //Configuration config = new Configuration()
            //{
            //    ActivationKey = Main.ActivationKey.ToString(),
            //    TwitchUsername = Main.TwitchUsername,
            //    TwitchChannel = Main.TwitchChannel,
            //    TwitchOAuth = Main.TwitchOAuth,
            //    FocusedWindow = Main.txtWindow.Text
            //};

            //File.WriteAllText("config.json", JsonConvert.SerializeObject(config, Formatting.Indented));
        }
    }
}