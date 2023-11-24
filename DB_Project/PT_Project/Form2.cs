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
    public partial class 회원 : Form
    {
        loginF _parent;
        식단작성 MenuInput;
        회원상세 UserDetail;
        public 회원(loginF loginF)
        {
            InitializeComponent();
            _parent = loginF;

        }

        private void 회원_Load(object sender, EventArgs e)
        {
            name.Text = _parent.getusername + "님";
            MenuInput = new 식단작성();
            MenuInput.MdiParent = this;
            MenuInput.Show();
        }
        private void 식단적성ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MenuInput == null || MenuInput.IsDisposed)  //Form4
            {
                MenuInput = new 식단작성();
                MenuInput.MdiParent = this;
                MenuInput.Show();
            }
        }

        private void 회원상세페이지ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UserDetail == null || UserDetail.IsDisposed)  //Form4
            {
                UserDetail = new 회원상세(_parent.getusernumber);
                UserDetail.MdiParent = this;
                UserDetail.Show();
            }
        }
        private void 평점조회ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
