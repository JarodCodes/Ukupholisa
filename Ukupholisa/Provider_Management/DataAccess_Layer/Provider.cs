using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukupholisa.Provider_Management.DataAccess_Layer
{
    public class Provider
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
    }
}
