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
    public partial class FormListClients : Form
    {
        private DatabaseCore core = new DatabaseCore();
        public FormListClients()
        {
            InitializeComponent();
            fetchDataToList("");
        }
        //dfghjkl;

        private void fetchDataToList(string searchKey)
        {
            tableListClients.Rows.Clear();
            DataSet table;

            if (searchKey == "")
            {
                table = core.RunTableFunction(new SqlCommand("select client_name,client_address,contact_person,phone,email,client_detail from ListClients()"));
            }
            else
            {
                table = core.RunTableFunction(new SqlCommand(
                    "select client_name,client_address,contact_person,phone,email,client_detail from ClientTableSearch('" + searchKey + "')"));
            }


            int i = 0;
            while (table.Tables[0].Rows.Count > i)
            {
                tableListClients.Rows.Add(
                    table.Tables[0].Rows[i].ItemArray.GetValue(0).ToString(),
                    table.Tables[0].Rows[i].ItemArray.GetValue(1).ToString(),
                    table.Tables[0].Rows[i].ItemArray.GetValue(2).ToString(),
                    table.Tables[0].Rows[i].ItemArray.GetValue(3).ToString(),
                    table.Tables[0].Rows[i].ItemArray.GetValue(4).ToString(),
                    table.Tables[0].Rows[i].ItemArray.GetValue(5).ToString()
                    );
                i++;
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            fetchDataToList(textBoxSearch.Text);
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DatabaseCore.user == "m")
            {
                string email = (tableListClients.SelectedRows[0].Cells[4].Value.ToString());

                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter("@Email", email));

                core.RunStored_Procedure("[SP_deleteClient]", parameters);
                MessageBox.Show("item deleted");
                fetchDataToList("");
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DatabaseCore.user == "m" || DatabaseCore.user == "r")
            {
                ClientPopUp popUp = new ClientPopUp(tableListClients.SelectedRows[0].Cells[4].Value.ToString());
                popUp.ShowDialog();
                fetchDataToList("");
            }
            else
            {

            }
        }


    }
}
