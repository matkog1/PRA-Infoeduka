namespace PRA_Infoeduka
{
    partial class formNewPost
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbTitle = new TextBox();
            cbYear = new ComboBox();
            datePicker = new DateTimePicker();
            label4 = new Label();
            rtbText = new RichTextBox();
            btnDiscard = new Button();
            btnConfirm = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(151, 113);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 0;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(151, 156);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 1;
            label2.Text = "Year";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(151, 196);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 2;
            label3.Text = "Valid";
            // 
            // tbTitle
            // 
            tbTitle.Location = new Point(211, 105);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(661, 23);
            tbTitle.TabIndex = 1;
            // 
            // cbYear
            // 
            cbYear.FormattingEnabled = true;
            cbYear.Location = new Point(211, 148);
            cbYear.Name = "cbYear";
            cbYear.Size = new Size(121, 23);
            cbYear.TabIndex = 2;
            // 
            // datePicker
            // 
            datePicker.Location = new Point(211, 190);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(200, 23);
            datePicker.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(151, 248);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 6;
            label4.Text = "Text";
            // 
            // rtbText
            // 
            rtbText.Location = new Point(209, 248);
            rtbText.Name = "rtbText";
            rtbText.Size = new Size(664, 340);
            rtbText.TabIndex = 5;
            rtbText.Text = "";
            // 
            // btnDiscard
            // 
            btnDiscard.Location = new Point(1, 651);
            btnDiscard.Name = "btnDiscard";
            btnDiscard.Size = new Size(75, 23);
            btnDiscard.TabIndex = 6;
            btnDiscard.Text = "Discard";
            btnDiscard.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(889, 651);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(75, 23);
            btnConfirm.TabIndex = 8;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            // 
            // formNewPost
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 676);
            Controls.Add(btnConfirm);
            Controls.Add(btnDiscard);
            Controls.Add(rtbText);
            Controls.Add(label4);
            Controls.Add(datePicker);
            Controls.Add(cbYear);
            Controls.Add(tbTitle);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "formNewPost";
            Text = "formNewPost";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbTitle;
        private ComboBox cbYear;
        private DateTimePicker datePicker;
        private Label label4;
        private RichTextBox rtbText;
        private Button btnDiscard;
        private Button btnConfirm;
    }
}