// See https://aka.ms/new-console-template for more information
class Program {

public static void Main(string[] args)
{
        System.Console.WriteLine("Hey , please enter the first number :");
        int a = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Hey , please enter the second number :");
        int b = Convert.ToInt32(Console.ReadLine());

      
        
         // int result = calculateTotal(a, b);
       // System.Console.WriteLine($"result of total value is {result}");
       //int resultMultiply = calculateMultiply(a, b);
       //System.Console.WriteLine($"result of Multiply is {resultMultiply}");
       int resultDivide = calculateDivide(a, b);
       System.Console.WriteLine($"result of Divide is {resultDivide}");

    }

  // calculate the total of 2 values 
// identity the return type of method 
// identify parameters of a method 

    public static int calculateTotal(int a , int b)
    {
        int totalValue = a+b;
        return totalValue;
    }

      public static int calculateMultiply(int a , int b)
    {
        int totalValue = a*b;
        return totalValue;
    }  

      public static int calculateDivide(int a , int b)
    {
        int totalValue = a/b;
        return totalValue;
    }  

}








