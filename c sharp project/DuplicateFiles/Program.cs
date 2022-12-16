namespace DuplicateFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of testcases: ");
            int testCase = Convert.ToInt32(Console.ReadLine());
            for (int j = 0; j < testCase; j++)
            {
                Console.WriteLine("\n ----------   For TESTCASE {0}  ----------",j);
                Console.Write("Enter the number of files you need to find duplicate for: ");
                int noOfFile = Convert.ToInt32(Console.ReadLine());
                Dictionary <string, int> files = new Dictionary<string, int>();
                int duplNo = 0;
                for (int i = 0; i < noOfFile; i++)
                {
                    string fileName;
                    int fileId;
                    Console.Write("\nEnter the filename{0} and Id{0} seperated by space: ",i+1);
                    
                    string[] fields = Console.ReadLine().Split();
                    fileName= fields[0];
                    fileId= Convert.ToInt32(fields[1]);
                    if (files.ContainsKey(fileName))
                    {
                        if (fileId < files[fileName])
                        {
                            files[fileName] = fileId;
                        }
                        
                    }
                    else
                    {
                        files[fileName] = fileId;
                    }

                }
                int[] values  = new int[files.Count];
                files.Values.CopyTo(values, 0);
                Array.Sort(values);
                Console.WriteLine("the result is ");
                foreach (int i in values)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
            
        }
    }
}