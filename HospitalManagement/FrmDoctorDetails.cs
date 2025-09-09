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
    public partial class FrmDoctorDetails : Form
    {
        public FrmDoctorDetails()
        {
            InitializeComponent();
        }
        SqlConnect bgl = new SqlConnect();
        public string TC;

        private void FrmDoctorDetails_Load(object sender, EventArgs e)
        {
            lblTc.Text = TC;

            // Doktor Ad-Soyad
            SqlCommand komut = new SqlCommand("Select DoctorName,DoctorSurname From Tbl_Doctors where DoctorTC=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",lblTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read()) 
            {
                lblNameSurname.Text = dr[0] + " " + dr[1];

            }
            bgl.baglanti().Close();

            // Randevular
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Appointment where AppointmentDoctor='"+lblNameSurname.Text+"'",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource= dt;

        }

        private void btnUpadete_Click(object sender, EventArgs e)
        {
            FrmDoctorInformationManagement fr = new FrmDoctorInformationManagement();
            fr.TCNO=lblTc.Text;
            fr.Show();
        }

        private void btnDuyurular_Click(object sender, EventArgs e)
        {
            FrmAnnouncements fr = new FrmAnnouncements();
            fr.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            rchSikayet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }
    }
}
