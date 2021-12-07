using System;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines(@"input.txt");
            int lastNum = 0;
            int retVal = -1;
            foreach(string line in lines){
                int thisNum = Int32.Parse(line);
                if(thisNum > lastNum){
                    retVal++;
                }
                lastNum = thisNum;

            }
            Console.WriteLine(retVal);
        }
    }
}
