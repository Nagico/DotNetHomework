namespace ConsoleCalculator
{
    public class Util
    {
        /// <summary>
        /// 执行运算
        /// </summary>
        /// <param name="a">数字1</param>
        /// <param name="b">数字2</param>
        /// <param name="op">操作</param>
        /// <returns>运算结果</returns>
        /// <exception cref="FormatException">操作符异常</exception>
        public static decimal Calculate(decimal a, decimal b, string op)
        {
            switch (op)
            {
                case "+":
                    return a + b;
                case "-":
                    return a - b;
                case "*":
                    return a * b;
                case "/":
                    return a / b;
                default:
                    throw new FormatException("Invalid operation");
            }
        }
    }
    class Program
    {
        static IList<string> ops = new List<string>() { "+", "-", "*", "/" };

        /// <summary>
        /// 处理输入
        /// </summary>
        /// <returns>(输入数字1，输入数字2，操作)</returns>
        /// <exception cref="FormatException">输入异常</exception>
        static (decimal, decimal, string) ParseInput()
        {
            Console.WriteLine("Enter first number:");
            var number1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter operation: (+ - * /)");
            var operation = Console.ReadLine();

            if (!ops.Contains(operation))
                throw new FormatException("Invalid operation");

            Console.WriteLine("Enter second number:");
            var number2 = decimal.Parse(Console.ReadLine());

            return (number1, number2, operation);
        }

        static void Main(string[] args)
        {
            try
            {
                var (number1, number2, operation) = ParseInput();
                var result = Util.Calculate(number1, number2, operation);

                Console.WriteLine($"Result: {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Divided by zero");
            }
        }
    }
}