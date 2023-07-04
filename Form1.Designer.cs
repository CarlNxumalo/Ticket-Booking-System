
namespace CMPG212_43400205
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userDashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hostDashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.userDashboardToolStripMenuItem,
            this.hostDashboardToolStripMenuItem,
            this.signUpToolStripMenuItem,
            this.loginToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(828, 36);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(57, 32);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // userDashboardToolStripMenuItem
            // 
            this.userDashboardToolStripMenuItem.Name = "userDashboardToolStripMenuItem";
            this.userDashboardToolStripMenuItem.Size = new System.Drawing.Size(166, 32);
            this.userDashboardToolStripMenuItem.Text = "User Dashboard";
            this.userDashboardToolStripMenuItem.Click += new System.EventHandler(this.userDashboardToolStripMenuItem_Click);
            // 
            // hostDashboardToolStripMenuItem
            // 
            this.hostDashboardToolStripMenuItem.Name = "hostDashboardToolStripMenuItem";
            this.hostDashboardToolStripMenuItem.Size = new System.Drawing.Size(168, 32);
            this.hostDashboardToolStripMenuItem.Text = "Host Dashboard";
            this.hostDashboardToolStripMenuItem.Click += new System.EventHandler(this.hostDashboardToolStripMenuItem_Click);
            // 
            // signUpToolStripMenuItem
            // 
            this.signUpToolStripMenuItem.Name = "signUpToolStripMenuItem";
            this.signUpToolStripMenuItem.Size = new System.Drawing.Size(96, 32);
            this.signUpToolStripMenuItem.Text = "Sign Up";
            this.signUpToolStripMenuItem.Click += new System.EventHandler(this.signUpToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(75, 32);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(828, 496);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "EventConnect";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hostDashboardToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem userDashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
    }
}

