using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static laba5.Program;

namespace laba5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 1000;
            int n = Convert.ToInt32(textBoxN.Text);
            double x  = Convert.ToDouble(textBoxX.Text);
            double k = Convert.ToDouble(textBoxK.Text);

            StringBuilder resultStringBuilder = new StringBuilder();
            for (int i = 0; i < n; ++i)
            {
                SinSeriesCalculator sin = new SinSeriesCalculator(x, a);
                resultStringBuilder.AppendLine($"Значення sin({x}): {sin.CalculateSinSeries(x, a)}");

                x = x + k;
            }

            MessageBox.Show(resultStringBuilder.ToString(), "Результати обчислень");
        }
    }
}
