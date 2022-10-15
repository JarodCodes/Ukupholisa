using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Ukupholisa.CallCentre.Logic_Layer
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
                MessageBox.Show("Connection successful");
            }
            catch (Exception)
            {

                MessageBox.Show("Connection error");
            }
            return sqlCon;
        }

        public DataTable PopulateClient()
        {
            //will get all client details
            string query = @"SELECT * FROM Client";

            SqlDataAdapter adapter = new SqlDataAdapter(query, con);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }
        public DataTable searchClient(DataAccess_Layer.Client client)
        {
            using (SqlConnection connect = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("clientSearch", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Client_Id", client.ClientID);

                connect.Open();
                DataTable dt = new DataTable();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    dt.Load(dr);
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No Client found!");
                    }
                    else
                    {
                        MessageBox.Show("Client found!");
                    }
                    return dt;
                }
            }
        }
        public void deleteClient(DataAccess_Layer.Client client)
        {
            using (SqlConnection connect = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("clientDelete", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Condition_Id", client.ClientID);    

                connect.Open();
                cmd.ExecuteNonQuery();    
            }
        }

        public void saveClient(string Name, string Surname, string Phone, string Address, string Family_Id)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(con))
                {
                    SqlCommand cmd = new SqlCommand("clientSave", connect);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Client_Name", Name);
                    cmd.Parameters.AddWithValue("@Client_Surname", Surname);
                    cmd.Parameters.AddWithValue("@Client_Phone", Phone);
                    cmd.Parameters.AddWithValue("@Client_Address", Address);
                    cmd.Parameters.AddWithValue("@Client_FamilyId", Name);
                    cmd.Parameters.AddWithValue("@Client_Name", Name);
                    int num = cmd.ExecuteNonQuery();
                    if (num > 0)
                    {
                        MessageBox.Show("Record added successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Oops! Something went wrong!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex);
            }
        }
        //Searching whether a medical condition exists
        public DataTable searchMedicalCondition(Medical_Department.DataAccess_Layer.MedCondition medCondition)
        {
            using (SqlConnection connect = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("medicalConditionSearch", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Condition_Id", medCondition.MedConID);

                connect.Open();
                DataTable dt = new DataTable();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    dt.Load(dr);
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Condition was not found!");
                    }
                    else
                    {
                        MessageBox.Show("Condition found!");
                    }
                    return dt;
                }
            }
        }

        public void updateClientDetails(string clientID)
        {
            DataAccess_Layer.Client client = new DataAccess_Layer.Client();

            DataTable dtData = searchClient(new DataAccess_Layer.Client(clientID));
            if (dtData.Rows.Count > 0)
            {
                client.FamilyID = dtData.Rows[0][1].ToString();
                client.Name = dtData.Rows[0][2].ToString();
                client.Surname = dtData.Rows[0][3].ToString();
                client.Phone = dtData.Rows[0][4].ToString();    
                client.Address = dtData.Rows[0][5].ToString();
            }
            else
            {
                //ClearAllData(); // For clear all control and refresh DataGridView data.  
            }
        }
    }


}