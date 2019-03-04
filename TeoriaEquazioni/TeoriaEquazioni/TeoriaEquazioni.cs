using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeoriaEquazioni
{
    public class TeoriaEquazioni
    {
        public static bool IsDetermined(double a)
        {
            bool resp = true;
            if (a == 0)
            {
                resp = false;
            }
            return resp;
        }
    }
}
