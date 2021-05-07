using System.Runtime.InteropServices.ComTypes;

namespace zadanie
{
    public class calculator
    {
        public int A;
        public int B;


        public calculator(int a, int b)
        {
            A = a;
            B = b;
        }

        public int Add()
        {
            return A + B;

        }
    }
    }
    
    