using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GSB
{
    static class Model
    {
        private static GSB_ZinadeDataSet   maConnexion;

        public static GSB_ZinadeDataSet MaConnexion
        {
            get
            {
                return maConnexion;
            }

            set
            {
                maConnexion = value;
            }
        }

        public static void initialConnexion()
        {
            maConnexion = new GSB_ZinadeDataSet();
        }
    }
}
