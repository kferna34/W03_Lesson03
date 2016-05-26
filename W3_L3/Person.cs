using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3_L3
{
    /**

    * This class defines a generic Person

    *

    * @class Person

    * @field _name {string}

*/

    public class Person

    {

        // PRIVATE INSTANCE VARIABLES ++++++++++++++++++++++++++++++++++

        private string _sayHello;
        private int _showAge;


        // PUBLIC PROPERTIES ++++++++++++++++++++++++++++++++++++++++++

        /**

        * This is a property for our _name field

        *

        * @property {string} Name

*/

        public string SayHello

        {

            get

            {

                return this._sayHello;

            }

            set

            {

                this._sayHello = value;

            }

        }

        /**

        * This is the default empty constructor for the Person class

        *

        * @constructor Person

*/

        public Person()

        {

            this._sayHello = "Unknown Name!! ";

        }

        /**

        * This is a consructor that takes name as a parameter and passes

        * it to the _sayHello private instance variable

        *

        * @constructor Person

        * @param {string} name

*/

        public Person(string sayHello)

        {

            this._sayHello = sayHello;

        }
        /**

        * This is a consructor that takes name as a parameter and passes

        * it to the _showAge private instance variable

        *

        * @constructor Person

        * @param {int} age

*/

        public int ShowAge
        {
            get
            {
                return this._showAge;
            }
            set
            {
                this._showAge = value;
            }
        }


        public Person(int ShowAge)
        {
            this._showAge = 20;
        }

    }
}

