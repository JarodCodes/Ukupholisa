using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Ukupholisa.Provider_Management.DataAccess_Layer
{
    class PolicyHandler
    {
        string con = "Server=(local); Initial Catalog=Ukupholisa_Healthcare; Integrated Security= SSPI";

        public DataTable PopulatePolicy()
        {
            //returns a bunch of policies
            string query = @"SELECT p.Policy_Id, p.Policy_Name, p.Policy_CoverLevel, p.Policy_Cost, pp.Provider_Id FROM Policy p, ProviderPolicy pp WHERE p.Policy_Id = pp.Policy_Id";

            SqlDataAdapter adapter = new SqlDataAdapter(query, con);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }
        public DataTable PopulatePackage()
        {
            //returns a list of packages
            string query = @"SELECT pp.Package_Id, p.Provider_Id, pp.Package_Name, pp.Package_Cost FROM Policy_Package pp, Provider_Package p WHERE pp.Package_Id = p.Package_Id";

            SqlDataAdapter adapter = new SqlDataAdapter(query, con);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }

        public DataTable PopulateMedProv()
        {
            //returns a list of medical providers
            string query = @"SELECT * FROM Medical_Provider";

            SqlDataAdapter adapter = new SqlDataAdapter(query, con);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }
        public DataTable retrieveProviderInfo()
        {
            //shortened details of medical providers
            string query = @"SELECT Provider_Id, Provider_Name FROM Medical_Provider";

            SqlDataAdapter adapter = new SqlDataAdapter(query, con);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }
        public DataTable retrieveTreatmentInfoPending(int provID)
        {
            //retrieves a list of pending treatments
            using (SqlConnection connect = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("pendingTreatmentSearch", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Provider_Id", provID);

                connect.Open();
                DataTable dt = new DataTable();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    dt.Load(dr);
                    return dt;
                }
            }
        }
        public DataTable retrieveTreatmentInfoProgress(int provID)
        {
            //retrieves a list of in progress treatments
            using (SqlConnection connect = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("inProgressTreatmentSearch", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Provider_Id", provID);

                connect.Open();
                DataTable dt = new DataTable();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    dt.Load(dr);
                    return dt;
                }
            }
        }
        public void addPolicy(Logic_Layer.Policy policy)
        {
            //adds a new policy
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
        public void updatePolicy(Logic_Layer.Policy policy)
        {
            //updates a policy
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
            //deletes a policy
                using (SqlConnection connect = new SqlConnection(con))
                {
                    SqlCommand cmd = new SqlCommand("polDelete", connect);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Policy_Id", polID);

                    connect.Open();
                    cmd.ExecuteNonQuery();
                } 
        }

        internal DataTable searchIfPolicyExists(int policyID, string clientcode)
        {
            //checks if the searched policy has already been added to a client
            using (SqlConnection connect = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("searchIfPolicyExists", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Policy_Id", policyID);
                cmd.Parameters.AddWithValue("@Client_Code", clientcode);

                connect.Open();
                DataTable dt = new DataTable();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    dt.Load(dr);
                    return dt;
                }
            }
        }

        internal void addPolicyToClient(int Policy_Id, string Client_Code, string Policy_Code)
        {
            //adds a policy to a client
            using (SqlConnection connect = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("addPolicyToClient", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Policy_Id", Policy_Id);
                cmd.Parameters.AddWithValue("@Client_Code", Client_Code);
                cmd.Parameters.AddWithValue("@UniquePolCode", Policy_Code);

                connect.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable searchPolicy(int polID)
        {
            //searches a policy
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
                    return dt;
                }
            }
        }
        public void createPackage(Logic_Layer.PolicyPackage package)
        {
            //creates a package
            using (SqlConnection connect = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("packCreateTest", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@Package_Id", package.PackageId);
                cmd.Parameters.AddWithValue("@Package_Name", package.Name);
                cmd.Parameters.AddWithValue("@Package_Cost", package.Cost);
                cmd.Parameters.AddWithValue("@Provider_Id", package.ProviderId);

                connect.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void updatePackage(Logic_Layer.PolicyPackage package)
        {
            //updates a package
            using (SqlConnection connect = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("packUpdate", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Package_Id", package.PackageId);
                cmd.Parameters.AddWithValue("@Package_Name", package.Name);
                cmd.Parameters.AddWithValue("@Package_Cost", package.Cost);
                cmd.Parameters.AddWithValue("@Provider_Id", package.ProviderId);

                connect.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void deletePackage(int packID)
        {
            //deletes a package
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
            //searches a package
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
                    return dt;
                }
            }
        }
        public void addProvider(Logic_Layer.Provider provider)
        {
            //adds a medical provider
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
        public void updateProvider(Logic_Layer.Provider provider)
        {
            //updates a medical provider
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
            //deletes a medical provider
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
            //searches a medical provider
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
                    return dt;
                }
            }
        }
        public void addPackPolicy(int polID, int packID)
        {
            //adds a policy to a package
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
            //sends a list of policies belonging to this package
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
                    return dt;
                }
            }
        }
        public void removePackPol(int polID, int packID)
        {
            //removes a policy from a package
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
        public DataTable searchFamPol(int family_Id)
        {
            //searches policies belonging to a family
            using (SqlConnection connect = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("famPolSearch", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Family_Id", family_Id);

                connect.Open();
                DataTable dt = new DataTable();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    dt.Load(dr);
                    return dt;
                }
            }
        }
        public void addFamPolicy(int polID, int famID)
        {
            //adds a policy to a family
            using (SqlConnection connect = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("famPolAdd", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Policy_Id", polID);
                cmd.Parameters.AddWithValue("@Family_Id", famID);

                connect.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void removeFamPol(int famID)
        {
            //removes a policy from a family
            using (SqlConnection connect = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("famPolRemove", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Family_Id", famID);

                connect.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public DataTable searchClientPol(string client_code)
        {
            //returns a list of policies belonging to a client
            using (SqlConnection connect = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("clientPolSearch", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Client_Code", client_code);

                connect.Open();
                DataTable dt = new DataTable();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    dt.Load(dr);
                    return dt;
                }
            }
        }
        public void updatePolicyStatus(Logic_Layer.Policy policy, string client_code)
        {
            //updates the clients policy status
            using (SqlConnection connect = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("policyStatusUpdate", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Policy_Code", policy.PolCode);
                cmd.Parameters.AddWithValue("@Client_Code", client_code);
                cmd.Parameters.AddWithValue("@Policy_Status", policy.Status);

                connect.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
