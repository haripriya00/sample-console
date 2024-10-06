using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sampleconsole
{
    internal class Program
    {
        static void Main(string[] args)
        {



            
                
                Console.WriteLine("Enter three numbers:");
                int num1 = Convert.ToInt32(Console.ReadLine());
                int num2 = Convert.ToInt32(Console.ReadLine());
                int num3 = Convert.ToInt32(Console.ReadLine());

                int secondLargest;

               
                if ((num1 > num2 && num1 < num3) || (num1 > num3 && num1 < num2))
                {
                    secondLargest = num1;
                }
                else if ((num2 > num1 && num2 < num3) || (num2 > num3 && num2 < num1))
                {
                    secondLargest = num2;
                }
                else
                {
                    secondLargest = num3;
                }

                
                Console.WriteLine("The second largest number is: " + secondLargest);
            Console.WriteLine("The second largest number is: " + secondLargest);
        }
        }

    


    }
 

