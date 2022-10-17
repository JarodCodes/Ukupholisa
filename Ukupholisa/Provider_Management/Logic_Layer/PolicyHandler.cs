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
            string query = @"SELECT p.Policy_Id, p.Policy_Name, p.Policy_CoverLevel, p.Policy_Cost, pp.Provider_Id FROM Policy p, ProviderPolicy pp WHERE p.Policy_Id = pp.Policy_Id";

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
                SqlCommand cmd = new SqlCommand("polAdd", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Provider_Id", policy.ProviderId);
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
        public void deletePolicy(int polID)
        {
            using (SqlConnection connect = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("polDelete", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Policy_Id", polID);

                connect.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public DataTable searchPolicy(int polID)
        {
            using (SqlConnection connect = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("polSearch", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Policy_Id", polID);

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
        public void createPackage(DataAccess_Layer.PolicyPackage package)
        {
            using (SqlConnection connect = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("packCreate", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Package_Id", package.Name);//verander die
                cmd.Parameters.AddWithValue("@Package_Name", package.Name);
                cmd.Parameters.AddWithValue("@Package_Cost", package.Cost);
                cmd.Parameters.AddWithValue("@Provider_Id", package.ProviderId);

                connect.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void updatePackage(DataAccess_Layer.PolicyPackage package)
        {
            using (SqlConnection connect = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("packUpdate", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Package_Id", package.PackageId);
                cmd.Parameters.AddWithValue("@Package_Name", package.Name);
                cmd.Parameters.AddWithValue("@Policy_Cost", package.Cost);
                cmd.Parameters.AddWithValue("@Provider_Id", package.ProviderId);

                connect.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void deletePackage(int packID)
        {
            using (SqlConnection connect = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("packDelete", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Package_Id", packID);

                connect.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public DataTable searchPackage(int packId)
        {
            using (SqlConnection connect = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("packSearch", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Package_Id", packId);

                connect.Open();
                DataTable dt = new DataTable();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    dt.Load(dr);
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No package found");
                    }
                    else
                    {
                        MessageBox.Show("Package found");
                    }
                    return dt;
                }
            }
        }
        public void addProvider(DataAccess_Layer.Provider provider)
        {
            using (SqlConnection connect = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("provAdd", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Provider_Name", provider.Name);
                cmd.Parameters.AddWithValue("@Provider_Location", provider.Location);
                cmd.Parameters.AddWithValue("@Provider_Status", provider.Status);

                connect.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void updateProvider(DataAccess_Layer.Provider provider)
        {
            using (SqlConnection connect = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("provUpdate", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Provider_Id", provider.ProviderId);
                cmd.Parameters.AddWithValue("@Provider_Name", provider.Name);
                cmd.Parameters.AddWithValue("@Provider_Location", provider.Location);
                cmd.Parameters.AddWithValue("@Provider_Status", provider.Status);

                connect.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void deleteProvider(int provID)
        {
            using (SqlConnection connect = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("provDelete", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Provider_Id", provID);

                connect.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public DataTable searchProvider(int provID)
        {
            using (SqlConnection connect = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("provSearch", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Provider_Id", provID);

                connect.Open();
                DataTable dt = new DataTable();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    dt.Load(dr);
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No provider found");
                    }
                    else
                    {
                        MessageBox.Show("Provider found");
                    }
                    return dt;
                }
            }
        }
        public void addPackPolicy(int polID, int packID)
        {
            using (SqlConnection connect = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("packPolAdd", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Policy_Id", polID);
                cmd.Parameters.AddWithValue("@Package_Id", packID);

                connect.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public DataTable populateCurPackPolicy(int packId)
        {
            using (SqlConnection connect = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("packPolSearch", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Package_Id", packId);

                connect.Open();
                DataTable dt = new DataTable();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    dt.Load(dr);
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No policies found, please create a pack");
                    }
                    else
                    {
                        MessageBox.Show("Policies found, this package already exists");
                    }
                    return dt;
                }
            }
        }
        public void removePackPol(int polID, int packID)
        {
            using (SqlConnection connect = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("packPolRemove", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Policy_Id", polID);
                cmd.Parameters.AddWithValue("@Package_Id", packID);

                connect.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
