using System;
using System.Collections.Generic;
using System.Linq;

namespace problemset1
{
    class Program
    {

        static void Main(string[] args)
        {
            // Q2a();
            // Q2b();
            // Q2c();
            // Q2d();  

            // Q3();

            // Q4();
        }

        static void Q2a()
        {
            string super = "Supercalifragilisticexpialidocious";
            //checks string length
            string superLength = super.Length.ToString();
            Console.WriteLine("Question 2a");
            Console.WriteLine(superLength);
            Console.WriteLine(" ");
        }

        static void Q2b()
        {
            Console.WriteLine("Question 2b");
            string super = "Supercalifragilisticexpialidocious";
            //checks if Contains ice
            if (super.Contains("ice") == true)
            {
                Console.WriteLine("Supercalifragilisticexpialidocious contains 'ice'");
                Console.WriteLine(" ");
            }
            else
            {
                Console.WriteLine("Supercalifragilisticexpialidocious does not contains 'ice'");
                Console.WriteLine(" ");
            }
        }

        static void Q2c()
        {
            Console.WriteLine("Question 2c");
            //created arr with all 3 words
            string[] arr = new string[3];
            arr[0] = "Supercalifragilisticexpialidocious";
            arr[1] = "Bababadalgharaghtakamminarronnkonn"; 
            arr[2] = "Honorificabilitudinitatibus";

            int w1 = arr[0].Length;
            int w2 = arr[1].Length;
            int w3 = arr[2].Length;

            string vWord1 = arr[0];
            string vWord2 = arr[1];
            string vWord3 = arr[2];

            //check if any values are the same
            if (w1 == w2 || w2 == w3 || w3 == w1)
            {
                if (w1 == w2)
                {                  
                    Console.WriteLine(vWord1 + " and " + vWord2 + "are the same length");
                }
                if (w2 == w3)
                {
                    Console.WriteLine(vWord2 + " and " + vWord3 + "are the same length");
                }
                if (w3 == w1)
                {
                    Console.WriteLine(vWord1 + " and " + vWord3 + "are the same length");
                }
            }
            //compares all values 
            else
            {
                if (w1 > w2)
                {
                    if (w1 > w3)
                    {
                        Console.WriteLine("The biggest word is: " + vWord1);
                    }
                    else
                    {
                        Console.WriteLine("The biggest word is: " + vWord3);
                    }
                }
                else
                {
                    if (w2 > w3)
                    {
                        Console.WriteLine("The biggest word is: " + vWord2);
                    }
                    else
                    {
                        Console.WriteLine("The biggest word is: " + vWord3);
                    }
                }
            }         
        }
        static void Q2d()
        {
            var composers = new SortedSet<string>();
            composers.Add("Berlioz");
            composers.Add("Borodin");
            composers.Add("Brian");
            composers.Add("Bartok");
            composers.Add("Bellini");
            composers.Add("Buxtehude");
            composers.Add("Bernstein");

          
            Console.WriteLine("The first composer is " +composers.ElementAtOrDefault(0));
            Console.WriteLine("The last composer is " + composers.ElementAtOrDefault(6));
          
        }

        static void Q3()
        {
            Console.WriteLine("Question 3");
            double area = 0;         
            double s = 0; 
            Console.Write("Enter a length: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter a length: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter a length: ");
            double c = Convert.ToDouble(Console.ReadLine());

            s = (a + b + c) / 2;
            Console.WriteLine(s);
            area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            //https://www.geeksforgeeks.org/c-sharp-math-sqrt-method/#:~:text=In%20C%23%2C%20Math.,cached%20for%20a%20performance%20boost. 
            //used to find square root funtion
            Console.WriteLine(area);
        }

        static void Q4()
        {
            Console.Write("element - 0: ");
            int e0 = Convert.ToInt32(Console.ReadLine());
            Console.Write("element - 1: ");
            int e1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("element - 2: ");
            int e2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("element - 3: ");
            int e3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("element - 4: ");
            int e4 = Convert.ToInt32(Console.ReadLine());


            int[] arr = new int[5];
            arr[0] = e0;
            arr[1] = e1;
            arr[2] = e2;
            arr[3] = e3;
            arr[4] = e4;

            List<int> even = new List<int>();
            List<int> odd = new List<int>();

            foreach (var i in arr)
            {
                if (i%2 == 0)
                {
                    even.Add(i);
                }
                else
                {
                    odd.Add(i);
                }
            }
            Console.Write("The Even elements are: ");
            foreach (int i in even)
            {                
                Console.Write(i + " ");
            }
            Console.WriteLine("");
            Console.Write("The Odd elements are: ");            
            foreach (int i in odd)
            {
                Console.Write(i + " ");
            }
            //https://www.codegrepper.com/code-examples/csharp/c%23+print+array+one+line 
            //for printing on single line (their syntax is different but showed me that write rather than write line exists)

        }
    }
}
