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
    public partial class FrmSignUp : Form
    {
        public FrmSignUp()
        {
            InitializeComponent();
        }
        SqlConnect bgl = new SqlConnect();
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into  Tbl_Patients (PatinetName,PatientSurname,PatientTC,PatientNumber,PatinetPassword,PatientGender) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtName.Text);
            komut.Parameters.AddWithValue("@p2", txtSurname.Text);
            komut.Parameters.AddWithValue("@p3", MskTc.Text);
            komut.Parameters.AddWithValue("@p4", MskNumber.Text);
            komut.Parameters.AddWithValue("@p5", txtPassword.Text);
            komut.Parameters.AddWithValue("@p6", cmbGender.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kaydınız Gerçekleştirilmiştir Şifreniz::"+ txtPassword.Text,"Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
