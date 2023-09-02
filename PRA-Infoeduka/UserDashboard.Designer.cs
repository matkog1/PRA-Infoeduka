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
            panelPosts = new Panel();
            btnEditPost = new Button();
            btnNewPost = new Button();
            button1 = new Button();
            pnlTop = new Panel();
            panelMainShow = new Panel();
            pnlSideMenu.SuspendLayout();
            panelPosts.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSideMenu
            // 
            pnlSideMenu.BackColor = Color.DarkSlateGray;
            pnlSideMenu.Controls.Add(panelPosts);
            pnlSideMenu.Controls.Add(button1);
            pnlSideMenu.Controls.Add(pnlTop);
            pnlSideMenu.Dock = DockStyle.Left;
            pnlSideMenu.Location = new Point(0, 0);
            pnlSideMenu.Name = "pnlSideMenu";
            pnlSideMenu.Size = new Size(203, 681);
            pnlSideMenu.TabIndex = 0;
            // 
            // panelPosts
            // 
            panelPosts.Controls.Add(btnEditPost);
            panelPosts.Controls.Add(btnNewPost);
            panelPosts.Dock = DockStyle.Top;
            panelPosts.Location = new Point(0, 130);
            panelPosts.Name = "panelPosts";
            panelPosts.Size = new Size(203, 60);
            panelPosts.TabIndex = 2;
            // 
            // btnEditPost
            // 
            btnEditPost.Dock = DockStyle.Top;
            btnEditPost.Location = new Point(0, 30);
            btnEditPost.Name = "btnEditPost";
            btnEditPost.Size = new Size(203, 30);
            btnEditPost.TabIndex = 3;
            btnEditPost.Text = "Edit Post";
            btnEditPost.UseVisualStyleBackColor = true;
            btnEditPost.Click += btnEditPost_Click;
            // 
            // btnNewPost
            // 
            btnNewPost.Dock = DockStyle.Top;
            btnNewPost.Location = new Point(0, 0);
            btnNewPost.Name = "btnNewPost";
            btnNewPost.Size = new Size(203, 30);
            btnNewPost.TabIndex = 2;
            btnNewPost.Text = "New Post";
            btnNewPost.UseVisualStyleBackColor = true;
            btnNewPost.Click += btnNewPost_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.Location = new Point(0, 100);
            button1.Name = "button1";
            button1.Size = new Size(203, 30);
            button1.TabIndex = 1;
            button1.Text = "Posts";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
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
            panelPosts.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSideMenu;
        private Panel pnlTop;
        private Panel panelMainShow;
        private Button button1;
        private Panel panelPosts;
        private Button btnEditPost;
        private Button btnNewPost;
    }
}