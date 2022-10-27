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
        string name, surname, phone, address, uniqueIdentifier;
        int client_Id, family_Id;

        public Client()
        {

        }

        public Client(int clientID)
        {
            this.client_Id = clientID;
        }

        public Client(string name, string surname, string phone, int client_Id, string address)
        {
            this.Name = name;
            this.Surname = surname;
            this.Phone = phone;
            this.Client_Id = client_Id;
            this.Address = address;
        }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }
        public int Client_Id { get => client_Id; set => client_Id = value; }
        public int Family_Id { get => family_Id; set => family_Id = value; }
        public string UniqueIdentifier { get => uniqueIdentifier; set => uniqueIdentifier = value; }

        public bool ifClientExists()
        {
            return false;
        }

        public void add()
        {
            //DataAccess_Layer.ClientHandler handler = new DataAccess_Layer.ClientHandler();
            //handler.saveClient(this);
        }

        public void getFamilyRole(string role)
        {
            DataAccess_Layer.ClientHandler handler = new DataAccess_Layer.ClientHandler();
            handler.saveClient(this, role);
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
            return handler.searchClient(uniqueIdentifier);
        }

        public void update()
        {
            DataAccess_Layer.ClientHandler handler = new DataAccess_Layer.ClientHandler();
            handler.updateClientDetails(this);
        }

        internal string getUniqueCode(string codeclass)
        {
            int codePart1 = 0;
            int codePart2 = 0;

            Random random = new Random();

            codePart1 = random.Next(1000, 9999);
            codePart2 = random.Next(1000, 9999);

            if (codeclass == "MOTHER")
            {
                return "J" + codePart1.ToString() + codePart2.ToString();
            }else if (codeclass == "CHILD")
            {
                return "H" + codePart1.ToString() + codePart2.ToString();
            }
            else
            {
                return "G" + codePart1.ToString() + codePart2.ToString();
            }
        }
    }
}
