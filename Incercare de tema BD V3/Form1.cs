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

namespace Incercare_de_tema_BD_V3
{
    public partial class Form1 : Form
    {
        String connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ELEVI;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            String sqlCommand = "SELECT * FROM STUDENTI";  
            using (connection)
            {
                connection.Open();
                SqlDataAdapter command = new SqlDataAdapter(sqlCommand, connection);

                DataTable dt = new DataTable();
                command.Fill(dt);
                StudentiDGV.AutoGenerateColumns = true;
                StudentiDGV.DataSource = dt;
            }
        }
    }
}
