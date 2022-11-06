using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Ukupholisa.CallCentre.DataAccess_Layer
{
    internal class ClientHandler
    {
        string con = "Server=(local); Initial Catalog=Ukupholisa_Healthcare; Integrated Security= SSPI";
        public SqlConnection Connect()
        {
            SqlConnection sqlCon = new SqlConnection(con);

            try
            {
                sqlCon.Open();

            }
            catch (Exception)
            {

            }
            return sqlCon;
        }

        public DataTable PopulateClient()
        {
            //will get all client details
            string query = @"SELECT Client_Code, Client_Name, Client_Surname, Client_Phone, Client_Address FROM Client";

            SqlDataAdapter adapter = new SqlDataAdapter(query, con);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }
        //public DataTable searchClient(string uniqueID)
        //{ 
        //    return 
        //}
        public DataTable populateClientFam() 
        {
            string query = @"SELECT c.Client_Code,c.Client_Name, c.Client_Surname, c.Client_Phone,c.Client_Address , cf.Family_Id, cf.Family_Role
                            FROM Client c 
                            INNER JOIN Client_Family cf ON cf.Client_Id = c.Client_Id";

            SqlDataAdapter adapter = new SqlDataAdapter(query, con);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }

        public DataTable searchClientPolicies(string uniqueID)
        {
            using (SqlConnection connect = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("clientPolSearch", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Client_Code", uniqueID);

                connect.Open();
                DataTable dt = new DataTable();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    dt.Load(dr);
                    return dt;
                }
            }
        }
        public DataTable searchClient(string uniqueID)
        {
            using (SqlConnection connect = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("clientSearch", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Client_Id", uniqueID);

                connect.Open();
                DataTable dt = new DataTable();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    dt.Load(dr);
                    return dt;
                }
            }
        }
        public void deleteClient(string client_code)
        {
            using (SqlConnection connect = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("clientDelete", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Client_Code", client_code);    

                connect.Open();
                cmd.ExecuteNonQuery();    
            }
        }
        public void saveClientFamily(string role, string Name, string Surname, string Phone, string Address, int family_Id)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(con))
                {
                    SqlCommand cmd = new SqlCommand("saveClientFamily", connect);
                    cmd.Parameters.AddWithValue("@Family_Role", role);
                    cmd.Parameters.AddWithValue("@Client_Name", Name);
                    cmd.Parameters.AddWithValue("@Client_Surname", Surname);
                    cmd.Parameters.AddWithValue("@Client_Phone", Phone);
                    cmd.Parameters.AddWithValue("@Client_Address", Address);
                    cmd.Parameters.AddWithValue("@Family_Id", family_Id);

                    connect.Open();

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error:" + ex.Message);
            }
        }

        public void saveClient(Logic_Layer.Client client, string family)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(con))
                {
                    SqlCommand cmd = new SqlCommand("clientSave", connect);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Client_Name", client.Name);
                    cmd.Parameters.AddWithValue("@Client_Surname", client.Surname);
                    cmd.Parameters.AddWithValue("@Client_Phone", client.Phone);
                    cmd.Parameters.AddWithValue("@Client_Address", client.Address);
                    //cmd.Parameters.AddWithValue("@Family_Id", family.FamilyID);
                    cmd.Parameters.AddWithValue("@Family_Role", family);
                    cmd.Parameters.AddWithValue("@Client_UniqueId", client.UniqueIdentifier);

                    connect.Open();

                    int num = cmd.ExecuteNonQuery();
                    if (num > 0)
                    {
                        
                    }
                    else
                    {
                        
                    }
                }
            }
            catch (Exception ex)
            {
                
            }
        }

        internal void saveCallLog(Logic_Layer.Client client)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(con))
                {
                    SqlCommand cmd = new SqlCommand("saveCallLog", connect);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Client_Code", client.UniqueIdentifier);
                    cmd.Parameters.AddWithValue("@Call_Start", client.Call_start);
                    cmd.Parameters.AddWithValue("@Call_End", client.Call_end);


                    connect.Open();

                    int num = cmd.ExecuteNonQuery();
                    if (num > 0)
                    {
                        //MessageBox.Show("Call Ended");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        public void saveClientExistingFam(Logic_Layer.Client client, string role, int famID)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(con))
                {
                    SqlCommand cmd = new SqlCommand("saveClientExistingFam", connect);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Client_UniqueId", client.UniqueIdentifier);
                    cmd.Parameters.AddWithValue("@Client_Name", client.Name);
                    cmd.Parameters.AddWithValue("@Client_Surname", client.Surname);
                    cmd.Parameters.AddWithValue("@Client_Phone", client.Phone);
                    cmd.Parameters.AddWithValue("@Client_Address", client.Address);
                    cmd.Parameters.AddWithValue("@Family_Id", famID);
                    cmd.Parameters.AddWithValue("@Family_Role", role);

                    connect.Open();

                    int num = cmd.ExecuteNonQuery();
                    if (num > 0)
                    {
                        //MessageBox.Show("Record added successfully!");
                    }
                    else
                    {
                        //MessageBox.Show("Oops! Something went wrong!");
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error:" + ex.Message);
            }
        }
        public void updateClientDetails(Logic_Layer.Client client, string role)
        {
            using (SqlConnection connect = new SqlConnection(con)) 
            {
                SqlCommand cmd = new SqlCommand("clientUpdate", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Client_Code", client.UniqueIdentifier);
                cmd.Parameters.AddWithValue("@Client_Name", client.Name);
                cmd.Parameters.AddWithValue("@Client_Surname", client.Surname);
                cmd.Parameters.AddWithValue("@Client_Phone", client.Phone);
                cmd.Parameters.AddWithValue("@Client_Address", client.Address);

                cmd.Parameters.AddWithValue("@Family_Role", role);

                connect.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void addClientPol(int ClientID, int PolID)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(con))
                {
                    SqlCommand cmd = new SqlCommand("clientAddPol", connect);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Client_Id", ClientID);
                    cmd.Parameters.AddWithValue("@Policy_Id", PolID);
                    int num = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error:" + ex);
            }
        }
        public DataTable searchFamily(int family_id) 
        {
            using (SqlConnection connect = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("famSearch", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Family_Id", family_id);

                connect.Open();
                DataTable dt = new DataTable();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    dt.Load(dr);
                    return dt;
                }
            }
        }
        public void addFamClient(Logic_Layer.Family family, int client_Id)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(con))
                {
                    SqlCommand cmd = new SqlCommand("familyClientAdd", connect);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Client_Id", client_Id);
                    cmd.Parameters.AddWithValue("@Family_Id", family.FamilyID);
                    cmd.Parameters.AddWithValue("@Family_Role", family.Family_role);
                    int num = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error:" + ex);
            }
        }
        public void updateFamily(Logic_Layer.Family family, int client_Id) 
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(con))
                {
                    SqlCommand cmd = new SqlCommand("familyClientUpdate", connect);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Client_Id", client_Id);
                    cmd.Parameters.AddWithValue("@Family_Id", family.FamilyID);
                    cmd.Parameters.AddWithValue("@Family_Role", family.Family_role);
                    int num = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error:" + ex);
            }
        }
        public void removeFamClient(int client_Id)
        {
            using (SqlConnection connect = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("famClientRemove", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Client_Id", client_Id);

                connect.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void deleteFam(int family_Id)
        {
            using (SqlConnection connect = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("familyDelete", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Family_Id", family_Id);

                connect.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }


}