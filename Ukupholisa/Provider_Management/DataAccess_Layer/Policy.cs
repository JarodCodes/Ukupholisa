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
        string policyId;

        public string Name { get => name; set => name = value; }
        public string CoverLevel { get => coverLevel; set => coverLevel = value; }
        public bool Status { get => status; set => status = value; }
        public string PolicyId { get => policyId; set => policyId = value; }

        public Policy(string name, string coverLevel, bool status, string policyId)
        {
            this.Name = name;
            this.CoverLevel = coverLevel;
            this.Status = status;
            this.PolicyId = policyId;
        }
        public Policy()
        {

        }
    }
}
