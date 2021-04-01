using System;
using static System.Console;
using SimUDuckLibrary.Models.DuckModels;
using SimUDuckLibrary.Models.FlyModels;

namespace SimUDuckApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var view = new ConsoleView();
            var mallardDuck = new MallardDuck();
            var rubberDuck = new RubberDuck();
            var modelDuck = new ModelDuck();
            view.Info(mallardDuck);
            view.Info(rubberDuck);
            view.Info(modelDuck);
            modelDuck.Flyable = new FlyRocketPowered();
            view.Info(modelDuck);
        }
    }
}
