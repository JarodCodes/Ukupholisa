using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ukupholisa.Medical_Department.DataAccess_Layer
{
    public class MedicalHandler
    {
        public SqlConnection Connect() 
        {
            //will connect to db
        }

        public BindingSource PopulateMedCon(SqlConnection connect)
        {
            //will get all medical conditions
        }
        public BindingSource PopulateMedProv(SqlConnection connect)
        {
            //will get all medical providers
        }
    }
}
