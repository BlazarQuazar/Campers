namespace Campers
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
            this.monthCalendarCamper = new System.Windows.Forms.MonthCalendar();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnSaveDates = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelAdminPanel = new System.Windows.Forms.Panel();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.btnEditBooking = new System.Windows.Forms.Button();
            this.btnDeleteBooking = new System.Windows.Forms.Button();
            this.lblAdminPanel = new System.Windows.Forms.Label();
            this.panelAdminPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendarCamper
            // 
            this.monthCalendarCamper.ForeColor = System.Drawing.SystemColors.WindowText;
            this.monthCalendarCamper.Location = new System.Drawing.Point(216, 48);
            this.monthCalendarCamper.Name = "monthCalendarCamper";
            this.monthCalendarCamper.ShowToday = false;
            this.monthCalendarCamper.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(12, 48);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(190, 244);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnSaveDates
            // 
            this.btnSaveDates.Location = new System.Drawing.Point(335, 311);
            this.btnSaveDates.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSaveDates.Name = "btnSaveDates";
            this.btnSaveDates.Size = new System.Drawing.Size(192, 35);
            this.btnSaveDates.TabIndex = 4;
            this.btnSaveDates.Text = "Book selected days";
            this.btnSaveDates.UseVisualStyleBackColor = true;
            this.btnSaveDates.Click += new System.EventHandler(this.btnSaveDates_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(13, 9);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(51, 20);
            this.lblWelcome.TabIndex = 5;
            this.lblWelcome.Text = "label1";
            this.lblWelcome.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 306);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 180);
            this.label2.TabIndex = 6;
            this.label2.Text = "Instructions\r\n\r\nSelect van from list on the left\r\n\r\ndates not in bold are availab" +
    "le for hire\r\n\r\nclick and drag date selection on calender\r\n\r\nclick Book selected " +
    "days";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "user booked";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "start date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "end date";
            // 
            // panelAdminPanel
            // 
            this.panelAdminPanel.Controls.Add(this.lblAdminPanel);
            this.panelAdminPanel.Controls.Add(this.label1);
            this.panelAdminPanel.Controls.Add(this.btnDeleteBooking);
            this.panelAdminPanel.Controls.Add(this.btnEditBooking);
            this.panelAdminPanel.Controls.Add(this.endDatePicker);
            this.panelAdminPanel.Controls.Add(this.startDatePicker);
            this.panelAdminPanel.Controls.Add(this.label3);
            this.panelAdminPanel.Controls.Add(this.label4);
            this.panelAdminPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelAdminPanel.Location = new System.Drawing.Point(565, 0);
            this.panelAdminPanel.Name = "panelAdminPanel";
            this.panelAdminPanel.Size = new System.Drawing.Size(232, 532);
            this.panelAdminPanel.TabIndex = 12;
            this.panelAdminPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAdminPanel_Paint);
            // 
            // startDatePicker
            // 
            this.startDatePicker.CustomFormat = "";
            this.startDatePicker.Location = new System.Drawing.Point(12, 188);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(200, 26);
            this.startDatePicker.TabIndex = 0;
            // 
            // endDatePicker
            // 
            this.endDatePicker.CustomFormat = "";
            this.endDatePicker.Location = new System.Drawing.Point(12, 287);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(200, 26);
            this.endDatePicker.TabIndex = 10;
            // 
            // btnEditBooking
            // 
            this.btnEditBooking.Location = new System.Drawing.Point(12, 340);
            this.btnEditBooking.Name = "btnEditBooking";
            this.btnEditBooking.Size = new System.Drawing.Size(155, 35);
            this.btnEditBooking.TabIndex = 11;
            this.btnEditBooking.Text = "Edit booking";
            this.btnEditBooking.UseVisualStyleBackColor = true;
            // 
            // btnDeleteBooking
            // 
            this.btnDeleteBooking.Location = new System.Drawing.Point(12, 396);
            this.btnDeleteBooking.Name = "btnDeleteBooking";
            this.btnDeleteBooking.Size = new System.Drawing.Size(155, 35);
            this.btnDeleteBooking.TabIndex = 12;
            this.btnDeleteBooking.Text = "Delete Booking";
            this.btnDeleteBooking.UseVisualStyleBackColor = true;
            // 
            // lblAdminPanel
            // 
            this.lblAdminPanel.AutoSize = true;
            this.lblAdminPanel.Location = new System.Drawing.Point(12, 13);
            this.lblAdminPanel.Name = "lblAdminPanel";
            this.lblAdminPanel.Size = new System.Drawing.Size(97, 20);
            this.lblAdminPanel.TabIndex = 13;
            this.lblAdminPanel.Text = "Admin panel";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 532);
            this.Controls.Add(this.panelAdminPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnSaveDates);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.monthCalendarCamper);
            this.Name = "MainPage";
            this.Text = "Campers";
            this.Load += new System.EventHandler(this.Campers_Load);
            this.panelAdminPanel.ResumeLayout(false);
            this.panelAdminPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendarCamper;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnSaveDates;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelAdminPanel;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.Label lblAdminPanel;
        private System.Windows.Forms.Button btnDeleteBooking;
        private System.Windows.Forms.Button btnEditBooking;
        private System.Windows.Forms.DateTimePicker endDatePicker;
    }
}