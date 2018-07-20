using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            addIntNumbers(78, 989);

            addDoubleNumbers(78, 989);



            Console.ReadKey();

        }

         static int  AddIntNumbers(int num1,int num2)
        {

              

                int totalNumbers = num1 + num2;

                Console.WriteLine("The number" + num1 + " + " + num2 + " is " + totalNumbers);

               

            
        }

         static double AddDoubleNumbers(double num1, double num2)
        {


            double totalNumbers = num1 + num2;

            Console.WriteLine("The number" + num1 + " + " + num2 + " is " + totalNumbers);




        }



        


    }
}
