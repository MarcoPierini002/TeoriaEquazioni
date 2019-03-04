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
        public static bool IsDegree2(double a, double b)
        {
            bool resp = true;
            if (a == 0)
            {
                resp = false;
            }
            return resp;
        }

        public static double Delta(double a, double b, double c)
        {
            double resp = 0;
            resp = (b * b) - (4 * (a * c));
            return resp;
        }
    }
}
