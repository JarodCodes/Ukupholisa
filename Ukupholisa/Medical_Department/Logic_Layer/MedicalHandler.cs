using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ukupholisa.Medical_Department.Logic_Layer
{
    public class MedicalHandler
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

        public DataTable PopulateMedCon()
        {
            string query = @"SELECT * FROM Medical_Condition";

            SqlDataAdapter adapter = new SqlDataAdapter(query, con);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }
        public void addMedCon(DataAccess_Layer.MedCondition medcon)
        {
            using (SqlConnection connect = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("mcAdd", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Condition_Name", medcon.Name);
                cmd.Parameters.AddWithValue("@Condition_Description", medcon.Description);
                cmd.Parameters.AddWithValue("@Policy_Id", medcon.PolicyID);

                connect.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void updateMedCon(DataAccess_Layer.MedCondition medcon)
        {
            using (SqlConnection connect = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("mcUpdate", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Condition_Name", medcon.Name);
                cmd.Parameters.AddWithValue("@Condition_Description", medcon.Description);
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
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No medical condition found");
                    }
                    else
                    {
                        MessageBox.Show("Medical condition found");
                    }
                    return dt;
                }
            }
        }
    }
}
