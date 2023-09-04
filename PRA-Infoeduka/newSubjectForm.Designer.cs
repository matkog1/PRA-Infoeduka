namespace PRA_Infoeduka
{
    partial class newSubjectForm
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
            tbTitle = new TextBox();
            tbLectureType = new TextBox();
            tbYear = new TextBox();
            tbEcts = new TextBox();
            tbCode = new TextBox();
            btnConfirm = new Button();
            btnDiscard = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // tbTitle
            // 
            tbTitle.Location = new Point(288, 40);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(229, 23);
            tbTitle.TabIndex = 1;
            // 
            // tbLectureType
            // 
            tbLectureType.Location = new Point(288, 69);
            tbLectureType.Name = "tbLectureType";
            tbLectureType.Size = new Size(229, 23);
            tbLectureType.TabIndex = 2;
            // 
            // tbYear
            // 
            tbYear.Location = new Point(288, 127);
            tbYear.Name = "tbYear";
            tbYear.Size = new Size(229, 23);
            tbYear.TabIndex = 4;
            // 
            // tbEcts
            // 
            tbEcts.Location = new Point(288, 156);
            tbEcts.Name = "tbEcts";
            tbEcts.Size = new Size(229, 23);
            tbEcts.TabIndex = 5;
            // 
            // tbCode
            // 
            tbCode.Location = new Point(288, 98);
            tbCode.Name = "tbCode";
            tbCode.Size = new Size(229, 23);
            tbCode.TabIndex = 3;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(713, 415);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(75, 23);
            btnConfirm.TabIndex = 7;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += button1_Click;
            // 
            // btnDiscard
            // 
            btnDiscard.Location = new Point(12, 415);
            btnDiscard.Name = "btnDiscard";
            btnDiscard.Size = new Size(75, 23);
            btnDiscard.TabIndex = 6;
            btnDiscard.Text = "Discard";
            btnDiscard.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(197, 43);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 8;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(197, 72);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 9;
            label2.Text = "Lecture Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(197, 106);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 10;
            label3.Text = "Code";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(197, 135);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 11;
            label4.Text = "Year";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(197, 164);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 12;
            label5.Text = "ECTS";
            // 
            // newSubjectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDiscard);
            Controls.Add(btnConfirm);
            Controls.Add(tbCode);
            Controls.Add(tbEcts);
            Controls.Add(tbYear);
            Controls.Add(tbLectureType);
            Controls.Add(tbTitle);
            Name = "newSubjectForm";
            Text = "newSubjectForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbTitle;
        private TextBox tbLectureType;
        private TextBox tbYear;
        private TextBox tbEcts;
        private TextBox tbCode;
        private Button btnConfirm;
        private Button btnDiscard;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}