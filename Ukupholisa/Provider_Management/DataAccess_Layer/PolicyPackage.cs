using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukupholisa.Provider_Management.DataAccess_Layer
{
    class PolicyPackage
    {
        int packageId, cost, providerId;
        string name;
        public PolicyPackage()
        {

        }

        public PolicyPackage(int packageId, int cost, string name, int providerId)
        {
            this.PackageId = packageId;
            this.Cost = cost;
            this.Name = name;
            this.ProviderId = providerId;
        }

        public int PackageId { get => packageId; set => packageId = value; }
        public int Cost { get => cost; set => cost = value; }
        public string Name { get => name; set => name = value; }
        public int ProviderId { get => providerId; set => providerId = value; }
    }
}
