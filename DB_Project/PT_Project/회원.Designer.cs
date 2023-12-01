namespace PT_Project
{
    partial class 회원
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.식단적성ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.회원상세페이지ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.name = new System.Windows.Forms.ToolStripTextBox();
            this.평점조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.식단적성ToolStripMenuItem,
            this.회원상세페이지ToolStripMenuItem,
            this.name,
            this.평점조회ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(922, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 식단적성ToolStripMenuItem
            // 
            this.식단적성ToolStripMenuItem.Name = "식단적성ToolStripMenuItem";
            this.식단적성ToolStripMenuItem.Size = new System.Drawing.Size(71, 23);
            this.식단적성ToolStripMenuItem.Text = "식단 적성";
            this.식단적성ToolStripMenuItem.Click += new System.EventHandler(this.식단적성ToolStripMenuItem_Click);
            // 
            // 회원상세페이지ToolStripMenuItem
            // 
            this.회원상세페이지ToolStripMenuItem.Name = "회원상세페이지ToolStripMenuItem";
            this.회원상세페이지ToolStripMenuItem.Size = new System.Drawing.Size(111, 23);
            this.회원상세페이지ToolStripMenuItem.Text = "회원 상세 페이지";
            this.회원상세페이지ToolStripMenuItem.Click += new System.EventHandler(this.회원상세페이지ToolStripMenuItem_Click);
            // 
            // name
            // 
            this.name.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.name.Enabled = false;
            this.name.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(71, 23);
            // 
            // 평점조회ToolStripMenuItem
            // 
            this.평점조회ToolStripMenuItem.Name = "평점조회ToolStripMenuItem";
            this.평점조회ToolStripMenuItem.Size = new System.Drawing.Size(71, 23);
            this.평점조회ToolStripMenuItem.Text = "평점 조회";
            this.평점조회ToolStripMenuItem.Click += new System.EventHandler(this.평점조회ToolStripMenuItem_Click);
            // 
            // 회원
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 569);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "회원";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.회원_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 식단적성ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 회원상세페이지ToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox name;
        private System.Windows.Forms.ToolStripMenuItem 평점조회ToolStripMenuItem;
    }
}