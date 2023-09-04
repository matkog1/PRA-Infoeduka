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
            lbTitle = new Label();
            tbTitle = new TextBox();
            tbYear = new TextBox();
            lbAuthor = new Label();
            tbAuthor = new TextBox();
            lbText = new Label();
            rtbMessage = new RichTextBox();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.ForeColor = SystemColors.InfoText;
            lbTitle.Location = new Point(31, 17);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(29, 15);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Title";
            // 
            // tbTitle
            // 
            tbTitle.Location = new Point(87, 9);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(815, 23);
            tbTitle.TabIndex = 1;
            // 
            // tbYear
            // 
            tbYear.Location = new Point(802, 38);
            tbYear.Name = "tbYear";
            tbYear.Size = new Size(100, 23);
            tbYear.TabIndex = 2;
            // 
            // lbAuthor
            // 
            lbAuthor.AutoSize = true;
            lbAuthor.ForeColor = SystemColors.InfoText;
            lbAuthor.Location = new Point(31, 46);
            lbAuthor.Name = "lbAuthor";
            lbAuthor.Size = new Size(44, 15);
            lbAuthor.TabIndex = 3;
            lbAuthor.Text = "Author";
            // 
            // tbAuthor
            // 
            tbAuthor.Location = new Point(87, 43);
            tbAuthor.Name = "tbAuthor";
            tbAuthor.Size = new Size(168, 23);
            tbAuthor.TabIndex = 4;
            // 
            // lbText
            // 
            lbText.AutoSize = true;
            lbText.ForeColor = SystemColors.InfoText;
            lbText.Location = new Point(31, 74);
            lbText.Name = "lbText";
            lbText.Size = new Size(28, 15);
            lbText.TabIndex = 5;
            lbText.Text = "Text";
            // 
            // rtbMessage
            // 
            rtbMessage.Location = new Point(86, 79);
            rtbMessage.Name = "rtbMessage";
            rtbMessage.Size = new Size(816, 96);
            rtbMessage.TabIndex = 6;
            rtbMessage.Text = "";
            // 
            // NewsPost
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(rtbMessage);
            Controls.Add(lbText);
            Controls.Add(tbAuthor);
            Controls.Add(lbAuthor);
            Controls.Add(tbYear);
            Controls.Add(tbTitle);
            Controls.Add(lbTitle);
            Name = "NewsPost";
            Size = new Size(963, 217);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitle;
        private TextBox tbTitle;
        private TextBox tbYear;
        private Label lbAuthor;
        private TextBox tbAuthor;
        private Label lbText;
        private RichTextBox rtbMessage;
    }
}
