using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukupholisa.CallCentre.Logic_Layer
{
    internal class Family
    {
        int familyID;
        string family_Surname;
        string family_role;

        public Family()
        {
        }

        public Family(int familyID, string family_Surname, string family_role)
        {
            this.FamilyID = familyID;
            this.Family_Surname = family_Surname;
            this.Family_role = family_role;
        }

        public int FamilyID { get => familyID; set => familyID = value; }
        internal string Family_Surname { get => family_Surname; set => family_Surname = value; }

        internal string Family_role { get => family_role; set => family_role = value; }

        public void add()
        {
            throw new NotImplementedException();
        }
        public DataTable populate()
        {
            DataAccess_Layer.ClientHandler handler = new DataAccess_Layer.ClientHandler();
            return handler.populateClientFam();
        }
        public void delete()
        {
            DataAccess_Layer.ClientHandler handler = new DataAccess_Layer.ClientHandler();
            handler.deleteFam(FamilyID);
        }

        public DataTable search()
        {
            DataAccess_Layer.ClientHandler handler = new DataAccess_Layer.ClientHandler();
            return handler.searchFamily(FamilyID);
        }

        public void update(int client_Id)
        {
            DataAccess_Layer.ClientHandler handler = new DataAccess_Layer.ClientHandler();
            handler.updateFamily(this, client_Id);
        }
        public void addToFam(int client_Id)
        {
            DataAccess_Layer.ClientHandler handler = new DataAccess_Layer.ClientHandler();
            handler.addFamClient(this, client_Id);
        }
        public void removeFromFam(int client_Id)
        {
            DataAccess_Layer.ClientHandler handler = new DataAccess_Layer.ClientHandler();
            handler.removeFamClient(client_Id);
        }
        public void addFamPol(int policy_Id) 
        {
            Provider_Management.DataAccess_Layer.PolicyHandler handler = new Provider_Management.DataAccess_Layer.PolicyHandler();
            handler.addFamPolicy(policy_Id, FamilyID);
        }
        public void removeFamPol()
        {
            Provider_Management.DataAccess_Layer.PolicyHandler handler = new Provider_Management.DataAccess_Layer.PolicyHandler();
            handler.removeFamPol(FamilyID);
        }
    }
}
