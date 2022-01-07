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
    public partial class FormStatistic : Form
    {
        public FormStatistic()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DOGUKAN\\SQLEXPRESS;Initial Catalog=PersonalDataBase;Integrated Security=True");

        private void FormStatistic_Load(object sender, EventArgs e)
        {
            //Number of Total Staff
            connection.Open();
            SqlCommand command1 = new SqlCommand("Select Count(*) From Table_Personal", connection);

            SqlDataReader dataReader1 = command1.ExecuteReader(); //ExecuteReader select için sorguyu çalıştırır. 
            while (dataReader1.Read())
            {
                lblTotalStaff.Text = dataReader1[0].ToString();
            }
            connection.Close();

            //Number of Married Staff
            connection.Open();
            SqlCommand command2 = new SqlCommand("Select Count(*) From Table_Personal where PerMaritalStatus=1", connection);

            SqlDataReader dataReader2 = command2.ExecuteReader(); //ExecuteReader select için sorguyu çalıştırır. 
            while (dataReader2.Read())
            {
                lblMarriedStaff.Text = dataReader2[0].ToString();
            }
            connection.Close();

            //Number of Single Staff
            connection.Open();
            SqlCommand command3 = new SqlCommand("Select Count(*) From Table_Personal where PerMaritalStatus=0", connection);

            SqlDataReader dataReader3 = command3.ExecuteReader(); //ExecuteReader select için sorguyu çalıştırır. 
            while (dataReader3.Read())
            {
                lblSingleStaff.Text = dataReader3[0].ToString();
            }
            connection.Close();

            //Number of Different Cities
            connection.Open();
            SqlCommand command4 = new SqlCommand("Select count(distinct (PerCity)) From Table_Personal", connection); // distinct gelen iki aynı şehiri tekrarsız olarak bir sayar.

            SqlDataReader dataReader4 = command4.ExecuteReader(); //ExecuteReader select için sorguyu çalıştırır. 
            while (dataReader4.Read())
            {
                lblDifferentCities.Text = dataReader4[0].ToString();
            }
            connection.Close();

            //Number of Total Salary
            connection.Open();
            SqlCommand command5 = new SqlCommand("Select sum(PerSalary) From Table_Personal", connection);

            SqlDataReader dataReader5 = command5.ExecuteReader(); //ExecuteReader select için sorguyu çalıştırır. 
            while (dataReader5.Read())
            {
                lblTotalSalary.Text = dataReader5[0].ToString() + "₺";
            }
            connection.Close();

            //Number of Average Salary
            connection.Open();
            SqlCommand command6 = new SqlCommand("Select avg(PerSalary) From Table_Personal", connection);

            SqlDataReader dataReader6 = command6.ExecuteReader(); //ExecuteReader select için sorguyu çalıştırır. 
            while (dataReader6.Read())
            {
                lblAverageSalary.Text = dataReader6[0].ToString() + "₺";
            }
            connection.Close();

        }
    }
}
