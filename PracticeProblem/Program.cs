using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print in console
            /* String fullName;
             fullName= "Divya Nagaraj.";
             String favouriteCar;
             favouriteCar= "Mazda Cx5. ";
             String comicBookhero;
            comicBookhero = "Captian America.";
             Console.WriteLine("My Full Name is " + fullName);
             Console.WriteLine("My Favourite Car " + favouriteCar);
              Console.WriteLine("My Favourite Comic Hero " + comicBookhero);*/
           
            
            
            // declaring the variables has double since we use decimal and whole numbers
            //lisa cooking muffin
           double valueOne, valueTwo;
            valueOne = 7;
            //valueTwo = 2;
            // reusing the variable a
            //valueOne = valueOne - valueTwo;
            Console.WriteLine("Enter the username");
            string userName = Console.ReadLine();//taking input from the user 
            Console.WriteLine("enter the cups you added");
            int cupsadded = int.Parse(Console.ReadLine());
            valueOne = valueOne - cupsadded;
            Console.WriteLine("1)"+userName+ " needs to add  " + valueOne  +" more cup of sugar to make muffin.\n");
           
            //mike and 3 friends
            valueOne = 13;
            valueTwo = 3;
            valueOne = valueOne * valueTwo;
            Console.WriteLine("Enter the Four freinds name at the restaurant");
            String Frnd1 = Console.ReadLine();
            String Frnd2 = Console.ReadLine();
            String Frnd3 = Console.ReadLine();
            String Frnd4 = Console.ReadLine();
            Console.WriteLine( "2) {0}, {1} ,{2} ,{3}  total bill at the restaurant " + valueOne+" dollars.\n" , Frnd1,Frnd2,Frnd3,Frnd4);
            
            //diapers
            valueOne = 40;
            valueTwo = 8;
            valueOne = valueOne/ valueTwo;
            Console.WriteLine("Who went to store to buy diapers?");
            String name= Console.ReadLine();
            Console.WriteLine("3){0} bought "+ valueOne +" diapers.\n",name);
            
            //Trevon's money earned
            valueOne = 29;
            valueTwo = 41;
            valueOne = valueTwo - valueOne;
            Console.WriteLine("Who recived the extra money over weekend for cleaning the attic?");
            String name2 = Console.ReadLine();
            Console.WriteLine("4){0} got "+ valueOne + " dollars more for cleaning the attic.\n",name2);

            //Pranav miles completed
            valueOne = 47;
            valueTwo = 30;
            valueOne = valueOne - valueTwo;
            Console.WriteLine("Enter the Name of the persons to know how many miles he completed.");
            String runner1 = Console.ReadLine();
            Console.WriteLine("5){0} ran "+ valueOne+"miles.\n", runner1);

            //Envelope
            valueOne = 12;
            valueTwo = 3;
            valueOne = valueOne / valueTwo;
            Console.WriteLine("What kind of envelope you want to buy?");
            String enveType = Console.ReadLine();
            Console.WriteLine("6)you will get "+valueOne+" {0} boxes of envelope.\n",enveType);
            
            //Norachi total money
            valueOne = 5.12;
           valueTwo = 27.10;
            valueOne = valueOne + valueTwo;
            Console.WriteLine("Who bought salad for lunch?");
            String person = Console.ReadLine();
            Console.WriteLine("7) Before buying salad {0} had "+ valueOne +" dollars.\n",person);


        }

    }
}
