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

namespace PT_Project
{
    public partial class 회원상세 : Form
    {
        private int SelectID;
        DBClass dbc = new DBClass(); //*****DBClass 객체 생성
        private void ClearTextBoxes()
        {
            txtname.Clear();
            txtage.Clear();
            txtheight.Clear();
            txtweight.Clear();
            txtphone.Clear();
            txtptdate.Clear();
            txtptlast.Clear();
        }
        public 회원상세(int Num)
        {
            InitializeComponent();
            dbc.DB_ObjCreate(); // *****
            SelectID = Num;
            dbc.DB_Open(SelectID); // *****
            
        }

        private void DAOpenBtn_Click(object sender, EventArgs e)
        {
            try
            {
                dbc.DS.Clear();
                dbc.DBAdapter.Fill(dbc.DS, "consumer");
                DBGrid.DataSource = dbc.DS.Tables["consumer"].DefaultView;
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
            catch (Exception DE)
            {
                MessageBox.Show(DE.Message);
            }
        }


        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string updateQuery = "UPDATE consumer SET cname = :이름, cage = :나이, cheight = :키, cweight = :몸무게, phone = :전화번호 WHERE U_NO = :회원번호";

                using (OracleConnection connection = new OracleConnection("User Id=ptadmin; Password=1111; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = xe) ) )"))
                {
                    connection.Open();

                    using (OracleCommand command = new OracleCommand(updateQuery, connection))
                    {
                        command.Parameters.Add(":이름", OracleDbType.Varchar2).Value = txtname.Text;
                        command.Parameters.Add(":나이", OracleDbType.Varchar2).Value = txtage.Text;
                        command.Parameters.Add(":키", OracleDbType.Varchar2).Value = txtheight.Text;
                        command.Parameters.Add(":몸무게", OracleDbType.Varchar2).Value = txtweight.Text;
                        command.Parameters.Add(":전화번호", OracleDbType.Varchar2).Value = txtphone.Text;
                        command.Parameters.Add(":회원번호", OracleDbType.Varchar2).Value = SelectID.ToString();

                        int rowsUpdated = command.ExecuteNonQuery();

                        if (rowsUpdated > 0)
                        {
                            MessageBox.Show("데이터가 성공적으로 업데이트되었습니다.");
                        }
                        else
                        {
                            MessageBox.Show("변경된 데이터가 없습니다.");
                        }
                    }
                }

                // DB 업데이트 후 그리드 다시 로드
                DAOpenBtn_Click(sender, e);
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }





        private void DBGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                DataTable DBTable = dbc.DS.Tables["consumer"];
                if (e.RowIndex < 0)
                {
                    return;
                }
                else if (e.RowIndex > DBTable.Rows.Count - 1)
                {
                    MessageBox.Show("해당하는 데이터가 존재하지 않습니다.");
                    return;
                }
                DataRow currRow = DBTable.Rows[e.RowIndex];
                txtname.Text = currRow["이름"].ToString();
                txtage.Text = currRow["나이"].ToString();
                txtheight.Text = currRow["키"].ToString();
                txtweight.Text = currRow["몸무게"].ToString();
                txtphone.Text = currRow["전화번호"].ToString();
                txtptdate.Text = currRow["PT기간"].ToString();
                txtptlast.Text = currRow["PT남은일수"].ToString();
                dbc.SelectedRowIndex = Convert.ToInt32(currRow["회원번호"]);
            }
            catch (DataException DE)
            { MessageBox.Show(DE.Message); }
            catch (Exception DE)
            { MessageBox.Show(DE.Message); }
        }

        private void 회원상세_Load(object sender, EventArgs e)
        {

        }
    }
}
