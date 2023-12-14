using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PT_Project
{
    public partial class appendform : Form
    {
        private readonly int currentProgramNo;
        public appendform(int currentProgramNo)
        {
            InitializeComponent();
            this.currentProgramNo = currentProgramNo;
        }
        public string TextBox1Text { get; private set; }
        public string TextBox2Text { get; private set; }
        public string TextBox3Text { get; private set; }

        private void okButton_Click(object sender, EventArgs e)
        {
            // 사용자가 확인 버튼을 눌렀을 때 텍스트를 속성에 저장하고 폼을 닫음
            TextBox1Text = textBox1.Text;
            TextBox2Text = textBox2.Text;
            TextBox3Text = textBox3.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            // 사용자가 취소 버튼을 눌렀을 때 폼을 닫음
            DialogResult = DialogResult.Cancel;
            Close();
        }

    }
}
