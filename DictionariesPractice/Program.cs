using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionariesPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //syntax - Dictionary<key data type, value data type> dictionary name
            Dictionary<string, int> studentGrades = new Dictionary<string, int>()
            {
                {"Kerry", 90 }, // Kerry is the key, 90 is the value
                {"Berry", 85 },
                {"Michelle", 100 }
            }; //SEMICOLON


            Dictionary<string, string> snackMachine = new Dictionary<string, string>()
            {
                {"A1", "Snickers" },
                {"A2", "Swedish Fish" },
                {"A3", "Sour Patch Kids" },
                {"A4", "Funyun" }
            };

            Dictionary<int, string> drinkMachine = new Dictionary<int, string>();
            // using the ADD method, let's add drinks to our drink machnie
            //This machine uses just a numbeer to vent an item instead of a letter number pair

            drinkMachine.Add(10, "Ginger Ale");
            drinkMachine.Add(11, "Coke");
            drinkMachine.Add(12, "Lemonade");
            drinkMachine.Add(13, "Pepsi");
            drinkMachine.Add(14, "Water");
            drinkMachine.Add(15, "7 - Up");

            //Count is a property. Returns the size of the dictionary. 
            Console.WriteLine(drinkMachine.Count);

            //We have another property called .Key
            foreach(KeyValuePair<int,string> drink in drinkMachine)
            {
                Console.WriteLine(drink.Key);
            }

            foreach(KeyValuePair<int,string> drink in drinkMachine)
            {
                Console.WriteLine(drink.Value);
            }

            //create a dictionary for a theater coat chack with 10 elements
            //the key will be a number and a value will be a coat style
            //print all values to the console.

            Dictionary<int, string> coatCheack = new Dictionary<int, string>()
            {
                {1, "Rain Coat" },
                {2, "Wool COat" },
                {3, "Trench Coat" },
                {4, "Bomber Jacket" },
                {5, "Leather Jacket"},
                {6, "Cape" },
                {7, "Puffer Jacket" },
                {8, "Pea Coat" },
                {9, "Fleece Jacket" },
                {10, "Hoodie" }
            };

            foreach(KeyValuePair<int,string> coat in coatCheack)
            {
                Console.WriteLine(coat.Value);
            }

            Dictionary<string, string> carValet = new Dictionary<string, string>()
            {
                {"Fudge", "Toyota" },
                {"Riddle", "Kia" },
                {"Hagrid", "Dodge" },
                {"Potter", "Crysler" },
                {"Wealsey", "Nisson" },
                {"Granger", "Honda" },
                {"Malfoy", "Jeep" },
                {"DumbleDdore", "Hyundai" },
                {"Snape", "Fiat" },
                {"Flitwick", "BMW" }

            };
            
            foreach(KeyValuePair<string,string> car in carValet)
            {
                Console.WriteLine(car.Key);
            }

            Dictionary<string, int> zooAnimals = new Dictionary<string, int>()
            {
                {"Tigers", 10 },
                {"Elephants", 100 },
                {"Bears", 12 },
                {"Lions", 2},
                {"Antelopes", 15 },
                {"Anteaters", 90 },
                {"Flying Squrills", 8 },
                {"Panthers", 78 },
                {"Kangaroos", 62 },
                {"Salmon", 3 }

            };

            int highest = 0;


            foreach (KeyValuePair<string, int> animals in zooAnimals)
            {
               if(animals.Value > highest)
                {
                    highest = animals.Value;

                }
            }

            Console.WriteLine(highest);

            if(zooAnimals.ContainsValue(highest))
            {
                Console.WriteLine();
            }


        }

    }
}
