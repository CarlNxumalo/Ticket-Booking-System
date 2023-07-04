
namespace CMPG212_43400205
{
    partial class HostDash
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
            this.tabPeople = new System.Windows.Forms.TabControl();
            this.tpCreateEditEvent = new System.Windows.Forms.TabPage();
            this.dgvTheirEvents = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbTheirEvents = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCCategory = new System.Windows.Forms.TextBox();
            this.dtpCDate = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCPrice = new System.Windows.Forms.TextBox();
            this.btnCreatEvent = new System.Windows.Forms.Button();
            this.cbCRegistration = new System.Windows.Forms.CheckBox();
            this.cmbCVenue = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCEvent = new System.Windows.Forms.TextBox();
            this.tpCancel = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbCancelEvent = new System.Windows.Forms.ComboBox();
            this.btnCancelEvent = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.tpParticipants = new System.Windows.Forms.TabPage();
            this.epHostDash = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbSeeParticipants = new System.Windows.Forms.ComboBox();
            this.btnSeeParticipants = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnTrack = new System.Windows.Forms.Button();
            this.lblTrack = new System.Windows.Forms.Label();
            this.tabPeople.SuspendLayout();
            this.tpCreateEditEvent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheirEvents)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tpCancel.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tpParticipants.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epHostDash)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPeople
            // 
            this.tabPeople.Controls.Add(this.tpCreateEditEvent);
            this.tabPeople.Controls.Add(this.tpCancel);
            this.tabPeople.Controls.Add(this.tpParticipants);
            this.tabPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPeople.Location = new System.Drawing.Point(12, 12);
            this.tabPeople.Name = "tabPeople";
            this.tabPeople.SelectedIndex = 0;
            this.tabPeople.Size = new System.Drawing.Size(627, 850);
            this.tabPeople.TabIndex = 0;
            this.tabPeople.Enter += new System.EventHandler(this.tabPeople_Enter);
            // 
            // tpCreateEditEvent
            // 
            this.tpCreateEditEvent.Controls.Add(this.groupBox1);
            this.tpCreateEditEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpCreateEditEvent.Location = new System.Drawing.Point(4, 29);
            this.tpCreateEditEvent.Name = "tpCreateEditEvent";
            this.tpCreateEditEvent.Padding = new System.Windows.Forms.Padding(3);
            this.tpCreateEditEvent.Size = new System.Drawing.Size(619, 817);
            this.tpCreateEditEvent.TabIndex = 1;
            this.tpCreateEditEvent.Text = "Create/Edit Event";
            this.tpCreateEditEvent.UseVisualStyleBackColor = true;
            // 
            // dgvTheirEvents
            // 
            this.dgvTheirEvents.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvTheirEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTheirEvents.Location = new System.Drawing.Point(645, 41);
            this.dgvTheirEvents.Name = "dgvTheirEvents";
            this.dgvTheirEvents.RowHeadersWidth = 51;
            this.dgvTheirEvents.RowTemplate.Height = 24;
            this.dgvTheirEvents.Size = new System.Drawing.Size(858, 817);
            this.dgvTheirEvents.TabIndex = 1;
            this.dgvTheirEvents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTheirEvents_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbTheirEvents);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtCCategory);
            this.groupBox1.Controls.Add(this.dtpCDate);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtCPrice);
            this.groupBox1.Controls.Add(this.btnCreatEvent);
            this.groupBox1.Controls.Add(this.cbCRegistration);
            this.groupBox1.Controls.Add(this.cmbCVenue);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtCTime);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCDescription);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCEvent);
            this.groupBox1.Location = new System.Drawing.Point(57, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 740);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Or Edit Events";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmbTheirEvents
            // 
            this.cmbTheirEvents.FormattingEnabled = true;
            this.cmbTheirEvents.Location = new System.Drawing.Point(182, 40);
            this.cmbTheirEvents.Name = "cmbTheirEvents";
            this.cmbTheirEvents.Size = new System.Drawing.Size(134, 28);
            this.cmbTheirEvents.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Event ID(For edit)";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(349, 671);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(134, 47);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(26, 591);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 20);
            this.label15.TabIndex = 13;
            this.label15.Text = "Category";
            // 
            // txtCCategory
            // 
            this.txtCCategory.Location = new System.Drawing.Point(182, 588);
            this.txtCCategory.Name = "txtCCategory";
            this.txtCCategory.Size = new System.Drawing.Size(301, 27);
            this.txtCCategory.TabIndex = 8;
            // 
            // dtpCDate
            // 
            this.dtpCDate.CustomFormat = "yyyy/MM/dd";
            this.dtpCDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCDate.Location = new System.Drawing.Point(182, 302);
            this.dtpCDate.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dtpCDate.MinDate = new System.DateTime(2023, 6, 24, 0, 0, 0, 0);
            this.dtpCDate.Name = "dtpCDate";
            this.dtpCDate.Size = new System.Drawing.Size(200, 27);
            this.dtpCDate.TabIndex = 3;
            this.dtpCDate.Value = new System.DateTime(2023, 6, 29, 0, 0, 0, 0);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(26, 538);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 20);
            this.label14.TabIndex = 11;
            this.label14.Text = "Price";
            // 
            // txtCPrice
            // 
            this.txtCPrice.Location = new System.Drawing.Point(182, 535);
            this.txtCPrice.Name = "txtCPrice";
            this.txtCPrice.Size = new System.Drawing.Size(301, 27);
            this.txtCPrice.TabIndex = 7;
            // 
            // btnCreatEvent
            // 
            this.btnCreatEvent.Location = new System.Drawing.Point(30, 671);
            this.btnCreatEvent.Name = "btnCreatEvent";
            this.btnCreatEvent.Size = new System.Drawing.Size(134, 47);
            this.btnCreatEvent.TabIndex = 9;
            this.btnCreatEvent.Text = "Create";
            this.btnCreatEvent.UseVisualStyleBackColor = true;
            this.btnCreatEvent.Click += new System.EventHandler(this.btnCreatEvent_Click);
            // 
            // cbCRegistration
            // 
            this.cbCRegistration.AutoSize = true;
            this.cbCRegistration.Location = new System.Drawing.Point(182, 482);
            this.cbCRegistration.Name = "cbCRegistration";
            this.cbCRegistration.Size = new System.Drawing.Size(84, 24);
            this.cbCRegistration.TabIndex = 6;
            this.cbCRegistration.Text = "disable";
            this.cbCRegistration.UseVisualStyleBackColor = true;
            // 
            // cmbCVenue
            // 
            this.cmbCVenue.FormattingEnabled = true;
            this.cmbCVenue.Location = new System.Drawing.Point(182, 425);
            this.cmbCVenue.Name = "cmbCVenue";
            this.cmbCVenue.Size = new System.Drawing.Size(301, 28);
            this.cmbCVenue.TabIndex = 5;
            this.cmbCVenue.SelectedIndexChanged += new System.EventHandler(this.cmbCVenue_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 486);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Registration";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 433);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = " Venue";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 367);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Time";
            // 
            // txtCTime
            // 
            this.txtCTime.Location = new System.Drawing.Point(182, 364);
            this.txtCTime.Name = "txtCTime";
            this.txtCTime.Size = new System.Drawing.Size(301, 27);
            this.txtCTime.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description";
            // 
            // txtCDescription
            // 
            this.txtCDescription.Location = new System.Drawing.Point(182, 149);
            this.txtCDescription.Multiline = true;
            this.txtCDescription.Name = "txtCDescription";
            this.txtCDescription.Size = new System.Drawing.Size(301, 129);
            this.txtCDescription.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Event name";
            // 
            // txtCEvent
            // 
            this.txtCEvent.Location = new System.Drawing.Point(182, 91);
            this.txtCEvent.Name = "txtCEvent";
            this.txtCEvent.Size = new System.Drawing.Size(301, 27);
            this.txtCEvent.TabIndex = 1;
            // 
            // tpCancel
            // 
            this.tpCancel.Controls.Add(this.groupBox3);
            this.tpCancel.Location = new System.Drawing.Point(4, 29);
            this.tpCancel.Name = "tpCancel";
            this.tpCancel.Size = new System.Drawing.Size(619, 817);
            this.tpCancel.TabIndex = 3;
            this.tpCancel.Text = "Cancel event";
            this.tpCancel.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbCancelEvent);
            this.groupBox3.Controls.Add(this.btnCancelEvent);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Location = new System.Drawing.Point(21, 35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(543, 279);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cancel Event";
            // 
            // cmbCancelEvent
            // 
            this.cmbCancelEvent.FormattingEnabled = true;
            this.cmbCancelEvent.Location = new System.Drawing.Point(182, 60);
            this.cmbCancelEvent.Name = "cmbCancelEvent";
            this.cmbCancelEvent.Size = new System.Drawing.Size(241, 28);
            this.cmbCancelEvent.TabIndex = 15;
            // 
            // btnCancelEvent
            // 
            this.btnCancelEvent.Location = new System.Drawing.Point(182, 151);
            this.btnCancelEvent.Name = "btnCancelEvent";
            this.btnCancelEvent.Size = new System.Drawing.Size(134, 31);
            this.btnCancelEvent.TabIndex = 14;
            this.btnCancelEvent.Text = "Cancel Event";
            this.btnCancelEvent.UseVisualStyleBackColor = true;
            this.btnCancelEvent.Click += new System.EventHandler(this.btnCancelEvent_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(26, 68);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(78, 20);
            this.label18.TabIndex = 1;
            this.label18.Text = "Event ID:";
            // 
            // tpParticipants
            // 
            this.tpParticipants.Controls.Add(this.groupBox2);
            this.tpParticipants.Location = new System.Drawing.Point(4, 29);
            this.tpParticipants.Name = "tpParticipants";
            this.tpParticipants.Size = new System.Drawing.Size(619, 817);
            this.tpParticipants.TabIndex = 4;
            this.tpParticipants.Text = "See Particpants";
            this.tpParticipants.UseVisualStyleBackColor = true;
            this.tpParticipants.Enter += new System.EventHandler(this.tpParticipants_Enter);
            // 
            // epHostDash
            // 
            this.epHostDash.ContainerControl = this;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTrack);
            this.groupBox2.Controls.Add(this.btnTrack);
            this.groupBox2.Controls.Add(this.cmbSeeParticipants);
            this.groupBox2.Controls.Add(this.btnSeeParticipants);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(20, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(543, 350);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Show participants at specific event";
            // 
            // cmbSeeParticipants
            // 
            this.cmbSeeParticipants.FormattingEnabled = true;
            this.cmbSeeParticipants.Location = new System.Drawing.Point(182, 60);
            this.cmbSeeParticipants.Name = "cmbSeeParticipants";
            this.cmbSeeParticipants.Size = new System.Drawing.Size(241, 28);
            this.cmbSeeParticipants.TabIndex = 15;
            // 
            // btnSeeParticipants
            // 
            this.btnSeeParticipants.Location = new System.Drawing.Point(182, 151);
            this.btnSeeParticipants.Name = "btnSeeParticipants";
            this.btnSeeParticipants.Size = new System.Drawing.Size(241, 32);
            this.btnSeeParticipants.TabIndex = 14;
            this.btnSeeParticipants.Text = "Show Participants";
            this.btnSeeParticipants.UseVisualStyleBackColor = true;
            this.btnSeeParticipants.Click += new System.EventHandler(this.btnSeeParticipants_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Event ID:";
            // 
            // btnTrack
            // 
            this.btnTrack.Location = new System.Drawing.Point(182, 211);
            this.btnTrack.Name = "btnTrack";
            this.btnTrack.Size = new System.Drawing.Size(241, 32);
            this.btnTrack.TabIndex = 16;
            this.btnTrack.Text = "Number of registrations";
            this.btnTrack.UseVisualStyleBackColor = true;
            this.btnTrack.Click += new System.EventHandler(this.btnTrack_Click);
            // 
            // lblTrack
            // 
            this.lblTrack.Location = new System.Drawing.Point(187, 279);
            this.lblTrack.Name = "lblTrack";
            this.lblTrack.Size = new System.Drawing.Size(62, 22);
            this.lblTrack.TabIndex = 17;
            // 
            // HostDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1548, 906);
            this.Controls.Add(this.dgvTheirEvents);
            this.Controls.Add(this.tabPeople);
            this.Name = "HostDash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HostDash";
            this.Load += new System.EventHandler(this.HostDash_Load);
            this.tabPeople.ResumeLayout(false);
            this.tpCreateEditEvent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheirEvents)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tpCancel.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tpParticipants.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.epHostDash)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPeople;
        private System.Windows.Forms.TabPage tpCreateEditEvent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCEvent;
        private System.Windows.Forms.ComboBox cmbCVenue;
        private System.Windows.Forms.Button btnCreatEvent;
        private System.Windows.Forms.CheckBox cbCRegistration;
        private System.Windows.Forms.TabPage tpCancel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbCancelEvent;
        private System.Windows.Forms.Button btnCancelEvent;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCPrice;
        private System.Windows.Forms.DateTimePicker dtpCDate;
        private System.Windows.Forms.ErrorProvider epHostDash;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCCategory;
        private System.Windows.Forms.DataGridView dgvTheirEvents;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbTheirEvents;
        private System.Windows.Forms.TabPage tpParticipants;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbSeeParticipants;
        private System.Windows.Forms.Button btnSeeParticipants;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnTrack;
        private System.Windows.Forms.Label lblTrack;
    }
}