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
    public partial class FrmBranch : Form
    {
        public FrmBranch()
        {
            InitializeComponent();
        }
        SqlConnect bgl = new SqlConnect();


        private void FrmBranch_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Branches", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void btnBranchAdd_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Branches (BranchesName) values (@b1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@b1", txtBranchName.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Mesaj Eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtBranchId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtBranchName.Text= dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void btnBranchDelete_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From Tbl_Branches where BranchesId=@b1",bgl.baglanti());
            komut.Parameters.AddWithValue("@b1", txtBranchId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Silindi");
        }

        private void btnBranchUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Branches set BranchesName=@p1 where BranchesId=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtBranchName.Text);
            komut.Parameters.AddWithValue("@p2", txtBranchId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Güncelleme İşlemi Başarılı");
        }
    }
}
