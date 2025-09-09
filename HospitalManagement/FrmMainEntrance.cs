using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnHastaLogin_Click(object sender, EventArgs e)
        {
            FrmPatientLogin fr = new FrmPatientLogin();
            fr.Show();
            this.Hide();
        }

        private void btnDoktorLogin_Click(object sender, EventArgs e)
        {
            FrmDoctorLogin fr = new FrmDoctorLogin();   
            fr.Show();
            this.Hide();
        }

        private void btnSekreterLogin_Click(object sender, EventArgs e)
        {
            FrmSecretaryLogin fr = new FrmSecretaryLogin();
            fr.Show();
            this.Hide();
        }
    }
}
