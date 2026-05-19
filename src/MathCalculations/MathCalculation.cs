namespace MathCalculations;

public class MathCalculation
{
    public double Sum(params double[] input)
    {
        double result = 0;
        foreach (var value in input)
        {
            result += value;
        }
        return result;
    }

    public double Pow(double baseValue, double exponent)
    {
        return Math.Pow(baseValue, exponent);
    }
}
