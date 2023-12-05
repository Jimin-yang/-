using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace PT_Project
{
    public partial class 프로그램관리 : Form
    {
        private int SelectID;
        private int intID;  //ID 필드 설정
        private string strCommand; //데이터 삭제, 추가, 업데이트 인지를 설정할 문자열 필드
        private OracleConnection odpConn = new OracleConnection();
        public int getintID
        {
            get
            {
                return  intID;
            }
        }

        public int getSelectID
        {
            get
            {
                return  SelectID;
            }
        }

        public string getstrCommand
        {
            get
            {
                return  strCommand;
            }
        }
        public 프로그램관리(int selectID)
        {
            InitializeComponent();
            SelectID = selectID;
        }
        private void showDataGridView()
        {
            try
            {
                 odpConn.ConnectionString = "User Id=ptadmin; Password=1111; Data Source=(DESCRIPTION =   (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))   (CONNECT_DATA =     (SERVER = DEDICATED)     (SERVICE_NAME = xe)   ) );";
                 odpConn.Open();
                OracleDataAdapter oda = new OracleDataAdapter()
                {
                    SelectCommand = new OracleCommand(string.Concat("SELECT P.P_NO as 프로그램번호, C.cname as 회원이름, P.P_Contract as 계약일자, P.P_Start as 시작일자, P.P_End as 종료일자 FROM program P, consumer C WHERE P.U_NO = C.U_NO AND P.T_NO = ",  SelectID.ToString()),  odpConn)
                };
                DataTable dt = new DataTable();
                oda.Fill(dt);
                 odpConn.Close();
                 DBGrid.DataSource = dt;
                 DBGrid.AutoResizeColumns();
                 DBGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                 DBGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                 DBGrid.AllowUserToAddRows = false;
            }
            catch (Exception exception)
            {
                Exception ex = exception;
                MessageBox.Show(string.Concat("에러 발생 : ", ex.ToString()));
                 odpConn.Close();
            }
        }

        private void 삭제_Click(object sender, EventArgs e)
        {
             strCommand = "삭제";
             intID = Convert.ToInt32( DBGrid.SelectedCells[0].Value);
            프로그램관리2 form2 = new 프로그램관리2(this);
            form2.ShowDialog();
            form2.Dispose();
             showDataGridView();
        }

        private void 업데이트_Click(object sender, EventArgs e)
        {
             strCommand = "업데이트";
             intID = Convert.ToInt32( DBGrid.SelectedCells[0].Value);
            프로그램관리2 form2 = new 프로그램관리2(this);
            form2.ShowDialog();
            form2.Dispose();
             showDataGridView();
        }

        private void 추가_Click(object sender, EventArgs e)
        {
             strCommand = "추가";
            프로그램관리2 form2 = new 프로그램관리2(this);
            form2.ShowDialog();
            form2.Dispose();
             showDataGridView();
        }

        private void 프로그램관리_Load(object sender, EventArgs e)
        {
             showDataGridView();
        }
    }
}
