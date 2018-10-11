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
    public partial class Form2 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Form2()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Jahan Zaib\Desktop\project C#\registration.mdb";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "insert into register (cname, fname, address, travelFrom, travelTo, ticketid, payment) values ('"+c_name.Text+"','"+c_fname.Text+"', '"+c_address.Text+"','"+c_travelfrom.Text+"','"+c_travelto.Text+"','"+c_ticketid.Text
                    +"','"+c_payment.Text+"')";
                command.ExecuteNonQuery();
                MessageBox.Show("Data Saved");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!  " + ex);
            };
        }

        private void c_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void c_travelfrom_TextChanged(object sender, EventArgs e)
        {

        }

        private void c_travelto_TextChanged(object sender, EventArgs e)
        {

        }

        private void c_address_TextChanged(object sender, EventArgs e)
        {

        }

        private void c_fname_TextChanged(object sender, EventArgs e)
        {

        }

        private void c_ticketid_TextChanged(object sender, EventArgs e)
        {

        }

        private void c_payment_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Details op = new Details();
            op.ShowDialog();

        }
    }
}
