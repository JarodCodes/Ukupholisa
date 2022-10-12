using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukupholisa.Medical_Department.DataAccess_Layer
{
    public class MedProvider
    {
        string name, providerID;
        Boolean status;

        public MedProvider(string name, string providerID, bool status)
        {
            this.Name = name;
            this.ProviderID = providerID;
            this.Status = status;
        }

        public string Name { get => name; set => name = value; }
        public string ProviderID { get => providerID; set => providerID = value; }
        public bool Status { get => status; set => status = value; }
    }
}
