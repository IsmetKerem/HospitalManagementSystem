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
using Microsoft.Identity.Client;


namespace HospitalManagement
{
    public partial class FrmAppointmentListAll : Form
    {
        public FrmAppointmentListAll()
        {
            InitializeComponent();
        }
        SqlConnect bgl = new SqlConnect();

        private void FrmAppointmentListAll_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Appointment",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;  
        }
       
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
