namespace Adam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Intput the number of test cases: ");
            int testCase = Convert.ToInt32(Console.ReadLine());
            while (testCase > 0)
            {
                Console.WriteLine("Enter the steps adam would take");

                string word = Console.ReadLine();
                if (word != word.ToUpper())
                {
                    Console.WriteLine("The steps should be in all Caps");
                    continue;

                }
                
                int count = 0;
                foreach(char letter in word)
                {
                    if (letter.Equals('D'))
                    {
                        break;
                    }
                    else if (letter.Equals('U')) 
                    { 
                        count++;
                    }
                    else
                    {
                        Console.WriteLine("Invalid step");
                        break;
                    }
                }
                Console.WriteLine("Adams made {0} steps", count);
                testCase--;
            }
            
                
        }

        
    }
}