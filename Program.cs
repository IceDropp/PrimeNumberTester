namespace PrimeNumberTester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number that you want to be checked:");
            int number = int.Parse(Console.ReadLine());
            int testNumber = number / 2;
            int flag = 0;
            for (int i = 2; i <= testNumber; i++)
            {
                if (testNumber % i == 0)
                {
                    Console.Write("Number is not Prime.");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.WriteLine("Number is Prime");
        }
    }
}
