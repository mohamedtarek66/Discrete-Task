namespace ConsoleApp2
{
    internal class Program
    {   
        static void Main(string[] args)
        {

            Console.Write("Enter the Start Number : ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the End Number : ");
            int n2 = int.Parse(Console.ReadLine());


            for (int i = n1; i <= n2; i++)
            {
                int c = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (j == 1 || i == j)
                        c++;
 
                    else if (i % j == 0)
                        break;
                }
                if (c == 2)
                    Console.WriteLine("{0} is Prime Number", i);
            }


        }
    }
}