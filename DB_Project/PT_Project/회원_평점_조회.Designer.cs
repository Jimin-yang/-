
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
<<<<<<< Updated upstream
            this.DBGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DBGrid
            // 
            this.DBGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBGrid.Location = new System.Drawing.Point(54, 66);
            this.DBGrid.Margin = new System.Windows.Forms.Padding(2);
            this.DBGrid.Name = "DBGrid";
            this.DBGrid.RowHeadersWidth = 62;
            this.DBGrid.RowTemplate.Height = 30;
            this.DBGrid.Size = new System.Drawing.Size(222, 316);
            this.DBGrid.TabIndex = 4;
=======
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DAOpen = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RatingAverage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Rating = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comment = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(74, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(225, 326);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DAOpen
            // 
            this.DAOpen.Location = new System.Drawing.Point(145, 406);
            this.DAOpen.Name = "DAOpen";
            this.DAOpen.Size = new System.Drawing.Size(75, 23);
            this.DAOpen.TabIndex = 1;
            this.DAOpen.Text = "조회";
            this.DAOpen.UseVisualStyleBackColor = true;
            this.DAOpen.Click += new System.EventHandler(this.DAOpen_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.RatingAverage);
            this.groupBox1.Location = new System.Drawing.Point(388, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "평균 평점";
            // 
            // RatingAverage
            // 
            this.RatingAverage.Location = new System.Drawing.Point(34, 41);
            this.RatingAverage.Name = "RatingAverage";
            this.RatingAverage.Size = new System.Drawing.Size(100, 21);
            this.RatingAverage.TabIndex = 0;
>>>>>>> Stashed changes
            // 
            // label1
            // 
            this.label1.AutoSize = true;
<<<<<<< Updated upstream
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(317, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "회원 평점 조회";
=======
            this.label1.Location = new System.Drawing.Point(140, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "점";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comment);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.Rating);
            this.groupBox2.Location = new System.Drawing.Point(388, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 201);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "선택 항목";
            // 
            // Rating
            // 
            this.Rating.Location = new System.Drawing.Point(34, 34);
            this.Rating.Name = "Rating";
            this.Rating.Size = new System.Drawing.Size(100, 21);
            this.Rating.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "점";
            // 
            // comment
            // 
            this.comment.Location = new System.Drawing.Point(34, 101);
            this.comment.Multiline = true;
            this.comment.Name = "comment";
            this.comment.Size = new System.Drawing.Size(257, 85);
            this.comment.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(133, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(51, 27);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(76, 16);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "날짜 검색";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
>>>>>>> Stashed changes
            // 
            // 회원평점조회
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
<<<<<<< Updated upstream
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DBGrid);
            this.Name = "회원평점조회";
            this.Text = "회원_평점_조회";
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid)).EndInit();
=======
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
>>>>>>> Stashed changes
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

<<<<<<< Updated upstream
        private System.Windows.Forms.DataGridView DBGrid;
        private System.Windows.Forms.Label label1;
=======
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button DAOpen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RatingAverage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox comment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Rating;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox checkBox1;
>>>>>>> Stashed changes
    }
}