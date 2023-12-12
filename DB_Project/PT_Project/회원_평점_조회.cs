using Oracle.DataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace PT_Project
{
    public partial class 회원평점조회 : Form
    {
        private int SelectID;
        private OracleConnection conn;  // 추가: OracleConnection 변수

        public 회원평점조회(int select)
        {
            InitializeComponent();
            SelectID = select;
            conn = new OracleConnection("User Id=ptadmin; Password=1111; Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));");

        }

        private void DAOpen_Click(object sender, EventArgs e)
        {
            conn.Open();

            string query = $"SELECT program.P_NO, T_Name as 트레이너, P_date as 작성날짜, P_Grade, P_Feedback FROM consumerDiet " +
                           "INNER JOIN program ON consumerDiet.P_NO = program.P_NO " +
                           "INNER JOIN trainer ON program.T_NO = trainer.T_NO " +
                           $"WHERE program.U_NO = {SelectID}";

            if (checkBox1.Checked)
            {
                DateTime selectedDate = dateTimePicker1.Value.Date;
                query += $" AND TO_CHAR(P_date, 'YYYY-MM-DD') = '{selectedDate.ToString("yyyy-MM-dd")}'";
            }

            if (checkBox2.Checked)
            {
                query += " AND P_Grade <= 3";
            }

            using (OracleCommand command = new OracleCommand(query, conn))
            {
                OracleDataAdapter adapter = new OracleDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                // 필요한 열만 선택
                DataTable filteredTable = new DataTable();
                filteredTable.Columns.Add("P_NO", typeof(int));  // 추가된 부분
                filteredTable.Columns.Add("트레이너", typeof(string));
                filteredTable.Columns.Add("작성날짜", typeof(DateTime));
                filteredTable.Columns.Add("P_Grade", typeof(int));
                filteredTable.Columns.Add("P_Feedback", typeof(string));

                foreach (DataRow row in table.Rows)
                {
                    filteredTable.Rows.Add(row["P_NO"], row["트레이너"], row["작성날짜"], row["P_Grade"], row["P_Feedback"]);
                }

                dataGridView1.DataSource = filteredTable;

                double averageRating = CalculateAverageRating(table);
                RatingAverage.Text = $"평균 평점: {averageRating:F2}";
            }
            dataGridView1.Columns["P_NO"].Visible = false;
            dataGridView1.Columns["P_Grade"].Visible = false;
            dataGridView1.Columns["P_Feedback"].Visible = false;

            conn.Close();  // 연결 닫기
        }

        private double CalculateAverageRating(DataTable table)
        {
            int count = 0;
            double totalRating = 0;

            foreach (DataRow row in table.Rows)
            {
                if (row["P_Grade"] != DBNull.Value)
                {
                    totalRating += Convert.ToDouble(row["P_Grade"]);
                    count++;
                }
            }

            if (count == 0)
                return 0;

            return totalRating / count;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                Rating.Text = selectedRow.Cells["P_Grade"].Value.ToString();
                comment.Text = selectedRow.Cells["P_Feedback"].Value.ToString();

                int P_NO = Convert.ToInt32(selectedRow.Cells["P_NO"].Value);

                DateTime selectedDate = dateTimePicker1.Value.Date;
                string dietQuery = $"SELECT P_Menu FROM consumerDiet WHERE P_NO = {P_NO} AND TO_CHAR(P_date, 'YYYY-MM-DD') = '{selectedDate.ToString("yyyy-MM-dd")}'";

                OracleCommand cmdDiet = new OracleCommand(dietQuery, conn);

                conn.Open();  // 연결 열기
                using (OracleDataReader odrDiet = cmdDiet.ExecuteReader())
                {
                    if (odrDiet.Read())
                    {
                        string m = Convert.ToString(odrDiet.GetValue(0));
                        int index1 = m.IndexOf("@");
                        int index2 = m.IndexOf("@", index1 + 1);
                        int length = m.Length;
                        string breakfast = m.Substring(0, index1);
                        string lunch = m.Substring(index1 + 1, index2 - index1 - 1);
                        string dinner = m.Substring(index2 + 1, length - index2 - 1);

                        breakfastTextBox.Text = breakfast;
                        lunchTextBox.Text = lunch;
                        dinnerTextBox.Text = dinner;
                    }
                }

                conn.Close();  // 연결 닫기
            }
            else
            {
                Rating.Text = string.Empty;
                comment.Text = string.Empty;
                breakfastTextBox.Text = string.Empty;
                lunchTextBox.Text = string.Empty;
                dinnerTextBox.Text = string.Empty;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            // CheckBox2에 대한 처리가 필요하다면 여기에 추가
        }
    }
}
