namespace PT_Project
{
    partial class 트레이너
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
            this.회원관리 = new System.Windows.Forms.ToolStripMenuItem();
            this.프로그램추가 = new System.Windows.Forms.ToolStripMenuItem();
            this.name = new System.Windows.Forms.ToolStripTextBox();
            this.상세페이지 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.회원관리,
            this.프로그램추가,
            this.name,
            this.상세페이지});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1378, 35);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 회원관리
            // 
            this.회원관리.Name = "회원관리";
            this.회원관리.Size = new System.Drawing.Size(148, 31);
            this.회원관리.Text = "회원 식단 관리";
            this.회원관리.Click += new System.EventHandler(this.회원관리_Click);
            // 
            // 프로그램추가
            // 
            this.프로그램추가.Name = "프로그램추가";
            this.프로그램추가.Size = new System.Drawing.Size(234, 31);
            this.프로그램추가.Text = "PT 프로그램 수정 및 관리";
            this.프로그램추가.Click += new System.EventHandler(this.프로그램추가_Click);
            // 
            // name
            // 
            this.name.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.name.Enabled = false;
            this.name.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 31);
            // 
            // 상세페이지
            // 
            this.상세페이지.Name = "상세페이지";
            this.상세페이지.Size = new System.Drawing.Size(196, 31);
            this.상세페이지.Text = "트레이너 상세페이지";
            this.상세페이지.Click += new System.EventHandler(this.상세페이지_Click);
            // 
            // 트레이너
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 644);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "트레이너";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "트레이너";
            this.Load += new System.EventHandler(this.트레이너_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 회원관리;
        private System.Windows.Forms.ToolStripMenuItem 프로그램추가;
        private System.Windows.Forms.ToolStripTextBox name;
        private System.Windows.Forms.ToolStripMenuItem 상세페이지;
    }
}