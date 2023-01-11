namespace Kamranın_tapşırıqlarından
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //verilmish n ededinin sade ve ya murekkeb oldugunu tapan 
            int n=Convert.ToInt32(Console.ReadLine());
            int counter = 0;

            if (n==0)
            {
                Console.WriteLine("0 ne sadedir ne murekkeb");
            }
            else if (n<0)
            {
                for (int i = 2; i < -n-1; i++)
                {
                    if (n % i == 0)
                    {
                        counter++;
                        

                    }

                }
            }

            else
            {
                for (int i = 2; i < n-1; i++)
                {
                    if (n%i==0)
                    {
                        counter++;

                    }

                }
            }
            if (counter>0)
            {
                Console.WriteLine(n + " murekkeb ededdir");
            }
            else if(n!=0)
            {
                Console.WriteLine(n + " sade eddir");
            }


        }
    }
}