
namespace CMPG212_43400205
{
    partial class SignUp
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
            this.components = new System.ComponentModel.Container();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbSignUp = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.epSignUp = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbSignUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epSignUp)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(533, 438);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(100, 34);
            this.btnSignUp.TabIndex = 4;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // txtFName
            // 
            this.txtFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFName.Location = new System.Drawing.Point(533, 172);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(147, 30);
            this.txtFName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(339, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "First Name:";
            // 
            // txtUserID
            // 
            this.txtUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserID.Location = new System.Drawing.Point(533, 110);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(147, 30);
            this.txtUserID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(339, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "User ID(4 digits):";
            // 
            // gbSignUp
            // 
            this.gbSignUp.Controls.Add(this.label3);
            this.gbSignUp.Controls.Add(this.txtLName);
            this.gbSignUp.Controls.Add(this.txtPassword);
            this.gbSignUp.Controls.Add(this.label4);
            this.gbSignUp.Controls.Add(this.btnSignUp);
            this.gbSignUp.Controls.Add(this.label1);
            this.gbSignUp.Controls.Add(this.txtUserID);
            this.gbSignUp.Controls.Add(this.txtFName);
            this.gbSignUp.Controls.Add(this.label2);
            this.gbSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSignUp.Location = new System.Drawing.Point(51, 36);
            this.gbSignUp.Margin = new System.Windows.Forms.Padding(2);
            this.gbSignUp.Name = "gbSignUp";
            this.gbSignUp.Padding = new System.Windows.Forms.Padding(2);
            this.gbSignUp.Size = new System.Drawing.Size(1089, 600);
            this.gbSignUp.TabIndex = 12;
            this.gbSignUp.TabStop = false;
            this.gbSignUp.Text = "Enter details";
            this.gbSignUp.Enter += new System.EventHandler(this.gbSignUp_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(339, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Last Name:";
            // 
            // txtLName
            // 
            this.txtLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLName.Location = new System.Drawing.Point(533, 240);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(147, 30);
            this.txtLName.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(533, 310);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(147, 30);
            this.txtPassword.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(339, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Password:";
            // 
            // epSignUp
            // 
            this.epSignUp.ContainerControl = this;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1196, 680);
            this.Controls.Add(this.gbSignUp);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.gbSignUp.ResumeLayout(false);
            this.gbSignUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epSignUp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbSignUp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider epSignUp;
    }
}