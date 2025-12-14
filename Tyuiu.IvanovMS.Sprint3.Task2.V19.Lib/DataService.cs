using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.IvanovMS.Sprint3.Task2.V19.Lib
{
    public class DataService : ISprint3Task2V19
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double sumseries = 0;
            int i = 1;
            do
            {
                sumseries = sumseries + (Math.Cos(i) * 0.5);
                startValue++;
            } while (startValue <= stopValue);
            return Math.Round(sumseries, 3);
        }
    }
}
