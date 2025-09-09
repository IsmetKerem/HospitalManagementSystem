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
using System.Xml.Linq;

namespace HospitalManagement
{
    public partial class FrmDoctorInformationManagement : Form
    {
        public FrmDoctorInformationManagement()
        {
            InitializeComponent();
        }
        SqlConnect bgl = new SqlConnect();
        public string TCNO;
        private void FrmDoctorInformationManagement_Load(object sender, EventArgs e)
        {
            MskTc.Text=TCNO;

            SqlCommand komut = new SqlCommand("Select * From Tbl_Doctors where DoctorTC=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",MskTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read()) 
            {
                txtName.Text = dr[1].ToString();
                txtSurname.Text = dr[2].ToString();
                cmbBranch.Text = dr[3].ToString();
                txtPassword.Text = dr[5].ToString();
            }
            bgl.baglanti().Close();
        }

        private void btnBilgiGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Doctors set DoctorName=@p1,DoctorSurname=@p2,DoctorBranch=@p3,DoctorPassword=@p4 where DoctorTC=@p5", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtName.Text);
            komut.Parameters.AddWithValue("@p2",txtSurname.Text);
            komut.Parameters.AddWithValue("@p3", cmbBranch.Text);
            komut.Parameters.AddWithValue("@p4", txtPassword.Text);
            komut.Parameters.AddWithValue("@p5", MskTc.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Güncellendi");
        }
    }
}
