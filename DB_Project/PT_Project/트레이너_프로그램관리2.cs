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
    public partial class 프로그램관리2 : Form
    {
        private OracleConnection odpConn = new OracleConnection();
        프로그램관리 _parent;
        public 프로그램관리2(프로그램관리 inform1)
        {
            InitializeComponent();
            _parent = inform1;
        }
        private void 프로그램관리2_Load(object sender, EventArgs e)
        {
            if ( _parent.getstrCommand == "삭제")
            {
                 btnOK.Text = "삭제";
                 P_NO.Enabled = false;
                 initialTextBoxes();
            }
            else if ( _parent.getstrCommand == "업데이트")
            {
                 btnOK.Text = "업데이트";
                 P_NO.Enabled = false;
                 U_NO.Enabled = false;
                 T_NO.Enabled = false;
                 initialTextBoxes();
            }
            else if ( _parent.getstrCommand == "추가")
            {
                 T_NO.Enabled = false;
                 T_NO.Text =  _parent.getSelectID.ToString();
                 btnOK.Text = "추가";
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if ( btnOK.Text == "추가")
            {
                if ( INSERTRow() <= 0)
                {
                    MessageBox.Show("데이터 행이 추가되지 않음!");
                }
                else
                {
                    MessageBox.Show("정상적으로 데이터 행이 추가됨.");
                }
                base.Close();
            }
            else if ( btnOK.Text != "삭제")
            {
                if ( UPDATERow() <= 0)
                {
                    MessageBox.Show("데이터 행이 업데이트되지 않음!");
                }
                else
                {
                    MessageBox.Show("정상적으로 데이터가 업데이트됨!");
                }
                base.Close();
            }
            else
            {
                if ( DELETERow() <= 0)
                {
                    MessageBox.Show("데이터 행이 삭제되지 않음!");
                }
                else
                {
                    MessageBox.Show("정상적으로 데이터 행이 삭제됨!");
                }
                base.Close();
            }
        }
        private void initialTextBoxes()
        {
             odpConn.ConnectionString = "User Id = ptadmin; Password = 1111; Data Source = (DESCRIPTION = (ADDRESS =(PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe))); ";
             odpConn.Open();
            int getID =  _parent.getintID;
            OracleCommand OraCmd = new OracleCommand("SELECT * FROM program WHERE P_NO= :p_id",  odpConn);
            OraCmd.Parameters.Add("p_id", OracleDbType.Int32).Value = getID;
            OracleDataReader odr = OraCmd.ExecuteReader();
            while (odr.Read())
            {
                 P_NO.Text = Convert.ToString(odr.GetValue(0));
                 U_NO.Text = Convert.ToString(odr.GetValue(1));
                 T_NO.Text = Convert.ToString(odr.GetValue(2));
                 P_Contract.Text = Convert.ToString(odr.GetValue(3)).Substring(0, 11);
                 P_Start.Text = Convert.ToString(odr.GetValue(4)).Substring(0, 11);
                 P_End.Text = Convert.ToString(odr.GetValue(5)).Substring(0, 11);
                 P_Outline.Text = Convert.ToString(odr.GetValue(6));
                 P_Demand.Text = Convert.ToString(odr.GetValue(7));
            }
            odr.Close();
             odpConn.Close();
        }
        private int INSERTRow()
        {
             odpConn.ConnectionString = "User Id = ptadmin; Password = 1111; Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe))); ";
             odpConn.Open();
            int i_P_NO = Convert.ToInt32( P_NO.Text.Trim());
            int i_U_NO = Convert.ToInt32( U_NO.Text.Trim());
            int i_T_NO = Convert.ToInt32( T_NO.Text.Trim());
            string s_P_Contract =  P_Contract.Text.Trim();
            string s_P_Start =  P_Start.Text.Trim();
            string s_P_End =  P_End.Text.Trim();
            string s_P_Outline =  P_Outline.Text.Trim();
            string s_P_Demand =  P_Demand.Text.Trim();
            OracleCommand OraCmd = new OracleCommand("INSERT INTO program VALUES (:P_NO, :U_NO, :T_NO, :P_Contract, :P_Start, :P_End, :P_Outline, :P_Demand)",  odpConn);
            OraCmd.Parameters.Add("P_NO", OracleDbType.Int32);
            OraCmd.Parameters["P_NO"].Value = i_P_NO;
            OraCmd.Parameters.Add("U_NO", OracleDbType.Int32);
            OraCmd.Parameters["U_NO"].Value = i_U_NO;
            OraCmd.Parameters.Add("T_NO", OracleDbType.Int32);
            OraCmd.Parameters["T_NO"].Value = i_T_NO;
            OraCmd.Parameters.Add("P_Contract", OracleDbType.Date);
            OraCmd.Parameters["P_Contract"].Value = s_P_Contract.Trim();
            OraCmd.Parameters.Add("P_Start", OracleDbType.Date);
            OraCmd.Parameters["P_Start"].Value = s_P_Start.Trim();
            OraCmd.Parameters.Add("P_End", OracleDbType.Date);
            OraCmd.Parameters["P_End"].Value = s_P_End.Trim();
            OraCmd.Parameters.Add("P_Outline", OracleDbType.Varchar2, 70);
            OraCmd.Parameters["P_Outline"].Value = s_P_Outline.Trim();
            OraCmd.Parameters.Add("P_Demand", OracleDbType.Varchar2, 70);
            OraCmd.Parameters["P_Demand"].Value = s_P_Demand.Trim();
            return OraCmd.ExecuteNonQuery();
        }
        private int UPDATERow()
        {
             odpConn.ConnectionString = "User Id = ptadmin; Password = 1111; Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe))); ";
             odpConn.Open();
            int i_P_NO = Convert.ToInt32( P_NO.Text);
            string s_P_Contract =  P_Contract.Text.Trim();
            string s_P_Start =  P_Start.Text.Trim();
            string s_P_End =  P_End.Text.Trim();
            string s_P_Outline =  P_Outline.Text.Trim();
            string s_P_Demand =  P_Demand.Text.Trim();
            OracleCommand OraCmd = new OracleCommand("UPDATE program SET P_Contract=:P_Contract, P_Start=:P_Start, P_End=:P_End, P_Outline=:P_Outline, P_Demand=:P_Demand WHERE P_NO=:P_NO",  odpConn);
            OraCmd.Parameters.Add("P_Contract", OracleDbType.Date);
            OraCmd.Parameters["P_Contract"].Value = s_P_Contract.Trim();
            OraCmd.Parameters.Add("P_Start", OracleDbType.Date);
            OraCmd.Parameters["P_Start"].Value = s_P_Start.Trim();
            OraCmd.Parameters.Add("P_End", OracleDbType.Date);
            OraCmd.Parameters["P_End"].Value = s_P_End.Trim();
            OraCmd.Parameters.Add("P_Outline", OracleDbType.Varchar2, 70);
            OraCmd.Parameters["P_Outline"].Value = s_P_Outline.Trim();
            OraCmd.Parameters.Add("P_Demand", OracleDbType.Varchar2, 70);
            OraCmd.Parameters["P_Demand"].Value = s_P_Demand.Trim();
            OraCmd.Parameters.Add("P_NO", OracleDbType.Int32);
            OraCmd.Parameters["P_NO"].Value = i_P_NO;
            return OraCmd.ExecuteNonQuery();
        }
        private int DELETERow()
        {
             odpConn.ConnectionString = "User Id = ptadmin; Password = 1111; Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe))); ";
             odpConn.Open();
            int getID =  _parent.getintID;
            OracleCommand OraCmd = new OracleCommand("DELETE FROM program WHERE P_NO = :id",  odpConn);
            OraCmd.Parameters.Add("id", OracleDbType.Int32);
            OraCmd.Parameters["id"].Value = getID;
            return OraCmd.ExecuteNonQuery();
        }

        
    }
}
