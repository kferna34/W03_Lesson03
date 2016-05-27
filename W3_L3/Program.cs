using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3_L3
{

    /**

    * This class is the "driver" class for our Program

    *

    * @class Program

*/

    public class Program

    {

        /**

        * the main method for our driver class Program

        *

        * @method Main

        * @param {sting[]} args

*/

        public static void Main(string[] args)

        {

            // create a new instance of the Person class
            Person angela = new Person(); //display by assigning val in a var
            angela.Name = "Angela";
            angela.Age = 27;
            angela.SaysHello();
            angela.ShowsAge();
            Console.WriteLine();


            Person krytia = new Person("Krytia "); // same as displaying says hello as new ("")
            krytia.Age = 19;
            krytia.ShowsAge();

            Console.WriteLine();

            Person trini = new Person(20);
            trini.Name = "Trini";
            trini.SaysHello();
            trini.ShowsAge();

            Console.WriteLine(); //display
            Person alyssa = new Person("Alyssa", 23);
            alyssa.SaysHello();
            alyssa.ShowsAge();









            // set a value in the Name property of the Person class

            //person.Name = "whatever name";

            // get the Name value and print to console



        }


    }

}