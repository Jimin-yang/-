using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Oracle.DataAccess.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PT_Project
{

    public partial class loginF: Form
    {
        private string username; // 로그인한 사용자 이름
        private int usernumber; // 로그인한 사용자 번호 

        public string getusername
        {
            get { return username; }
        }

        public int getusernumber
        {
            get { return usernumber; }
        }
        public loginF()
        {
            InitializeComponent();
        }

        
        private bool IsValidConsumer(int usernumber)
        {
            try
            {
                using (OracleConnection odpConn = new OracleConnection())
                {
                    odpConn.ConnectionString = "User Id = ptadmin; Password = 1111; Data Source = (DESCRIPTION = (ADDRESS =(PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe))); ";
                    odpConn.Open();
                    using (OracleCommand cmd = new OracleCommand("SELECT * FROM consumer WHERE U_NO = :usernumber", odpConn))
                    {
                        cmd.Parameters.Add("usernumber", OracleDbType.Int32).Value = usernumber;
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        if (count > 0)
                        {
                            OracleDataReader odr = cmd.ExecuteReader();
                            odr.Read();
                            username = Convert.ToString(odr.GetValue(1));
                            odr.Close();
                        }
                        odpConn.Close();
                        return count > 0;

                    }
                }

            }
            catch (Exception ex)
            {
                return false;
            }
        }
        private bool IsValidTrainer(int usernumber)
        {
            try
            {
                using (OracleConnection odpConn = new OracleConnection())
                {
                    odpConn.ConnectionString = "User Id = ptadmin; Password = 1111; Data Source = (DESCRIPTION = (ADDRESS =(PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe))); ";
                    odpConn.Open();
                    using (OracleCommand cmd = new OracleCommand("SELECT * FROM trainer  WHERE T_NO = :usernumber", odpConn))
                    {
                        cmd.Parameters.Add("usernumber", OracleDbType.Int32).Value = usernumber;
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        if (count > 0)
                        {
                            OracleDataReader odr = cmd.ExecuteReader();
                            odr.Read();
                            username = Convert.ToString(odr.GetValue(1));
                            odr.Close();
                        }
                        return count > 0;
                    }

                }

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            usernumber = Convert.ToInt32(textBox1.Text);
            if (IsValidConsumer(usernumber))
            {
                MessageBox.Show(username + " 회원님 로그인 성공!");
                회원 form2 = new 회원(this);
                this.Hide();
                form2.ShowDialog();
                this.Close();
            }
            else if (IsValidTrainer(usernumber))
            {
                MessageBox.Show(username + " 트레이너님 로그인 성공!");
                트레이너 form3 = new 트레이너(this);
                this.Hide();
                form3.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("로그인 실패. 올바른 사용자 이름과 비밀번호를 입력하세요.");
            }
        }
    }
}
