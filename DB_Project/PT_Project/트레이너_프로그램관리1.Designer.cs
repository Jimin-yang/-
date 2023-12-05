namespace PT_Project
{
    partial class 프로그램관리
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.추가 = new System.Windows.Forms.ToolStripMenuItem();
            this.업데이트 = new System.Windows.Forms.ToolStripMenuItem();
            this.삭제 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.DBGrid = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.추가,
            this.업데이트,
            this.삭제});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(235, 100);
            // 
            // 추가
            // 
            this.추가.Name = "추가";
            this.추가.Size = new System.Drawing.Size(234, 32);
            this.추가.Text = "프로그램 추가";
            this.추가.Click += new System.EventHandler(this.추가_Click);
            // 
            // 업데이트
            // 
            this.업데이트.Name = "업데이트";
            this.업데이트.Size = new System.Drawing.Size(234, 32);
            this.업데이트.Text = "프로그램 업데이트";
            this.업데이트.Click += new System.EventHandler(this.업데이트_Click);
            // 
            // 삭제
            // 
            this.삭제.Name = "삭제";
            this.삭제.Size = new System.Drawing.Size(234, 32);
            this.삭제.Text = "프로그램 삭제";
            this.삭제.Click += new System.EventHandler(this.삭제_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(508, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "* 수정하고 싶은 행을 선택하여 오른쪽 클릭하면 됩니다!";
            // 
            // DBGrid
            // 
            this.DBGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBGrid.ContextMenuStrip = this.contextMenuStrip1;
            this.DBGrid.Location = new System.Drawing.Point(35, 70);
            this.DBGrid.Name = "DBGrid";
            this.DBGrid.RowHeadersWidth = 62;
            this.DBGrid.RowTemplate.Height = 30;
            this.DBGrid.Size = new System.Drawing.Size(934, 366);
            this.DBGrid.TabIndex = 0;
            // 
            // 프로그램관리
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 464);
            this.Controls.Add(this.DBGrid);
            this.Controls.Add(this.label1);
            this.Name = "프로그램관리";
            this.Text = "PT 프로그램 수정 및 관리";
            this.Load += new System.EventHandler(this.프로그램관리_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 추가;
        private System.Windows.Forms.ToolStripMenuItem 업데이트;
        private System.Windows.Forms.ToolStripMenuItem 삭제;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DBGrid;
    }
}