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
            Person person = new Person("Krytia" );
            Person showAge = new Person(19);
            Console.WriteLine(person.SayHello);



            // set a value in the Name property of the Person class

            //person.Name = "Tom";

            // get the Name value and print to console

            Console.WriteLine(person.SayHello);
            Console.WriteLine(person.ShowAge);
        }
       

    }

}