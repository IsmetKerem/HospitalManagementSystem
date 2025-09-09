using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HospitalManagement
{
     class SqlConnect
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=localhost;Initial Catalog=HospitalDb;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
