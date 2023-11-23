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
            this.button5 = new System.Windows.Forms.Button();
            this.DAOpenBtn = new System.Windows.Forms.Button();
            this.DBGrid = new System.Windows.Forms.DataGridView();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.AppendBtn = new System.Windows.Forms.Button();
            this.txtptlast = new System.Windows.Forms.TextBox();
            this.txtptdate = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtheight = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(865, 587);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(107, 34);
            this.button5.TabIndex = 61;
            this.button5.Text = "메인화면";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // DAOpenBtn
            // 
            this.DAOpenBtn.Location = new System.Drawing.Point(645, 587);
            this.DAOpenBtn.Margin = new System.Windows.Forms.Padding(4);
            this.DAOpenBtn.Name = "DAOpenBtn";
            this.DAOpenBtn.Size = new System.Drawing.Size(107, 34);
            this.DAOpenBtn.TabIndex = 60;
            this.DAOpenBtn.Text = "조회";
            this.DAOpenBtn.UseVisualStyleBackColor = true;
            this.DAOpenBtn.Click += new System.EventHandler(this.DAOpenBtn_Click);
            // 
            // DBGrid
            // 
            this.DBGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBGrid.Location = new System.Drawing.Point(531, 73);
            this.DBGrid.Margin = new System.Windows.Forms.Padding(4);
            this.DBGrid.Name = "DBGrid";
            this.DBGrid.RowHeadersWidth = 62;
            this.DBGrid.RowTemplate.Height = 23;
            this.DBGrid.Size = new System.Drawing.Size(556, 468);
            this.DBGrid.TabIndex = 59;
            this.DBGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DBGrid_CellClick);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(404, 587);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(107, 34);
            this.DeleteBtn.TabIndex = 58;
            this.DeleteBtn.Text = "삭제";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(221, 587);
            this.UpdateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(107, 34);
            this.UpdateBtn.TabIndex = 57;
            this.UpdateBtn.Text = "수정";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // AppendBtn
            // 
            this.AppendBtn.Location = new System.Drawing.Point(47, 587);
            this.AppendBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AppendBtn.Name = "AppendBtn";
            this.AppendBtn.Size = new System.Drawing.Size(107, 34);
            this.AppendBtn.TabIndex = 56;
            this.AppendBtn.Text = "추가";
            this.AppendBtn.UseVisualStyleBackColor = true;
            this.AppendBtn.Click += new System.EventHandler(this.AppendBtn_Click);
            // 
            // txtptlast
            // 
            this.txtptlast.Location = new System.Drawing.Point(157, 518);
            this.txtptlast.Margin = new System.Windows.Forms.Padding(4);
            this.txtptlast.Name = "txtptlast";
            this.txtptlast.Size = new System.Drawing.Size(141, 28);
            this.txtptlast.TabIndex = 55;
            // 
            // txtptdate
            // 
            this.txtptdate.Location = new System.Drawing.Point(157, 445);
            this.txtptdate.Margin = new System.Windows.Forms.Padding(4);
            this.txtptdate.Multiline = true;
            this.txtptdate.Name = "txtptdate";
            this.txtptdate.Size = new System.Drawing.Size(231, 30);
            this.txtptdate.TabIndex = 54;
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(157, 380);
            this.txtphone.Margin = new System.Windows.Forms.Padding(4);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(141, 28);
            this.txtphone.TabIndex = 52;
            // 
            // txtheight
            // 
            this.txtheight.Location = new System.Drawing.Point(157, 311);
            this.txtheight.Margin = new System.Windows.Forms.Padding(4);
            this.txtheight.Name = "txtheight";
            this.txtheight.Size = new System.Drawing.Size(141, 28);
            this.txtheight.TabIndex = 53;
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(157, 236);
            this.txtage.Margin = new System.Windows.Forms.Padding(4);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(141, 28);
            this.txtage.TabIndex = 51;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(157, 158);
            this.txtname.Margin = new System.Windows.Forms.Padding(4);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(141, 28);
            this.txtname.TabIndex = 50;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(157, 79);
            this.txtid.Margin = new System.Windows.Forms.Padding(4);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(141, 28);
            this.txtid.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 523);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 18);
            this.label8.TabIndex = 48;
            this.label8.Text = "PT남은 일수";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 449);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 18);
            this.label7.TabIndex = 47;
            this.label7.Text = "PT기간";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 385);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 46;
            this.label6.Text = "전화번호";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 311);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 18);
            this.label5.TabIndex = 45;
            this.label5.Text = "키";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 241);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 44;
            this.label4.Text = "나이";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 163);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 43;
            this.label3.Text = "성명";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 18);
            this.label2.TabIndex = 42;
            this.label2.Text = "id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 18);
            this.label1.TabIndex = 41;
            this.label1.Text = "회원 상세 페이지";
            // 
            // 식단작성
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 660);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.DAOpenBtn);
            this.Controls.Add(this.DBGrid);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.AppendBtn);
            this.Controls.Add(this.txtptlast);
            this.Controls.Add(this.txtptdate);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtheight);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "식단작성";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button DAOpenBtn;
        private System.Windows.Forms.DataGridView DBGrid;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button AppendBtn;
        private System.Windows.Forms.TextBox txtptlast;
        private System.Windows.Forms.TextBox txtptdate;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtheight;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}