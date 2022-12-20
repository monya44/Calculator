namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float firstNumber;
            float secondNumber;
            float output = 0;

            do
            {
                Console.WriteLine(">>> Choose your action:\n1.Addition\n2.Subtraction\n3.Increase\n4.Division\n5.Exit\n");
                int action = Convert.ToInt32(Console.ReadLine());
                if (action == 5)
                    break;
                Console.WriteLine("Input first number:");
                firstNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input second number:");
                secondNumber = Convert.ToInt32(Console.ReadLine());
                switch(action)
                {
                    case 1:
                    output = firstNumber + secondNumber; break;
                    case 2:
                    output = firstNumber - secondNumber; break;
                    case 3:
                    output = firstNumber * secondNumber; break;
                    case 4:
                    output = firstNumber / secondNumber; break;
                }

                Console.WriteLine(">>> Result: " + output);
                Console.WriteLine();
            }
            while(true);
        }
    }
}