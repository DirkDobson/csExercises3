﻿using System;
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
            System.Console.WriteLine("Enter a time (HH:mm) and I will see if it is in that format");
            string user = Console.ReadLine();
            CultureInfo enUS = new CultureInfo("en-US"); 
            DateTime dateValue;
            
            if (DateTime.TryParseExact(user, "HH:mm", enUS, 
                                        DateTimeStyles.None, out dateValue))
                Console.WriteLine("'{0}' is acceptable", user);
            else
                Console.WriteLine("'{0}' is not in an acceptable format.", user);
        }

        public void Question4()
        {
            //Question 4
            System.Console.WriteLine("Enter a few words separated by a space and I will make it PascalCase");
            var user = Console.ReadLine();
            string newUser = user.ToLower();
            string [] words = newUser.Split(" ");
            string [] display = new string[words.Length]; 
            string [] first = new string[words.Length];
            for (byte i = 0; i <= words.Length -1; i++)
            {
               first[i] = words[i].Substring(0,1).ToUpper();
               display[i] = words[i].Substring(1);
            }
            System.Console.WriteLine();
            for(byte i = 0; i <= words.Length - 1; i++)
            {
                Console.Write("{0}{1}", first[i], display[i]);
            }
            System.Console.WriteLine();
        }

        public void Question5()
        {
            System.Console.WriteLine("I will count the vowels in an English word");
            string word = Console.ReadLine().ToLower();
            int count = 0;
            foreach(var i in word)
            {
                switch (i) 
                {
                    case 'a' :
                        count++;
                        break;
                    case 'e' :
                        count++;
                        break;
                    case 'i' :
                        count++;
                        break;
                    case 'o' :
                        count++;
                        break;
                    case 'u' :
                        count++;
                        break;
                }
            }
            if (count == 0)
            {
                foreach(var i in word)
                {
                    if(i == 'y')
                        count++;
                }
            }
            System.Console.WriteLine(count);
        }

        public class test
        {
            static void Main(string[] args)
            {
                var display = new Program();
                display.Question1();
                display.Question2();
                display.Question3();
                display.Question4();
                display.Question5();
            }
        }
    }
}
