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
    public partial class FrmInformationManagement : Form
    {
        public FrmInformationManagement()
        {
            InitializeComponent();
        }
        public string TCno;

        SqlConnect bgl = new SqlConnect();

        private void FrmInformationManagement_Load(object sender, EventArgs e)
        {
            MskTc.Text = TCno;
            SqlCommand komut = new SqlCommand("Select * From Tbl_Patients where PatientTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read()) 
            {
                txtName.Text= dr[1].ToString();
                txtSurname.Text= dr[2].ToString();
                MskNumber.Text = dr[4].ToString();
                txtPassword.Text = dr[5].ToString();
                cmbGender.Text = dr[6].ToString();

            }
            bgl.baglanti().Close();
            
        }

        private void btnBilgiGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update Tbl_Patients set PatinetName=@p1,PatientSurname=@p2,PatientNumber=@p3,PatinetPassword=@p4,PatientGender=@p5 where PatientTC=@p6", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1",txtName.Text);
            komut2.Parameters.AddWithValue("@p2", txtSurname.Text);
            komut2.Parameters.AddWithValue("@p3", MskNumber.Text);
            komut2.Parameters.AddWithValue("@p4", txtPassword.Text);
            komut2.Parameters.AddWithValue("@p5", cmbGender.Text );
            komut2.Parameters.AddWithValue("@p6", MskTc.Text );
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellendi!","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);

        }
    }
}
