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
    public partial class 트레이너 : Form
    {
        Form1 _parent;
        회원관리 UserManagement;
        프로그램관리 ProgramManagement;
        public 트레이너(Form1 loginF)
        {
            InitializeComponent();
            _parent = loginF;
        }

        

        private void 회원관리_Click(object sender, EventArgs e)
        {
            if (UserManagement == null || UserManagement.IsDisposed)  //Form4
            {
                UserManagement = new 회원관리(_parent.getusernumber);
                UserManagement.MdiParent = this;
                UserManagement.Show();
            }
        }

        private void 프로그램추가_Click(object sender, EventArgs e)
        {
            if (ProgramManagement == null || ProgramManagement.IsDisposed)  //Form4
            {
                ProgramManagement = new 프로그램관리(_parent.getusernumber);
                ProgramManagement.MdiParent = this;
                ProgramManagement.Show();
            }
        }

        private void 트레이너_Load(object sender, EventArgs e)
        {
            name.Text = _parent.getusername + " 님";
            UserManagement = new 회원관리(_parent.getusernumber);
            UserManagement.MdiParent = this;
            UserManagement.Show();
        }
    }
}
