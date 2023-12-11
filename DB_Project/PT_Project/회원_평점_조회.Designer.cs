
namespace PT_Project
{
    partial class 회원평점조회
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DAOpen = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RatingAverage = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dinnerTextBox = new System.Windows.Forms.TextBox();
            this.lunchTextBox = new System.Windows.Forms.TextBox();
            this.breakfastTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comment = new System.Windows.Forms.TextBox();
            this.Rating = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(68, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(240, 382);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DAOpen
            // 
            this.DAOpen.Location = new System.Drawing.Point(140, 415);
            this.DAOpen.Name = "DAOpen";
            this.DAOpen.Size = new System.Drawing.Size(75, 23);
            this.DAOpen.TabIndex = 1;
            this.DAOpen.Text = "조회";
            this.DAOpen.UseVisualStyleBackColor = true;
            this.DAOpen.Click += new System.EventHandler(this.DAOpen_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RatingAverage);
            this.groupBox1.Location = new System.Drawing.Point(357, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 57);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "평균 평점";
            // 
            // RatingAverage
            // 
            this.RatingAverage.Location = new System.Drawing.Point(27, 20);
            this.RatingAverage.Name = "RatingAverage";
            this.RatingAverage.ReadOnly = true;
            this.RatingAverage.Size = new System.Drawing.Size(100, 21);
            this.RatingAverage.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dinnerTextBox);
            this.groupBox2.Controls.Add(this.lunchTextBox);
            this.groupBox2.Controls.Add(this.breakfastTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.comment);
            this.groupBox2.Controls.Add(this.Rating);
            this.groupBox2.Location = new System.Drawing.Point(357, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 252);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "선택한 항목";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(238, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "저녁";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "점심";
            // 
            // dinnerTextBox
            // 
            this.dinnerTextBox.Location = new System.Drawing.Point(286, 95);
            this.dinnerTextBox.Name = "dinnerTextBox";
            this.dinnerTextBox.ReadOnly = true;
            this.dinnerTextBox.Size = new System.Drawing.Size(100, 21);
            this.dinnerTextBox.TabIndex = 7;
            // 
            // lunchTextBox
            // 
            this.lunchTextBox.Location = new System.Drawing.Point(286, 57);
            this.lunchTextBox.Name = "lunchTextBox";
            this.lunchTextBox.ReadOnly = true;
            this.lunchTextBox.Size = new System.Drawing.Size(100, 21);
            this.lunchTextBox.TabIndex = 6;
            // 
            // breakfastTextBox
            // 
            this.breakfastTextBox.Location = new System.Drawing.Point(286, 17);
            this.breakfastTextBox.Name = "breakfastTextBox";
            this.breakfastTextBox.ReadOnly = true;
            this.breakfastTextBox.Size = new System.Drawing.Size(100, 21);
            this.breakfastTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "아침";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "코멘트";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "평점";
            // 
            // comment
            // 
            this.comment.Location = new System.Drawing.Point(87, 122);
            this.comment.Multiline = true;
            this.comment.Name = "comment";
            this.comment.ReadOnly = true;
            this.comment.Size = new System.Drawing.Size(288, 111);
            this.comment.TabIndex = 1;
            // 
            // Rating
            // 
            this.Rating.Location = new System.Drawing.Point(87, 47);
            this.Rating.Name = "Rating";
            this.Rating.ReadOnly = true;
            this.Rating.Size = new System.Drawing.Size(100, 21);
            this.Rating.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(460, 27);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(357, 27);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(76, 16);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "선택 날짜";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(357, 59);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(90, 16);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "3점이하검색";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // 회원평점조회
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DAOpen);
            this.Controls.Add(this.dataGridView1);
            this.Name = "회원평점조회";
            this.Text = "회원_평점_조회";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button DAOpen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox RatingAverage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox comment;
        private System.Windows.Forms.TextBox Rating;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dinnerTextBox;
        private System.Windows.Forms.TextBox lunchTextBox;
        private System.Windows.Forms.TextBox breakfastTextBox;
        private System.Windows.Forms.Label label3;
    }
}