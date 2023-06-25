using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace uji_nafa
{
    public partial class Login : Form
    {
        public MySqlCommand cmd;
        public MySqlDataReader dr;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btLogin_Click(object sender, EventArgs e)
        {

            Koneksi.conn.Open();
            String query = "SELECT * FROM `users` WHERE `email` = '" + txtusername.Text + "' AND `password` = '" + txtpassword.Text + "'";
            cmd = new MySqlCommand(query, Koneksi.conn);
            dr = cmd.ExecuteReader();

            try
            {
                if (dr.Read())
                {
                    new Dashboard().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Ups! Username atau Password anda Salah");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Ups! Gagal Login");
            }

            Koneksi.conn.Close();
        }
    }
}
