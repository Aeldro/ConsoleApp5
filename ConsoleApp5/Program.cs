namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static float Add(float x, float y)
            {
                return x + y;
            }

            static float Substract(float x, float y)
            {
                return x - y;
            }

            static float Multiply(float x, float y)
            {
                return x * y;
            }

            static float Divide(float x, float y)
            {
                return x / y;
            }

            static int Modulo(int x, int y)
            {
                return x % y;
            }

            while (true)
            {
                Console.WriteLine("Enter a number.");
                float firstNumber = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter another number.");
                float secondNumber = float.Parse(Console.ReadLine());
                Console.WriteLine("Chose an operation. (add, substract, multiply, divide, modulo)");
                string operation = Console.ReadLine();

                if (operation == "add")
                {
                    float result = Add(firstNumber, secondNumber);
                    Console.WriteLine($"{firstNumber} + {secondNumber} = {result}");
                } else if (operation == "substract") { 
                    float result = Substract(firstNumber, secondNumber);
                    Console.WriteLine($"{firstNumber} - {secondNumber} = {result}");
                } else if (operation == "multiply")
                {
                    float result = Multiply(firstNumber, secondNumber);
                    Console.WriteLine($"{firstNumber} x {secondNumber} = {result}");
                } else if (operation == "divide") {
                    float result = Divide(firstNumber, secondNumber);
                    Console.WriteLine($"{firstNumber} / {secondNumber} = {result}");
                } else if (operation == "modulo")
                {
                    float result = Modulo(Convert.ToInt32(firstNumber), Convert.ToInt32(secondNumber));
                    Console.WriteLine($"{firstNumber} % {secondNumber} = {result}");
                } else
                {
                    Console.WriteLine("Wrong operation.");
                }

            }
        }
    }
}
