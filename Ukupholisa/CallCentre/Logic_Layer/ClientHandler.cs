using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ukupholisa.CallCentre.Logic_Layer
{
    public class ClientHandler
    {
        public SqlConnection Connect()
        {
            //will connect to db
        }

        public BindingSource PopulateClient(SqlConnection connect)
        {
            //will get all medical conditions
        }
        public BindingSource PopulatePolicy(SqlConnection connect)
        {
            //will get all medical providers
        }
    }
}
}
