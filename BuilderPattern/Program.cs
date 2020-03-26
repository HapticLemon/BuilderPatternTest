using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var director = new CDirector();
            var builderN1 = new CEquipadorN1();
            var builderN5 = new CEquipadorN5();
            var builderN10 = new CEquipadorN10();

            director.BuilderN1 = builderN1;

            director.buildFullFeaturedMonsterN1();
            Console.WriteLine(builderN1.GetProduct().ListParts());

            director.BuilderN5 = builderN5;

            director.buildFullFeaturedMonsterN5();
            Console.WriteLine(builderN5.GetProduct().ListParts());

            director.BuilderN10 = builderN10;

            director.buildFullFeaturedMonsterN10();
            Console.WriteLine(builderN10.GetProduct().ListParts());

        }
    }
}
