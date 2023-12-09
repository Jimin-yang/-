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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PT_Project
{
    public partial class 트레이너_회원관리2 : Form
    {
        private int SelectConsumerID = 0;
        private OracleConnection odpConn = new OracleConnection();
        public 트레이너_회원관리2(int num)
        {
            InitializeComponent();
            SelectConsumerID = num;
        }
        private void 트레이너_회원관리2_Load(object sender, EventArgs e)
        {

            odpConn.ConnectionString = "User Id=ptadmin; Password=1111; Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));";
            odpConn.Open();

            OracleCommand OraCmd = new OracleCommand("SELECT C.U_NO, C.cname, C.cage, C.cheight, C.cweight, C.phone, P.P_Start || ' - ' || P.P_End AS ProgramDate, TRUNC(P.P_End - SYSDATE) AS DaysRemaining FROM consumer C JOIN program P ON C.U_NO = P.U_NO AND C.U_NO = :U_NO", odpConn);
            OraCmd.Parameters.Add("U_NO", OracleDbType.Int32).Value = SelectConsumerID;

            OracleDataReader odr = OraCmd.ExecuteReader();

            while (odr.Read())
            {
                txtname.Text = Convert.ToString(odr.GetValue(1));           // C.cname
                txtage.Text = Convert.ToString(odr.GetValue(2));            // C.cage
                txtheight.Text = Convert.ToString(odr.GetValue(3));         // C.cheight
                txtweight.Text = Convert.ToString(odr.GetValue(4));         // C.cweight
                txtphone.Text = Convert.ToString(odr.GetValue(5));          // C.phone
                txtptdate.Text = Convert.ToString(odr.GetValue(6));          // ProgramDate
                txtptlast.Text = Convert.ToString(odr.GetValue(7));
                txtptlast.Text = Convert.ToString(odr.GetValue(7));// DaysRemaining

                double weight = Convert.ToDouble(odr.GetValue(4));          // C.cweight
                double height = Convert.ToDouble(odr.GetValue(3)) / 100.0;   // C.cheight (cm를 m로 변환)

                double bmi = weight / (height * height);
                txtBMI.Text = bmi.ToString("0.00");
            }

            odr.Close();
            odpConn.Close();

        }
    }
}
