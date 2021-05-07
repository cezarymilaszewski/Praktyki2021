using System.Runtime.InteropServices.ComTypes;

namespace praca
{
    public class Kalkulator
    {

        private int C;
        public int D;

        public Kalkulator(int c, int d)
        {
            C = c;
            D = d;
        }

        public int Substract()
        {
            return C - D;

        }
    }
}