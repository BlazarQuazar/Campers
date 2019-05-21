namespace Campers2
{
    partial class VanDetails
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
            this.txtBoxVanName = new System.Windows.Forms.TextBox();
            this.txtBoxRegistration = new System.Windows.Forms.TextBox();
            this.txtBoxNoOfOccupants = new System.Windows.Forms.TextBox();
            this.lblVanName = new System.Windows.Forms.Label();
            this.lblRegistration = new System.Windows.Forms.Label();
            this.lblMaxPeople = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.btnAmend = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxVanName
            // 
            this.txtBoxVanName.Location = new System.Drawing.Point(165, 18);
            this.txtBoxVanName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxVanName.Name = "txtBoxVanName";
            this.txtBoxVanName.Size = new System.Drawing.Size(148, 26);
            this.txtBoxVanName.TabIndex = 0;
            this.txtBoxVanName.TextChanged += new System.EventHandler(this.txtBoxVanName_TextChanged);
            // 
            // txtBoxRegistration
            // 
            this.txtBoxRegistration.Location = new System.Drawing.Point(165, 58);
            this.txtBoxRegistration.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxRegistration.Name = "txtBoxRegistration";
            this.txtBoxRegistration.Size = new System.Drawing.Size(148, 26);
            this.txtBoxRegistration.TabIndex = 1;
            this.txtBoxRegistration.TextChanged += new System.EventHandler(this.txtBoxRegistration_TextChanged);
            // 
            // txtBoxNoOfOccupants
            // 
            this.txtBoxNoOfOccupants.Location = new System.Drawing.Point(165, 98);
            this.txtBoxNoOfOccupants.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxNoOfOccupants.Name = "txtBoxNoOfOccupants";
            this.txtBoxNoOfOccupants.Size = new System.Drawing.Size(148, 26);
            this.txtBoxNoOfOccupants.TabIndex = 2;
            this.txtBoxNoOfOccupants.TextChanged += new System.EventHandler(this.txtBoxNoOfOccupants_TextChanged);
            // 
            // lblVanName
            // 
            this.lblVanName.AutoSize = true;
            this.lblVanName.Location = new System.Drawing.Point(18, 23);
            this.lblVanName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVanName.Name = "lblVanName";
            this.lblVanName.Size = new System.Drawing.Size(82, 20);
            this.lblVanName.TabIndex = 3;
            this.lblVanName.Text = "Van name";
            // 
            // lblRegistration
            // 
            this.lblRegistration.AutoSize = true;
            this.lblRegistration.Location = new System.Drawing.Point(18, 63);
            this.lblRegistration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistration.Name = "lblRegistration";
            this.lblRegistration.Size = new System.Drawing.Size(95, 20);
            this.lblRegistration.TabIndex = 4;
            this.lblRegistration.Text = "Registration";
            // 
            // lblMaxPeople
            // 
            this.lblMaxPeople.AutoSize = true;
            this.lblMaxPeople.Location = new System.Drawing.Point(18, 103);
            this.lblMaxPeople.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaxPeople.Name = "lblMaxPeople";
            this.lblMaxPeople.Size = new System.Drawing.Size(90, 20);
            this.lblMaxPeople.TabIndex = 5;
            this.lblMaxPeople.Text = "Max people";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(112, 138);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 35);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(112, 183);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(112, 35);
            this.BtnDelete.TabIndex = 7;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnAmend
            // 
            this.btnAmend.Location = new System.Drawing.Point(112, 228);
            this.btnAmend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAmend.Name = "btnAmend";
            this.btnAmend.Size = new System.Drawing.Size(112, 35);
            this.btnAmend.TabIndex = 8;
            this.btnAmend.Text = "Amend";
            this.btnAmend.UseVisualStyleBackColor = true;
            this.btnAmend.Click += new System.EventHandler(this.btnAmend_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(22, 138);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(50, 125);
            this.btnPrevious.TabIndex = 9;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(266, 138);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(50, 125);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // VanDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 282);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnAmend);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblMaxPeople);
            this.Controls.Add(this.lblRegistration);
            this.Controls.Add(this.lblVanName);
            this.Controls.Add(this.txtBoxNoOfOccupants);
            this.Controls.Add(this.txtBoxRegistration);
            this.Controls.Add(this.txtBoxVanName);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "VanDetails";
            this.Text = "VanDetails";
            this.Load += new System.EventHandler(this.VanDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxVanName;
        private System.Windows.Forms.TextBox txtBoxRegistration;
        private System.Windows.Forms.TextBox txtBoxNoOfOccupants;
        private System.Windows.Forms.Label lblVanName;
        private System.Windows.Forms.Label lblRegistration;
        private System.Windows.Forms.Label lblMaxPeople;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button btnAmend;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
    }
}