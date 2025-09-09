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
    public partial class FrmDoctorPanel : Form
    {
        public FrmDoctorPanel()
        {
            InitializeComponent();
        }
        SqlConnect bgl = new SqlConnect();

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Doctors set DoctorName=@d1,DoctorSurname=@d2,DoctorBranch=@d3,DoctorPassword=@d5 where DoctorTC=@d4", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", txtName.Text);
            komut.Parameters.AddWithValue("@d2", txtSurname.Text);
            komut.Parameters.AddWithValue("@d3", cmbBranch.Text);
            komut.Parameters.AddWithValue("@d4", mskTC.Text);
            komut.Parameters.AddWithValue("@d5", txtPassword.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmDoctorPanel_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * From Tbl_Doctors", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;


            // Branşları Combox Aktarma
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
            SqlCommand komut = new SqlCommand("insert into Tbl_Doctors (DoctorName,DoctorSurname,DoctorBranch,DoctorTC,DoctorPassword) values (@d1,@d2,@d3,@d4,@d5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", txtName.Text);
            komut.Parameters.AddWithValue("@d2", txtSurname.Text);
            komut.Parameters.AddWithValue("@d3", cmbBranch.Text);
            komut.Parameters.AddWithValue("@d4", mskTC.Text);
            komut.Parameters.AddWithValue("@d5", txtPassword.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Eklendi","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from Tbl_Doctors where DoctorTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",mskTC.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Silindi","Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtName.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSurname.Text= dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbBranch.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskTC.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtPassword.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();

        }
    }
}
