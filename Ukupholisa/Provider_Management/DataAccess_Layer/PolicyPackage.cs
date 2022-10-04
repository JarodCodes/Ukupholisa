using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukupholisa.Provider_Management.DataAccess_Layer
{
    class PolicyPackage
    {
        List<Policy> policies;

        public PolicyPackage()
        {

        }

        public PolicyPackage(List<Policy> policies)
        {
            this.Policies = policies;
        }

        internal List<Policy> Policies { get => policies; set => policies = value; }
    }
}
