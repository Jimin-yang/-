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
    public partial class 식단작성 : Form
    {
        DBClass dbc = new DBClass(); //*****DBClass 객체 생성
        private void ClearTextBoxes()
        {
            txtid.Clear();
            txtname.Clear();
            txtage.Clear();
            txtheight.Clear();
            txtphone.Clear();
            txtptdate.Clear();
            txtptlast.Clear();
        }
        public 식단작성()
        {
            InitializeComponent();
            dbc.DB_ObjCreate(); // *****
            dbc.DB_Open(); // *****
        }

        private void DAOpenBtn_Click(object sender, EventArgs e)
        {
            try
            {
                dbc.DS.Clear();
                dbc.DBAdapter.Fill(dbc.DS, "customer");
                DBGrid.DataSource = dbc.DS.Tables["customer"].DefaultView;
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

        private void AppendBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("텍스트 상자에 모든 데이터 입력하셨으면 추가합니다!");
                //DS.Clear();
                //DBAdapter.Fill(DS, "Phone");
                dbc.CustomerTable = dbc.DS.Tables["Customer"]; //*
                DataRow newRow = dbc.CustomerTable.NewRow();
                newRow["id"] = Convert.ToInt32(txtid.Text);
                newRow["cName"] = txtname.Text;
                newRow["cage"] = txtage.Text;
                newRow["cheight"] = txtheight.Text;
                newRow["phone"] = txtphone.Text;
                newRow["cptdate"] = txtptdate.Text;
                newRow["cptlastdate"] = txtptlast.Text;
                dbc.CustomerTable.Rows.Add(newRow);
                dbc.DBAdapter.Update(dbc.DS, "Customer");
                dbc.DS.AcceptChanges();
                ClearTextBoxes();
                DBGrid.DataSource = dbc.DS.Tables["Customer"].DefaultView;
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
                //DS.Clear();
                //DBAdapter.Fill(DS, "Phone");
                dbc.CustomerTable = dbc.DS.Tables["Customer"];
                DataColumn[] PrimaryKey = new DataColumn[1];
                PrimaryKey[0] = dbc.CustomerTable.Columns["id"];
                dbc.CustomerTable.PrimaryKey = PrimaryKey;
                DataRow currRow = dbc.CustomerTable.Rows.Find(dbc.SelectedRowIndex);
                currRow.BeginEdit();
                currRow["id"] = txtid.Text;
                currRow["cName"] = txtname.Text;
                currRow["cage"] = txtage.Text;
                currRow["cheight"] = txtheight.Text;
                currRow["phone"] = txtphone.Text;
                currRow["cptdate"] = txtptdate.Text;
                currRow["cptlastdate"] = txtptlast.Text;
                currRow.EndEdit();
                DataSet UpdatedSet = dbc.DS.GetChanges(DataRowState.Modified);
                if (UpdatedSet.HasErrors)
                { MessageBox.Show("변경된 데이터에 문제가 있습니다."); }
                else
                { dbc.DBAdapter.Update(UpdatedSet, "Customer"); dbc.DS.AcceptChanges(); }
                DBGrid.DataSource = dbc.DS.Tables["Customer"].DefaultView;
            }
            catch (DataException DE)
            { MessageBox.Show(DE.Message); }
            catch (Exception DE)
            { MessageBox.Show(DE.Message); }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //DS.Clear();
                //DBAdapter.Fill(DS, "Phone");
                dbc.CustomerTable = dbc.DS.Tables["Phone"];
                DataColumn[] PrimaryKey = new DataColumn[1];
                PrimaryKey[0] = dbc.CustomerTable.Columns["id"];
                dbc.CustomerTable.PrimaryKey = PrimaryKey;
                DataRow currRow = dbc.CustomerTable.Rows.Find(dbc.SelectedRowIndex);
                currRow.Delete();
                dbc.DBAdapter.Update(dbc.DS.GetChanges(DataRowState.Deleted), "Customer");
                DBGrid.DataSource = dbc.DS.Tables["Customer"].DefaultView;
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

        private void DBGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //DataSet DS = new DataSet();
                //DBAdapter.Fill(DS, "Phone");
                DataTable CustomerTable = dbc.DS.Tables["Customer"];
                if (e.RowIndex < 0)
                {
                    return;
                }
                else if (e.RowIndex > CustomerTable.Rows.Count - 1)
                {
                    MessageBox.Show("해당하는 데이터가 존재하지 않습니다.");
                    return;
                }
                DataRow currRow = CustomerTable.Rows[e.RowIndex];
                txtid.Text = currRow["id"].ToString();
                txtname.Text = currRow["cname"].ToString();
                txtage.Text = currRow["cage"].ToString();
                txtheight.Text = currRow["cheight"].ToString();
                txtphone.Text = currRow["phone"].ToString();
                txtptdate.Text = currRow["cptdate"].ToString();
                txtptlast.Text = currRow["cptlastdate"].ToString();
                dbc.SelectedRowIndex = Convert.ToInt32(currRow["id"]);
            }
            catch (DataException DE)
            { MessageBox.Show(DE.Message); }
            catch (Exception DE)
            { MessageBox.Show(DE.Message); }
        }
    }
}
