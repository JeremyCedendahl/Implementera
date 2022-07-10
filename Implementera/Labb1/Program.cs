using Labb1.Adapter;
using Labb1.Factory;
using System;
using System.Threading;

namespace Labb1
{
    class Program
    {
       public static void Main()
        {
            Adaptee adaptee = new Adaptee();
            ITarget target = new Adapterr(adaptee);

            Singleton.GetInstance().Typer(target.GetRequest());
            Console.WriteLine();



            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    MakeDish(new BurgerCreator());
                    break;
                case "2":
                    MakeDish(new PizzaCreator());
                    break;

                default:
                    break;
            }
          
        }
   public static void MakeDish(Creator creator)
        {
            Singleton.GetInstance().Typer(creator.FoodOperation()); 
        }
    }
}
