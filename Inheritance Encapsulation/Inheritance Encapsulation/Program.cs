using Inheritance_Encapsulation.Models;
using System;
using System.Reflection;

namespace Inheritance_Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person();
            //person.age = 44;
            ////Console.WriteLine(person.age);

            //Employee employee1 = new Employee();
            //employee1.age = person.age;

            //Console.WriteLine(employee1.age);

            //Dog dog = new Dog("Rex");
            //Console.WriteLine(dog.name);

            //Dog dog1 = new Dog("Toplan");
            //Console.WriteLine(dog1.name);

            //Employee employee = new Employee("7021212");

            //Person person = new Person("7031313");


            //Person person = new Person();

            //person.ShowSurname();


            //show private fields with reflection
            //var ShowSurname = typeof(Person).GetField("surname", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(person);

            //typeof(Person).GetField("_surname", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(person, "newValue");

            //Console.WriteLine(ShowSurname);

            //Person person = new Person();

            //person.Age = 88;

            //Console.WriteLine(person.Age);

            //person.MyProperty = 77;
            //Console.WriteLine(person.MyProperty);

            //Cars cars = new Cars();



        }
    }
}
