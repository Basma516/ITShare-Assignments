namespace C_BasicsTask01
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("================find the largest of three numbers================");
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            int largest;
            if (num1 >= num2 && num1 >= num3)
            {
                largest = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                largest = num2;
            }
            else
            {
                largest = num3;
            }
            Console.WriteLine($"The largest number is: {largest}");
            Console.WriteLine("=================================================================");

            Console.WriteLine("================find the largest of three numbers by using lists================");
            List<int> numbers = new List<int>();
            Console.Write("Enter first number: ");
            numbers.Add(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Enter second number: ");
            numbers.Add(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Enter third number: ");
            numbers.Add(Convert.ToInt32(Console.ReadLine()));
            int largestNum = numbers.Max();
            Console.WriteLine($"The largest number is: {largestNum}");
            Console.WriteLine("=================================================================");

            Console.WriteLine("============Determining the type of triangle============");
            Console.Write("Enter length of first side: ");
            int side1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter length of second side: ");
            int side2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter length of third side: ");
            int side3 = Convert.ToInt32(Console.ReadLine());
            if (side1 == side2 && side2 == side3)
            {
                Console.WriteLine("The triangle is equilateral.");
            }
            else if (side1 == side2 || side2 == side3 || side1 == side3)
            {
                Console.WriteLine("The triangle is isosceles.");
            }
            else
            {
                Console.WriteLine("The triangle is scalene.");
            }
            Console.WriteLine("=================================================================");
            Console.WriteLine("========== read 10 numbers and find thier avg and sum============ ");
            int[] arr = new int[10];
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
                sum += arr[i];
            }
            double average = sum / arr.Length;
            Console.WriteLine($"Sum of the Numbers is {sum} and thier Average is {average}.");
            Console.WriteLine("=================================================================");

            Console.WriteLine("============Display the multiplication table of the given number============");
            Console.Write("Enter a number to display its multiplication table: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Multiplication table of {number}:");
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine($"{number} x {i + 1} = {number * (i + 1)}");
            }

            Console.WriteLine("=================================================================");
            Console.WriteLine("=======Factorial of the given number by using Recursion function");
            Console.Write("Enter a number to calc Factorial:");
            int num = Convert.ToInt32(Console.ReadLine());
            int fact = Factorial(num);
            Console.WriteLine($"Factorial of {num} is {fact}.");
            Console.WriteLine("=================================================================");
            while (true)
            {
                Console.WriteLine("============ Prime Number or Not ============");
                Console.Write("Enter the number (or 0 to exit): ");
                int input = int.Parse(Console.ReadLine());
                if (input == 0)
                    break;
                if (Prime(input))
                    Console.WriteLine($"The {input} is Prime");
                else
                    Console.WriteLine($"The {input} is Not Prime");
            }

        }
        //5*4*3*2*1
        public static int Factorial(int number)
        {
            if (number < 0)
                return 0; 
            if (number == 0 || number == 1)
                return 1;
            return number * Factorial(number - 1);
        }

        // prime number is a number that is only divisible by 1 and itself.
        // prime number > 0 and 1 is not prime number
        public static bool Prime(int number)
        {
            if (number <= 1)
                return false;

            for (int i = 2; i < number; i++)
            {
                // if accept then not prime
                if (number % i == 0)
                    return false;
            }
            // if not accept then prime
            return true;
        }

    }
}