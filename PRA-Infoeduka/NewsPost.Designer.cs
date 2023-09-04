namespace PRA_Infoeduka
{
    partial class NewsPost
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTitle = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.lbAuthor = new System.Windows.Forms.Label();
            this.tbAuthor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbMessage = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbTitle.Location = new System.Drawing.Point(31, 17);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(29, 15);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Title";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(87, 9);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(815, 23);
            this.tbTitle.TabIndex = 1;
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(802, 38);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(100, 23);
            this.tbYear.TabIndex = 2;
            // 
            // lbAuthor
            // 
            this.lbAuthor.AutoSize = true;
            this.lbAuthor.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbAuthor.Location = new System.Drawing.Point(31, 46);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(44, 15);
            this.lbAuthor.TabIndex = 3;
            this.lbAuthor.Text = "Author";
            // 
            // tbAuthor
            // 
            this.tbAuthor.Location = new System.Drawing.Point(87, 43);
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.Size = new System.Drawing.Size(168, 23);
            this.tbAuthor.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(31, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Text";
            // 
            // rtbMessage
            // 
            this.rtbMessage.Location = new System.Drawing.Point(86, 79);
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.Size = new System.Drawing.Size(816, 96);
            this.rtbMessage.TabIndex = 6;
            this.rtbMessage.Text = "";
            // 
            // NewsPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rtbMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAuthor);
            this.Controls.Add(this.lbAuthor);
            this.Controls.Add(this.tbYear);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.lbTitle);
            this.Name = "NewsPost";
            this.Size = new System.Drawing.Size(963, 217);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbTitle;
        private TextBox tbTitle;
        private TextBox tbYear;
        private Label lbAuthor;
        private TextBox tbAuthor;
        private Label label1;
        private RichTextBox rtbMessage;
    }
}
