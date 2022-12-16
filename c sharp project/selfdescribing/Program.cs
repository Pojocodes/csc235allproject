namespace selfdescribing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Intput the number of test cases: ");
            int testCase = Convert.ToInt32(Console.ReadLine());
            while (testCase > 0)
            {
                Console.WriteLine("input the number");
                int number = Convert.ToInt32(Console.ReadLine());
                int temp = number;
                bool x = true;
                int noofdigit = GetNumDigit(number) - 1;
                while (temp > 0)
                {
                    int digit = temp % 10;
                    int count = NoOfOccurence(number, noofdigit);
                    if (count != digit)
                    {
                        Console.WriteLine("Not self-describing");
                        x = false;
                        break;
                    }
                    temp /= 10;
                    noofdigit--;


                }

                if (x)
                {
                    Console.WriteLine("Self-Describing");
                }
                testCase--;
            }
            


            
        }

        static int NoOfOccurence(int num, int digit)
        {
            int count = 0;
            while (num>0)
            {
                if(num%10 == digit)
                {
                    count++;
                }
                num /= 10;
            }
            return count;
        }

        static int GetNumDigit(long num)
        {
            int digit = 0;
            while (num > 0)
            {
                num/=10;
                digit++;
            }
            return digit;
        }
    }
}