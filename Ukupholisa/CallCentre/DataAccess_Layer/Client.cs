using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukupholisa.CallCentre.DataAccess_Layer
{
    public class Client
    {
        string name, surname, phone, clientID, familyID, address;

        public Client(string name, string surname, string phone, string clientID, string familyID, string address)
        {
            this.name = name;
            this.surname = surname;
            this.phone = phone;
            this.clientID = clientID;
            this.FamilyID = familyID;
            this.Address = address;
        }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Phone { get => phone; set => phone = value; }
        public string ClientID { get => clientID; set => clientID = value; }
        public string FamilyID { get => familyID; set => familyID = value; }
        public string Address { get => address; set => address = value; }
    }
}
