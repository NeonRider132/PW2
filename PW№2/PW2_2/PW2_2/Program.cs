using System.Reflection.Metadata.Ecma335;

namespace PW2_2
{
    class programm
    {
        static void Main()
        {
            replic number = new replic();
            for (int i = 0; i < number.Getn(); i++)
            {
                number.SetNumber(Convert.ToInt32(Console.ReadLine()));
            }
        }
    }
    class replic
    {
        private int n = 0;
        public void SetNumber(int number)
        {
            if (number == n + 1)
            {
                Console.WriteLine(Convert.ToInt32(Getn()));
                n = number;
            }
            else
            {
                Console.WriteLine(Convert.ToInt32(Getn()));
                Console.WriteLine("error");
                n = 0;
            }
        }
        public bool Ret()
        {
            return Ret();
        }
        public int Getn()
        {
            return n + 1;
        }
    }

}