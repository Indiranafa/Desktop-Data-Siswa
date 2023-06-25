using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uji_nafa
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void btSiswa_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            Fill.Visible = false;
            Siswa FormAktif = new Siswa();

            FormAktif.MdiParent = this;
            FormAktif.Show();
            label1.Text = "Kelola Data Siswa";
        }

        private void btGuru_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            Fill.Visible = false;
            Guru FormAktif = new Guru();

            FormAktif.MdiParent = this;
            FormAktif.Show();
            label1.Text = "Kelola Data Guru";
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            Fill.Visible = true;
            label1.Text = "Aplikasi Pendataan Nilai";
        }

        private void btMapel_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            Fill.Visible = false;
            Mapel FormAktif = new Mapel();

            FormAktif.MdiParent = this;
            FormAktif.Show();
            label1.Text = "Kelola Data Mata Pelajaran";
        }

        private void btNilai_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            Fill.Visible = false;
            Nilai FormAktif = new Nilai();

            FormAktif.MdiParent = this;
            FormAktif.Show();
            label1.Text = "Kelola Data Nilai";
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }
    }
}
