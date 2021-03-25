using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CommercialAutomation
{
    class CommercialAutomationContext
    {
        public SqlConnection connection()
        {
            SqlConnection connect = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DboCommercialAutomation;Integrated Security=True");
            connect.Open();
            return connect;
        }
    }
}
