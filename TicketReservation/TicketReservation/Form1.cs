﻿using System;
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
    public partial class Form1 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        
        public Form1()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Jahan Zaib\Desktop\project C#\registration.mdb";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                checkConnection.Text = "Connection Successful";
                connection.Close();
            } catch(Exception ex)
            {
                MessageBox.Show("Error, Databse Not Connected!  " + ex);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "Select * from userLogin where username = '" + txt_username.Text + "' and password = '" + txt_password.Text + "' ";
            OleDbDataReader reader = command.ExecuteReader();
            int count = 0;
            while(reader.Read())
            {
                count = count + 1;


            }
            if (count == 1)
            {
                MessageBox.Show("Username and Password is Correct!");
                connection.Close();
                connection.Dispose();
                this.Hide();
                Form2 f2 = new Form2();
                f2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Wrong User and password");
            }
            


            connection.Close();
        }
    }
}
