using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukupholisa.CallCentre.Logic_Layer
{
    public class Client:ICRUD
    {
        string name, surname, phone, address;
        int client_Id, family_Id;

        public Client()
        {

        }

        public Client(int clientID)
        {
            this.client_Id = clientID;
        }

        public Client(string name, string surname, string phone, int client_Id, int family_Id, string address)
        {
            this.name = name;
            this.surname = surname;
            this.phone = phone;
            this.client_Id = client_Id;
            this.family_Id = family_Id;
            this.address = address;
        }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }
        public int Client_Id { get => client_Id; set => client_Id = value; }
        public int Family_Id { get => family_Id; set => family_Id = value; }

        public void add()
        {
            Family fam = new Family();
            DataAccess_Layer.ClientHandler handler = new DataAccess_Layer.ClientHandler();
            handler.saveClient(this, fam);
        }

        public void delete()
        {
            DataAccess_Layer.ClientHandler handler = new DataAccess_Layer.ClientHandler();
            handler.deleteClient(Client_Id);
        }

        public DataTable populate()
        {
            DataAccess_Layer.ClientHandler handler = new DataAccess_Layer.ClientHandler();
            return handler.PopulateClient();
        }

        public DataTable search()
        {
            DataAccess_Layer.ClientHandler handler = new DataAccess_Layer.ClientHandler();
            return handler.searchClient(Client_Id);
        }

        public void update()
        {
            DataAccess_Layer.ClientHandler handler = new DataAccess_Layer.ClientHandler();
            handler.updateClientDetails(this);
        }
    }
}
