namespace PRA_Infoeduka
{
    partial class formNewsFeedPostsAll
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
            flpPosts = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 51);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 0;
            label1.Text = "Posts";
            // 
            // flpPosts
            // 
            flpPosts.AutoScroll = true;
            flpPosts.BackColor = Color.DarkSlateGray;
            flpPosts.ForeColor = SystemColors.ControlLightLight;
            flpPosts.Location = new Point(24, 82);
            flpPosts.Name = "flpPosts";
            flpPosts.Size = new Size(929, 582);
            flpPosts.TabIndex = 1;
            // 
            // formNewsFeedPostsAll
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 676);
            Controls.Add(flpPosts);
            Controls.Add(label1);
            Name = "formNewsFeedPostsAll";
            Text = "formNewsFeedPostsAll";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel flpPosts;
    }
}