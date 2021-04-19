using System;
//using System.Linq;
using System.Text;

namespace HomeworkTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(args[0]);
            int maxIterations = args[0].Length;
            int maxLength = 0;
            StringBuilder sequence = new StringBuilder();
            for (int i = 0; i < maxIterations; i++)
            {
                //char value = args.GetValue(i);
                //char value = args[0].ElementAt(i);
                //usable and cleaner, but linq requiered
                //TODO: check after linq learned
                char value = args[0][i];
                sequence.Append(value);
                for (int j = 0; j < sequence.Length-1; j++)
                    if (sequence[j] == value)
                    {
                        sequence.Remove(0, j+1);
                        break;
                    }
                if (sequence.Length > maxLength) maxLength = sequence.Length;

            }
            Console.WriteLine(maxLength);
        }
    }
}
