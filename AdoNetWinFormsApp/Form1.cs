using Microsoft.Data.SqlClient;
using System.Data;

namespace AdoNetWinFormsApp
{
    public partial class Form1 : Form
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AcademyDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        string sqlString = "SELECT * FROM Teacher";

        public Form1()
        {
            InitializeComponent();
            using(SqlConnection connection = new(connectionString))
            {
                SqlDataAdapter adapter = new(sqlString, connection);
                DataSet dataTechers = new DataSet();

                adapter.Fill(dataTechers);

                dataGridTeachers.AutoGenerateColumns = true;
                dataGridTeachers.DataSource = dataTechers.Tables[0].Copy();
                dataGridTeachers.Columns[0].HeaderText = "ָה";
                dataGridTeachers.Columns[0].Width = 30;
            }
        }
    }
}
