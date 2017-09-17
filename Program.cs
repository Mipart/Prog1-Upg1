using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPG1
{
    //Marcus Forsberg TE16
    class Program
    {
        static void Main(string[] args)
        {
            //declarerar och tilldelar variabler
            char firstChar = 'M'; 
            char secondChar = 'F';
            float myFloat = 4.5f;
            int myInt = 5;

            //Declarerar en array, samt bestämmer längden på den.
            int[] myArray = new int[10];
            //For lopen går igenom tio gånger, och varje gång tilldelar en
            //av myArrays positioner med motsvarande "varv". i står för vilket varv.
            for(int i = 0; i < 10; i++)
                {
                myArray[i] = i;
                }

            //Går igenom alla positioner i myArray och läser upp dem i consolen.
            foreach (int element in myArray)
            {
                System.Console.WriteLine(element);
            }

            //testar för att se vilket värde myFloat har. Berättar också
            // i consolen sedan vilket värde myFloat hade.
            if(myFloat < 4f)
            {
                Console.WriteLine("myFloat är mindre än 4");
            } else if (myFloat == 4.5f)
            {
                Console.WriteLine("myFloat är lika med 4.5");
            } else
            {
                Console.WriteLine("myFloar är varken mindre än 4, eller lika med 4.5");
            }
            //Skriver ut de declarerade ¨char¨ variablerna
            Console.WriteLine(firstChar);
            Console.WriteLine(secondChar);
            //läser av ett knapptryck, för att programet inte ska
            //automatiskt stänga av sig själv efter den läst klart all kod.
            Console.ReadKey();

        }
    }
}
