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


namespace HospitalManagement
{
    public partial class FrmPatientLogin : Form
    {
        public FrmPatientLogin()
        {
            InitializeComponent();
        }
        SqlConnect bgl = new SqlConnect();

        private void lnkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmSignUp fr = new FrmSignUp();
            fr.Show();
           
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Patients Where PatientTC=@p1 and PatinetPassword=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTc.Text);
            komut.Parameters.AddWithValue("@p2", txtPassword.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read()) 
            {
                FrmPatientDetails fr = new FrmPatientDetails();
                fr.tc= MskTc.Text;
                fr.Show();
                this.Hide();
            
            }
            else
            {
                MessageBox.Show("Hatalı Tc veya Şifre");
            }
            bgl.baglanti().Close();
        }
    }
}
