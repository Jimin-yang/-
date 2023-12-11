using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        private void DAOpen_Click(object sender, EventArgs e)
        {
            // TODO: 데이터베이스 연결 문자열을 수정해주세요.
            string connectionString = "User Id = ptadmin; Password = 1111; Data Source = (DESCRIPTION = (ADDRESS =(PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe))); ";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open();

                // TODO: SQL 쿼리를 수정해주세요.
                string query = $"SELECT T_Name as 트레이너, P_date as 작성날짜, P_Grade, P_Feedback FROM consumerDiet " +
                               "INNER JOIN program ON consumerDiet.P_NO = program.P_NO " +
                               "INNER JOIN trainer ON program.T_NO = trainer.T_NO " +
                               $"WHERE program.U_NO = {SelectID}";

                // 날짜 선택 체크박스가 체크되어 있으면 선택한 날짜의 데이터만 가져오도록 쿼리를 수정
                if (checkBox1.Checked)
                {
                    string selectedDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                    query += $" AND TO_CHAR(P_date, 'YYYY-MM-DD') = '{selectedDate}'";
                }

                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    OracleDataAdapter adapter = new OracleDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    // 필요한 열만 선택
                    DataTable filteredTable = new DataTable();
                    filteredTable.Columns.Add("트레이너", typeof(string));
                    filteredTable.Columns.Add("작성날짜", typeof(DateTime));
                    filteredTable.Columns.Add("P_Grade", typeof(int));
                    filteredTable.Columns.Add("P_Feedback", typeof(string));

                    foreach (DataRow row in table.Rows)
                    {
                        filteredTable.Rows.Add(row["트레이너"], row["작성날짜"], row["P_Grade"], row["P_Feedback"]);
                    }

                    dataGridView1.DataSource = filteredTable;

                    // TODO: 로그인한 회원의 평균 평점을 계산하고 출력하세요.
                    double averageRating = CalculateAverageRating(table);
                    RatingAverage.Text = $"평균 평점: {averageRating:F2}";
                }
            }
        }

        private double CalculateAverageRating(DataTable table)
        {
            if (table.Rows.Count == 0)
                return 0;

            double totalRating = 0;

            foreach (DataRow row in table.Rows)
            {
                if (row["P_Grade"] != DBNull.Value)
                    totalRating += Convert.ToDouble(row["P_Grade"]);
            }

            return totalRating / table.Rows.Count;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // 원래의 열 이름인 "P_Grade"와 "P_Feedback"을 사용
                Rating.Text = selectedRow.Cells["P_Grade"].Value.ToString();
                comment.Text = selectedRow.Cells["P_Feedback"].Value.ToString();
            }
            else
            {
                Rating.Text = string.Empty;
                comment.Text = string.Empty;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = checkBox1.Checked;
        }
    }
}
