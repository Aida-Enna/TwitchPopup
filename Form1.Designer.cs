namespace TwitchPopup
{
    partial class Form1
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
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
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
            button1.Location = new Point(11, 10);
            button1.Name = "button1";
            button1.Size = new Size(86, 47);
            button1.TabIndex = 1;
            button1.Text = "Reassign hotkey";
            button1.UseVisualStyleBackColor = true;
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
            // button2
            // 
            button2.Location = new Point(103, 10);
            button2.Name = "button2";
            button2.Size = new Size(86, 47);
            button2.TabIndex = 3;
            button2.Text = "Connect to Twitch";
            button2.UseVisualStyleBackColor = true;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(126, 75);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 5;
            label3.Text = "False";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(264, 96);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(lblKeyPressed);
            Name = "Form1";
            Text = "Twitch Popup";
            WindowState = FormWindowState.Minimized;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private ErrorProvider errorProvider1;
        private Label label2;
        private Button button2;
        public Label lblKeyPressed;
        private Label label3;
    }
}