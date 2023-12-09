using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PT_Project
{
    public partial class 트레이너 : Form
    {
        loginF _parent;
        회원관리 UserManagement;
        트레이너_회원관리2 UserManagement2;
        프로그램관리 ProgramManagement;
        트레이너_상세페이지 trainerManagement;
        int usernumber;
        public 트레이너(loginF loginF)
        {
            InitializeComponent();
            _parent = loginF;
            usernumber = _parent.getusernumber;
        }
        public int getusernumber
        {
            get { return usernumber; }
        }

        public void open회원관리2(int seleteID)
        {
            if (UserManagement2 == null || UserManagement2.IsDisposed)  //Form4
            {
                UserManagement2 = new 트레이너_회원관리2(seleteID);
                UserManagement2.ShowDialog();
                UserManagement2.Dispose();
            }

        }
        private void 회원관리_Click(object sender, EventArgs e)
        {
            if (UserManagement == null || UserManagement.IsDisposed)  //Form4
            {
                UserManagement = new 회원관리(this);
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
            UserManagement = new 회원관리(this);
            UserManagement.MdiParent = this;
            UserManagement.Show();
        }

        private void 상세페이지_Click(object sender, EventArgs e)
        {
            if (trainerManagement == null || trainerManagement.IsDisposed)  //Form4
            {
                trainerManagement = new 트레이너_상세페이지(_parent.getusernumber);
                trainerManagement.MdiParent = this;
                trainerManagement.Show();
            }
        }
    }
}
