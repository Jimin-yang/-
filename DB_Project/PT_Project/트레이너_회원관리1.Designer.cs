namespace PT_Project
{
    partial class 회원관리
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.회원번호 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.회원이름 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.비만도 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.DBGrid = new System.Windows.Forms.DataGridView();
            this.searchBtn2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.Label();
            this.day = new System.Windows.Forms.Label();
            this.r5 = new System.Windows.Forms.RadioButton();
            this.r4 = new System.Windows.Forms.RadioButton();
            this.r3 = new System.Windows.Forms.RadioButton();
            this.r2 = new System.Windows.Forms.RadioButton();
            this.r1 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchBtn1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.회원번호,
            this.회원이름,
            this.비만도});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(11, 18);
            this.listView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(222, 317);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // 회원번호
            // 
            this.회원번호.Text = "회원번호";
            this.회원번호.Width = 70;
            // 
            // 회원이름
            // 
            this.회원이름.Text = "회원이름";
            this.회원이름.Width = 70;
            // 
            // 비만도
            // 
            this.비만도.Text = "비만도";
            this.비만도.Width = 100;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(15, 347);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(88, 16);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "작성한 평점";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // DBGrid
            // 
            this.DBGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBGrid.Location = new System.Drawing.Point(15, 18);
            this.DBGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DBGrid.Name = "DBGrid";
            this.DBGrid.RowHeadersWidth = 62;
            this.DBGrid.RowTemplate.Height = 30;
            this.DBGrid.Size = new System.Drawing.Size(229, 316);
            this.DBGrid.TabIndex = 3;
            this.DBGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DBGrid_CellClick);
            // 
            // searchBtn2
            // 
            this.searchBtn2.Location = new System.Drawing.Point(118, 345);
            this.searchBtn2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchBtn2.Name = "searchBtn2";
            this.searchBtn2.Size = new System.Drawing.Size(127, 19);
            this.searchBtn2.TabIndex = 4;
            this.searchBtn2.Text = "식단조회";
            this.searchBtn2.UseVisualStyleBackColor = true;
            this.searchBtn2.Click += new System.EventHandler(this.searchBtn2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "날짜";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "식단내용";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 185);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "평점";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 226);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "코멘트";
            // 
            // menu
            // 
            this.menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menu.Location = new System.Drawing.Point(71, 52);
            this.menu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(278, 109);
            this.menu.TabIndex = 9;
            // 
            // day
            // 
            this.day.AutoSize = true;
            this.day.Location = new System.Drawing.Point(69, 24);
            this.day.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(65, 12);
            this.day.TabIndex = 10;
            this.day.Text = "0000-00-00";
            // 
            // r5
            // 
            this.r5.AutoSize = true;
            this.r5.Location = new System.Drawing.Point(69, 187);
            this.r5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.r5.Name = "r5";
            this.r5.Size = new System.Drawing.Size(41, 16);
            this.r5.TabIndex = 11;
            this.r5.TabStop = true;
            this.r5.Text = "5점";
            this.r5.UseVisualStyleBackColor = true;
            // 
            // r4
            // 
            this.r4.AutoSize = true;
            this.r4.Location = new System.Drawing.Point(122, 187);
            this.r4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.r4.Name = "r4";
            this.r4.Size = new System.Drawing.Size(41, 16);
            this.r4.TabIndex = 12;
            this.r4.TabStop = true;
            this.r4.Text = "4점";
            this.r4.UseVisualStyleBackColor = true;
            // 
            // r3
            // 
            this.r3.AutoSize = true;
            this.r3.Location = new System.Drawing.Point(180, 187);
            this.r3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.r3.Name = "r3";
            this.r3.Size = new System.Drawing.Size(41, 16);
            this.r3.TabIndex = 13;
            this.r3.TabStop = true;
            this.r3.Text = "3점";
            this.r3.UseVisualStyleBackColor = true;
            // 
            // r2
            // 
            this.r2.AutoSize = true;
            this.r2.Location = new System.Drawing.Point(241, 187);
            this.r2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.r2.Name = "r2";
            this.r2.Size = new System.Drawing.Size(41, 16);
            this.r2.TabIndex = 14;
            this.r2.TabStop = true;
            this.r2.Text = "2점";
            this.r2.UseVisualStyleBackColor = true;
            // 
            // r1
            // 
            this.r1.AutoSize = true;
            this.r1.Location = new System.Drawing.Point(298, 187);
            this.r1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.r1.Name = "r1";
            this.r1.Size = new System.Drawing.Size(41, 16);
            this.r1.TabIndex = 15;
            this.r1.TabStop = true;
            this.r1.Text = "1점";
            this.r1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(71, 226);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(278, 103);
            this.textBox1.TabIndex = 16;
            // 
            // Btn
            // 
            this.Btn.Location = new System.Drawing.Point(241, 345);
            this.Btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn.Name = "Btn";
            this.Btn.Size = new System.Drawing.Size(108, 19);
            this.Btn.TabIndex = 17;
            this.Btn.Text = "추가";
            this.Btn.UseVisualStyleBackColor = true;
            this.Btn.Click += new System.EventHandler(this.Btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchBtn1);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(245, 376);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "회원 조회";
            // 
            // searchBtn1
            // 
            this.searchBtn1.Location = new System.Drawing.Point(11, 343);
            this.searchBtn1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchBtn1.Name = "searchBtn1";
            this.searchBtn1.Size = new System.Drawing.Size(220, 19);
            this.searchBtn1.TabIndex = 5;
            this.searchBtn1.Text = "회원님 상세 조회";
            this.searchBtn1.UseVisualStyleBackColor = true;
            this.searchBtn1.Click += new System.EventHandler(this.searchBtn1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DBGrid);
            this.groupBox2.Controls.Add(this.searchBtn2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Location = new System.Drawing.Point(291, 8);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(260, 376);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "식단 조회";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(259, 187);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 19);
            this.label5.TabIndex = 20;
            this.label5.Text = "▶";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.r1);
            this.groupBox3.Controls.Add(this.Btn);
            this.groupBox3.Controls.Add(this.menu);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.day);
            this.groupBox3.Controls.Add(this.r5);
            this.groupBox3.Controls.Add(this.r2);
            this.groupBox3.Controls.Add(this.r4);
            this.groupBox3.Controls.Add(this.r3);
            this.groupBox3.Location = new System.Drawing.Point(588, 8);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(367, 376);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "식단 작성";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(556, 191);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 19);
            this.label6.TabIndex = 22;
            this.label6.Text = "▶";
            // 
            // 회원관리
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 411);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "회원관리";
            this.Text = "회원 식단 관리";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.회원관리_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader 회원번호;
        private System.Windows.Forms.ColumnHeader 회원이름;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridView DBGrid;
        private System.Windows.Forms.Button searchBtn2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label menu;
        private System.Windows.Forms.Label day;
        private System.Windows.Forms.RadioButton r5;
        private System.Windows.Forms.RadioButton r4;
        private System.Windows.Forms.RadioButton r3;
        private System.Windows.Forms.RadioButton r2;
        private System.Windows.Forms.RadioButton r1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColumnHeader 비만도;
        private System.Windows.Forms.Button searchBtn1;
    }
}