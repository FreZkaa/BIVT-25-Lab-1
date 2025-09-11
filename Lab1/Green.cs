namespace Lab1
{
    public class Green
    {
        public bool Task1(double d)
        {
            bool answer = false;

            // code here
            //var input = new double[] { 0, 1.5, 1, 3, -1, -2.3, 0.78, -0.3 };
            // var answer = new bool[] { false, true, true, true, true, true, false, false };
            double n = double.Parse(Console.ReadLine());
            if (Math.Abs(n) >= 1.0)
            {
                Console.WriteLine("true");
            }
            else { Console.WriteLine("false"); }
            // end

            return answer;
        }
        public bool Task2(double d, double f)
        {
            bool answer = false;

            // code here
            //var input = new double[] { 0, 1.5, 1, 3, -1, -2.3, 0.78, -0.3 };
            // var answer = new bool[] { false, true, true, true, true, true, false, false };
            double n = double.Parse(Console.ReadLine());
            double t =  double.Parse(Console.ReadLine());
            double summ = n+t;
            if (summ > 0.0)
            {
                Console.WriteLine("true");
            }
            else { Console.WriteLine("false"); }
            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            //var input = new int[] { 0, 5, 2, -3, -2, 11, 22, -31, -418 };
            //var answer = new bool[] { true, true, false, false, true, true, false, false, false };
            int n = int.Parse(Console.ReadLine());
            int t =  int.Parse(Console.ReadLine());
            double summ = n+t;
            if (summ > ((Math.Abs(n) + Math.Abs(t)) / 2))
            {
                Console.WriteLine("true");
            }
            else { Console.WriteLine("false"); }
            // end

            return answer;
        }
        public int Task4(int a, int b, int c)
        {
            int answer = 0;

            // code here
            //var input = new int[] { 0, 5, 2, -3, -2, 11, 22, -31, -418 };
            // var answer = new int[] { 5, 5, 2, 11, 22, 22, 22, 0, 5 };
            int n = int.Parse(Console.ReadLine());
            int t = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int maxx = n > t ? n : t;
            maxx = maxx > p ? maxx : p;
            Console.WriteLine(maxx);
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            //var input = new double[] { 0, 1.5, 1, 0.3, -1, -2.3, 0.78, -0.3 };
            // var answer = new double[] { -1, 0, 0, -0.91, 0, 0, -0.39159999, -0.91 };
            double n = double.Parse(Console.ReadLine());
            double y;
            if (Math.Abs(n) > 1)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(n * n - 1);
            }
            // end

            return answer;
        }
        public bool Task6(double x, double y)
        {
            bool answer = false;

            // code here
            //var input = new double[,] {
            //    { 0, 1.5, 1, 1, -1, 0.3, -1, -0.3, 0.78, -0.3 },
            //    { 0, 2.3, -1, 1, 1, 0.1, 1.23, -0.2, 0.41, 0.69 }
            //};
            //var answer = new bool[] { true, false, false, false, false, true, false, false, false }; ;
            double n = double.Parse(Console.ReadLine());
            double t = double.Parse(Console.ReadLine());
            if (t >= 0)
            {
                if (n < 0 && t <= 1 + n)
                    Console.WriteLine("true");
                else if (n >= 0 && t <= 1 - n)
                    Console.WriteLine("true");
                else { Console.WriteLine("false"); }
            }
            else { Console.WriteLine("false"); }
            // end

            return answer;
        }

        public bool Task7(int n)
        {
            bool answer = true;

            // code here
            //var input = new int[] { 0, 5, 2, -3, -2, 11, 22, -31, -418 };
            // var answer = new bool[] { false, true, false, false, false, true, false, false, false };
            bool f = true;
            int t = int.Parse(Console.ReadLine());
            if (t < 0)
            {
                f = false;
            }
            else
            {
                if (t % 2 == 0)
                {
                    f = false;
                }
                else { f = true; }
            }
            Console.WriteLine(f);
            // end

            return answer;
        }
        public bool Task8(int X, int Y)
        {
            bool answer = false;
            //code here
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int bed = 4 * 60;   
            int wake = 14 * 60;   
            for (int day = 1; day <= x; day++)
            {
                wake -= 60;
                if (day % 2 == 1)
                {
                    bed -= y;
                }
                if (bed < 0) bed += 24 * 60;
                if (wake < 0) wake += 24 * 60;
                if (wake == 7 * 60)
                {
                    int sleep = wake - bed;
                    if (sleep < 0) sleep += 24 * 60; 
                    double h = sleep / 60.0;
                    if (h >= 7 && h <= 9)
                    {
                        Console.WriteLine("true");
                        System.Threading.Thread.CurrentThread.Abort();
                    }
                }
            }
            Console.WriteLine("false");
            // end

            return answer;
        }
    }
}