namespace Discrete
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the Start Number : ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the End Number : ");
            int n2 = int.Parse(Console.ReadLine());

            for (int i = n1; i < n2; i++)
            {
                int sum = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                        sum += j;
                }
                if (sum == 0)
                    continue;
                if (i == sum)

                    Console.WriteLine("{0} is Perfect Number", i);
            }



        }
    }
}