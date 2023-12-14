namespace PT_Project
{
    partial class 식단작성
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
            this.label7 = new System.Windows.Forms.Label();
            this.lb_trainerName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_demand = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_prname = new System.Windows.Forms.Label();
            this.append_btn = new System.Windows.Forms.Button();
            this.modify_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_pnum = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.serch_btn = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "담당피티";
            // 
            // lb_trainerName
            // 
            this.lb_trainerName.AutoSize = true;
            this.lb_trainerName.Location = new System.Drawing.Point(199, 28);
            this.lb_trainerName.Name = "lb_trainerName";
            this.lb_trainerName.Size = new System.Drawing.Size(90, 12);
            this.lb_trainerName.TabIndex = 15;
            this.lb_trainerName.Text = "lb_trainerName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 12);
            this.label4.TabIndex = 22;
            this.label4.Text = "pt요구사항";
            // 
            // txt_demand
            // 
            this.txt_demand.Location = new System.Drawing.Point(201, 153);
            this.txt_demand.Multiline = true;
            this.txt_demand.Name = "txt_demand";
            this.txt_demand.ReadOnly = true;
            this.txt_demand.Size = new System.Drawing.Size(222, 84);
            this.txt_demand.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 31;
            this.label5.Text = "프로그램이름";
            // 
            // lb_prname
            // 
            this.lb_prname.AutoSize = true;
            this.lb_prname.Location = new System.Drawing.Point(199, 59);
            this.lb_prname.Name = "lb_prname";
            this.lb_prname.Size = new System.Drawing.Size(38, 12);
            this.lb_prname.TabIndex = 32;
            this.lb_prname.Text = "label6";
            // 
            // append_btn
            // 
            this.append_btn.Location = new System.Drawing.Point(523, 173);
            this.append_btn.Name = "append_btn";
            this.append_btn.Size = new System.Drawing.Size(75, 23);
            this.append_btn.TabIndex = 36;
            this.append_btn.Text = "추가";
            this.append_btn.UseVisualStyleBackColor = true;
            this.append_btn.Click += new System.EventHandler(this.append_btn_Click);
            // 
            // modify_btn
            // 
            this.modify_btn.Location = new System.Drawing.Point(639, 173);
            this.modify_btn.Name = "modify_btn";
            this.modify_btn.Size = new System.Drawing.Size(75, 23);
            this.modify_btn.TabIndex = 37;
            this.modify_btn.Text = "수정";
            this.modify_btn.UseVisualStyleBackColor = true;
            this.modify_btn.Click += new System.EventHandler(this.modify_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(759, 173);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(75, 23);
            this.delete_btn.TabIndex = 38;
            this.delete_btn.Text = "삭제";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 79);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 39;
            this.label1.Text = "프로그램번호";
            // 
            // lb_pnum
            // 
            this.lb_pnum.AutoSize = true;
            this.lb_pnum.Location = new System.Drawing.Point(199, 79);
            this.lb_pnum.Name = "lb_pnum";
            this.lb_pnum.Size = new System.Drawing.Size(38, 12);
            this.lb_pnum.TabIndex = 40;
            this.lb_pnum.Text = "label6";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.serch_btn);
            this.groupBox1.Controls.Add(this.txt_search);
            this.groupBox1.Location = new System.Drawing.Point(523, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 100);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "프로그램번호로 식단 검색하기";
            // 
            // serch_btn
            // 
            this.serch_btn.Location = new System.Drawing.Point(179, 44);
            this.serch_btn.Name = "serch_btn";
            this.serch_btn.Size = new System.Drawing.Size(64, 23);
            this.serch_btn.TabIndex = 1;
            this.serch_btn.Text = "찾기";
            this.serch_btn.UseVisualStyleBackColor = true;
            this.serch_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(6, 46);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(150, 21);
            this.txt_search.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(52, 267);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(816, 230);
            this.dataGridView1.TabIndex = 42;
            // 
            // 식단작성
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 518);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb_pnum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.modify_btn);
            this.Controls.Add(this.append_btn);
            this.Controls.Add(this.lb_prname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_demand);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_trainerName);
            this.Controls.Add(this.label7);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "식단작성";
            this.Text = "Form4";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.식단작성_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_trainerName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_demand;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_prname;
        private System.Windows.Forms.Button append_btn;
        private System.Windows.Forms.Button modify_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_pnum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button serch_btn;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}