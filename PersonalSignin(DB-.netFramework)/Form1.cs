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

namespace Personal_SignIn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        SqlConnection connection = new SqlConnection("Data Source=DOGUKAN\\SQLEXPRESS;Initial Catalog=PersonalDataBase;Integrated Security=True");


        void clear()
        {
            tbPerID.Text = "";
            tbPerName.Text = "";
            tbPerSurname.Text = "";
            cbCity.Text = "";
            tbJob.Text = "";
            maskedTextBox1.Text = "";
            rbMarried.Checked = false;
            rbSingle.Checked = false;
            tbPerName.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personalDataBaseDataSet.Table_Personal' table. You can move, or remove it, as needed.
            //this.table_PersonalTableAdapter.Fill(this.personalDataBaseDataSet.Table_Personal);
            tbPerID.Visible = false;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            this.table_PersonalTableAdapter.Fill(this.personalDataBaseDataSet.Table_Personal);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();

            SqlCommand command = new SqlCommand("insert into Table_Personal(PerName,PerSurname,PerCity,PerSalary,PerMaritalStatus,PerJob) values (@p1,@p2,@p3,@p4,@p5,@p6)", connection); //p = parameter
            command.Parameters.AddWithValue("@p1", tbPerName.Text);
            command.Parameters.AddWithValue("@p2", tbPerSurname.Text);
            command.Parameters.AddWithValue("@p3", cbCity.Text);
            command.Parameters.AddWithValue("@p4", maskedTextBox1.Text);
            command.Parameters.AddWithValue("@p5", lblRadioButtonStatus.Text);
            command.Parameters.AddWithValue("@p6", tbJob.Text);
            command.ExecuteNonQuery(); //Sorguyu çalıştırır. Ekleme silme ve güncellemelerde kullanılır. Tabloda değişiklik olduğunda kullanılır.
            connection.Close();

            MessageBox.Show("Personal Added!");
        }
       

        private void rbMarried_CheckedChanged(object sender, EventArgs e)
        {
            lblRadioButtonStatus.Text = "True";
        }

        private void rbSingle_CheckedChanged(object sender, EventArgs e)
        {
            lblRadioButtonStatus.Text = "false";

        }

        private void btnGrapsh_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
