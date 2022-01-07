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
using PersonalSignin_DB_.netFramework_;

namespace Personal_SignIn
{
    public partial class FormMain : Form
    {
        public FormMain()
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
            this.table_PersonalTableAdapter.Fill(this.personalDataBaseDataSet.Table_Personal);
            tbPerID.Visible = false;
            lblMaritalStatus.Visible = false;
            
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            this.table_PersonalTableAdapter.Fill(this.personalDataBaseDataSet.Table_Personal);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
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
            if (rbMarried.Checked == true)
            {
                lblMaritalStatus.Text = "True";
            }

        }

        private void rbSingle_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMarried.Checked == true)
            {
                lblMaritalStatus.Text = "False";
            }
        }

        private void btnGrapsh_Click(object sender, EventArgs e)
        {
            FormGraphs formGrapsh = new FormGraphs();
            formGrapsh.Show();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            connection.Open();

            SqlCommand commandDelete = new SqlCommand("Delete From Table_Personal Where PerID=@k1", connection);
            commandDelete.Parameters.AddWithValue("@k1", tbPerID.Text);
            commandDelete.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Data Deleted!");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedValue = dataGridView1.SelectedCells[0].RowIndex;

            tbPerID.Text = dataGridView1.Rows[selectedValue].Cells[0].Value.ToString();
            tbPerName.Text = dataGridView1.Rows[selectedValue].Cells[1].Value.ToString();
            tbPerSurname.Text = dataGridView1.Rows[selectedValue].Cells[2].Value.ToString();
            cbCity.Text = dataGridView1.Rows[selectedValue].Cells[3].Value.ToString();
            maskedTextBox1.Text = dataGridView1.Rows[selectedValue].Cells[4].Value.ToString();
            lblMaritalStatus.Text = dataGridView1.Rows[selectedValue].Cells[5].Value.ToString();
            tbJob.Text = dataGridView1.Rows[selectedValue].Cells[6].Value.ToString();

        }

        private void lblMaritalStatus_TextChanged(object sender, EventArgs e)
        {
            if (lblMaritalStatus.Text == "True")
            {
                rbMarried.Checked = true;
            }

            if (lblMaritalStatus.Text == "False")
            {
                rbSingle.Checked = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            connection.Open();

            SqlCommand commandUpdate = new SqlCommand("Update Table_Personal Set PerName=@a1,PerSurname=@a2,PerCity=@a3, PerSalary=@a4, PerMaritalStatus=@a5,PerJob=@a6 where perID = @a7", connection);
            commandUpdate.Parameters.AddWithValue("@a1", tbPerName.Text);
            commandUpdate.Parameters.AddWithValue("@a2", tbPerSurname.Text);
            commandUpdate.Parameters.AddWithValue("@a3", cbCity.Text);
            commandUpdate.Parameters.AddWithValue("@a4", maskedTextBox1.Text);
            commandUpdate.Parameters.AddWithValue("@a5", lblMaritalStatus.Text);
            commandUpdate.Parameters.AddWithValue("@a6", tbJob.Text);
            commandUpdate.Parameters.AddWithValue("@a7", tbPerID.Text);
            commandUpdate.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Data Updated!");

        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            FormStatistic formStatistic = new FormStatistic();
            formStatistic.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
