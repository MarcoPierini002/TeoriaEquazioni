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

        public static bool IsnotDetermined(double a, double b)
        {
            bool resp = false;
            if (a == 0 && b != 0)
            {
                resp = true;
            }
            return resp;
        }
        public static bool IsImpossible(double a, double b)
        {
            bool resp = false;
            if (a == 0 && b != 0)
            {
                resp = true;

            }
            return resp;
        }
    }
}
