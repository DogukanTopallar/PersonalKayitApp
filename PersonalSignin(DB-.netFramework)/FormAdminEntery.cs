using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Personal_SignIn;

namespace PersonalSignin_DB_.netFramework_
{
    public partial class FormAdminEntery : Form
    {
        public FormAdminEntery()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DOGUKAN\\SQLEXPRESS;Initial Catalog=PersonalDataBase;Integrated Security=True");


        private void btnLogin_Click(object sender, EventArgs e)
        {

            connection.Open();
            SqlCommand command = new SqlCommand("Select * From Table_Admin where UserName = @p1 and Password = @p2", connection);
            command.Parameters.AddWithValue("@p1", tbUserName.Text);
            command.Parameters.AddWithValue("@p2", tbPassword.Text);
            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                FormMain formMain = new FormMain();
                formMain.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Wrong username or password!");
            }
            connection.Close();

        }
    }
}
