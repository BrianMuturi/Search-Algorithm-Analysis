using System;

namespace Search_Algorithm_Analysis
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Please enter some integers, separated by spaces:");
            string input = Console.ReadLine();
            string[] integers = input.Split(' ');            
            int[] data = new int[integers.Length];
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = int.Parse(integers[i]);
            }  
            while (true)
            {
                Console.WriteLine("Please enter a number you want to find:");
                input = Console.ReadLine();
                if (input.Length == 0)
                {
                    break;
                }              
                int searchItem = int.Parse(input);
                Console.WriteLine("Please enter a position to start searching from: ");
                input = Console.ReadLine();
                int searchPos = int.Parse(input);
                int foundPos = IntArrayLinearSearch(data, searchItem, searchPos);
                if (foundPos < 0)
                {
                    Console.WriteLine("Item {0} not found", searchItem);
                }
                else
                {
                    Console.WriteLine("Item {0} found at position {1}", searchItem, foundPos);
                }        
            }
        }
        public static int IntArrayLinearSearch(int[] data, int item, int start)
        {
            int N = data.Length;
            if (start < 0)
            {
                return -1;
            }    
            for (int i = start; i < N; i++)
            {
                if (data[i] == item)
                {
                    return i;
                }                 
            }                
            return -1;
        }
    }

}
