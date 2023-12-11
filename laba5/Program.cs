using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba5
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
        public class SinSeriesCalculator
        {
            public double x;
            public int n;

            public SinSeriesCalculator(double x, int n)
            {
                this.x = x;
                this.n = n;
            }
            public double CalculateSinSeries(double x, int n)
            {
                double result = 0;

                for (int i = 0; i <= n; i++)
                {
                    result += Math.Pow(-1, i) * Math.Pow(x, 2 * i + 1) / Factorial(2 * i + 1);
                }

                return result;
            }

            public double CalculateSinSeriesRecursive(double x, int n)
            {
                if (n == 0)
                {
                    return x;
                }

                return Math.Pow(-1, n) * Math.Pow(x, 2 * n + 1) / Factorial(2 * n + 1) + CalculateSinSeriesRecursive(x, n - 1);
            }

            public double Factorial(int number)
            {
                if (number == 0)
                {
                    return 1;
                }

                return number * Factorial(number - 1);
            }
        }
}
