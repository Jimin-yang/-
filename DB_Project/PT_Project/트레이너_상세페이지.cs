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
    
    public partial class 트레이너_상세페이지 : Form
    {

        private OracleConnection odpConn = new OracleConnection();
        private int SelectID;
        public 트레이너_상세페이지(int selectID)
        {
            InitializeComponent();
            SelectID = selectID;
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            odpConn.ConnectionString = "User Id = ptadmin; Password = 1111; Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = COM4-019)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe))); ";
            odpConn.Open();
            OracleCommand OraCmd = new OracleCommand("UPDATE trainer SET T_Name=:T_Name, T_PhoneNum=:T_PhoneNum, T_Career=:T_Career WHERE T_NO= :T_NO", odpConn);
            OraCmd.Parameters.Add("T_Name", OracleDbType.Varchar2, 20).Value = txtName.Text.Trim();
            OraCmd.Parameters.Add("T_PhoneNum", OracleDbType.Varchar2, 20).Value = txtPhone.Text.Trim();
            OraCmd.Parameters.Add("T_Career", OracleDbType.Varchar2, 100).Value = txtCareer.Text.Trim();
            OraCmd.Parameters.Add("T_NO", OracleDbType.Int32).Value = SelectID;
            OraCmd.ExecuteReader().Close();
            odpConn.Close();
            MessageBox.Show(string.Concat("수정하셨습니다!"));
        }

        private void 트레이너_상세페이지_Load(object sender, EventArgs e)
        {
            OracleConnection myConnection = new OracleConnection("User Id=ptadmin; Password=1111; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = COM4-019)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = xe) ) );");
            string commandString = string.Concat("select T_Name, T_PhoneNum, T_Career from trainer where T_NO = ", SelectID.ToString());
            OracleCommand myCommand = new OracleCommand()
            {
                Connection = myConnection,
                CommandText = commandString
            };
            myConnection.Open();
            OracleDataReader MR = myCommand.ExecuteReader();
            while (MR.Read())
            {
                txtName.Text = MR[0].ToString();
                txtPhone.Text = MR[1].ToString();
                txtCareer.Text = MR[2].ToString();
            }
            MR.Close();
            myConnection.Close();
        }
    }
}
