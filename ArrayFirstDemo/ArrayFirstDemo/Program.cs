using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayFirstDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the first demo of arrays");
            int tickets;
            Console.WriteLine("Write the number of tickets you would like to process");
            while(!int.TryParse(Console.ReadLine(), out tickets)|| tickets<=0 || tickets > 100)
            {
                Console.WriteLine("Sorry we cant process the tickets that are bewlo zero and above 100");
                Console.WriteLine("Please enter the amount below above zero and below 100, enter a integer value");

            }

            int[] nums = new int[tickets];
            Calcbags(nums);
            sum(nums);
        }

        static void Calcbags(int[] dest)
        {
            Console.WriteLine("Here we will be entering the number of bags");
            

            for(int i=0; i<dest.Length; i++)
            {
                int code = 0;
                Console.WriteLine("Please enter the number of bag for destination" + i);
                while(!int.TryParse(Console.ReadLine(), out code)|| code>3|| code < 0)
                {
                    Console.WriteLine(" cannot be more than 3 or less than 0");
                    Console.WriteLine("Please enter the values again");

                }

                dest[i] = code;

            }

            }
         static void sum (int[] sums)
        {
            Console.WriteLine("Here we will be calculating the avg of your bags for the all trips");

            int adds = 0;
            foreach( int add in sums)
            {

                
                Console.WriteLine("avg is" + adds/add);  
            
               
            }

            

        }

        }
      
    }

