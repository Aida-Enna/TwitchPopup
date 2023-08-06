using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrayIconForm;

namespace TwitchPopup
{
    public partial class Form1 : Form
    {
        public static Keys ActivationKey = Keys.Z;
        private KeyHandler ghk;

        public Form1()
        {
            InitializeComponent();

            ghk = new KeyHandler(0, ActivationKey, this);
            ghk.Register();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine("You pressed " + e.KeyCode);
            if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0)
            {
                //Do Something if the 0 key is pressed (includes Num Pad 0)
            }
        }

        private void HandleHotkey()
        {

            string promptValue = Input.ShowDialog("Test", "123");
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
