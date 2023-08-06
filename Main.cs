using System.Diagnostics;
using TrayIconForm;
using TwitchXIV;

namespace TwitchPopup
{
    public partial class Main : Form
    {
        public static Keys ActivationKey = Keys.F4;
        private KeyHandler ghk;
        public static string TwitchUsername = "null";
        public static string TwitchChannel = "null";
        public static string TwitchOAuth = "null";

        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private static extern bool ShowWindow(IntPtr hwnd, int nCmdShow);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hwnd);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr SetFocus(IntPtr hwnd);

        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("config.json")) { Configuration.Load(); }
            lblKeyPressed.Text = ActivationKey.ToString();
            ghk = new KeyHandler(0, ActivationKey, this);
            ghk.Register();
        }

        private void HandleHotkey()
        {
            if (WindowTitle.GetActiveWindowTitle().Contains(txtWindow.Text) == false && String.IsNullOrWhiteSpace(txtWindow.Text) == false) { return; }
            ghk.Unregister();
            string TwitchMessage = Input.ShowDialog("Enter your message:");
            IntPtr h = FindWindow("Twitch Popup Input", null);
            ShowWindow(h, 5);
            SetForegroundWindow(h);
            SetFocus(h);
            if (String.IsNullOrWhiteSpace(TwitchMessage)) { ghk.Register(); return; }
            if (BG3Client.Client == null || lblConnected.Text == "False") { MessageBox.Show("You are not connected to twitch!"); ghk.Register(); return; }
            if (BG3Client.Client.IsConnected == false)
            {
                BG3Client.DoConnect();
                BG3Client.Client.JoinChannel(TwitchChannel);
            }
            BG3Client.Client.SendMessage(BG3Client.Client.JoinedChannels.First(), TwitchMessage);
            ghk.Register();
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == Constants.WM_HOTKEY_MSG_ID)
                HandleHotkey();
            base.WndProc(ref m);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (TwitchUsername == "null") { TwitchUsername = Input.ShowDialog("Enter your twitch username:"); }
            if (TwitchChannel == "null") { TwitchChannel = Input.ShowDialog("Enter the initial channel name to join here:"); }
            if (TwitchOAuth == "null")
            {
                MessageBox.Show("Next, we'll open a window to the twitch OAuth Password Generator. Click 'Connect' and log into Twitch and then it'll spit out a series of letters and numbers. Copy that and come back here after.");
                Process.Start(new ProcessStartInfo("https://twitchapps.com/tmi/") { UseShellExecute = true });
                TwitchOAuth = Input.ShowDialog("Enter your oath code here (including the \"oath:\" part):");
            }
            lblConnected.Text = "Attempting to connect...";
            BG3Client.DoConnect();
            do
            {
                Thread.Sleep(1000);
            } while (BG3Client.Client.IsConnected == false);
            lblConnected.Text = "Logged in, joining channel...";
            BG3Client.Client.JoinChannel(TwitchChannel);
            do
            {
                Thread.Sleep(1000);
            } while (BG3Client.Client.JoinedChannels.Count() == 0);
            lblConnected.Text = "Connected!";
            Configuration.Save();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            TwitchUsername = "null";
            TwitchChannel = "null";
            TwitchOAuth = "null";
            Configuration.Save();
        }
    }
}