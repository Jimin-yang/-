using Oracle.DataAccess.Client;
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
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Globalization;
using System.Xml.Linq;
using System.Diagnostics.PerformanceData;



namespace PT_Project
{
    public partial class 식단작성 : Form
    {
        private OracleConnection Odpconn = new OracleConnection();
        private OracleDataAdapter adapter = new OracleDataAdapter();
        private loginF loginform;
        private int userid;

        public 식단작성(loginF loginForm)
        {
            InitializeComponent();
            loginform = loginForm;
        }

        private void 식단작성_Load(object sender, EventArgs e)
        {
            userid = loginform.getusernumber;
            dataGridView1.Columns.Clear();
            SetupDataGridViewColumns();
            using (OracleConnection Odpconn = new OracleConnection("User Id=ptadmin;Password=1111;Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)))"))
            {
                Odpconn.Open();
                string strqry = "select * from Consumerdiet where P_NO=:programId";
                string strqry2 = "select * from program where U_NO=:userid";
                string strqry3 = "select T_NAME from Trainer where T_NO=:trainerID";

                OracleCommand OraCmd = new OracleCommand(strqry, Odpconn);
                OracleCommand OraCmd2 = new OracleCommand(strqry2, Odpconn);
                OracleCommand OraCmd3 = new OracleCommand(strqry3, Odpconn);
                OraCmd2.Parameters.Add("userid", OracleDbType.Int32).Value = userid;

                OracleDataReader odr2 = OraCmd2.ExecuteReader(); // 두 번째 쿼리 실행

                while (odr2.Read())
                {
                    int P_NO = Convert.ToInt32(odr2["P_NO"]);
                    int T_NO = Convert.ToInt32(odr2["T_NO"]);

                    lb_prname.Text = Convert.ToString(odr2["P_Outline"]);
                    lb_pnum.Text = Convert.ToString(odr2["P_NO"]);
                    txt_demand.Text = Convert.ToString(odr2["P_Demand"]);
                    txt_search.Text = Convert.ToString(odr2["P_NO"]);
                    OraCmd.Parameters.Add("programId", OracleDbType.Int32).Value = P_NO;
                    OraCmd3.Parameters.Add("trainerId", OracleDbType.Int32).Value = T_NO;

                    OracleDataReader odr = OraCmd.ExecuteReader(); // 첫 번째 쿼리 실행
                    OracleDataReader odr3 = OraCmd3.ExecuteReader();

                    while (odr3.Read())
                    {
                        lb_trainerName.Text = Convert.ToString(odr3["T_NAME"]);
                    }
                }

                odr2.Close();

                // ConsumerDiet 테이블에서 데이터를 가져와서 DataGridView에 표시
                string consumerDietQuery = "SELECT * FROM ConsumerDiet WHERE P_NO = :programId";
                adapter.SelectCommand = new OracleCommand(consumerDietQuery, Odpconn);
                adapter.SelectCommand.Parameters.Add("programId", OracleDbType.Int32).Value = Convert.ToInt32(lb_pnum.Text);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, "ConsumerDiet");
                dataGridView1.DataSource = dataSet.Tables["ConsumerDiet"];

                Odpconn.Close();
            }
        }


        private void delete_btn_Click(object sender, EventArgs e)
        {
            // DataGridView에서 선택된 행 확인
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // 선택된 행에서 P_DATE 값을 가져옴
                DateTime selectedDate = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells["P_DATE"].Value);

                // P_DATE 값에 해당하는 데이터를 ConsumerDiet 테이블에서 삭제
                DeleteConsumerDiet(selectedDate);

