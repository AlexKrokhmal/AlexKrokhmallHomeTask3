using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "HomeTask3";

            int customArraySize = 0;

            Console.WriteLine("The programm allows to eneter the array size and elements and returns min and max values\n");

            //Ask to enter and read array size
            Console.WriteLine("Please enter the array size");
            customArraySize = CheckIfArraySizeValueIsCorrect();

            int[] arrayFromConsole = new int[customArraySize];
            arrayFromConsole = fillArrayElements(arrayFromConsole);
            
            int minArrayValue = arrayFromConsole[0];
            int maxArrayValue = arrayFromConsole[0];

            foreach (var i in arrayFromConsole) //what is the best way to get 2 returned values from method? 
            {
                if (minArrayValue > i)
                {
                    minArrayValue = i;
                }
                if (maxArrayValue < i)
                {
                    maxArrayValue = i;
                }
            }

            Console.WriteLine("******************************************");
            Console.WriteLine("The MIN array value is: {0}", minArrayValue);
            Console.WriteLine("The MAX array value is: {0}", maxArrayValue);
            Console.WriteLine("Press any key to exit");

            Console.ReadLine();
            
        }
                
        //Method to read array elements from console
        static int[] fillArrayElements(int[] incomingArray)
        {
            for (int i = 0; i < incomingArray.Length; i++)  //can we use foreach to fill array from console?
            {
                Console.WriteLine("Please enter the value #{0}", i + 1);
                incomingArray[i] = CheckIfArrayValueIsCorrect();
                Console.WriteLine("You have entered {0}", incomingArray[i]);
            }

            return incomingArray;
        }

        //Method to check if entered arraysize is a correct value (integer in range [1; 2 147 483 647])
        static int CheckIfArraySizeValueIsCorrect()
        {
            bool doWeNeedToRepeat = true;
            int parsedValue = 0;

            do
            {
                if (Int32.TryParse(Console.ReadLine(), out parsedValue) && parsedValue > 0)
                {
                    doWeNeedToRepeat = false;
                }
                else
                {
                    Console.WriteLine("\nYou have entered incorrect value.\nInteger values from range [1; 2 147 483 647] are supported.\nTry again\n");
                }

            } while (doWeNeedToRepeat);

            return parsedValue;

        }

        //Method to check if entered array element value is correct (integer in range [-2 147 483 648; 2 147 483 647])
        static int CheckIfArrayValueIsCorrect()
        {
            bool doWeNeedToRepeat = true;
            int parsedValue = 0;

            do
            {
                if (Int32.TryParse(Console.ReadLine(), out parsedValue))
                {
                    doWeNeedToRepeat = false;
                }
                else
                {
                    Console.WriteLine("\nYou have entered incorrect value.\nInteger values from range [-2 147 483 648; 2 147 483 647] are supported.\nTry again\n");
                }

            } while (doWeNeedToRepeat);

            return parsedValue;
        }


    }
}
