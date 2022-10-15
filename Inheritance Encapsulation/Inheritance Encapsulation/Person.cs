using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Encapsulation
{
    class Person
    {
        //public string name;
        //public string surname;
        //public string address;
        //public int age;

        internal string name;
        private string surname;
        protected string address;
        public int _age = 13;

        public int Age {
            get
            {
                if (_age<18)
                {
                    Console.WriteLine("Can not see");
                    return 404;
                }
                return _age;
            }

            set
            {
                _age = value;
            }
        
        }









        //public Person()
        //{
        //    surname = "Narimanli";
        //}

        //public void ShowSurname()
        //{
        //    Console.WriteLine(surname);
        //}



        //public Person(string phone)
        //{
        //    //Console.WriteLine(phone);
        //}
    }
}
