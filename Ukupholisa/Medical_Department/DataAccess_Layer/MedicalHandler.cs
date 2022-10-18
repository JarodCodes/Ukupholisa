using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Ukupholisa.Medical_Department.DataAccess_Layer
{
    public class MedicalHandler
    {
        string con = "Server=(local); Initial Catalog=Ukupholisa_Healthcare; Integrated Security= SSPI";

        public DataTable PopulateMedCon()
        {
            string query = @"SELECT * FROM Medical_Condition";

            SqlDataAdapter adapter = new SqlDataAdapter(query, con);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }
        public void addMedCon(Logic_layer.MedCondition medcon)//wil net seker maak oor die...
        {
            using (SqlConnection connect = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("mcAdd", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Condition_Name", medcon.Name);
                cmd.Parameters.AddWithValue("@Condition_Description", medcon.Description);
                cmd.Parameters.AddWithValue("@Condition_Treatment", medcon.Treatment);
                cmd.Parameters.AddWithValue("@Policy_Id", medcon.PolicyID);

                connect.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void updateMedCon(Logic_layer.MedCondition medcon)
        {
            using (SqlConnection connect = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("mcUpdate", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Condition_Id", medcon.MedConID);
                cmd.Parameters.AddWithValue("@Condition_Name", medcon.Name);
                cmd.Parameters.AddWithValue("@Condition_Description", medcon.Description);
                cmd.Parameters.AddWithValue("@Condition_Treatment", medcon.Treatment);
                cmd.Parameters.AddWithValue("@Policy_Id", medcon.PolicyID);

                connect.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void deleteMedCon(int conID)
        {
            using (SqlConnection connect = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("mcDelete", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Condition_Id", conID);

                connect.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public DataTable searchMedCon(int conID)
        {
            using (SqlConnection connect = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("mcSearch", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Condition_Id", conID);

                connect.Open();
                DataTable dt = new DataTable();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    dt.Load(dr);
                    return dt;
                }
            }
        }
        public DataTable searchMedPol(int conID)
        {
            using (SqlConnection connect = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("mcPolSearch", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Condition_Id", conID);

                connect.Open();
                DataTable dt = new DataTable();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    dt.Load(dr);
                    return dt;
                }
            }
        }
    }
}
