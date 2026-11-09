namespace LibraryAssessment
{
    partial class AllBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllBooks));
            this.lstBooks = new System.Windows.Forms.ListBox();
            this.lblAllBooks = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDetail = new System.Windows.Forms.Button();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstBooks
            // 
            this.lstBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lstBooks.FormattingEnabled = true;
            this.lstBooks.ItemHeight = 18;
            this.lstBooks.Location = new System.Drawing.Point(48, 108);
            this.lstBooks.Name = "lstBooks";
            this.lstBooks.Size = new System.Drawing.Size(637, 292);
            this.lstBooks.TabIndex = 0;
            // 
            // lblAllBooks
            // 
            this.lblAllBooks.AutoSize = true;
            this.lblAllBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblAllBooks.Location = new System.Drawing.Point(277, 34);
            this.lblAllBooks.Name = "lblAllBooks";
            this.lblAllBooks.Size = new System.Drawing.Size(187, 25);
            this.lblAllBooks.TabIndex = 1;
            this.lblAllBooks.Text = "All Stored Books";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(438, 419);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(192, 56);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDetail
            // 
            this.btnDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetail.Location = new System.Drawing.Point(108, 419);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(192, 56);
            this.btnDetail.TabIndex = 4;
            this.btnDetail.Text = "Details";
            this.btnDetail.UseVisualStyleBackColor = false;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // txtDetails
            // 
            this.txtDetails.Location = new System.Drawing.Point(215, 73);
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(312, 20);
            this.txtDetails.TabIndex = 5;
            // 
            // AllBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(733, 532);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblAllBooks);
            this.Controls.Add(this.lstBooks);
            this.Name = "AllBooks";
            this.Text = "AllBooks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAllBooks;
        private System.Windows.Forms.Button btnBack;
        public System.Windows.Forms.ListBox lstBooks;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.TextBox txtDetails;
    }
}