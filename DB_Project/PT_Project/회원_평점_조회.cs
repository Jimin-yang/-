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
    public partial class 회원평점조회 : Form
    {
        private int SelectID;
        public 회원평점조회(int select)
        {
            InitializeComponent();
            SelectID = select;
        }
    }
}
