using System;

public class ParameterDemo
{
    // 1. Method using ref keyword
    public void Increase(ref int number)
    {
        number += 10;
    }

    // 2. Method using out keyword
    public void GetFullName(out string fullname)
    {
        fullname = "Preeti Mehta";  
    }

    // 3. Method using params array
    public int SumAll(params int[] numbers)
    {
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        return sum;
    }
}
