using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukupholisa.CallCentre.DataAccess_Layer
{
    internal class Family
    {
        string familyID;
        List<Client> clients;

        public Family(string familyID, List<Client> clients)
        {
            this.familyID = familyID;
            this.clients = clients;
        }

        public string FamilyID { get => familyID; set => familyID = value; }
        internal List<Client> Clients { get => clients; set => clients = value; }
    }
}
