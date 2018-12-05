using System;
using System.Globalization;

namespace csExercises3
{
    public class Program
    {
        
        public void Question1()
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
        }

        public void Question2()
        {
            //Question 2
            Console.WriteLine("Put hyphen separated numbers and I see if there are duplicates");
            var dupl = Console.ReadLine();
            int [] dupls = Array.ConvertAll(dupl.Split("-"), int.Parse);
            Array.Sort(dupls);
            var truth1 = true;
            for (byte i = 0; i <= dupls.Length - 2; i++)
            {
                if(dupls[i] == dupls[i + 1])
                {
                    System.Console.WriteLine("Duplicates Exist");
                    truth1 = false;
                    break;
                }
            }
            if (truth1 == true)
                System.Console.WriteLine("No Duplicates");
        }
        public void Question3()
        {
            //Question 3
            System.Console.WriteLine("Enter a time (HH:mm) and I will see if it exists");
            string user = Console.ReadLine();
            if (CheckDate(user) == true)
            {
                var date = Convert.ToDateTime(user);
                if (CheckDateString(date) == true)
                {
                    System.Console.WriteLine("Valid");
                } else {
                    System.Console.WriteLine("Not Valid");
                }
            } else {
                System.Console.WriteLine("Not Valid");
            }
        }

        protected bool CheckDate(String date)
        {
            //Function used for Question 3
            try
            {
                DateTime dateValue;
                DateTime dt = DateTime.TryParseExact(date, "HH:mm", new CultureInfo("en-US"), DateTimeStyles.None, out dateValue);
                return true;
            } catch {
                return false;
            }
        }

        protected bool CheckDateString(DateTime date)
        {
            try
            {
                string hourMinute = date.TryParseExact(date, "HH:mm");
                System.Console.WriteLine(hourMinute);
                return true;
            }  catch {
                return false;
            }
        }



        public class test
        {
            static void Main(string[] args)
            {
                var display = new Program();
                // display.Question1();
                // display.Question2();
                display.Question3();
                // var now = DateTime.Now;
                // System.Console.WriteLine(now.ToString("HH:mm"));
            }
        }
    }
}
