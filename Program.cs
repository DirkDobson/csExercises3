using System;

namespace csExercises3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            Console.WriteLine("Put hyphen separated numbers and I see if they are consecutive");
            var consec = Console.ReadLine();
            int [] numbers = Array.ConvertAll(consec.Split("-"), int.Parse);
            Array.Sort(numbers);
            bool truth = true;
            for (byte i = 0; i <= numbers.Length - 2; i++)
            {
                if(numbers[i] + 1 != numbers[i + 1])
                {
                    System.Console.WriteLine("Not Consecutive");
                    truth = false;
                    break;
                }
            }
            if(truth == true) 
                System.Console.WriteLine("Consecutive");

            //Question 2
            Console.WriteLine("Put hyphen separated numbers and I see if there are duplicates");
            var dupl = Console.ReadLine();
            int [] dupls = Array.ConvertAll(consec.Split("-"), int.Parse);
            Array.Sort(dupls);
            truth = true;
            for (byte i = 0; i <= dupls.Length - 1; i++)
            {
                if(dupls[i] == dupls[i + 1])
                {
                    System.Console.WriteLine("Duplicates Exist");
                    truth = false;
                    break;
                }
            }
            if(truth == true)
                System.Console.WriteLine("No Duplicates");
        }
    }
}
