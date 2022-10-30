using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Ukupholisa
{
    public interface ICRUD
    {
        DataTable populate();
        DataTable search();
        void add();
        void update();
        void delete();

        bool validateStrings(string input);        
    }
}
