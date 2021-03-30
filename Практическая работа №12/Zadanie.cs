using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_работа__12
{
    class Zadanie
    {
        public double LengthOtrAC(double A, double C)
        {
            double AC = C - A;
            return AC;

        }
        public double LengthOtrBC(double B, double C)
        {
            double BC = C - B;
            return BC;

        }
        public double SumOtr(double A, double B, double C)
        {
            double AC = C - A;
            double BC = C - B;
            double sum = AC + BC;
            return sum;
        }

        public int Time(int N)
        {
            N %= 3600;
            N /= 60;
            int Min = N;
            return Min;
        }

    }
}
