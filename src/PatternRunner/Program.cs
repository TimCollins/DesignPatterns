using System;
using BlackWasp.Builder;

namespace PatternRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            MealDirector director = new MealDirector();
            MealBuilder jv = new JollyVegetarianMealBuilder();

            director.MakeMeal(jv);

            Console.WriteLine(jv.GetMeal());

            MealBuilder mm = new MischievousMexicanBuilder();

            director.MakeMeal(mm);

            Console.WriteLine(mm.GetMeal());

            ConsoleUtils.WaitForEscape();
        }        
    }
}

