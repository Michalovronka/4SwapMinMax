using System.Numerics;

namespace _4SwapMinMax;

class Program
{
    static void Main(string[] args)
    {
        int number1 = 1;
        int number2 = 2;
        SwapInt(number1, number2);
        
        string word1 = "Word";
        string word2 = "Worlds";
        SwapString(word1,word2);
        
        decimal decimal1 = 1.6555m;
        decimal decimal2 = 89.6555m;
        SwapDecimal(decimal1,decimal2);

        MaxInt(number1, number2);
        MaxDecimal(decimal1, decimal2);
        
        MinInt(number1, number2);
        MinDecimal(decimal1, decimal2);

        Console.Read();
        
        
        
    }

    static void SwapInt(int variable1, int variable2)
    {
        SwapVariables(variable1,variable2);
    }
    static void SwapString(string variable1, string variable2)
    {
        SwapVariables(variable1,variable2);
    } 
    static void SwapDecimal(decimal variable1, decimal variable2)
    {
        SwapVariables(variable1,variable2);
    }
    
    static void MaxInt(int variable1, int variable2)
    {
        Console.WriteLine($"\nMaxInt: {MaxVariable(variable1, variable2)}");
    }
    static void MaxDecimal(decimal variable1, decimal variable2)
    {
        Console.WriteLine($"\nMaxDecimal: {MaxVariable(variable1, variable2)}");
    }
    
    static void MinInt(int variable1, int variable2)
    {
        Console.WriteLine($"\nMinInt: {MinVariable(variable1, variable2)}");
    }
    static void MinDecimal(decimal variable1, decimal variable2)
    {
        Console.WriteLine($"\nMinDecimal: {MinVariable(variable1, variable2)}");
    }
    
    
    static void SwapVariables<T> (T variable1,  T variable2)
    {
        Console.WriteLine($"\nBefore swap:\n variable 1: {variable1} \n variable 2: {variable2}");
        T help = variable1;
        variable1 = variable2;
        variable2 = help;
        Console.WriteLine($"After swap:\n variable 1: {variable1} \n variable 2: {variable2}");
    } 
    static T MaxVariable <T>(T variable1,  T variable2) where T : INumber<T>
    {
        if (variable1 > variable2)
        {
            return variable1;
        }
        return variable2;
    }
    
    static T MinVariable <T>(T variable1,  T variable2) where T : INumber<T>
    {
        if (variable1 < variable2)
        {
            return variable1;
        }
        return variable2;
    }
}
