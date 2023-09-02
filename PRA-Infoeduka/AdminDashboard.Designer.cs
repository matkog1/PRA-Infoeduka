namespace PRA_Infoeduka
{
    partial class AdminDashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mainSidePanel = new FlowLayoutPanel();
            panelTop = new Panel();
            buttonNews = new Button();
            buttonPosts = new Button();
            buttonSubjects = new Button();
            panelSubjects = new Panel();
            buttonEditSubject = new Button();
            buttonNewSubject = new Button();
            buttonUsers = new Button();
            panelUsers = new Panel();
            buttonEditUser = new Button();
            buttonNewUser = new Button();
            panelMainShow = new Panel();
            mainSidePanel.SuspendLayout();
            panelSubjects.SuspendLayout();
            panelUsers.SuspendLayout();
            SuspendLayout();
            // 
            // mainSidePanel
            // 
            mainSidePanel.BackColor = Color.DarkSlateGray;
            mainSidePanel.Controls.Add(panelTop);
            mainSidePanel.Controls.Add(buttonNews);
            mainSidePanel.Controls.Add(buttonPosts);
            mainSidePanel.Controls.Add(buttonSubjects);
            mainSidePanel.Controls.Add(panelSubjects);
            mainSidePanel.Controls.Add(buttonUsers);
            mainSidePanel.Controls.Add(panelUsers);
            mainSidePanel.Dock = DockStyle.Left;
            mainSidePanel.Location = new Point(0, 0);
            mainSidePanel.Name = "mainSidePanel";
            mainSidePanel.Size = new Size(203, 681);
            mainSidePanel.TabIndex = 0;
            // 
            // panelTop
            // 
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(3, 3);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(200, 100);
            panelTop.TabIndex = 0;
            // 
            // buttonNews
            // 
            buttonNews.AutoSize = true;
            buttonNews.Dock = DockStyle.Top;
            buttonNews.Location = new Point(3, 109);
            buttonNews.Name = "buttonNews";
            buttonNews.Size = new Size(203, 30);
            buttonNews.TabIndex = 1;
            buttonNews.Text = "News Feed";
            buttonNews.TextAlign = ContentAlignment.MiddleLeft;
            buttonNews.UseVisualStyleBackColor = true;
            // 
            // buttonPosts
            // 
            buttonPosts.AutoSize = true;
            buttonPosts.Dock = DockStyle.Top;
            buttonPosts.Location = new Point(3, 145);
            buttonPosts.Name = "buttonPosts";
            buttonPosts.Size = new Size(203, 30);
            buttonPosts.TabIndex = 2;
            buttonPosts.Text = "Posts";
            buttonPosts.TextAlign = ContentAlignment.MiddleLeft;
            buttonPosts.UseVisualStyleBackColor = true;
            // 
            // buttonSubjects
            // 
            buttonSubjects.AutoSize = true;
            buttonSubjects.Dock = DockStyle.Top;
            buttonSubjects.Location = new Point(3, 181);
            buttonSubjects.Name = "buttonSubjects";
            buttonSubjects.Size = new Size(203, 30);
            buttonSubjects.TabIndex = 3;
            buttonSubjects.Text = "Subjects";
            buttonSubjects.TextAlign = ContentAlignment.MiddleLeft;
            buttonSubjects.UseVisualStyleBackColor = true;
            buttonSubjects.Click += buttonSubjects_Click;
            // 
            // panelSubjects
            // 
            panelSubjects.Controls.Add(buttonEditSubject);
            panelSubjects.Controls.Add(buttonNewSubject);
            panelSubjects.Dock = DockStyle.Top;
            panelSubjects.Location = new Point(3, 217);
            panelSubjects.Name = "panelSubjects";
            panelSubjects.Size = new Size(200, 61);
            panelSubjects.TabIndex = 4;
            // 
            // buttonEditSubject
            // 
            buttonEditSubject.AutoSize = true;
            buttonEditSubject.Dock = DockStyle.Top;
            buttonEditSubject.FlatStyle = FlatStyle.Flat;
            buttonEditSubject.ForeColor = Color.White;
            buttonEditSubject.Location = new Point(0, 30);
            buttonEditSubject.Name = "buttonEditSubject";
            buttonEditSubject.Size = new Size(200, 30);
            buttonEditSubject.TabIndex = 5;
            buttonEditSubject.Text = "Edit Subject";
            buttonEditSubject.UseVisualStyleBackColor = true;
            // 
            // buttonNewSubject
            // 
            buttonNewSubject.AutoSize = true;
            buttonNewSubject.Dock = DockStyle.Top;
            buttonNewSubject.FlatStyle = FlatStyle.Flat;
            buttonNewSubject.ForeColor = Color.White;
            buttonNewSubject.Location = new Point(0, 0);
            buttonNewSubject.Name = "buttonNewSubject";
            buttonNewSubject.Size = new Size(200, 30);
            buttonNewSubject.TabIndex = 4;
            buttonNewSubject.Text = "New Subject";
            buttonNewSubject.UseVisualStyleBackColor = true;
            // 
            // buttonUsers
            // 
            buttonUsers.AutoSize = true;
            buttonUsers.Dock = DockStyle.Top;
            buttonUsers.Location = new Point(3, 284);
            buttonUsers.Name = "buttonUsers";
            buttonUsers.Size = new Size(200, 30);
            buttonUsers.TabIndex = 6;
            buttonUsers.Text = "Users";
            buttonUsers.TextAlign = ContentAlignment.MiddleLeft;
            buttonUsers.UseVisualStyleBackColor = true;
            buttonUsers.Click += buttonUsers_Click;
            // 
            // panelUsers
            // 
            panelUsers.Controls.Add(buttonEditUser);
            panelUsers.Controls.Add(buttonNewUser);
            panelUsers.Location = new Point(3, 320);
            panelUsers.Name = "panelUsers";
            panelUsers.Size = new Size(200, 61);
            panelUsers.TabIndex = 7;
            // 
            // buttonEditUser
            // 
            buttonEditUser.AutoSize = true;
            buttonEditUser.Dock = DockStyle.Top;
            buttonEditUser.FlatStyle = FlatStyle.Flat;
            buttonEditUser.ForeColor = Color.White;
            buttonEditUser.Location = new Point(0, 30);
            buttonEditUser.Name = "buttonEditUser";
            buttonEditUser.Size = new Size(200, 30);
            buttonEditUser.TabIndex = 8;
            buttonEditUser.Text = "Edit User";
            buttonEditUser.UseVisualStyleBackColor = true;
            buttonEditUser.Click += buttonEditUser_Click;
            // 
            // buttonNewUser
            // 
            buttonNewUser.AutoSize = true;
            buttonNewUser.Dock = DockStyle.Top;
            buttonNewUser.FlatStyle = FlatStyle.Flat;
            buttonNewUser.ForeColor = Color.White;
            buttonNewUser.Location = new Point(0, 0);
            buttonNewUser.Name = "buttonNewUser";
            buttonNewUser.Size = new Size(200, 30);
            buttonNewUser.TabIndex = 7;
            buttonNewUser.Text = "New User";
            buttonNewUser.UseVisualStyleBackColor = true;
            buttonNewUser.Click += buttonNewUser_Click;
            // 
            // panelMainShow
            // 
            panelMainShow.Dock = DockStyle.Fill;
            panelMainShow.Location = new Point(203, 0);
            panelMainShow.Name = "panelMainShow";
            panelMainShow.Size = new Size(981, 681);
            panelMainShow.TabIndex = 1;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 681);
            Controls.Add(panelMainShow);
            Controls.Add(mainSidePanel);
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminDashboard";
            mainSidePanel.ResumeLayout(false);
            mainSidePanel.PerformLayout();
            panelSubjects.ResumeLayout(false);
            panelSubjects.PerformLayout();
            panelUsers.ResumeLayout(false);
            panelUsers.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel mainSidePanel;
        private Panel panelTop;
        private Button buttonNews;
        private Button buttonPosts;
        private Button buttonSubjects;
        private Panel panelSubjects;
        private Button buttonEditSubject;
        private Button buttonNewSubject;
        private Button buttonUsers;
        private Panel panelUsers;
        private Button buttonEditUser;
        private Button buttonNewUser;
        private Panel panelMainShow;
    }
}