namespace PRA_Infoeduka
{
    partial class formEditSubject
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
            label5 = new Label();
            tbTitle = new TextBox();
            tbEcts = new TextBox();
            tbYear = new TextBox();
            tbCode = new TextBox();
            tbLectureType = new TextBox();
            label6 = new Label();
            listView1 = new ListView();
            button1 = new Button();
            button2 = new Button();
            label7 = new Label();
            cbSubjects = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(230, 129);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 0;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(228, 161);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 1;
            label2.Text = "Lecture Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(228, 195);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 2;
            label3.Text = "Code";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(230, 228);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 3;
            label4.Text = "Year";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(230, 257);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 4;
            label5.Text = "Ects";
            // 
            // tbTitle
            // 
            tbTitle.Location = new Point(320, 121);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(270, 23);
            tbTitle.TabIndex = 5;
            // 
            // tbEcts
            // 
            tbEcts.Location = new Point(320, 187);
            tbEcts.Name = "tbEcts";
            tbEcts.Size = new Size(270, 23);
            tbEcts.TabIndex = 6;
            // 
            // tbYear
            // 
            tbYear.Location = new Point(320, 220);
            tbYear.Name = "tbYear";
            tbYear.Size = new Size(270, 23);
            tbYear.TabIndex = 7;
            // 
            // tbCode
            // 
            tbCode.Location = new Point(320, 257);
            tbCode.Name = "tbCode";
            tbCode.Size = new Size(270, 23);
            tbCode.TabIndex = 8;
            // 
            // tbLectureType
            // 
            tbLectureType.Location = new Point(320, 153);
            tbLectureType.Name = "tbLectureType";
            tbLectureType.Size = new Size(270, 23);
            tbLectureType.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(230, 292);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 10;
            label6.Text = "Overview";
            // 
            // listView1
            // 
            listView1.Location = new Point(320, 295);
            listView1.Name = "listView1";
            listView1.Size = new Size(270, 124);
            listView1.TabIndex = 11;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(320, 445);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 12;
            button1.Text = "Discard";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(515, 436);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 13;
            button2.Text = "Confirm";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(230, 90);
            label7.Name = "label7";
            label7.Size = new Size(46, 15);
            label7.TabIndex = 14;
            label7.Text = "Subject";
            // 
            // cbSubjects
            // 
            cbSubjects.FormattingEnabled = true;
            cbSubjects.Location = new Point(320, 82);
            cbSubjects.Name = "cbSubjects";
            cbSubjects.Size = new Size(270, 23);
            cbSubjects.TabIndex = 15;
            // 
            // formEditSubject
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 676);
            Controls.Add(cbSubjects);
            Controls.Add(label7);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(label6);
            Controls.Add(tbLectureType);
            Controls.Add(tbCode);
            Controls.Add(tbYear);
            Controls.Add(tbEcts);
            Controls.Add(tbTitle);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "formEditSubject";
            Text = "formEditSubject";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tbTitle;
        private TextBox tbEcts;
        private TextBox tbYear;
        private TextBox tbCode;
        private TextBox tbLectureType;
        private Label label6;
        private ListView listView1;
        private Button button1;
        private Button button2;
        private Label label7;
        private ComboBox cbSubjects;
    }
}