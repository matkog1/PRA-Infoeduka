namespace PRA_Infoeduka
{
    partial class formEditPost
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
            label4 = new Label();
            rtbText = new RichTextBox();
            cbYear = new ComboBox();
            button1 = new Button();
            btnConfirm = new Button();
            dateTimePicker1 = new DateTimePicker();
            cbPost = new ComboBox();
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(151, 248);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 3;
            label4.Text = "Text";
            // 
            // rtbText
            // 
            rtbText.Location = new Point(209, 248);
            rtbText.Name = "rtbText";
            rtbText.Size = new Size(664, 340);
            rtbText.TabIndex = 4;
            rtbText.Text = "";
            // 
            // cbYear
            // 
            cbYear.FormattingEnabled = true;
            cbYear.Location = new Point(211, 148);
            cbYear.Name = "cbYear";
            cbYear.Size = new Size(121, 23);
            cbYear.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(1, 650);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "Discard";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(889, 650);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(75, 23);
            btnConfirm.TabIndex = 11;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(211, 190);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 3;
            // 
            // cbPost
            // 
            cbPost.FormattingEnabled = true;
            cbPost.Location = new Point(211, 110);
            cbPost.Name = "cbPost";
            cbPost.Size = new Size(662, 23);
            cbPost.TabIndex = 1;
            // 
            // formEditPost
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 676);
            Controls.Add(cbPost);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnConfirm);
            Controls.Add(button1);
            Controls.Add(cbYear);
            Controls.Add(rtbText);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "formEditPost";
            Text = "formEditPost";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private RichTextBox rtbText;
        private ComboBox cbYear;
        private Button button1;
        private Button btnConfirm;
        private DateTimePicker dateTimePicker1;
        private ComboBox cbPost;
    }
}