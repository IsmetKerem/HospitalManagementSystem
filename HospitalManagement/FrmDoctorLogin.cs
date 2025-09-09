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
    public partial class FrmDoctorLogin : Form
    {
        public FrmDoctorLogin()
        {
            InitializeComponent();
        }
        SqlConnect bgl = new SqlConnect();

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Doctors where DoctorTC=@p1 and DoctorPassword=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTc.Text);
            komut.Parameters.AddWithValue("@p2",txtPassword.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmDoctorDetails fr = new FrmDoctorDetails();
                fr.TC= MskTc.Text;
                fr.Show();
                this.Hide();

            
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı adı veya şifre");
            }
            bgl.baglanti().Close();
        }
    }
}
