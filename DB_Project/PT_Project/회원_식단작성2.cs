using Oracle.DataAccess.Client;
using PT_Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using System.Net.NetworkInformation;

using Oracle.DataAccess.Client;
using PT_Project;
using System;
using System.Data;
using System.Windows.Forms;

namespace PT_Project
{
    public partial class 회원식단작성2 : Form
    {
        private 식단작성 Parent;
        private DataSet DS;
        private OracleDataAdapter DBAdapter;
        private int selectedPNO;
        public 회원식단작성2(int selectedPNO)
        {
            InitializeComponent();  
            this.selectedPNO = selectedPNO; // 클래스 수준의 변수에 할당
            DB_Open();
        }

        private void 회원식단작성2_Load(object sender, EventArgs e)
        {
            DS.Clear();
            DBAdapter.Fill(DS, "ConsumerDiet");
            Parent = (식단작성)Owner;

            listBox1.DisplayMember = "P_DATE";
            listBox1.ValueMember = "P_DATE";
            listBox1.DataSource = DS.Tables["ConsumerDiet"];
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                DataRowView selectedRow = (DataRowView)listBox1.SelectedItem;
                DateTime selectedDate = Convert.ToDateTime(selectedRow["P_DATE"]);
                string selectedPMenu = GetPMenu(selectedPNO, selectedDate);

                // 선택된 P_DATE에 해당하는 P_MENU를 '@' 기준으로 3분할하여 각각의 TextBox에 표시
                string[] menuParts = selectedPMenu.Split('@');
                if (menuParts.Length >= 3)
                {
                    textBox1.Text = menuParts[0];
                    textBox2.Text = menuParts[1];
                    textBox3.Text = menuParts[2];
                }
                else
                {
                    // P_Menu가 '@'로 구분된 부분이 3개 미만일 경우 예외 처리
                    MessageBox.Show("P_Menu 값이 '@'로 구분된 부분이 3개 미만입니다.");
                }
            }
        }

        private string GetPMenu(int pNo, DateTime pDate)
        {
            string query = "SELECT P_Menu FROM ConsumerDiet WHERE P_NO = :P_NO AND P_DATE = :P_DATE";
            using (OracleCommand command = new OracleCommand(query, DBAdapter.SelectCommand.Connection))
            {
                command.Parameters.Add("P_NO", OracleDbType.Int32).Value = pNo;
                command.Parameters.Add("P_DATE", OracleDbType.Date).Value = pDate;
                
                try
                {
                    if (DBAdapter.SelectCommand.Connection.State == ConnectionState.Closed)
                    {
                        DBAdapter.SelectCommand.Connection.Open();
                    }

                    object result = command.ExecuteScalar();
                    return result != null ? result.ToString() : string.Empty;
                }
                finally
                {
                    DBAdapter.SelectCommand.Connection.Close();
                }
            }
        }


        private void DB_Open()
        {
            try
            {
                string connectionString = "User Id=ptadmin;Password=1111;Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=DESKTOP-M7OKFI9)(PORT=1521))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)))";
                string commandString = "SELECT * FROM ConsumerDiet WHERE P_NO = :SearchValue";
                DBAdapter = new OracleDataAdapter(commandString, connectionString);
                // 매개변수 추가
                DBAdapter.SelectCommand.Parameters.Add("SearchValue", OracleDbType.Int32).Value = selectedPNO;
                DS = new DataSet();
            }   
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
        }

        private void UpBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != 0)
            {
                listBox1.SelectedIndex = listBox1.SelectedIndex - 1;
            }
            else
            {
                MessageBox.Show("이곳은 레코드의 처음입니다.");
            }
        }

        private void DownBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != listBox1.Items.Count - 1)
            {
                listBox1.SelectedIndex = listBox1.SelectedIndex + 1;
            }
            else
            {
                MessageBox.Show("이곳은 레코드의 마지막입니다.");
             }
        }

        private void modify_btn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                DataRowView selectedRow = (DataRowView)listBox1.SelectedItem;
                DateTime selectedDate = Convert.ToDateTime(selectedRow["P_DATE"]);
                string modifiedPMenu1 = textBox1.Text;
                string modifiedPMenu2 = textBox2.Text;
                string modifiedPMenu3 = textBox3.Text;

                // 데이터 수정
                ModifyConsumerDiet(selectedDate, modifiedPMenu1, modifiedPMenu2, modifiedPMenu3);

                // 부모 폼의 RefreshDataGridView 메서드 호출
                Parent.RefreshDataGridView();


                // DataSet 업데이트
                DS.Tables["ConsumerDiet"].Clear();
                DBAdapter.Fill(DS, "ConsumerDiet");

                // DataSource 갱신
                listBox1.DataSource = DS.Tables["ConsumerDiet"];
                listBox1.DisplayMember = "P_DATE";
                listBox1.ValueMember = "P_DATE";

                MessageBox.Show("수정이 성공적으로 완료됬습니다");
            }
            else
            {
                MessageBox.Show("수정할 행을 선택하세요.");
            }
        }

        private void ModifyConsumerDiet(DateTime selectedDate, string modifiedPMenu1, string modifiedPMenu2, string modifiedPMenu3)
        {
            using (OracleConnection Odpconn = new OracleConnection("User Id=ptadmin;Password=1111;Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=DESKTOP-M7OKFI9)(PORT=1521))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)))"))
            {
                Odpconn.Open();

                // P_NO와 P_DATE 값에 해당하는 데이터를 ConsumerDiet 테이블에서 수정하는 쿼리
                string modifyQuery = "UPDATE ConsumerDiet SET P_Menu = :modifiedPMenu1 || '@' || :modifiedPMenu2 || '@' || :modifiedPMenu3 WHERE P_NO = :programId AND P_DATE = :selectedDate";
                using (OracleCommand modifyCommand = new OracleCommand(modifyQuery, Odpconn))
                {
                    modifyCommand.Parameters.Add("modifiedPMenu1", OracleDbType.Varchar2).Value = modifiedPMenu1;
                    modifyCommand.Parameters.Add("modifiedPMenu2", OracleDbType.Varchar2).Value = modifiedPMenu2;
                    modifyCommand.Parameters.Add("modifiedPMenu3", OracleDbType.Varchar2).Value = modifiedPMenu3;
                    modifyCommand.Parameters.Add("programId", OracleDbType.Int32).Value = Convert.ToInt32(selectedPNO);
                    modifyCommand.Parameters.Add("selectedDate", OracleDbType.Date).Value = selectedDate;
                    modifyCommand.ExecuteNonQuery();
                }

                Odpconn.Close();
            }
        }


    }
}
