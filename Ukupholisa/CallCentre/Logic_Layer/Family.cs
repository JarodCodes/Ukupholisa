using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukupholisa.CallCentre.Logic_Layer
{
    internal class Family:ICRUD
    {
        int familyID;
        string family_Surname;
        string family_role;

        public Family()
        {
        }

        public Family(int familyID, string family_Surname, string family_role)
        {
            this.familyID = familyID;
            this.family_Surname = family_Surname;
            this.family_role = family_role;
        }

        public int FamilyID { get => familyID; set => familyID = value; }
        internal string Family_Surname { get => family_Surname; set => family_Surname = value; }

        internal string Family_role { get => family_Surname; set => family_Surname = value; }

        public void add()
        {
            throw new NotImplementedException();
        }

        public void delete()
        {
            throw new NotImplementedException();
        }

        public DataTable populate()
        {
            throw new NotImplementedException();
        }

        public DataTable search()
        {
            throw new NotImplementedException();
        }

        public void update()
        {
            throw new NotImplementedException();
        }
    }
}
