using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAppStandalone
{
    public class DatabaseHelpers
    {
        public static string connStr = @"Data Source=DESKTOP-DJ6F641;Initial Catalog=DemoDB;Persist Security Info=True;User ID=demoUser;Password=12345;TrustServerCertificate=True";

        public static DataTable ExecuteQuery(string query, params SqlParameter[] sqlParameters)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (sqlParameters != null) cmd.Parameters.AddRange(sqlParameters);
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    return dt;
                }
            }
        }

        public static void ExecuteNonQuery(string query, params SqlParameter[] sqlParameters)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using(SqlCommand cmd = new SqlCommand(query,conn))
                {
                    if (sqlParameters != null) cmd.Parameters.AddRange(sqlParameters);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
