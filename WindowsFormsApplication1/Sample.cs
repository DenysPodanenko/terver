using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApplication1
{
    class Sample
    {
        public List<double> numbers;
        public List<double> pockets;

        public Sample()
        {
            numbers = new List<double>();
            pockets = new List<double>();
        }

        public Sample(string path)
        {
            numbers = new List<double>();
            pockets = new List<double>();

            StreamReader sr = new StreamReader(path);

            while (!sr.EndOfStream)
            {
                string strNum = sr.ReadLine();
                numbers.Add(double.Parse(strNum));
            }


        }

        public double sampleMean()
        {
            int sum = 0;
            foreach (int num in this.numbers)
            {
                sum = sum + num;
            }

            return (double)sum / (double)this.numbers.Count;
        }

        public double sampleVariance()
        {
            double sum = 0;
            foreach (int num in this.numbers)
            {
                sum = sum + Math.Pow((double)(num - this.sampleMean()), (double)2);
            }

            return sum / ((double)this.numbers.Count - 1);
        }

        public double sampleStandartDeviation()
        {
            return Math.Sqrt(this.sampleVariance());
        }

        public double sampleAsymetry()
        {
            double sum = 0;
            foreach (int num in this.numbers)
            {
                sum = sum + Math.Pow((num - this.sampleMean()), (double)3);
            }

            return sum / (double)(this.numbers.Count * Math.Pow(this.sampleStandartDeviation(), (double)3));
        }

        public double sampleExces()
        {
            double sum = 0;
            foreach (int num in this.numbers)
            {
                sum = sum + Math.Pow((num - this.sampleMean()), (double)4);
            }

            return (sum / (double)(this.numbers.Count * Math.Pow(this.sampleStandartDeviation(), (double)4)))-(double)3;
        }

        public Dictionary<string, int> getValueOfPockets()
        {
            Dictionary<string, int> value = new Dictionary<string, int>();

            int valueCount = 0;

            for (int i = 0; i < pockets.Count - 1; i++)
            {
                int z1 = i;
                int z2 = i+1;
                valueCount = 0;

                foreach (int num in numbers)
                {
                    if (i == pockets.Count - 2)
                    {
                        if (num >= pockets.ElementAt(z1) && num <= pockets.ElementAt(z2))
                        {
                            valueCount++;
                        }
                    }
                    else
                    {
                        if (num >= pockets.ElementAt(z1) && num < pockets.ElementAt(z2))
                        {
                            valueCount++;
                        }
                    }
                }

                string one = pockets.ElementAt(z1).ToString();
                string two = pockets.ElementAt(z2).ToString();

                string str = "[" + one + "-" + two + ")";

                value.Add(str, valueCount);
            }

            return value;
        }

        public void setPockets()
        {
            double min = numbers.Min();
            double max = numbers.Max();
            double step = (double)(max - min) / Math.Sqrt(numbers.Count);

            double pocket = min;
            
            while (pocket<max)
            {
                pockets.Add(pocket);
                pocket = pocket + step;
            }
            if (pockets.Last() != max)
            {
                double x = max - pocket;
                pocket = pocket + x;
                pockets.Add(pocket);
            }
        }
    }
}
