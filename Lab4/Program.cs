using System;
using Lab4_2;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Car kombi = new Car() { Type = "kupe" };
            kombi.Type = "suv";
            Console.WriteLine(kombi.Type);

            Radio rixFm = new Radio(volume: 50, frequency: 107.6);
            Console.WriteLine(rixFm);

            Radio lassesSprakare = new Radio(volume: 88, frequency: 99.9);
            Console.WriteLine(lassesSprakare);

            Radio lyssnaRadio = new Radio(volume: 65, frequency: 101.0);
            Console.WriteLine(lyssnaRadio);
            Console.WriteLine($"Number of radios: {rixFm.ReadInstanceCount}");

            Bike basicBike = new Bike();
            Console.WriteLine(basicBike);

            Bike mountainBike = new Bike(12, "Razer", "mountain", "black", "red", "green");
            Console.WriteLine(mountainBike);
        }
    }
}
