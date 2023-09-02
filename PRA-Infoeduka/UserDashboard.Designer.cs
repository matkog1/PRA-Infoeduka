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
            button5 = new Button();
            pnlBottom = new Panel();
            button2 = new Button();
            panelPosts = new Panel();
            btnEditPost = new Button();
            btnNewPost = new Button();
            button1 = new Button();
            pnlTop = new Panel();
            button3 = new Button();
            panelMainShow = new Panel();
            pnlSideMenu.SuspendLayout();
            pnlBottom.SuspendLayout();
            panelPosts.SuspendLayout();
            pnlTop.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSideMenu
            // 
            pnlSideMenu.BackColor = Color.DarkSlateGray;
            pnlSideMenu.Controls.Add(button5);
            pnlSideMenu.Controls.Add(pnlBottom);
            pnlSideMenu.Controls.Add(panelPosts);
            pnlSideMenu.Controls.Add(button1);
            pnlSideMenu.Controls.Add(pnlTop);
            pnlSideMenu.Dock = DockStyle.Left;
            pnlSideMenu.Location = new Point(0, 0);
            pnlSideMenu.Name = "pnlSideMenu";
            pnlSideMenu.Size = new Size(203, 681);
            pnlSideMenu.TabIndex = 0;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Top;
            button5.Location = new Point(0, 195);
            button5.Name = "button5";
            button5.Size = new Size(203, 35);
            button5.TabIndex = 5;
            button5.Text = "Subjects";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
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
            // panelPosts
            // 
            panelPosts.Controls.Add(btnEditPost);
            panelPosts.Controls.Add(btnNewPost);
            panelPosts.Dock = DockStyle.Top;
            panelPosts.Location = new Point(0, 135);
            panelPosts.Name = "panelPosts";
            panelPosts.Size = new Size(203, 60);
            panelPosts.TabIndex = 2;
            // 
            // btnEditPost
            // 
            btnEditPost.Dock = DockStyle.Top;
            btnEditPost.FlatStyle = FlatStyle.Flat;
            btnEditPost.ForeColor = Color.White;
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
            btnNewPost.FlatStyle = FlatStyle.Flat;
            btnNewPost.ForeColor = Color.White;
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
            button1.Size = new Size(203, 35);
            button1.TabIndex = 1;
            button1.Text = "Posts";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pnlTop
            // 
            pnlTop.Controls.Add(button3);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(203, 100);
            pnlTop.TabIndex = 0;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Bottom;
            button3.Location = new Point(0, 65);
            button3.Name = "button3";
            button3.Size = new Size(203, 35);
            button3.TabIndex = 0;
            button3.Text = "User";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
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
            pnlBottom.ResumeLayout(false);
            panelPosts.ResumeLayout(false);
            pnlTop.ResumeLayout(false);
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
        private Panel pnlBottom;
        private Button button2;
        private Button button5;
        private Button button3;
    }
}