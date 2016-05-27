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

    * @field {string}_name 
    *@field {int} age


*/

    public class Person

    {

        // PRIVATE INSTANCE VARIABLES ++++++++++++++++++++++++++++++++++

        private string _name;

        private int _age;


        // PUBLIC PROPERTIES ++++++++++++++++++++++++++++++++++++++++++

        /**
        *<summary>
        * This is a property for our _SayHello field
        </summary>

        *

        * @property {string} Name

*/

        public string Name

        {

            get

            {

                return this._name;

            }

            set

            {
                //Console.WriteLine("_name value set");
                this._name = value;

            }

        }

        /**
        *<summary>This is the default empty constructor for the Person class 
        *</summary>
        * 
        *

        * @constructor Person

*/

        public Person()// this is an example of a constructor || "triggers" || default constructor 

        {
            //initialize public properties 
            this.Name = "Unknown Name!!";
            this.Age = 0;


        }

        /**

        * This is a consructor that takes name as a parameter and passes

        * it to the _sayHello private instance variable

        *

        * @constructor Person

        * @param {string} name

*/

        public Person(string name)

        {

            this.Name = name;
            this.SaysHello();

        }
        /*
        *<summay>
        *This method outputs the _name value with "says Hello " to the console
        *</summary>
        *@ method _saysHello
        *@returns {void}
        */

        public void SaysHello()
        {
            Console.WriteLine(this._name + " Says Hello!");

        }


        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        //+++++++++++++++++++++++++++++AGE++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /*
   *<summary>
   *This is a public property for our private _age field
   *</summary>
   *@property int Age
   */
        public int Age
        {
            get
            {
                return this._age;
            }
            set
            {
                this._age = value;
            }
        }
        /*
        *<summary> 
        *this is a constructor that takes age as a param && passes
        *it to the _age provate instance var   
        *</summary>
        *  @constructor Person
        *@param int age
        */
        public Person(int age)
        {
            this.Name = "Unknown Name !!";
            this.Age = age;

        }
        /*
        *<summary>
        * this is a constuctor that takes both name and age as param
        *assigns the local nameval to the name prop
        * assigns the local age val to the age prop
        *</summary>
        */
        public Person (string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        /**
        *<summary>
        *this method outputs the _name && _age value in the following format :(this.Name + "is" + this.Age +"Years Old")
        *</summary>
        *@method ShowAge
        *@returns void 
        */

        public void ShowsAge()
        {
            Console.WriteLine(this.Name + " is " + this.Age + " Years Old");
        }

    }
}

