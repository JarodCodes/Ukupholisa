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
        bool status;
        int policyId;
        int cost;
        int providerId;

        public string Name { get => name; set => name = value; }
        public string CoverLevel { get => coverLevel; set => coverLevel = value; }
        public bool Status { get => status; set => status = value; }
        public int PolicyId { get => policyId; set => policyId = value; }
        public int Cost { get => cost; set => cost = value; }
        public int ProviderId { get => providerId; set => providerId = value; }

        public Policy(string name, string coverLevel, bool status, int policyId, int cost, int providerId)
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

        public bool validateStrings(string input)
        {
            throw new NotImplementedException();
        }
    }
}
