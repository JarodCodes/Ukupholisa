using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukupholisa.Provider_Management.Logic_Layer
{
    class PolicyPackage:ICRUD
    {
        int packageId, cost, providerId, policyId;
        string name;
        public PolicyPackage()
        {

        }

        public PolicyPackage(int packageId, int cost, string name, int providerId, int policyId)
        {
            this.PackageId = packageId;
            this.Cost = cost;
            this.Name = name;
            this.ProviderId = providerId;
            this.PolicyId = policyId;
        }

        public int PackageId { get => packageId; set => packageId = value; }
        public int Cost { get => cost; set => cost = value; }
        public string Name { get => name; set => name = value; }
        public int ProviderId { get => providerId; set => providerId = value; }
        public int PolicyId { get => policyId; set => policyId = value; }

        public void add()
        {
            DataAccess_Layer.PolicyHandler handler = new DataAccess_Layer.PolicyHandler();
            handler.createPackage(this);
        }

        public void delete()
        {
            DataAccess_Layer.PolicyHandler handler = new DataAccess_Layer.PolicyHandler();
            handler.deletePackage(PackageId);
        }

        public DataTable populate()
        {
            DataAccess_Layer.PolicyHandler handler = new DataAccess_Layer.PolicyHandler();
            return handler.PopulatePackage();
        }

        public DataTable search()
        {
            DataAccess_Layer.PolicyHandler handler = new DataAccess_Layer.PolicyHandler();
            return handler.searchPackage(PackageId);
        }

        public void update()
        {
            DataAccess_Layer.PolicyHandler handler = new DataAccess_Layer.PolicyHandler();
            handler.updatePackage(this);
        }

        public void addPol()
        {
            DataAccess_Layer.PolicyHandler handler = new DataAccess_Layer.PolicyHandler();
            handler.addPackPolicy(PolicyId, PackageId);
        }
        public void removePol()
        {
            DataAccess_Layer.PolicyHandler handler = new DataAccess_Layer.PolicyHandler();
            handler.removePackPol(PolicyId, PackageId);
        }
        public DataTable packPolSearch()
        {
            DataAccess_Layer.PolicyHandler handler = new DataAccess_Layer.PolicyHandler();
            return handler.populateCurPackPolicy(PackageId);
        }

        public bool validateStrings(string input)
        {
            throw new NotImplementedException();
        }
    }
}
