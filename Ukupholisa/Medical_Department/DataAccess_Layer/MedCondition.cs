using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukupholisa.Medical_Department.DataAccess_Layer
{
    public class MedCondition
    {
        string name, description, treatment;
        int medConID, policyID;

        public MedCondition(string name, string description, string treatment, int medConID, int policyID)
        {
            this.Name = name;
            this.Description = description;
            this.Treatment = treatment;
            this.MedConID = medConID;
            this.PolicyID = policyID;
        }

        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public string Treatment { get => treatment; set => treatment = value; }
        public int MedConID { get => medConID; set => medConID = value; }
        public int PolicyID { get => policyID; set => policyID = value; }
    }
}
