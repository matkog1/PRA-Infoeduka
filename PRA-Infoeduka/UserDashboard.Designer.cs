namespace PRA_Infoeduka
{
    partial class UserDashboard
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
            pnlSideMenu = new Panel();
            pnlUser = new Panel();
            btnUser = new Button();
            pnlSubjects = new Panel();
            btnSubjects = new Button();
            pnlPostsMenu = new Panel();
            btnNewPost = new Button();
            btnEditPost = new Button();
            pnlPosts = new Panel();
            btnPosts = new Button();
            pnlNewsFeed = new Panel();
            btnNewsFeed = new Button();
            pnlBottom = new Panel();
            button2 = new Button();
            pnlTop = new Panel();
            panelMainShow = new Panel();
            pnlSideMenu.SuspendLayout();
            pnlUser.SuspendLayout();
            pnlSubjects.SuspendLayout();
            pnlPostsMenu.SuspendLayout();
            pnlPosts.SuspendLayout();
            pnlNewsFeed.SuspendLayout();
            pnlBottom.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSideMenu
            // 
            pnlSideMenu.BackColor = Color.DarkSlateGray;
            pnlSideMenu.Controls.Add(pnlUser);
            pnlSideMenu.Controls.Add(pnlSubjects);
            pnlSideMenu.Controls.Add(pnlPostsMenu);
            pnlSideMenu.Controls.Add(pnlPosts);
            pnlSideMenu.Controls.Add(pnlNewsFeed);
            pnlSideMenu.Controls.Add(pnlBottom);
            pnlSideMenu.Controls.Add(pnlTop);
            pnlSideMenu.Dock = DockStyle.Left;
            pnlSideMenu.Location = new Point(0, 0);
            pnlSideMenu.Name = "pnlSideMenu";
            pnlSideMenu.Size = new Size(203, 681);
            pnlSideMenu.TabIndex = 0;
            // 
            // pnlUser
            // 
            pnlUser.Controls.Add(btnUser);
            pnlUser.Dock = DockStyle.Top;
            pnlUser.Location = new Point(0, 268);
            pnlUser.Name = "pnlUser";
            pnlUser.Size = new Size(203, 37);
            pnlUser.TabIndex = 9;
            // 
            // btnUser
            // 
            btnUser.Dock = DockStyle.Top;
            btnUser.Location = new Point(0, 0);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(203, 35);
            btnUser.TabIndex = 0;
            btnUser.Text = "User";
            btnUser.TextAlign = ContentAlignment.MiddleLeft;
            btnUser.UseVisualStyleBackColor = true;
            btnUser.Click += btnUser_Click;
            // 
            // pnlSubjects
            // 
            pnlSubjects.Controls.Add(btnSubjects);
            pnlSubjects.Dock = DockStyle.Top;
            pnlSubjects.Location = new Point(0, 231);
            pnlSubjects.Name = "pnlSubjects";
            pnlSubjects.Size = new Size(203, 37);
            pnlSubjects.TabIndex = 8;
            // 
            // btnSubjects
            // 
            btnSubjects.Dock = DockStyle.Top;
            btnSubjects.Location = new Point(0, 0);
            btnSubjects.Name = "btnSubjects";
            btnSubjects.Size = new Size(203, 35);
            btnSubjects.TabIndex = 5;
            btnSubjects.Text = "Subjects";
            btnSubjects.TextAlign = ContentAlignment.MiddleLeft;
            btnSubjects.UseVisualStyleBackColor = true;
            btnSubjects.Click += btnSubjects_Click;
            // 
            // pnlPostsMenu
            // 
            pnlPostsMenu.Controls.Add(btnNewPost);
            pnlPostsMenu.Controls.Add(btnEditPost);
            pnlPostsMenu.Dock = DockStyle.Top;
            pnlPostsMenu.Location = new Point(0, 172);
            pnlPostsMenu.Name = "pnlPostsMenu";
            pnlPostsMenu.Size = new Size(203, 59);
            pnlPostsMenu.TabIndex = 7;
            // 
            // btnNewPost
            // 
            btnNewPost.Dock = DockStyle.Top;
            btnNewPost.FlatStyle = FlatStyle.Flat;
            btnNewPost.ForeColor = Color.White;
            btnNewPost.Location = new Point(0, 30);
            btnNewPost.Name = "btnNewPost";
            btnNewPost.Size = new Size(203, 29);
            btnNewPost.TabIndex = 2;
            btnNewPost.Text = "New Post";
            btnNewPost.UseVisualStyleBackColor = true;
            btnNewPost.Click += btnNewPost_Click_1;
            // 
            // btnEditPost
            // 
            btnEditPost.Dock = DockStyle.Top;
            btnEditPost.FlatStyle = FlatStyle.Flat;
            btnEditPost.ForeColor = Color.White;
            btnEditPost.Location = new Point(0, 0);
            btnEditPost.Name = "btnEditPost";
            btnEditPost.Size = new Size(203, 30);
            btnEditPost.TabIndex = 3;
            btnEditPost.Text = "Edit Post";
            btnEditPost.UseVisualStyleBackColor = true;
            btnEditPost.Click += btnEditPost_Click_1;
            // 
            // pnlPosts
            // 
            pnlPosts.Controls.Add(btnPosts);
            pnlPosts.Dock = DockStyle.Top;
            pnlPosts.Location = new Point(0, 136);
            pnlPosts.Name = "pnlPosts";
            pnlPosts.Size = new Size(203, 36);
            pnlPosts.TabIndex = 6;
            // 
            // btnPosts
            // 
            btnPosts.Dock = DockStyle.Top;
            btnPosts.Location = new Point(0, 0);
            btnPosts.Name = "btnPosts";
            btnPosts.Size = new Size(203, 35);
            btnPosts.TabIndex = 1;
            btnPosts.Text = "Posts";
            btnPosts.TextAlign = ContentAlignment.MiddleLeft;
            btnPosts.UseVisualStyleBackColor = true;
            btnPosts.Click += btnPosts_Click;
            // 
            // pnlNewsFeed
            // 
            pnlNewsFeed.Controls.Add(btnNewsFeed);
            pnlNewsFeed.Dock = DockStyle.Top;
            pnlNewsFeed.Location = new Point(0, 100);
            pnlNewsFeed.Name = "pnlNewsFeed";
            pnlNewsFeed.Size = new Size(203, 36);
            pnlNewsFeed.TabIndex = 4;
            // 
            // btnNewsFeed
            // 
            btnNewsFeed.Dock = DockStyle.Top;
            btnNewsFeed.Location = new Point(0, 0);
            btnNewsFeed.Name = "btnNewsFeed";
            btnNewsFeed.Size = new Size(203, 36);
            btnNewsFeed.TabIndex = 6;
            btnNewsFeed.Text = "News Feed";
            btnNewsFeed.TextAlign = ContentAlignment.MiddleLeft;
            btnNewsFeed.UseVisualStyleBackColor = true;
            btnNewsFeed.Click += btnNewsFeed_Click;
            // 
            // pnlBottom
            // 
            pnlBottom.Controls.Add(button2);
            pnlBottom.Dock = DockStyle.Bottom;
            pnlBottom.Location = new Point(0, 657);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Size = new Size(203, 24);
            pnlBottom.TabIndex = 3;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Bottom;
            button2.Location = new Point(0, 1);
            button2.Name = "button2";
            button2.Size = new Size(203, 23);
            button2.TabIndex = 0;
            button2.Text = "Help";
            button2.UseVisualStyleBackColor = true;
            // 
            // pnlTop
            // 
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(203, 100);
            pnlTop.TabIndex = 0;
            // 
            // panelMainShow
            // 
            panelMainShow.Dock = DockStyle.Fill;
            panelMainShow.Location = new Point(203, 0);
            panelMainShow.Name = "panelMainShow";
            panelMainShow.Size = new Size(981, 681);
            panelMainShow.TabIndex = 1;
            // 
            // UserDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 681);
            Controls.Add(panelMainShow);
            Controls.Add(pnlSideMenu);
            Name = "UserDashboard";
            Text = "UserDashboard";
            pnlSideMenu.ResumeLayout(false);
            pnlUser.ResumeLayout(false);
            pnlSubjects.ResumeLayout(false);
            pnlPostsMenu.ResumeLayout(false);
            pnlPosts.ResumeLayout(false);
            pnlNewsFeed.ResumeLayout(false);
            pnlBottom.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSideMenu;
        private Panel pnlTop;
        private Panel panelMainShow;
        private Button btnPosts;
        private Button btnEditPost;
        private Button btnNewPost;
        private Panel pnlBottom;
        private Button button2;
        private Button btnSubjects;
        private Button btnUser;
        private Button btnNewsFeed;
        private Panel pnlPosts;
        private Panel pnlNewsFeed;
        private Panel pnlPostsMenu;
        private Panel pnlUser;
        private Panel pnlSubjects;
    }
}