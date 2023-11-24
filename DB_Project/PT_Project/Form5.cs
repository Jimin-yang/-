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
                dbc.ConsumerTable = dbc.DS.Tables["consumer"];
                DataColumn[] PrimaryKey = new DataColumn[1];
                PrimaryKey[0] = dbc.ConsumerTable.Columns["U_NO"];
                dbc.ConsumerTable.PrimaryKey = PrimaryKey;
                DataRow currRow = dbc.ConsumerTable.Rows.Find(dbc.SelectedRowIndex);
                currRow.BeginEdit();
                currRow["U_NO"] = SelectID.ToString();
                currRow["cName"] = txtname.Text;
                currRow["cage"] = txtage.Text;
                currRow["cheight"] = txtheight.Text;
                currRow["phone"] = txtphone.Text;
                currRow["시작날짜"] = txtptdate.Text;
                currRow["P_End"] = txtptlast.Text;
                currRow.EndEdit();
                DataSet UpdatedSet = dbc.DS.GetChanges(DataRowState.Modified);
                if (UpdatedSet.HasErrors)
                { MessageBox.Show("변경된 데이터에 문제가 있습니다."); }
                else
                { dbc.DBAdapter.Update(UpdatedSet, "consumer"); dbc.DS.AcceptChanges(); }
                DBGrid.DataSource = dbc.DS.Tables["consumer"].DefaultView;
            }
            catch (DataException DE)
            { MessageBox.Show(DE.Message); }
            catch (Exception DE)
            { MessageBox.Show(DE.Message); }
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
                txtname.Text = currRow["cname"].ToString();
                txtage.Text = currRow["cage"].ToString();
                txtheight.Text = currRow["cheight"].ToString();
                txtphone.Text = currRow["phone"].ToString();
                txtptdate.Text = currRow["PT기간"].ToString();
                txtptlast.Text = currRow["PT남은일수"].ToString();
                dbc.SelectedRowIndex = Convert.ToInt32(currRow["U_NO"]);
            }
            catch (DataException DE)
            { MessageBox.Show(DE.Message); }
            catch (Exception DE)
            { MessageBox.Show(DE.Message); }
        }
    }
}
