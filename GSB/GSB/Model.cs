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
        private static GSB_ZinadeEntities maConnexion;
        private static Visiteur visiteurConnecte;

        public static GSB_ZinadeEntities MaConnexion
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

        public static Visiteur VisiteurConnecte
        {
            get
            {
                return visiteurConnecte;
            }

            set
            {
                visiteurConnecte = value;
            }
        }

        public static void initialConnexion()
        {
            maConnexion = new GSB_ZinadeEntities();
        }

    }
}
