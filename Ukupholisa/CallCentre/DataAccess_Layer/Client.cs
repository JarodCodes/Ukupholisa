using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukupholisa.CallCentre.DataAccess_Layer
{
    internal class Client
    {
        string name, surname, phone, clientID;

        public Client(string name, string surname, string phone, string clientID)
        {
            this.name = name;
            this.surname = surname;
            this.phone = phone;
            this.clientID = clientID;
        }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Phone { get => phone; set => phone = value; }
        public string ClientID { get => clientID; set => clientID = value; }
    }
}
