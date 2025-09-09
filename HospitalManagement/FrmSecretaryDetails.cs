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
    public partial class FrmSecretaryDetails : Form
    {
        public FrmSecretaryDetails()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {


        }
        public string TCnumara;
        SqlConnect bgl = new SqlConnect();
        private void FrmSecretaryDetails_Load(object sender, EventArgs e)
        {
            lblTc.Text= TCnumara;


            // Ad-Soyad
            SqlCommand komut1 = new SqlCommand("Select SecretaryNameSurname From Tbl_Secretary where SecretaryTC=@p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1",lblTc.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lblNameSurname.Text= dr1[0].ToString();

            }
            bgl.baglanti().Close();


            // Branşları Datagride Aktarma
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Branches", bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource= dt1;

            // Doktorları Listeye Aktarma
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (DoctorName+' '+DoctorSurname)as 'Doktorlar',DoctorBranch From Tbl_Doctors", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource= dt2;


            // Branşları Combobax a Aktarma
            SqlCommand komut2 = new SqlCommand("Select BranchesName From Tbl_Branches", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read()) 
            {
                cmbBranch.Items.Add(dr2[0]);

            }
            bgl.baglanti().Close();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into Tbl_Appointment(AppointmentDate,AppointmentTime,AppointmentBranch,AppointmentDoctor) values (@r1,@r2,@r3,@r4)", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@r1", mskDate.Text);
            komutkaydet.Parameters.AddWithValue("@r2", mskTime.Text);
            komutkaydet.Parameters.AddWithValue("@r3",cmbBranch.Text);
            komutkaydet.Parameters.AddWithValue("@r4", cmbDoctor.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Oluşturuldu");
        }

        private void cmbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoctor.Items.Clear();
            SqlCommand komut = new SqlCommand("Select DoctorName,DoctorSurname From Tbl_Doctors where DoctorBranch=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbBranch.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read()) 
            {
                cmbDoctor.Items.Add(dr[0]+" "+ dr[1]);

            }
            bgl.baglanti().Close();
        }

        private void btnDuyuruAdd_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Duyurular (Duyuru) values (@d1) ", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", rchDuyuru.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru Oluşturuldu");
        }

        private void btnDoctorPnl_Click(object sender, EventArgs e)
        {
            FrmDoctorPanel drp = new FrmDoctorPanel();
            drp.Show();
        }

        private void btnBranchPnl_Click(object sender, EventArgs e)
        {
            FrmBranch frb = new FrmBranch();
            frb.Show();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            FrmAppointmentListAll frl = new FrmAppointmentListAll();
            frl.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAnnouncements frd = new FrmAnnouncements();
            frd.Show();

        }
    }
}
