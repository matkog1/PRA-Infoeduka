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
            labelTitle = new Label();
            labelLectureType = new Label();
            labelCode = new Label();
            labelYear = new Label();
            labelEcts = new Label();
            tbEcts = new TextBox();
            tbYear = new TextBox();
            tbCode = new TextBox();
            tbLectureType = new TextBox();
            tbTitle = new TextBox();
            labelOverview = new Label();
            listView1 = new ListView();
            btnDiscard = new Button();
            btnConfirm = new Button();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(230, 129);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(29, 15);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Title";
            // 
            // labelLectureType
            // 
            labelLectureType.AutoSize = true;
            labelLectureType.Location = new Point(228, 161);
            labelLectureType.Name = "labelLectureType";
            labelLectureType.Size = new Size(73, 15);
            labelLectureType.TabIndex = 1;
            labelLectureType.Text = "Lecture Type";
            // 
            // labelCode
            // 
            labelCode.AutoSize = true;
            labelCode.Location = new Point(228, 195);
            labelCode.Name = "labelCode";
            labelCode.Size = new Size(35, 15);
            labelCode.TabIndex = 2;
            labelCode.Text = "Code";
            // 
            // labelYear
            // 
            labelYear.AutoSize = true;
            labelYear.Location = new Point(230, 228);
            labelYear.Name = "labelYear";
            labelYear.Size = new Size(29, 15);
            labelYear.TabIndex = 3;
            labelYear.Text = "Year";
            // 
            // labelEcts
            // 
            labelEcts.AutoSize = true;
            labelEcts.Location = new Point(230, 257);
            labelEcts.Name = "labelEcts";
            labelEcts.Size = new Size(33, 15);
            labelEcts.TabIndex = 4;
            labelEcts.Text = "ECTS";
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
            // labelOverview
            // 
            labelOverview.AutoSize = true;
            labelOverview.Location = new Point(230, 295);
            labelOverview.Name = "labelOverview";
            labelOverview.Size = new Size(56, 15);
            labelOverview.TabIndex = 13;
            labelOverview.Text = "Overview";
            // 
            // listView1
            // 
            listView1.Location = new Point(320, 295);
            listView1.Name = "listView1";
            listView1.Size = new Size(270, 124);
            listView1.TabIndex = 14;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnDiscard
            // 
            btnDiscard.Location = new Point(2, 651);
            btnDiscard.Name = "btnDiscard";
            btnDiscard.Size = new Size(75, 23);
            btnDiscard.TabIndex = 15;
            btnDiscard.Text = "Discard";
            btnDiscard.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(888, 651);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(75, 23);
            btnConfirm.TabIndex = 16;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // formNewSubject
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 676);
            ControlBox = false;
            Controls.Add(btnConfirm);
            Controls.Add(btnDiscard);
            Controls.Add(listView1);
            Controls.Add(labelOverview);
            Controls.Add(tbTitle);
            Controls.Add(tbLectureType);
            Controls.Add(tbCode);
            Controls.Add(tbYear);
            Controls.Add(tbEcts);
            Controls.Add(labelEcts);
            Controls.Add(labelYear);
            Controls.Add(labelCode);
            Controls.Add(labelLectureType);
            Controls.Add(labelTitle);
            Name = "formNewSubject";
            Text = "formNewSubject";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Label labelLectureType;
        private Label labelCode;
        private Label labelYear;
        private Label labelEcts;
        private TextBox tbEcts;
        private TextBox tbYear;
        private TextBox tbCode;
        private TextBox tbLectureType;
        private TextBox tbTitle;
        private Label labelOverview;
        private ListView listView1;
        private Button btnDiscard;
        private Button btnConfirm;
    }
}