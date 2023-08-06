using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchPopup
{
    public static class Input
    {
        public static string ShowDialog(string text)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 100,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "Twitch Popup Input",
                TopMost = true,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 0, Top =0, AutoSize = true, Text =  text};
            TextBox textBox = new TextBox() { Left = 0, Top = 20, Width = 500 };
            Button confirmation = new Button() { Text = "OK", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            prompt.TopMost = true;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
    }
}
