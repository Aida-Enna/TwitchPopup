using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrayIconForm;
using TwitchLib.Api.Helix;
using TwitchLib.Client.Models;
using TwitchXIV;

namespace TwitchPopup
{
    public partial class Form1 : Form
    {
        public static Keys ActivationKey = Keys.F4;
        private KeyHandler ghk;
        public static bool DetectingKeys = false;
        public static string TwitchUsername = "";
        public static string TwitchChannel = "";
        public static string TwitchOAuth = "";

        public Form1()
        {
            InitializeComponent();

            ghk = new KeyHandler(0, ActivationKey, this);
            ghk.Register();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblKeyPressed.Text = ActivationKey.ToString();
        }

        private void HandleHotkey()
        {
            if (WindowTitle.GetActiveWindowTitle() != txtWindow.Text) { return; }
            string TwitchMessage = Input.ShowDialog("Enter your message:");
            if (BG3Client.Client.IsConnected == false)
            {
                BG3Client.DoConnect();
                BG3Client.Client.JoinChannel(TwitchChannel);
            }
            BG3Client.Client.SendMessage(BG3Client.Client.JoinedChannels.First(), TwitchMessage);
            //string s = Get_Copy();

            //notifyIcon1.BalloonTipText = s;
            //notifyIcon1.BalloonTipTitle = "You have pressed CTRL+i";
            //notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;

            //notifyIcon1.Visible = true;
            //notifyIcon1.ShowBalloonTip(500);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == Constants.WM_HOTKEY_MSG_ID)
                HandleHotkey();
            base.WndProc(ref m);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DetectingKeys = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TwitchUsername = Input.ShowDialog("Enter your twitch username:");
            TwitchChannel = Input.ShowDialog("Enter the initial channel name to join here:");
            TwitchOAuth = Input.ShowDialog("Enter your oath code here (including the \"oath:\" part):");
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
        }

        //private string Get_Copy()
        //{
        //    string r;
        //    // Retrieves data from Clipboard
        //    IDataObject iData = Clipboard.GetDataObject();
        //    // Is Data Text?
        //    if (iData.GetDataPresent(DataFormats.Text))
        //        r = (String)iData.GetData(DataFormats.Text);
        //    else
        //        r = "nothing";
        //    return r;
        //}
        //private void Information_Resize(object sender, EventArgs e)
        //{
        //    //if (FormWindowState.Minimized == this.WindowState)
        //    //{
        //    //    notifyIcon1.BalloonTipText = "My application still working...";
        //    //    notifyIcon1.BalloonTipTitle = "My Sample Application";
        //    //    notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;

        //    //    notifyIcon1.Visible = true;
        //    //    notifyIcon1.ShowBalloonTip(500);
        //    //    this.Hide();
        //    //}
        //    //else if (FormWindowState.Normal == this.WindowState)
        //    //{
        //    //    notifyIcon1.Visible = false;
        //    //}
        //}
    }
}