                // DataGridView에서 선택된 행을 삭제
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);

                MessageBox.Show("데이터가 삭제되었습니다.");
            }
            else
            {
                MessageBox.Show("삭제할 행을 선택하세요.");
            }
        }

        private void DeleteConsumerDiet(DateTime selectedDate)
        {
            using (OracleConnection Odpconn = new OracleConnection("User Id=ptadmin;Password=1111;Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)))"))
            {
                Odpconn.Open();

                // P_NO와 P_DATE 값에 해당하는 데이터를 ConsumerDiet 테이블에서 삭제하는 쿼리
                string deleteQuery = "DELETE FROM ConsumerDiet WHERE P_NO = :programId AND P_DATE = :selectedDate";
                using (OracleCommand deleteCommand = new OracleCommand(deleteQuery, Odpconn))
                {
                    deleteCommand.Parameters.Add("programId", OracleDbType.Int32).Value = Convert.ToInt32(lb_pnum.Text);
                    deleteCommand.Parameters.Add("selectedDate", OracleDbType.Date).Value = selectedDate;
                    deleteCommand.ExecuteNonQuery();
                }

                Odpconn.Close();
            }
        }



        private void search_btn_Click(object sender, EventArgs e)
        {
            // 사용자가 입력한 값을 가져옴
            int selectedPNO = Convert.ToInt32(txt_search.Text);

            // 회원식단작성2 폼을 생성할 때 selectedPNO 값을 전달
            회원식단작성2 frm2 = new 회원식단작성2(selectedPNO);
            frm2.Owner = this;

            // 생성자를 통해 selectedPNO 값을 전달
            frm2.ShowDialog();
            frm2.Dispose();
        }


        public String TxtS //속성 설정
        {
            get { return txt_search.Text; }
            set { txt_search.Text = value.ToString(); }
        }

        private void modify_btn_Click(object sender, EventArgs e)
        {
            // DataGridView에서 선택된 행 확인
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // 선택된 행에서 P_DATE 값을 가져옴
                DateTime selectedDate = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells["P_DATE"].Value);

                // P_DATE 값에 해당하는 데이터를 ConsumerDiet 테이블에서 가져와서 폼에 전달
                // 생성자에 선택된 날짜를 전달하도록 수정
                회원식단작성2 frm2 = new 회원식단작성2(Convert.ToInt32(lb_pnum.Text));
                frm2.Owner = this;

                // 생성자를 통해 데이터 전달 후 폼을 실행
                frm2.ShowDialog();
                frm2.Dispose();
            }
            else
            {
                MessageBox.Show("수정할 행을 선택하세요.");
            }
        }

        private void append_btn_Click(object sender, EventArgs e)
        {
            // 현재 프로그램의 P_NO
            int currentProgramNo = Convert.ToInt32(lb_pnum.Text);

            // 새로운 폼 생성
            using (appendform appendForm = new appendform(currentProgramNo))
            {
                if (appendForm.ShowDialog() == DialogResult.OK)
                {
                    // 사용자가 확인을 눌렀을 때 데이터를 테이블에 추가
                    string text1 = appendForm.TextBox1Text;
                    string text2 = appendForm.TextBox2Text;
                    string text3 = appendForm.TextBox3Text;

                    // 현재 시간 가져오기
                    DateTime currentTime = DateTime.Now;

                    // 테이블에 데이터 추가
                    InsertDataIntoTable(currentProgramNo, currentTime, text1, text2, text3);

                    // DataGridView 갱신
                    RefreshDataGridView();
                }
            }
        }
        private void InsertDataIntoTable(int programNo, DateTime currentTime, string text1, string text2, string text3)
        {
            using (OracleConnection Odpconn = new OracleConnection("User Id=ptadmin;Password=1111;Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)))"))
            {
                string currentTimeString = currentTime.ToString("yyyy-MM-dd");
                Odpconn.Open();
                string combinedText = $"{text1}@{text2}@{text3}";
                string insertQuery = "INSERT INTO ConsumerDiet (P_NO, P_DATE, P_Menu, P_Grade, P_Feedback) VALUES (:programNo, :currentTime, :combinedText, null, null)";
                using (OracleCommand insertCommand = new OracleCommand(insertQuery, Odpconn))
                {
                    insertCommand.Parameters.Add("programNo", OracleDbType.Int32).Value = programNo;
                    insertCommand.Parameters.Add("currentTime", OracleDbType.Date).Value = currentTimeString;
                    insertCommand.Parameters.Add("combinedText", OracleDbType.Varchar2).Value = combinedText;
  

                    insertCommand.ExecuteNonQuery();
                }

                Odpconn.Close();
            }
        }

        public void RefreshDataGridView()
        {
            using (OracleConnection Odpconn = new OracleConnection("User Id=ptadmin;Password=1111;Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)))"))
            {
                Odpconn.Open();
                // 현재 프로그램의 P_NO
                int currentProgramNo = Convert.ToInt32(lb_pnum.Text);

            // ConsumerDiet 테이블에서 데이터를 가져와서 DataGridView에 표시
            string consumerDietQuery = "SELECT * FROM ConsumerDiet WHERE P_NO = :programId";
            adapter.SelectCommand = new OracleCommand(consumerDietQuery, Odpconn);
            adapter.SelectCommand.Parameters.Add("programId", OracleDbType.Int32).Value = currentProgramNo;
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "ConsumerDiet");
            dataGridView1.DataSource = dataSet.Tables["ConsumerDiet"];
                Odpconn.Close();
            }
        }

        private void SetupDataGridViewColumns()
        {
            // P_NO 열 추가
            DataGridViewTextBoxColumn pMenuColumn = new DataGridViewTextBoxColumn();
            pMenuColumn.HeaderText = "P_Menu";
            pMenuColumn.DataPropertyName = "P_Menu";
            dataGridView1.Columns.Add(pMenuColumn);

            // P_DATE 열 추가
            DataGridViewTextBoxColumn pGradeColumn = new DataGridViewTextBoxColumn();
            pGradeColumn.HeaderText = "P_Grade";
            pGradeColumn.DataPropertyName = "P_Grade";
            dataGridView1.Columns.Add(pGradeColumn);

            DataGridViewTextBoxColumn pFeedbackColumn = new DataGridViewTextBoxColumn();
            pFeedbackColumn.HeaderText = "P_Feedback";
            pFeedbackColumn.DataPropertyName = "P_Feedback";
            dataGridView1.Columns.Add(pFeedbackColumn);


            // 다른 열들을 숨기기
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                if (column.Name != "P_Menu" && column.Name != "P_Grade" && column.Name != "P_Feedback")
                {
                    column.Visible = false;
                }
            }
        }
    }


}