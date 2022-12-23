using Perfectnumbers;


namespace Perfectnumbers
{
    class Program
    {
        static void Main(string [] args)
        {
            int i, j;

            Console.WriteLine("please enter your starting number");
            int start = int.Parse(Console.ReadLine());

            Console.WriteLine("your ending number");
            int end = int.Parse(Console.ReadLine());

            Console.WriteLine("perfect Numbers between {0} and {1} are :", start,end);


            for (i = start; i <= end; i++)
            {
                int sum = 0;    
                for (j = 1; j < i; j++)
                {
                    if (i % j == 0)
                        sum+= j;
                }
                if (i == sum)
                    Console.WriteLine("{0}", i);
            }
        }



    }
    
}