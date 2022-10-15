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
            //will connect to db
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

        public DataTable PopulateClient()
        {
            //will get all client details
            string query = @"SELECT * FROM Client";

            SqlDataAdapter adapter = new SqlDataAdapter(query, con);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }
        //check this
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

        public void updateMedCon(DataAccess_Layer.Client client)
        {
            using (SqlConnection connect = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("mcUpdate", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Client_Id", client.ClientID);
                cmd.Parameters.AddWithValue("@Client_Name", client.Name);
                cmd.Parameters.AddWithValue("@Client_Surname", client.Surname);
                cmd.Parameters.AddWithValue("@Client_Phone", client.Phone);
                cmd.Parameters.AddWithValue("@Family_Id", client.Phone);//still need to add family Id to the Client Class
                cmd.Parameters.AddWithValue("@Client_Address", client.Phone);


                connect.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }


}