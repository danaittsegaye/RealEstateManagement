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
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Forms
{
    public partial class FormListEstates : Form
    {
        DatabaseCore core = new DatabaseCore();
        public FormListEstates()
        {
            InitializeComponent();
            mapToTable("");
        }

        private void mapToTable(string searchKey)
        {
            tableListEstates.Rows.Clear();

            DataSet table;
            
            if (searchKey == "")
            {
                table = core.RunTableFunction(new SqlCommand("select * from ListEstate()"));
            }
            else
            {
                table = core.RunTableFunction(new SqlCommand(
                    "select * from EstateTableSearch('"+searchKey+"')"));
            }

            int i = 0;
            while (table.Tables[0].Rows.Count > i)
            {
                tableListEstates.Rows.Add(
                    table.Tables[0].Rows[i].ItemArray.GetValue(0).ToString(), 
                    table.Tables[0].Rows[i].ItemArray.GetValue(1).ToString(),
                    table.Tables[0].Rows[i].ItemArray.GetValue(2).ToString(),
                    table.Tables[0].Rows[i].ItemArray.GetValue(3).ToString(),
                    table.Tables[0].Rows[i].ItemArray.GetValue(4).ToString(),
                    table.Tables[0].Rows[i].ItemArray.GetValue(5).ToString(),
                    table.Tables[0].Rows[i].ItemArray.GetValue(6).ToString(),
                    table.Tables[0].Rows[i].ItemArray.GetValue(7).ToString(),
                    table.Tables[0].Rows[i].ItemArray.GetValue(8).ToString(),
                    table.Tables[0].Rows[i].ItemArray.GetValue(9).ToString(),
                    table.Tables[0].Rows[i].ItemArray.GetValue(10).ToString(),
                    table.Tables[0].Rows[i].ItemArray.GetValue(11).ToString(),
                    table.Tables[0].Rows[i].ItemArray.GetValue(12).ToString());
                i++;
            }

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //edit
            if (DatabaseCore.user =="m" || DatabaseCore.user == "r")
            {
                int id = int.Parse(tableListEstates.SelectedRows[0].Cells[0].Value.ToString());
                EstatePopUp p = new EstatePopUp(id);

                DialogResult results = p.ShowDialog();
                mapToTable("");
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //delete
            if (DatabaseCore.user == "m")
            {
                int id = int.Parse(tableListEstates.SelectedRows[0].Cells[0].Value.ToString());
            
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter("@id", id));

                core.RunStored_Procedure("[SP_DeleteEstate]", parameters);
                MessageBox.Show("item deleted");
                mapToTable("");
            }
        }
        

        private void btnSearch_Click(object sender, EventArgs e)
        {
            mapToTable(textBoxSearch.Text);
        }
    }
}
