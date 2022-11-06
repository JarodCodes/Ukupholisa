using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ukupholisa.Medical_Department.Logic_layer
{
    public class MedCondition:ICRUD
    {
        string name, description, treatment;
        int medConID, policyID, duration;

        public MedCondition() { }
        public MedCondition(string name, string description, string treatment, int medConID, int policyID, int duration)
        {
            this.Name = name;
            this.Description = description;
            this.Treatment = treatment;
            this.MedConID = medConID;
            this.PolicyID = policyID;
            this.Duration = duration;
        }

        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public string Treatment { get => treatment; set => treatment = value; }
        public int MedConID { get => medConID; set => medConID = value; }
        public int PolicyID { get => policyID; set => policyID = value; }
        public int Duration { get => duration; set => duration = value; }

        public void add()
        {
            DataAccess_Layer.MedicalHandler handler = new DataAccess_Layer.MedicalHandler();
            handler.addMedCon(this);
        }

        public void delete()
        {
            DataAccess_Layer.MedicalHandler handler = new DataAccess_Layer.MedicalHandler();
            handler.deleteMedCon(MedConID);
        }

        public DataTable populate()
        {
            DataAccess_Layer.MedicalHandler handler = new DataAccess_Layer.MedicalHandler();
            return handler.PopulateMedCon();
        }

        public DataTable search()
        {
            DataAccess_Layer.MedicalHandler handler = new DataAccess_Layer.MedicalHandler();
            return handler.searchMedCon(Name);
        }

        public void update()
        {
            DataAccess_Layer.MedicalHandler handler = new DataAccess_Layer.MedicalHandler();
            handler.updateMedCon(this);
        }
    }
}
