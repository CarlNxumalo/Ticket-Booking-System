
namespace CMPG212_43400205
{
    partial class Invoice
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblEventName = new System.Windows.Forms.Label();
            this.lblVenue = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblPurchaseDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "EventConnect Invoice";
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventName.Location = new System.Drawing.Point(31, 100);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(125, 25);
            this.lblEventName.TabIndex = 1;
            this.lblEventName.Text = "Event Name:";
            // 
            // lblVenue
            // 
            this.lblVenue.AutoSize = true;
            this.lblVenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenue.Location = new System.Drawing.Point(31, 148);
            this.lblVenue.Name = "lblVenue";
            this.lblVenue.Size = new System.Drawing.Size(76, 25);
            this.lblVenue.TabIndex = 2;
            this.lblVenue.Text = "Venue:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(31, 295);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(62, 25);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(31, 200);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(114, 25);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Event Date:";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(36, 343);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 49);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblPurchaseDate
            // 
            this.lblPurchaseDate.AutoSize = true;
            this.lblPurchaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchaseDate.Location = new System.Drawing.Point(31, 247);
            this.lblPurchaseDate.Name = "lblPurchaseDate";
            this.lblPurchaseDate.Size = new System.Drawing.Size(147, 25);
            this.lblPurchaseDate.TabIndex = 6;
            this.lblPurchaseDate.Text = "Purchase Date:";
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(664, 435);
            this.Controls.Add(this.lblPurchaseDate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblVenue);
            this.Controls.Add(this.lblEventName);
            this.Controls.Add(this.label1);
            this.Name = "Invoice";
            this.Text = "Invoice";
            this.Load += new System.EventHandler(this.Invoice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.Label lblEventName;
        public System.Windows.Forms.Label lblVenue;
        public System.Windows.Forms.Label lblPrice;
        public System.Windows.Forms.Label lblDate;
        public System.Windows.Forms.Label lblPurchaseDate;
    }
}