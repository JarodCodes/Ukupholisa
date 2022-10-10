using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ukupholisa.Provider_Management.Logic_Layer
{
    class PolicyHandler
    {
        string con = "Server=(local); Initial Catalog=Ukupholisa_Healthcare; Integrated Security= SSPI";
        public SqlConnection Connect()
        {
            SqlConnection cn = new SqlConnection(con);

            try
            {
                cn.Open();
                MessageBox.Show("Connection successful");
            }
            catch (Exception)
            {

                MessageBox.Show("Connection error");
            }
            return cn;
        }

        public DataTable PopulatePolicy()
        {
            string query = @"SELECT * FROM Policy";

            SqlDataAdapter adapter = new SqlDataAdapter(query, con);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }
        public DataTable PopulatePackage()
        {
            string query = @"SELECT * FROM Policy_Package";

            SqlDataAdapter adapter = new SqlDataAdapter(query, con);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }
        public DataTable PopulateMedProv()
        {
            string query = @"SELECT * FROM Medical_Provider";

            SqlDataAdapter adapter = new SqlDataAdapter(query, con);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }
        public void addPolicy(DataAccess_Layer.Policy policy)
        {
            using (SqlConnection connect = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("polUpdate", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Policy_Id", policy.PolicyId);
                cmd.Parameters.AddWithValue("@Policy_Name", policy.Name);
                cmd.Parameters.AddWithValue("@Policy_CoverLevel", policy.CoverLevel);
                cmd.Parameters.AddWithValue("@Policy_Cost", policy.Cost);

                connect.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void updatePolicy(DataAccess_Layer.Policy policy)
        {
            using (SqlConnection connect = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("polUpdate", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Policy_Id", policy.PolicyId);
                cmd.Parameters.AddWithValue("@Policy_Name", policy.Name);
                cmd.Parameters.AddWithValue("@Policy_CoverLevel", policy.CoverLevel);
                cmd.Parameters.AddWithValue("@Policy_Cost", policy.Cost);

                connect.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void deletePolicy(DataAccess_Layer.Policy policy)
        {
            using (SqlConnection connect = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("polDelete", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Policy_Id", policy.PolicyId);

                connect.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public DataTable searchPolicy(DataAccess_Layer.Policy policy)
        {
            using (SqlConnection connect = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("polSearch", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Policy_Id", policy.PolicyId);

                connect.Open();
                DataTable dt = new DataTable();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    dt.Load(dr);
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No policy found");
                    }
                    else
                    {
                        MessageBox.Show("Policy found");
                    }
                    return dt;
                }
            }
        }
        public void addPackage(DataAccess_Layer.PolicyPackage package)
        {
            using (SqlConnection connect = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("packUpdate", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Policy_Id", package.);
                cmd.Parameters.AddWithValue("@Policy_Name", package.Name);
                cmd.Parameters.AddWithValue("@Policy_CoverLevel", package.CoverLevel);
                cmd.Parameters.AddWithValue("@Policy_Cost", package.Cost);

                connect.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void updatePolicy(DataAccess_Layer.Policy policy)
        {
            using (SqlConnection connect = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("polUpdate", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Policy_Id", policy.PolicyId);
                cmd.Parameters.AddWithValue("@Policy_Name", policy.Name);
                cmd.Parameters.AddWithValue("@Policy_CoverLevel", policy.CoverLevel);
                cmd.Parameters.AddWithValue("@Policy_Cost", policy.Cost);

                connect.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void deletePolicy(DataAccess_Layer.Policy policy)
        {
            using (SqlConnection connect = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("polDelete", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Policy_Id", policy.PolicyId);

                connect.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public DataTable searchPolicy(DataAccess_Layer.Policy policy)
        {
            using (SqlConnection connect = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("polSearch", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Policy_Id", policy.PolicyId);

                connect.Open();
                DataTable dt = new DataTable();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    dt.Load(dr);
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No policy found");
                    }
                    else
                    {
                        MessageBox.Show("Policy found");
                    }
                    return dt;
                }
            }
        }
    }
}
