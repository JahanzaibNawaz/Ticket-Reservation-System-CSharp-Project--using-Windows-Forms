using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace TicketReservation
{
    public partial class Details : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Details()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Jahan Zaib\Desktop\project C#\registration.mdb";
        }

        private void Details_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            
        }

        private void btn_View_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from register";
                command.CommandText = query;
                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                formView.DataSource = dt;




                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!  " + ex);
            };

        }

        
    }
}
