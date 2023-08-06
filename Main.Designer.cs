namespace TwitchPopup
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblKeyPressed = new Label();
            button1 = new Button();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            btnConnectToTwitch = new Button();
            label2 = new Label();
            lblConnected = new Label();
            txtWindow = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblKeyPressed
            // 
            lblKeyPressed.AutoSize = true;
            lblKeyPressed.Location = new Point(217, 60);
            lblKeyPressed.Name = "lblKeyPressed";
            lblKeyPressed.Size = new Size(45, 15);
            lblKeyPressed.TabIndex = 0;
            lblKeyPressed.Text = "Hotkey";
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new Point(11, 10);
            button1.Name = "button1";
            button1.Size = new Size(64, 47);
            button1.TabIndex = 1;
            button1.Text = "Reassign hotkey";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 60);
            label1.Name = "label1";
            label1.Size = new Size(207, 15);
            label1.TabIndex = 2;
            label1.Text = "This is your currently assigned hotkey:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnConnectToTwitch
            // 
            btnConnectToTwitch.Location = new Point(81, 10);
            btnConnectToTwitch.Name = "btnConnectToTwitch";
            btnConnectToTwitch.Size = new Size(64, 47);
            btnConnectToTwitch.TabIndex = 3;
            btnConnectToTwitch.Text = "Connect to Twitch";
            btnConnectToTwitch.UseVisualStyleBackColor = true;
            btnConnectToTwitch.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 75);
            label2.Name = "label2";
            label2.Size = new Size(118, 15);
            label2.TabIndex = 4;
            label2.Text = "Connected to twitch:";
            label2.Click += label2_Click;
            // 
            // lblConnected
            // 
            lblConnected.AutoSize = true;
            lblConnected.Location = new Point(126, 75);
            lblConnected.Name = "lblConnected";
            lblConnected.Size = new Size(33, 15);
            lblConnected.TabIndex = 5;
            lblConnected.Text = "False";
            lblConnected.Click += lblConnected_Click;
            // 
            // txtWindow
            // 
            txtWindow.Location = new Point(11, 108);
            txtWindow.Name = "txtWindow";
            txtWindow.Size = new Size(241, 23);
            txtWindow.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 90);
            label4.Name = "label4";
            label4.Size = new Size(221, 15);
            label4.TabIndex = 7;
            label4.Text = "Only show when this window is focused:";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(266, 143);
            Controls.Add(label4);
            Controls.Add(txtWindow);
            Controls.Add(lblConnected);
            Controls.Add(label2);
            Controls.Add(btnConnectToTwitch);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(lblKeyPressed);
            Name = "Main";
            Text = "Twitch Popup";
            WindowState = FormWindowState.Minimized;
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button button1;
        public Label label1;
        public ErrorProvider errorProvider1;
        public Label label2;
        public Button btnConnectToTwitch;
        public Label lblKeyPressed;
        public Label label4;
        public static TextBox txtWindow;
        public static Label lblConnected;
    }
}