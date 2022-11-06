using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukupholisa.Provider_Management.Logic_Layer
{
    class Policy:ICRUD
    {
        string name;
        string coverLevel;
        string status;
        int policyId;
        int cost;
        int providerId;
        string polCode;


        public string Name { get => name; set => name = value; }
        public string CoverLevel { get => coverLevel; set => coverLevel = value; }
        public string Status { get => status; set => status = value; }
        public int PolicyId { get => policyId; set => policyId = value; }
        public int Cost { get => cost; set => cost = value; }
        public int ProviderId { get => providerId; set => providerId = value; }
        public string PolCode { get => polCode; set => polCode = value; }

        public Policy(string name, string coverLevel, string status, int policyId, int cost, int providerId)
        {
            this.Name = name;
            this.CoverLevel = coverLevel;
            this.Status = status;
            this.PolicyId = policyId;
            this.Cost = cost;
            this.ProviderId = providerId;
        }
        public Policy()
        {

        }

        public DataTable populate()
        {
            DataAccess_Layer.PolicyHandler handler = new DataAccess_Layer.PolicyHandler();
            return handler.PopulatePolicy();
        }

        public DataTable search()
        {
            DataAccess_Layer.PolicyHandler handler = new DataAccess_Layer.PolicyHandler();
            return handler.searchPolicy(PolicyId);
        }

        public void add()
        {
            DataAccess_Layer.PolicyHandler handler = new DataAccess_Layer.PolicyHandler();
            handler.addPolicy(this);
        }

        public void update()
        {
            DataAccess_Layer.PolicyHandler handler = new DataAccess_Layer.PolicyHandler();
            handler.updatePolicy(this);
        }

        public void delete()
        {
            DataAccess_Layer.PolicyHandler handler = new DataAccess_Layer.PolicyHandler();
            handler.deletePolicy(PolicyId);
        }
        public DataTable famPolSearch(int family_Id)
        {
            DataAccess_Layer.PolicyHandler handler = new DataAccess_Layer.PolicyHandler();
            return handler.searchFamPol(family_Id);
        }
        public DataTable clientPolSearch(string client_Id)
        {
            DataAccess_Layer.PolicyHandler handler = new DataAccess_Layer.PolicyHandler();
            return handler.searchClientPol(client_Id);
        }
        public void updateStatus(string client_Id) 
        {
            DataAccess_Layer.PolicyHandler handler = new DataAccess_Layer.PolicyHandler();
            handler.updatePolicyStatus(this, client_Id);
        }
        public bool checkStatus(DataTable dt, string status) 
        {
            //checks if there is alreadya policy in progress or not
            if (status == "In Progress")
            {
                foreach (DataRow item in dt.Rows)
                {
                    if (item.Field<string>("Policy_Status") == "In Progress")
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public string generateCode() 
        {
            //generates a unique policy code
            DateTime time = DateTime.Now;
            string year = time.Year.ToString();
            string coverCode="";
            string importance="";
            switch (CoverLevel)
            {
                case "PRT":
                    coverCode = "B";
                    break;
                case "FLL":
                    coverCode = "A";
                    break;
            }
            if (Cost <= 1000)
            {
                importance = "D";
            }
            else if(Cost > 1000 && Cost <= 10000)
            {
                importance = "C";
            }
            else if (Cost > 10000 && Cost <= 100000)
            {
                importance = "B";
            }
            else if (Cost > 100000 && Cost <= 1000000)
            {
                importance = "A";
            }
            Random random = new Random();
            string digits = random.Next(100000, 999999).ToString();
            return String.Format("{0}{1}{2}{3}", year, coverCode, importance, digits);
        }

        internal void addPolicyToClient(int policyID, string clientcode, string polcode)
        {
            DataAccess_Layer.PolicyHandler handler = new DataAccess_Layer.PolicyHandler();
            handler.addPolicyToClient(policyID, clientcode, polcode);
        }

        internal bool searchIfPolicyExists(int policyID, string clientcode)
        {
            DataAccess_Layer.PolicyHandler handler = new DataAccess_Layer.PolicyHandler();
            DataTable dt = handler.searchIfPolicyExists(policyID, clientcode);

            foreach (DataRow dr in dt.Rows)
            {
                if (int.Parse(dr["Total"].ToString()) >1)
                {
                    return false;
                }
                
            }

            return true;
        }
    }
}
