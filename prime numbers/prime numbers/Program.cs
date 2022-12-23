using Primenumbers;


namespace Primenumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            
            Console.WriteLine("enter your starting number");
            int start = int.Parse(Console.ReadLine());

            Console.WriteLine("your ending number");
            int end = int.Parse(Console.ReadLine());

            Console.WriteLine("Prime Numbers between {0} and {1} are :",start,end);


            for (i = start; i <= end; i++)
            {
                for (j = 2; j < i; j++)
                {
                    if (i % j == 0)
                        break;
                }
                if (i == j)
                    Console.WriteLine("{0}", i);
            }
        }

    }

}
