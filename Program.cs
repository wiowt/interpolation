using System;

namespace Interpolation
{
    class Program
    {
        public static double F(double[,] b, int k, double x)
        {
            int i,t = 0;

            for (i=0; i<=k-2; i+=1)
            {
                if (x>=b[0,i] && x<=b[0,i+1])
                {
                    t = i;
                    break;
                }

            }
            double y = b[1,t] + (x-b[0,t])*(b[1,t+1]-b[1,t])/(b[0,t+1]-b[0,t]);
            return y;
        }
        static void Main()
        {
            //подразумевается, что сначала вводится число пар n, затем пары x1,y1,x2,y2,..., а затем точка x, в которой нужно посчитать зн-ие
            int n = Convert.ToInt32(Console.ReadLine());
            double[,] a = new double[2,n];
            int i;
            for (i=0; i<=n-1; i+=1)
            {
                a[0,i] = Convert.ToDouble(Console.ReadLine());
                a[1,i] = Convert.ToDouble(Console.ReadLine());

            }
            double x0 = Convert.ToDouble(Console.ReadLine());
            double y0 = F(a,n,x0);
            Console.WriteLine(y0);

            
            
        }
    }
}
