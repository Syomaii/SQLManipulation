using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLManipulation
{
    public partial class Form1 : Form
    {
        private OleDbConnection connection;
        public Form1()
        {
            InitializeComponent();
            connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Desktop\dev\2NDYEAR\2nd SEM\appsdev\SQLManipulation\KOMPANYA.accdb");
        }


        private void btnDETC_Click(object sender, EventArgs e)
        {
            
            string query = "SELECT EMPLOYEEFILE.EMPLOYEEIDNO, EMPLOYEEFILE.EMPLOYEEFIRSTNAME, EMPLOYEEFILE.EMPLOYEELASTNAME, TRAININGFILE.TRAININGCOURSE, EMPLOYEEFILE.EMPLOYEEDEPARTMENT FROM ((EMPLOYEEFILE INNER JOIN ATTENDANCEFILE ON EMPLOYEEFILE.EMPLOYEEIDNO = ATTENDANCEFILE.ATTENDANCETRAININGEMPLOYEEID) INNER JOIN TRAININGFILE ON ATTENDANCEFILE.ATTENDANCETRAININGCODE = TRAININGFILE.TRAININGCODE)";

            OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            // Set the data source of the DataGridView control to the filled DataTable
            dGrid1.DataSource = table;

            // Set the column names in the DataGridView control to match the columns provided
            dGrid1.Columns[0].HeaderText = "EMPLOYEEIDNO";
            dGrid1.Columns[1].HeaderText = "EMPLOYEEFIRSTNAME";
            dGrid1.Columns[2].HeaderText = "TRAININGCOURSE";
            dGrid1.Columns[3].HeaderText = "EMPLOYEEDEPARTMENT";
        }

        private void btnDTS_Click(object sender, EventArgs e)
        {
            string query = "Select Sum(EMPLOYEESALARY) from EMPLOYEEFILE";
            OleDbCommand command = new OleDbCommand(query, connection);
            connection.Open();
            object result = command.ExecuteScalar();
            connection.Close();

            if (result != DBNull.Value && result != null)
            {
                int totalSalary = Convert.ToInt32(result);
                MessageBox.Show(string.Format($"Total Salary = {result:C}"));
            }
            else
            {
                MessageBox.Show("No data found");
            }
        }

        private void btnDSLNSM_Click(object sender, EventArgs e)
        {
            string query = "SELECT AVG(EMPLOYEESALARY) FROM EMPLOYEEFILE WHERE EMPLOYEELASTNAME LIKE 'M%'";
            OleDbCommand command = new OleDbCommand(query, connection);
            connection.Open();
            object result = command.ExecuteScalar();
            connection.Close();

            if (result != DBNull.Value && result != null)
            {
                double aveSalary = Convert.ToDouble(result);
                MessageBox.Show(string.Format($"Average salary of employees whose last name starts with 'M' = {aveSalary:C}"));
            }
            else
            {
                MessageBox.Show("No data found");
            }
        }

        private void btnDPEADS_Click(object sender, EventArgs e)
        {
            string query = "Select EMPLOYEEIDNO as [ID NUMBER], EMPLOYEEFIRSTNAME as FIRSTNAME, EMPLOYEELASTNAME as LASTNAME, EMPLOYEESALARY as SALARY From EMPLOYEEFILE Where EMPLOYEEDEPARTMENT = 'PRODUCTION' And EMPLOYEESALARY > (SELECT AVG(EMPLOYEESALARY) FROM EMPLOYEEFILE WHERE EMPLOYEEDEPARTMENT = 'PRODUCTION')";
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            dGrid1.DataSource = table;
        }

        private void btnDTSDS_Click(object sender, EventArgs e)
        {
            string query = "SELECT SUM(EMPLOYEESALARY) FROM EMPLOYEEFILE WHERE EMPLOYEEDEPARTMENT = 'SALES'";
            OleDbCommand command = new OleDbCommand(query, connection);
            connection.Open();
            object result = command.ExecuteScalar();
            connection.Close();

            if (result != DBNull.Value && result != null)
            {
                int totalSalary = Convert.ToInt32(result);
                MessageBox.Show(string.Format($"Total salaries of SALES department employees = {totalSalary:C}"));
            }
            else
            {
                MessageBox.Show("No data found");
            }
        }

        private void btnDELS_Click(object sender, EventArgs e)
        {
            string query = "SELECT EMPLOYEEIDNO as [ID Number], EMPLOYEEFIRSTNAME + ' ' + EMPLOYEELASTNAME as [Full Name], EMPLOYEESALARY as Salary, EMPLOYEEDEPARTMENT as Department FROM EMPLOYEEFILE WHERE EMPLOYEESALARY = (SELECT MIN(EMPLOYEESALARY) FROM EMPLOYEEFILE)";
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            dGrid1.DataSource = table;
        }

        private void btnEAPAS_Click(object sender, EventArgs e)
        {
            string query = "SELECT EMPLOYEEIDNO, EMPLOYEEFIRSTNAME + ' ' + EMPLOYEELASTNAME as FULLNAME, EMPLOYEEDEPARTMENT, EMPLOYEESALARY FROM EMPLOYEEFILE WHERE EMPLOYEESALARY > (SELECT AVG(EMPLOYEESALARY) FROM EMPLOYEEFILE WHERE EMPLOYEEDEPARTMENT = 'PRODUCTION')";
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
            DataSet ds = new DataSet();
            try
            {
                connection.Open();
                adapter.Fill(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
            if (ds.Tables.Count > 0)
                dGrid1.DataSource = ds.Tables[0];
            else
                MessageBox.Show("No tables found in DataSet");
        }

        private void btnDEMT_Click(object sender, EventArgs e)
        {
            string query = "SELECT EMPLOYEELASTNAME as [Last Name], COUNT(*) as [Training Count] FROM ATTENDANCEFILE INNER JOIN EMPLOYEEFILE ON ATTENDANCEFILE.ATTENDANCETRAININGEMPLOYEEID = EMPLOYEEFILE.EMPLOYEEIDNO GROUP BY EMPLOYEELASTNAME HAVING COUNT(*) > 1";
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            dGrid1.DataSource = table;

            dGrid1.Columns[0].HeaderText = "Last Name";
            dGrid1.Columns[1].HeaderText = "Training Count";
        }

        private void btnPAMT_Click(object sender, EventArgs e)
        {
            string query = "SELECT EMPLOYEEFILE.EMPLOYEEFIRSTNAME + ' ' + EMPLOYEEFILE.EMPLOYEELASTNAME AS [Full Name], EMPLOYEEFILE.EMPLOYEEDEPARTMENT AS [Department] " +
                                 "FROM ((ATTENDANCEFILE " +
                                 "INNER JOIN EMPLOYEEFILE ON ATTENDANCEFILE.ATTENDANCETRAININGEMPLOYEEID = EMPLOYEEFILE.EMPLOYEEIDNO) " +
                                 "INNER JOIN TRAININGFILE ON ATTENDANCEFILE.ATTENDANCETRAININGCODE = TRAININGFILE.TRAININGCODE) " +
                                 "WHERE TRAININGFILE.TRAININGCOURSE = 'ANGER MANAGEMENT'";

            OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            dGrid1.DataSource = table;
            dGrid1.Columns[0].HeaderText = "Full Name";
            dGrid1.Columns[1].HeaderText = "Department";
        }
    }
}
