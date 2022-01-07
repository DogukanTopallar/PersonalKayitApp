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

namespace PersonalSignin_DB_.netFramework_
{
    public partial class FormGraphs : Form
    {
        public FormGraphs()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DOGUKAN\\SQLEXPRESS;Initial Catalog=PersonalDataBase;Integrated Security=True");


        private void FormGraphs_Load(object sender, EventArgs e)
        {
            //Graph 1
            connection.Open();

            SqlCommand graph1 = new SqlCommand("Select PerCity, Count(*) From Table_Personal Group by PerCity", connection);
            SqlDataReader dataReader1 = graph1.ExecuteReader();
            while (dataReader1.Read())
            {
                chart1.Series["Cities"].Points.AddXY(dataReader1[0], dataReader1[1]);
            }

            connection.Close();

            //Graph 2
            connection.Open();

            SqlCommand graph2 = new SqlCommand("Select PerJob , Avg(PerSalary) From Table_Personal group by PerJob", connection);
            SqlDataReader dataReader2 = graph2.ExecuteReader();
            while (dataReader2.Read())
            {
                chart2.Series["Job-Salary"].Points.AddXY(dataReader2[0], dataReader2[1]);
            }

            connection.Close();




        }
    }
}
