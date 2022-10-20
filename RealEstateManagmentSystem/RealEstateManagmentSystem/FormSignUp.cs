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
    public partial class FormSignUp : Form
    {
        public FormSignUp()
        {
            InitializeComponent();
        }
        private void signUp()
        {
            DatabaseCore core = new DatabaseCore();
            //DatabaseCore.closeConnection();
            DatabaseCore.connectToDB("p", "p");

            List<SqlParamater> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParamater("@first_name", textBoxFirstName.Text));
            parameters.Add(new SqlParamater("@last_name", textBoxLastName.Text));
            parameters.Add(new SqlParamater("@phone", textBoxPhone.Text));
            parameters.Add(new SqlParamater("@address", textBoxAddress.Text));
            parameters.Add(new SqlParamater("@id", new Random().Next()));
            parameters.Add(new SqlParamater("@email", textBoxEmail.Text));
            parameters.Add(new SqlParamater("@password", textBoxPassword.Text));
            parameters.Add(new SqlParamater("@role", "user"));
            core.RunStored_Procedure("[SP_addEmployee]", parameters);
        }

        private bool checkIfEmpty()
        {
            if (textBoxFirstName.Text == "" || textBoxLastName.Text == "" || textBoxPhone.Text == "" || textBoxAddress.Text == "" || textBoxEmail.Text == "")
            {
                MessageBox.Show("Please enter all the field to sign up");
                return true;

            }
            return false;
        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (!checkIfEmpty())
            {
                if (textBoxPassword.Text == textBoxConfirmPaasword.Text)
                {
                    try
                    {
                        signUp();

                        new MainWindow(textBoxFirstName.Text + " " + textBoxLastName.Text).Show();
                        this.Hide();
                    }
                    catch (SqlException exception)
                    {
                        MessageBox.Show(exception.ToString());
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("this email is already in use");
                        throw;

                    }
                }
                else
                {
                    MessageBox.Show("Wrong Pasword");

                }

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
