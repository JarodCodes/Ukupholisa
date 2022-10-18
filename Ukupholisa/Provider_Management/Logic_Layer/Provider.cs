using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukupholisa.Provider_Management.Logic_Layer
{
    public class Provider:ICRUD
    {
        int providerId;
        string name, location;
        int status;

        public Provider() { }
        public Provider(int providerId, string name, string location, int status)
        {
            this.providerId = providerId;
            this.name = name;
            this.location = location;
            this.status = status;
        }

        public int ProviderId { get => providerId; set => providerId = value; }
        public string Name { get => name; set => name = value; }
        public string Location { get => location; set => location = value; }
        public int Status { get => status; set => status = value; }

        public void add()
        {
            DataAccess_Layer.PolicyHandler handler = new DataAccess_Layer.PolicyHandler();
            handler.addProvider(this);
        }

        public void delete()
        {
            DataAccess_Layer.PolicyHandler handler = new DataAccess_Layer.PolicyHandler();
            handler.deleteProvider(ProviderId);
        }

        public DataTable populate()
        {
            DataAccess_Layer.PolicyHandler handler = new DataAccess_Layer.PolicyHandler();
            return handler.PopulateMedProv();
        }

        public DataTable search()
        {
            DataAccess_Layer.PolicyHandler handler = new DataAccess_Layer.PolicyHandler();
            return handler.searchProvider(ProviderId);
        }

        public void update()
        {
            DataAccess_Layer.PolicyHandler handler = new DataAccess_Layer.PolicyHandler();
            handler.addProvider(this);
        }

    }
}
