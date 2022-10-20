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
using WindowsFormsApp1.Forms.PopUps;

namespace RealEstateManagmentSystem
{
    public partial class FormContractsList : Form
    {
        DatabaseCore core = new DatabaseCore();
        private void view_contract(string searchKey)
        {
            tableListContracts.Rows.Clear();
            DataSet contracts;


            if (searchKey == "")
            {
                contracts = core.RunTableFunction(new SqlCommand(" select * from viewContract()"));
            }
            else
            {
                contracts = core.RunTableFunction(new SqlCommand(
                    "select * from ContractTableSearch('" + searchKey + "')"));
            }

            int i = 0;
            while (contracts.Tables[0].Rows.Count > i)
            {
                var a = contracts.Tables[0].Rows[i];
                tableListContracts.Rows.Add(a.ItemArray.GetValue(0).ToString(),
                    a.ItemArray.GetValue(1).ToString(),
                    a.ItemArray.GetValue(2).ToString(),
                    a.ItemArray.GetValue(3).ToString(),
                    a.ItemArray.GetValue(4).ToString(),
                    a.ItemArray.GetValue(5).ToString(),
                    a.ItemArray.GetValue(6).ToString(),
                    a.ItemArray.GetValue(7).ToString(),
                    a.ItemArray.GetValue(8).ToString(),
                    a.ItemArray.GetValue(9).ToString(),
                    a.ItemArray.GetValue(10).ToString(),
                    a.ItemArray.GetValue(11).ToString()
                    );
                i++;

            }
        }
        public FormListContracts()
        {
            InitializeComponent();
            view_contract("");
        }

        private void tableListContracts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            view_contract(textBoxSearch.Text);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DatabaseCore.user == "m")
            {

            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DatabaseCore.user == "m" || DatabaseCore.user == "r")
            {
                int id = int.Parse(tableListContracts.SelectedRows[0].Cells[11].Value.ToString());
                ContractPopUp popUp = new ContractPopUp(id);
                popUp.ShowDialog();
                view_contract("");
            }
        }
    }
}