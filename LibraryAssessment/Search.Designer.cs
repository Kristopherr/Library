namespace LibraryAssessment
{
    partial class Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lstContent = new System.Windows.Forms.ListBox();
            this.radioBookName = new System.Windows.Forms.RadioButton();
            this.radioAuthor = new System.Windows.Forms.RadioButton();
            this.radioISBN = new System.Windows.Forms.RadioButton();
            this.radioSummary = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(81, 45);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(227, 20);
            this.txtSearch.TabIndex = 0;
            // 
            // lstContent
            // 
            this.lstContent.FormattingEnabled = true;
            this.lstContent.Location = new System.Drawing.Point(12, 112);
            this.lstContent.Name = "lstContent";
            this.lstContent.Size = new System.Drawing.Size(409, 316);
            this.lstContent.TabIndex = 1;
            this.lstContent.SelectedIndexChanged += new System.EventHandler(this.lstContent_SelectedIndexChanged);
            // 
            // radioBookName
            // 
            this.radioBookName.AutoSize = true;
            this.radioBookName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.radioBookName.Cursor = System.Windows.Forms.Cursors.Default;
            this.radioBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBookName.ForeColor = System.Drawing.Color.White;
            this.radioBookName.Location = new System.Drawing.Point(485, 160);
            this.radioBookName.Name = "radioBookName";
            this.radioBookName.Size = new System.Drawing.Size(119, 24);
            this.radioBookName.TabIndex = 2;
            this.radioBookName.TabStop = true;
            this.radioBookName.Text = "Book Name";
            this.radioBookName.UseVisualStyleBackColor = false;
            this.radioBookName.CheckedChanged += new System.EventHandler(this.radioBookName_CheckedChanged);
            // 
            // radioAuthor
            // 
            this.radioAuthor.AutoSize = true;
            this.radioAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.radioAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioAuthor.ForeColor = System.Drawing.Color.White;
            this.radioAuthor.Location = new System.Drawing.Point(485, 207);
            this.radioAuthor.Name = "radioAuthor";
            this.radioAuthor.Size = new System.Drawing.Size(81, 24);
            this.radioAuthor.TabIndex = 3;
            this.radioAuthor.TabStop = true;
            this.radioAuthor.Text = "Author";
            this.radioAuthor.UseVisualStyleBackColor = false;
            this.radioAuthor.CheckedChanged += new System.EventHandler(this.radioAuthor_CheckedChanged);
            // 
            // radioISBN
            // 
            this.radioISBN.AutoSize = true;
            this.radioISBN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.radioISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioISBN.ForeColor = System.Drawing.Color.White;
            this.radioISBN.Location = new System.Drawing.Point(485, 258);
            this.radioISBN.Name = "radioISBN";
            this.radioISBN.Size = new System.Drawing.Size(79, 24);
            this.radioISBN.TabIndex = 4;
            this.radioISBN.TabStop = true;
            this.radioISBN.Text = "ISBN#";
            this.radioISBN.UseVisualStyleBackColor = false;
            this.radioISBN.CheckedChanged += new System.EventHandler(this.radioISBN_CheckedChanged);
            // 
            // radioSummary
            // 
            this.radioSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(90)))));
            this.radioSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSummary.ForeColor = System.Drawing.Color.White;
            this.radioSummary.Location = new System.Drawing.Point(485, 308);
            this.radioSummary.Name = "radioSummary";
            this.radioSummary.Size = new System.Drawing.Size(112, 24);
            this.radioSummary.TabIndex = 5;
            this.radioSummary.TabStop = true;
            this.radioSummary.Text = "Key Words";
            this.radioSummary.UseVisualStyleBackColor = false;
            this.radioSummary.CheckedChanged += new System.EventHandler(this.radioSummary_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(503, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search By :";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(439, 364);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(136, 48);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnBack.Location = new System.Drawing.Point(439, 433);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(136, 36);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(742, 510);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioSummary);
            this.Controls.Add(this.radioISBN);
            this.Controls.Add(this.radioAuthor);
            this.Controls.Add(this.radioBookName);
            this.Controls.Add(this.lstContent);
            this.Controls.Add(this.txtSearch);
            this.Name = "Search";
            this.Text = "Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ListBox lstContent;
        private System.Windows.Forms.RadioButton radioBookName;
        private System.Windows.Forms.RadioButton radioAuthor;
        private System.Windows.Forms.RadioButton radioISBN;
        private System.Windows.Forms.RadioButton radioSummary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnBack;
    }
}