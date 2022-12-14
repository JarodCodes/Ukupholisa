using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ukupholisa.CallCentre.Logic_Layer
{
    public class Client
    {
        string name, surname, phone, address, uniqueIdentifier;
        int client_Id, family_Id;
        DateTime call_start, call_end;

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
        public DateTime Call_start { get => call_start; set => call_start = value; }
        public DateTime Call_end { get => call_end; set => call_end = value; }

        public void addClientWithFamily(string role, int famID)
        {
            DataAccess_Layer.ClientHandler handler = new DataAccess_Layer.ClientHandler();
            handler.saveClientExistingFam(this, role, famID);
        }



        public void addClientWithoutFamily(string role)
        {
            DataAccess_Layer.ClientHandler handler = new DataAccess_Layer.ClientHandler();
            handler.saveClient(this, role);
        }

        public void delete()
        {
            DataAccess_Layer.ClientHandler handler = new DataAccess_Layer.ClientHandler();
            handler.deleteClient(uniqueIdentifier);
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

        public DataTable searchClientPol()
        {
            DataAccess_Layer.ClientHandler handler = new DataAccess_Layer.ClientHandler();
            return handler.searchClientPolicies(uniqueIdentifier);
        }

        public void updateClient(string role)
        {
            DataAccess_Layer.ClientHandler handler = new DataAccess_Layer.ClientHandler();
            handler.updateClientDetails(this, role);
        }

        internal string getUniqueCode(string codeclass)
        {
            //generates unqiue client code
            int codePart1 = 0;
            int codePart2 = 0;

            Random random = new Random();

            codePart1 = random.Next(1000, 9999);
            codePart2 = random.Next(1000, 9999);

            if (codeclass == "J")
            {
                return codeclass + codePart1.ToString() + codePart2.ToString();
            }
            else if (codeclass == "H")
            {
                return codeclass + codePart1.ToString() + codePart2.ToString();
            }
            else if (codeclass == "L")
            {
                return codeclass + codePart1.ToString() + codePart2.ToString();
            }
            else
            {
                return codeclass + codePart1.ToString() + codePart2.ToString();
            }
        }

        internal DataTable searchCallLogs()
        {
            DataAccess_Layer.ClientHandler handler = new DataAccess_Layer.ClientHandler();
            return handler.searchCallLog(uniqueIdentifier);
        }

        internal string getRoleCode(string role)
        {
            //generates a role code based on the clients family role
            if (role == "MOTHER")
            {
                return "J";
            }
            else if (role == "CHILD")
            {
                return "H";
            }
            else if (role == "UNSPECIFIED")
            {
                return "L";
            }
            else
            {
                return "G";
            }
        }

        internal bool setImportantCaller(string uniqueID)
        {
            //sets the call as important enough to log
            if (string.IsNullOrWhiteSpace(uniqueID))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        internal void saveCallLog(DateTime call_start, DateTime call_end, string uniqueIdentifier)
        {
            DataAccess_Layer.ClientHandler handler = new DataAccess_Layer.ClientHandler();
            handler.saveCallLog(this);
        }

        internal string searchfamId()
        {

            DataAccess_Layer.ClientHandler handler = new DataAccess_Layer.ClientHandler();
            
            DataTable dt = handler.searchfamId(this);
            string famId = "";

            foreach (DataRow dr in dt.Rows)
            {           
                famId =  dr["Family_Id"].ToString();
            }

            return famId;
        }
    }
}
