using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukupholisa.Medical_Department.Logic_Layer
{
    public class MedCondition
    {
        string name, description, treatment, medConID;

        public MedCondition(string name, string description, string treatment, string medConID)
        {
            this.Name = name;
            this.Description = description;
            this.Treatment = treatment;
            this.MedConID = medConID;
        }

        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public string Treatment { get => treatment; set => treatment = value; }
        public string MedConID { get => medConID; set => medConID = value; }
    }
}
