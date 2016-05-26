﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W3_L3;

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

            Person person = new Person("Tom");

            Console.WriteLine(person.Name);

            // set a value in the Name property of the Person class

            //person.Name = "Tom";

            // get the Name value and print to console

            Console.WriteLine(person.Name);

        }

    }

}