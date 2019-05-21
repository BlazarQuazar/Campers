namespace Campers2
{
    partial class MainPage
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnSaveDates = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.monthCalendarCamper = new System.Windows.Forms.MonthCalendar();
            this.AdminPanel = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnVanDetails = new System.Windows.Forms.Button();
            this.btnAmend = new System.Windows.Forms.Button();
            this.comboBoxVans = new System.Windows.Forms.ComboBox();
            this.lblRentedVan = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.datePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.datePickerStart = new System.Windows.Forms.DateTimePicker();
            this.comboBoxUsers = new System.Windows.Forms.ComboBox();
            this.btnAddBooking = new System.Windows.Forms.Button();
            this.AdminPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 117);
            this.label2.TabIndex = 11;
            this.label2.Text = "Instructions\r\n\r\nSelect van from list on the left\r\n\r\ndates not in bold are availab" +
    "le for hire\r\n\r\nclick and drag date selection on calender\r\n\r\nclick Book selected " +
    "days";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(12, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(35, 13);
            this.lblWelcome.TabIndex = 10;
            this.lblWelcome.Text = "label1";
            // 
            // btnSaveDates
            // 
            this.btnSaveDates.Location = new System.Drawing.Point(477, 208);
            this.btnSaveDates.Name = "btnSaveDates";
            this.btnSaveDates.Size = new System.Drawing.Size(128, 23);
            this.btnSaveDates.TabIndex = 9;
            this.btnSaveDates.Text = "Book selected days";
            this.btnSaveDates.UseVisualStyleBackColor = true;
            this.btnSaveDates.Click += new System.EventHandler(this.btnSaveDates_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(11, 37);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(128, 160);
            this.listBox1.TabIndex = 8;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // monthCalendarCamper
            // 
            this.monthCalendarCamper.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.monthCalendarCamper.ForeColor = System.Drawing.SystemColors.WindowText;
            this.monthCalendarCamper.Location = new System.Drawing.Point(147, 37);
            this.monthCalendarCamper.Margin = new System.Windows.Forms.Padding(6);
            this.monthCalendarCamper.Name = "monthCalendarCamper";
            this.monthCalendarCamper.ShowToday = false;
            this.monthCalendarCamper.TabIndex = 7;
            this.monthCalendarCamper.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendarCamper_DateChanged);
            // 
            // AdminPanel
            // 
            this.AdminPanel.Controls.Add(this.btnAddBooking);
            this.AdminPanel.Controls.Add(this.comboBoxUsers);
            this.AdminPanel.Controls.Add(this.btnDelete);
            this.AdminPanel.Controls.Add(this.btnVanDetails);
            this.AdminPanel.Controls.Add(this.btnAmend);
            this.AdminPanel.Controls.Add(this.comboBoxVans);
            this.AdminPanel.Controls.Add(this.lblRentedVan);
            this.AdminPanel.Controls.Add(this.lblUser);
            this.AdminPanel.Controls.Add(this.lblEndDate);
            this.AdminPanel.Controls.Add(this.lblStartDate);
            this.AdminPanel.Controls.Add(this.datePickerEnd);
            this.AdminPanel.Controls.Add(this.datePickerStart);
            this.AdminPanel.Location = new System.Drawing.Point(220, 237);
            this.AdminPanel.Name = "AdminPanel";
            this.AdminPanel.Size = new System.Drawing.Size(400, 138);
            this.AdminPanel.TabIndex = 12;
            this.AdminPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.AdminPanel_Paint);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(310, 71);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnVanDetails
            // 
            this.btnVanDetails.Location = new System.Drawing.Point(310, 100);
            this.btnVanDetails.Name = "btnVanDetails";
            this.btnVanDetails.Size = new System.Drawing.Size(75, 23);
            this.btnVanDetails.TabIndex = 10;
            this.btnVanDetails.Text = "Van details";
            this.btnVanDetails.UseVisualStyleBackColor = true;
            this.btnVanDetails.Click += new System.EventHandler(this.btnVanDetails_Click);
            // 
            // btnAmend
            // 
            this.btnAmend.Location = new System.Drawing.Point(310, 42);
            this.btnAmend.Name = "btnAmend";
            this.btnAmend.Size = new System.Drawing.Size(75, 23);
            this.btnAmend.TabIndex = 9;
            this.btnAmend.Text = "Amend";
            this.btnAmend.UseVisualStyleBackColor = true;
            this.btnAmend.Click += new System.EventHandler(this.btnAmend_Click);
            // 
            // comboBoxVans
            // 
            this.comboBoxVans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVans.FormattingEnabled = true;
            this.comboBoxVans.Location = new System.Drawing.Point(166, 41);
            this.comboBoxVans.Name = "comboBoxVans";
            this.comboBoxVans.Size = new System.Drawing.Size(123, 21);
            this.comboBoxVans.TabIndex = 8;
            this.comboBoxVans.SelectedIndexChanged += new System.EventHandler(this.comboBoxVans_SelectedIndexChanged);
            // 
            // lblRentedVan
            // 
            this.lblRentedVan.AutoSize = true;
            this.lblRentedVan.Location = new System.Drawing.Point(163, 22);
            this.lblRentedVan.Name = "lblRentedVan";
            this.lblRentedVan.Size = new System.Drawing.Size(59, 13);
            this.lblRentedVan.TabIndex = 7;
            this.lblRentedVan.Text = "Rental van";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(163, 87);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(58, 13);
            this.lblUser.TabIndex = 6;
            this.lblUser.Text = "Booked by";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(39, 88);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(50, 13);
            this.lblEndDate.TabIndex = 3;
            this.lblEndDate.Text = "End date";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(39, 23);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(53, 13);
            this.lblStartDate.TabIndex = 2;
            this.lblStartDate.Text = "Start date";
            // 
            // datePickerEnd
            // 
            this.datePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerEnd.Location = new System.Drawing.Point(38, 104);
            this.datePickerEnd.Name = "datePickerEnd";
            this.datePickerEnd.Size = new System.Drawing.Size(87, 20);
            this.datePickerEnd.TabIndex = 1;
            this.datePickerEnd.ValueChanged += new System.EventHandler(this.datePickerEnd_ValueChanged);
            // 
            // datePickerStart
            // 
            this.datePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerStart.Location = new System.Drawing.Point(38, 42);
            this.datePickerStart.Name = "datePickerStart";
            this.datePickerStart.Size = new System.Drawing.Size(87, 20);
            this.datePickerStart.TabIndex = 0;
            this.datePickerStart.ValueChanged += new System.EventHandler(this.datePickerStart_ValueChanged);
            // 
            // comboBoxUsers
            // 
            this.comboBoxUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUsers.FormattingEnabled = true;
            this.comboBoxUsers.Location = new System.Drawing.Point(166, 103);
            this.comboBoxUsers.Name = "comboBoxUsers";
            this.comboBoxUsers.Size = new System.Drawing.Size(123, 21);
            this.comboBoxUsers.TabIndex = 12;
            this.comboBoxUsers.SelectedIndexChanged += new System.EventHandler(this.comboBoxUsers_SelectedIndexChanged);
            // 
            // btnAddBooking
            // 
            this.btnAddBooking.Location = new System.Drawing.Point(310, 12);
            this.btnAddBooking.Name = "btnAddBooking";
            this.btnAddBooking.Size = new System.Drawing.Size(75, 23);
            this.btnAddBooking.TabIndex = 13;
            this.btnAddBooking.Text = "Add Booking";
            this.btnAddBooking.UseVisualStyleBackColor = true;
            this.btnAddBooking.Click += new System.EventHandler(this.btnAddBooking_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 375);
            this.Controls.Add(this.AdminPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnSaveDates);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.monthCalendarCamper);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.AdminPanel.ResumeLayout(false);
            this.AdminPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnSaveDates;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.MonthCalendar monthCalendarCamper;
        private System.Windows.Forms.Panel AdminPanel;
        private System.Windows.Forms.DateTimePicker datePickerEnd;
        private System.Windows.Forms.DateTimePicker datePickerStart;
        private System.Windows.Forms.ComboBox comboBoxVans;
        private System.Windows.Forms.Label lblRentedVan;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnVanDetails;
        private System.Windows.Forms.Button btnAmend;
        private System.Windows.Forms.ComboBox comboBoxUsers;
        private System.Windows.Forms.Button btnAddBooking;
    }
}