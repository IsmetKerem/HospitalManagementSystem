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
    public partial class FrmPatientDetails : Form
    {
        public FrmPatientDetails()
        {
            InitializeComponent();
        }
        public string tc;
        SqlConnect bgl = new SqlConnect();



        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void FrmPatientDetails_Load(object sender, EventArgs e)
        {
            lblTc.Text = tc;

            SqlCommand komut = new SqlCommand("Select PatinetName,PatientSurname From Tbl_Patients where PatientTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read()) 
            {
                lblNameSurname.Text = dr[0] +" "+ dr[1];
            }
            bgl.baglanti().Close(); 


            // Randevu Geçmiş
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Appointment where PatientTC=" + tc, bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            // Branşları Çekme
            SqlCommand komut2 = new SqlCommand("Select BranchesName From Tbl_Branches", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read()) 
            {
                cmbBranch.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private void cmbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoctor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("Select DoctorName,DoctorSurname From Tbl_Doctors where DoctorBranch=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", cmbBranch.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read()) 
            {
                cmbDoctor.Items.Add(dr3[0]+ " "+ dr3[1]);
            }
            bgl.baglanti().Close();
        }

        private void cmbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Appointment where AppointmentBranch='"+ cmbBranch.Text+"'"+ "and AppointmentDoctor='"+cmbDoctor.Text+ "' and AppointmentStatus=0", bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void lnkBilgiDuzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmInformationManagement fr = new FrmInformationManagement();
            fr.TCno = lblTc.Text;
            fr.Show();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            txtId.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();

        }

        private void btnRandevuAl_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand ("Update Tbl_Appointment set AppointmentStatus=1,PatientTC=@p1,PatientSikayet=@p2 where AppointmentId=@p3", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",lblTc.Text);
            komut.Parameters.AddWithValue("@p2", rchComplaint.Text);
            komut.Parameters.AddWithValue("@p3", txtId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Alındı","Uyarı",MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
