namespace PW2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            equa equation = new equa();
            Console.WriteLine(equation.VarA());
            Console.WriteLine(equation.VarB());
            Console.WriteLine(equation.VarC());
            equation.CalculateRoots();
        }
    }
    public class equa
    {
        private double a = -1;
        private double b = 2;
        private double c = 3;
        public double VarA()
        {
            return a;
        }
        public double VarB()
        {
            return b;
        }
        public double VarC()
        {
            return c;
        }
        public void SetA(double a)
        {
            this.a = a;
        }
        public void SetB(double b)
        {
            this.b = b;
        }
        public void SetC(double c)
        {
            this.c = c;
        }
        private double discrim()
        {
            return (VarB() * VarB()) - 4 * VarA() * VarC();
        }
        public void CalculateRoots()
        {
            if (discrim() > 0 || discrim() == 0)
            {
                double x1 = (-VarB() + Math.Sqrt(Convert.ToInt32(discrim()))) / (2 * VarA());
                double x2 = (-VarB() - Math.Sqrt(Convert.ToInt32(discrim()))) / (2 * VarA());
                Console.WriteLine("x1= {0}   x2= {1}", x1, x2);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Действительных корней нет");
                Console.ReadKey();
            }
        }
    }
}
