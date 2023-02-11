using System;

////        IF STATEMENT
///

/*
 * if(condition){
 *      what to do if condition is met
 * }else if(condition2){
 *      what to do if condition2 is met
 * }else {
 *      what to do if none of the conditions is met
 * }
 *             TRY PARSE
 *             
 * static void Main(string[] args) {
 *      
 *      string numberAsString ="128";
 *      float parsedValue; /// can also be other datatypes (ex. int, double, etc)
 *      
 *      bool success = float.TryParse(numberAsString, out parsedValue);
 *      
 *      if(success)
 *          Console.WriteLine("Parsing successful - number is " + parseValue);
 *      else
 *          Console.WriteLine("Parsing failed");
 * }
 * 
 *      parsing will fail: string age = "18xyz";
 *                         
 *          
 */

namespace If_ElseIF_Else_Statement
{
    class Project
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's the temperature like?");
            string temperature = Console.ReadLine();
            // Parse --- will have a problem when entering different value that int(datatype)
            // int numTemp = int.Parse(temperature);

            //TryParse ---avoids the problem of Parse
            int numTemp;
            int number;
            bool userEnteredANumber = int.TryParse(temperature, out number);
            
            //if(int.TryParse(temperature, out number))
            if(userEnteredANumber)
            {
                numTemp = number;
            }
            else
            {
                numTemp = 0;
                Console.WriteLine("Value entered, has no number. 0 set as temperature");
            }

            if(numTemp < 20)
            {
                Console.WriteLine("Take the coat");
            }

            else if(numTemp == 20)
            {
                Console.WriteLine("Pants and Pull Over should be fine");
            }
            else if(numTemp > 30)
            {
                Console.WriteLine("It's supper hot!");
            }

            else// 21 to 29
            {
                Console.WriteLine("Shorts are enough today");
            }

            Console.Read();
        }
    }
}