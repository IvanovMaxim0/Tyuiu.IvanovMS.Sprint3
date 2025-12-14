using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.IvanovMS.Sprint3.Task1.V22.Lib
{
    public class DataService : ISprint3Task1V22
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sumseries = 1;
            while (startValue <= stopValue)
            {
                sumseries = sumseries + ((Math.Pow(value, startValue) + 0.5) * Math.Cos(startValue));
                startValue++;
            }
            return Math.Round(sumseries, 3);
        }
    }
}

