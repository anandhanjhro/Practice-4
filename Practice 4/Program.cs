using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int number = 10;
             int number2 = 32;

             if ( number == 10 && number2 == 32)
             {
                 Console.WriteLine("Numbers are equal ");
             }*/


            // here is the ternary operator

            /*int numb = 20;
            bool isnumb10 = numb == 20 ? true : false;
            *//*bool isnumb10;
            if (numb == 10)
            {
                isnumb10 = true;
            }
            else
            {
                isnumb10 = false;
            }*//*
            Console.WriteLine("Number == 10 is {0}", isnumb10);// it will return flase because nmber is not eqaul to 10*/

            //Conversion of data types this is implicit conversion
            /*int i = 20;
            float f = i;
            Console.WriteLine(f);*/
            //============================
            /*float fl = 987.89F;
            int i = (int)fl;
            Console.WriteLine(i); // ooutput will be 987 because of explicit conversion*/
            //============================
            /*int[] array1 = new int[10];
            array1[0] = 1;
            array1[1] = 2;
            array1[2] = 3;
            array1[3] = 4;
            array1[4] = 5;
            array1[5] = 6;
            array1[6] = 7;
            array1[7] = 8;
            array1[8] = 9;
            array1[9] = 10;

            
            Console.WriteLine(array1[0] + " - " + array1[1]);
            Console.WriteLine(array1[9]);
            //Forward for Loop
            for (int i = 0; i >=array1.Length-1; i++)
            {
                Console.WriteLine(array1[i]);
            }
            for (int i = array1.Length - 1; i >= 0; i--) 
            {
                Console.WriteLine(array1[i]);
            }*/
            //==================================
            int totalamount = 0;

            Start:
            Console.WriteLine("1-small, 2- medium, 3-large");
            int choice = int.Parse(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    totalamount += 1;
                    break;
                case 2:
                    totalamount += 2;
                    break;
                case 3:
                    totalamount += 3;
                    break;
                default:
                    Console.WriteLine("Your number {0} is invalid", choice);
                    break;
            }
            Decide:
            Console.WriteLine("Do you want another coffee Yes or No");
            string userChoice = Console.ReadLine();

            switch(userChoice)
            {
                case "Yes":
                    goto Start;
                case "No":
                    break;
                default:
                    Console.WriteLine("Your choice is {0} is invalid, Please try again");
                    goto Decide;
            }    


            Console.WriteLine("Thank you for shopping");
            Console.WriteLine("Cost of cofee is {0}", totalamount);



        }
    }
}

