using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Forms
{
    public partial class FormListEmployees : Form
    {
        DatabaseCore core = new DatabaseCore();
        public FormListEmployees()
        {
            InitializeComponent();
            fetchDataToList("");
        }

        private void fetchDataToList(string searchKey)
        {
            
            tableListEmployees.Rows.Clear();
            DataSet table;

            if (searchKey == "")
            {
                table = core.RunTableFunction(new SqlCommand(
                    "select first_name,last_name,phone,address,id,email,role from EmployeeTableGetAllEmployees()"));
            }
            else
            {
                table = core.RunTableFunction(new SqlCommand(
                    "select first_name,last_name,phone,address,id,email,role from EmployeeTableSearch('"+searchKey+"')"));
            }
            int i = 0;
            while (table.Tables[0].Rows.Count>i)
            {
                tableListEmployees.Rows.Add(table.Tables[0].Rows[i].ItemArray.GetValue(0).ToString(),table.Tables[0].Rows[i].ItemArray.GetValue(1).ToString(),table.Tables[0].Rows[i].ItemArray.GetValue(3).ToString(),table.Tables[0].Rows[i].ItemArray.GetValue(2).ToString(),table.Tables[0].Rows[i].ItemArray.GetValue(5).ToString(),table.Tables[0].Rows[i].ItemArray.GetValue(4).ToString());
                i++;
            }
        }

        private void FormListEmployees_DoubleClick(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (DatabaseCore.user == "m" || DatabaseCore.user =="r")
            {
                Employee emp = new Employee(tableListEmployees.SelectedRows[0].Cells[0].Value.ToString(),tableListEmployees.SelectedRows[0].Cells[1].Value.ToString(),tableListEmployees.SelectedRows[0].Cells[3].Value.ToString(),tableListEmployees.SelectedRows[0].Cells[2].Value.ToString(),tableListEmployees.SelectedRows[0].Cells[4].Value.ToString());
                emp.id = int.Parse(tableListEmployees.SelectedRows[0].Cells[5].Value.ToString());
            
                PopUp p = new PopUp(emp);
                DialogResult result = p.ShowDialog();
                fetchDataToList("");
            }
        }
        
        private void tableListEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (DatabaseCore.user == "m")
            {
                int id = int.Parse(tableListEmployees.SelectedRows[0].Cells[5].Value.ToString());
            
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter("@id", id));

                core.RunStored_Procedure("[SP_deleteEmployee]", parameters);
                MessageBox.Show("item deleted");
                fetchDataToList("");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            fetchDataToList(textBoxSearch.Text);
            textBoxSearch.Text = "";
        }
    }
}
