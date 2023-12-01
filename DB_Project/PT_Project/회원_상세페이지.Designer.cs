namespace PT_Project
{
    partial class 회원상세
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
            this.DAOpenBtn = new System.Windows.Forms.Button();
            this.DBGrid = new System.Windows.Forms.DataGridView();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.txtptlast = new System.Windows.Forms.TextBox();
            this.txtptdate = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtheight = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtweight = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DAOpenBtn
            // 
            this.DAOpenBtn.Location = new System.Drawing.Point(224, 415);
            this.DAOpenBtn.Name = "DAOpenBtn";
            this.DAOpenBtn.Size = new System.Drawing.Size(75, 23);
            this.DAOpenBtn.TabIndex = 123;
            this.DAOpenBtn.Text = "조회";
            this.DAOpenBtn.UseVisualStyleBackColor = true;
            this.DAOpenBtn.Click += new System.EventHandler(this.DAOpenBtn_Click);
            // 
            // DBGrid
            // 
            this.DBGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBGrid.Location = new System.Drawing.Point(12, 269);
            this.DBGrid.Name = "DBGrid";
            this.DBGrid.RowHeadersWidth = 62;
            this.DBGrid.RowTemplate.Height = 23;
            this.DBGrid.Size = new System.Drawing.Size(762, 96);
            this.DBGrid.TabIndex = 122;
            this.DBGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DBGrid_CellClick);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(445, 415);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.UpdateBtn.TabIndex = 120;
            this.UpdateBtn.Text = "수정";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // txtptlast
            // 
            this.txtptlast.Enabled = false;
            this.txtptlast.Location = new System.Drawing.Point(611, 153);
            this.txtptlast.Name = "txtptlast";
            this.txtptlast.Size = new System.Drawing.Size(100, 21);
            this.txtptlast.TabIndex = 118;
            // 
            // txtptdate
            // 
            this.txtptdate.Enabled = false;
            this.txtptdate.Location = new System.Drawing.Point(611, 105);
            this.txtptdate.Multiline = true;
            this.txtptdate.Name = "txtptdate";
            this.txtptdate.Size = new System.Drawing.Size(163, 21);
            this.txtptdate.TabIndex = 117;
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(361, 154);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(100, 21);
            this.txtphone.TabIndex = 115;
            // 
            // txtheight
            // 
            this.txtheight.Location = new System.Drawing.Point(361, 108);
            this.txtheight.Name = "txtheight";
            this.txtheight.Size = new System.Drawing.Size(100, 21);
            this.txtheight.TabIndex = 116;
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(122, 160);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(100, 21);
            this.txtage.TabIndex = 114;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(122, 108);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 21);
            this.txtname.TabIndex = 113;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(532, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 12);
            this.label8.TabIndex = 111;
            this.label8.Text = "PT남은 일수";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(532, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 12);
            this.label7.TabIndex = 110;
            this.label7.Text = "PT기간";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(282, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 109;
            this.label6.Text = "전화번호";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(282, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 108;
            this.label5.Text = "키";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 107;
            this.label4.Text = "나이";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 106;
            this.label3.Text = "성명";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 12);
            this.label1.TabIndex = 104;
            this.label1.Text = "회원 상세 페이지";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 124;
            this.label2.Text = "몸무게";
            // 
            // txtweight
            // 
            this.txtweight.Location = new System.Drawing.Point(361, 203);
            this.txtweight.Name = "txtweight";
            this.txtweight.Size = new System.Drawing.Size(100, 21);
            this.txtweight.TabIndex = 125;
            // 
            // 회원상세
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 481);
            this.Controls.Add(this.txtweight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DAOpenBtn);
            this.Controls.Add(this.DBGrid);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.txtptlast);
            this.Controls.Add(this.txtptdate);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtheight);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "회원상세";
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button DAOpenBtn;
        private System.Windows.Forms.DataGridView DBGrid;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.TextBox txtptlast;
        private System.Windows.Forms.TextBox txtptdate;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtheight;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtweight;
    }
}