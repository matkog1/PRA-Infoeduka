namespace PRA_Infoeduka
{
    partial class formNewSubject
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
            tbEcts = new TextBox();
            tbYear = new TextBox();
            tbCode = new TextBox();
            tbLectureType = new TextBox();
            tbTitle = new TextBox();
            label6 = new Label();
            listView1 = new ListView();
            button1 = new Button();
            button2 = new Button();
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
            label5.Size = new Size(33, 15);
            label5.TabIndex = 4;
            label5.Text = "ECTS";
            // 
            // tbEcts
            // 
            tbEcts.Location = new Point(320, 249);
            tbEcts.Name = "tbEcts";
            tbEcts.Size = new Size(270, 23);
            tbEcts.TabIndex = 8;
            // 
            // tbYear
            // 
            tbYear.Location = new Point(320, 220);
            tbYear.Name = "tbYear";
            tbYear.Size = new Size(270, 23);
            tbYear.TabIndex = 9;
            // 
            // tbCode
            // 
            tbCode.Location = new Point(320, 187);
            tbCode.Name = "tbCode";
            tbCode.Size = new Size(270, 23);
            tbCode.TabIndex = 10;
            // 
            // tbLectureType
            // 
            tbLectureType.Location = new Point(320, 153);
            tbLectureType.Name = "tbLectureType";
            tbLectureType.Size = new Size(270, 23);
            tbLectureType.TabIndex = 11;
            // 
            // tbTitle
            // 
            tbTitle.Location = new Point(320, 121);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(270, 23);
            tbTitle.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(230, 295);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 13;
            label6.Text = "Overview";
            // 
            // listView1
            // 
            listView1.Location = new Point(320, 295);
            listView1.Name = "listView1";
            listView1.Size = new Size(270, 124);
            listView1.TabIndex = 14;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            button1.Location = new Point(2, 651);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 15;
            button1.Text = "Discard";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(888, 651);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 16;
            button2.Text = "Confirm";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // formNewSubject
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 676);
            ControlBox = false;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(label6);
            Controls.Add(tbTitle);
            Controls.Add(tbLectureType);
            Controls.Add(tbCode);
            Controls.Add(tbYear);
            Controls.Add(tbEcts);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "formNewSubject";
            Text = "formNewSubject";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tbEcts;
        private TextBox tbYear;
        private TextBox tbCode;
        private TextBox tbLectureType;
        private TextBox tbTitle;
        private Label label6;
        private ListView listView1;
        private Button button1;
        private Button button2;
    }
}