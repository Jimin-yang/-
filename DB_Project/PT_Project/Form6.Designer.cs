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
            this.searchBtn1 = new System.Windows.Forms.Button();
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
            this.회원번호 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.회원이름 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.회원번호,
            this.회원이름});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(27, 23);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(315, 474);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // searchBtn1
            // 
            this.searchBtn1.Location = new System.Drawing.Point(27, 525);
            this.searchBtn1.Name = "searchBtn1";
            this.searchBtn1.Size = new System.Drawing.Size(315, 29);
            this.searchBtn1.TabIndex = 1;
            this.searchBtn1.Text = "회원조회";
            this.searchBtn1.UseVisualStyleBackColor = true;
            this.searchBtn1.Click += new System.EventHandler(this.searchBtn1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(368, 525);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(130, 22);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "작성한 평점";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // DBGrid
            // 
            this.DBGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBGrid.Location = new System.Drawing.Point(368, 23);
            this.DBGrid.Name = "DBGrid";
            this.DBGrid.RowHeadersWidth = 62;
            this.DBGrid.RowTemplate.Height = 30;
            this.DBGrid.Size = new System.Drawing.Size(317, 474);
            this.DBGrid.TabIndex = 3;
            this.DBGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DBGrid_CellClick);
            // 
            // searchBtn2
            // 
            this.searchBtn2.Location = new System.Drawing.Point(504, 525);
            this.searchBtn2.Name = "searchBtn2";
            this.searchBtn2.Size = new System.Drawing.Size(181, 29);
            this.searchBtn2.TabIndex = 4;
            this.searchBtn2.Text = "식단조회";
            this.searchBtn2.UseVisualStyleBackColor = true;
            this.searchBtn2.Click += new System.EventHandler(this.searchBtn2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(706, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "날짜";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(706, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "식단내용";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(705, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "평점";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(706, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "코멘트";
            // 
            // menu
            // 
            this.menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menu.Location = new System.Drawing.Point(822, 74);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(397, 163);
            this.menu.TabIndex = 9;
            // 
            // day
            // 
            this.day.AutoSize = true;
            this.day.Location = new System.Drawing.Point(820, 32);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(106, 18);
            this.day.TabIndex = 10;
            this.day.Text = "0000-00-00";
            // 
            // r5
            // 
            this.r5.AutoSize = true;
            this.r5.Location = new System.Drawing.Point(820, 276);
            this.r5.Name = "r5";
            this.r5.Size = new System.Drawing.Size(61, 22);
            this.r5.TabIndex = 11;
            this.r5.TabStop = true;
            this.r5.Text = "5점";
            this.r5.UseVisualStyleBackColor = true;
            // 
            // r4
            // 
            this.r4.AutoSize = true;
            this.r4.Location = new System.Drawing.Point(896, 276);
            this.r4.Name = "r4";
            this.r4.Size = new System.Drawing.Size(61, 22);
            this.r4.TabIndex = 12;
            this.r4.TabStop = true;
            this.r4.Text = "4점";
            this.r4.UseVisualStyleBackColor = true;
            // 
            // r3
            // 
            this.r3.AutoSize = true;
            this.r3.Location = new System.Drawing.Point(978, 276);
            this.r3.Name = "r3";
            this.r3.Size = new System.Drawing.Size(61, 22);
            this.r3.TabIndex = 13;
            this.r3.TabStop = true;
            this.r3.Text = "3점";
            this.r3.UseVisualStyleBackColor = true;
            // 
            // r2
            // 
            this.r2.AutoSize = true;
            this.r2.Location = new System.Drawing.Point(1065, 276);
            this.r2.Name = "r2";
            this.r2.Size = new System.Drawing.Size(61, 22);
            this.r2.TabIndex = 14;
            this.r2.TabStop = true;
            this.r2.Text = "2점";
            this.r2.UseVisualStyleBackColor = true;
            // 
            // r1
            // 
            this.r1.AutoSize = true;
            this.r1.Location = new System.Drawing.Point(1158, 276);
            this.r1.Name = "r1";
            this.r1.Size = new System.Drawing.Size(61, 22);
            this.r1.TabIndex = 15;
            this.r1.TabStop = true;
            this.r1.Text = "1점";
            this.r1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(823, 343);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(396, 153);
            this.textBox1.TabIndex = 16;
            // 
            // Btn
            // 
            this.Btn.Location = new System.Drawing.Point(1088, 521);
            this.Btn.Name = "Btn";
            this.Btn.Size = new System.Drawing.Size(131, 29);
            this.Btn.TabIndex = 17;
            this.Btn.Text = "추가";
            this.Btn.UseVisualStyleBackColor = true;
            this.Btn.Click += new System.EventHandler(this.Btn_Click);
            // 
            // 회원번호
            // 
            this.회원번호.Text = "회원번호";
            // 
            // 회원이름
            // 
            this.회원이름.Text = "회원이름";
            // 
            // 회원관리
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 588);
            this.Controls.Add(this.Btn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.r1);
            this.Controls.Add(this.r2);
            this.Controls.Add(this.r3);
            this.Controls.Add(this.r4);
            this.Controls.Add(this.r5);
            this.Controls.Add(this.day);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchBtn2);
            this.Controls.Add(this.DBGrid);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.searchBtn1);
            this.Controls.Add(this.listView1);
            this.Name = "회원관리";
            this.Text = "Form6";
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader 회원번호;
        private System.Windows.Forms.ColumnHeader 회원이름;
        private System.Windows.Forms.Button searchBtn1;
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
    }
}