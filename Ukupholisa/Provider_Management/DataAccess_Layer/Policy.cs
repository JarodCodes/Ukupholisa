using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukupholisa.Provider_Management.DataAccess_Layer
{
    class Policy
    {
        string name;
        string coverLevel;
        bool status;
        int policyId;
        int cost;

        public string Name { get => name; set => name = value; }
        public string CoverLevel { get => coverLevel; set => coverLevel = value; }
        public bool Status { get => status; set => status = value; }
        public int PolicyId { get => policyId; set => policyId = value; }
        public int Cost { get => cost; set => cost = value; }

        public Policy(string name, string coverLevel, bool status, int policyId, int cost)
        {
            this.Name = name;
            this.CoverLevel = coverLevel;
            this.Status = status;
            this.PolicyId = policyId;
            this.Cost = cost;
        }
        public Policy()
        {

        }
    }
}
