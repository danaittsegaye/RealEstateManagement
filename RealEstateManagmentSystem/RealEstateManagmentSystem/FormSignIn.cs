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

namespace RealEstateManagmentSystem
{
    public partial class FormSignIn : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        DatabaseCore core = new DatabaseCore();
        public FormSignIn()
        {
            InitializeComponent();
        }
        private bool signIn()
        {
            List<SqlParamater> paramaters = new List<SqlParamater>();
            paramaters.Add(new SqlParamater("@email", textBoxEmail.Text));
            paramaters.Add(new SqlParamater("@Password", textBoxPassword.Text));
            String ss = Core.RunScalar(@"SELECT[dbo].[EmployeeTableValidationUser](@email,@password)AS TotalEmployee;", paramaters);
            if (int.Parse(ss) == 1)
            {
                return true;
            }
            return false;
        }
        private Employee getEmployee()
        {
            var reder = core.RunTableFunction(new SqlCommand($"select * from findEmployeeByEmail('{textBoxEmail.Text}')"));
            getEmployee emp new Employee(reder.tables[0].Rows[0].ItemArray.Getvale(0).ToString(),
               reder.tables[0].Rows[0].ItemArray.Getvale(1).ToString(),
               reder.tables[0].Rows[0].ItemArray.Getvale(2).ToString(),
               reder.tables[0].Rows[0].ItemArray.Getvale(3).ToString(),
               reder.tables[0].Rows[0].ItemArray.Getvale(5).ToString());
            emp.role = reder.tables[0].Rows[0].ItemArray.Getvale(7).ToString();
            emp.id =int.Parse(reder.tables[0].Rows[0].ItemArray.Getvale(4).ToString());
            return emp;
        }

        private void btnSingIn_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = getEmployee();
                DatabaseCore.connectToDB("p", "p");

                if (SignIn())
                {
                    if (emp.role == "mannager")
                    {
                        DatabaseCore.closeConnection();
                        DatabaseCore.connectToDB("m", "m");

                    }
                    else if (emp.role == "realter")
                    {

                        DatabaseCore.closeConnection();
                        DatabaseCore.connectToDB("r", "r");
                    }
                    else
                    {
                        MessageBox.Show("In correct Login Info");

                    }
                }
                catch(SqlException exc)
            {
                Console.WriteLine(e);
                textBoxEmail.Text = "";
                textBoxPassword.Text = "";
                MessageBox.Show("encounter error of type : " + exc.message);
            }
        }
        private void panelTopBar_MouseDown(object sender,MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSingUp_Click(object sender, EventArgs e)
        {
            new FormSignIn().FormSignUp().Show();
            this.Hide();
        }
    }
}
