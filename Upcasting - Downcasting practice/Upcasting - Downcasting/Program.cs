using System;
using Upcasting___Downcasting.Models;

namespace Upcasting___Downcasting
{
    class Program
    {
        static void Main(string[] args)
        {
            //Eagle eagle = new Eagle();
            //Animal animal = eagle;
            //Eagle eagle2 = new Eagle();
            //Shark shark = new Shark();
            //Animal shark1 = shark;

            //Animal[] forest = { eagle, animal, eagle2, shark, shark1 };
            //foreach (var item in forest)
            //{

            //    item.Eat();

            //}
            Child child = new Child();
            Family family = child;
            Child sister =(Child) family; 

            //Family[] guys = { child, family };
            //foreach(var item in guys)
            //{
            //    item.Survive();
            //}

            //child.Survive();

        }
    }
}
