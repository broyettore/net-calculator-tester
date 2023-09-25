using net_calculator_tester.Classes;

namespace net_calculator_tester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert two numbers please: ");
            int num1;
            int num2;

            while (!int.TryParse(Console.ReadLine(), out num1))
            {
                Console.Write("Insert a valid number please: ");
            }

            while (!int.TryParse(Console.ReadLine(), out num2))
            {
                Console.Write("Insert a valid number please: ");
            }

            try
            {
                float testAdd = Calculator.Add(num1, num2);
                float testSub = Calculator.Substract(num1, num2);
                float testDivide = Calculator.Divide(num1, num2);
                float testMultiply = Calculator.Multiply(num1, num2);

                Console.WriteLine($"The result for adding tow numbers is: {testAdd}");
                Console.WriteLine($"The result for adding tow numbers is: {testSub}");
                Console.WriteLine($"The result for adding tow numbers is: {testDivide}");
                Console.WriteLine($"The result for adding tow numbers is: {testMultiply}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}