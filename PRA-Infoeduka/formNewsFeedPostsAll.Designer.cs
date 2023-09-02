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
            fsdfsd = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(119, 51);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 0;
            label1.Text = "Posts";
            // 
            // flpPosts
            // 
            flpPosts.Location = new Point(123, 82);
            flpPosts.Name = "flpPosts";
            flpPosts.Size = new Size(784, 506);
            flpPosts.TabIndex = 1;
            // 
            // fsdfsd
            // 
            fsdfsd.AutoSize = true;
            fsdfsd.Location = new Point(229, 44);
            fsdfsd.Name = "fsdfsd";
            fsdfsd.Size = new Size(271, 15);
            fsdfsd.TabIndex = 2;
            fsdfsd.Text = "Tu idu postovi kao usercontrole u flowlayoutpanel";
            // 
            // formNewsFeedPostsAll
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 676);
            Controls.Add(fsdfsd);
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
        private Label fsdfsd;
    }
}