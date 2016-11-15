using System;
using System.Collections.Generic;

class Car
{
  public string MakeModel;
  public int Price;
  public int Miles;
}

class Inventory
{
  public static void Main()
  {
    Car porsche = new Car();
    porsche.MakeModel = "2014 Porsche 911";
    porsche.Price = 114991;
    porsche.Miles = 7864;

    Car ford = new Car();
    ford.MakeModel = "2011 Ford F450";
    ford.Price = 55995;
    ford.Miles = 14241;

    Car lexus = new Car();
    lexus.MakeModel = "2013 Lexus RX 350";
    lexus.Price = 44700;
    lexus.Miles = 20000;

    Car mercedes = new Car();
    mercedes.MakeModel = "Mercedes Benz CLS550";
    mercedes.Price = 39900;
    mercedes.Miles = 37979;

    List<Car> Dealership = new List<Car>() {porsche, ford, lexus, mercedes};

    Car bmw = new Car();
    bmw.MakeModel = "2014 Bmw X5 3.3";
    bmw.Price = 54700;
    bmw.Miles = 10000;

    Car infiniti = new Car();
    infiniti.MakeModel = "2015 Infiniti QX80";
    infiniti.Price = 90000;
    infiniti.Miles = 10;

    Dealership.Add(bmw);
    Dealership.Add(infiniti);

    foreach (Car vehicle in Dealership)
    {
      Console.WriteLine(vehicle.MakeModel);
    }

    Console.WriteLine("Enter maximum price: ");
    string stringMaxPrice = Console.ReadLine();
    int maxPrice = int.Parse(stringMaxPrice);

    List<Car> CarsMatchingSearch = new List<Car>();

    foreach (Car vehicle in Dealership)
    {
      if (vehicle.Price < maxPrice)
      {
        CarsMatchingSearch.Add(vehicle);
      }
    }
    Console.WriteLine("Here are the cars that match your search: ");
    foreach (Car vehicle in CarsMatchingSearch)
    {
      Console.WriteLine(vehicle.MakeModel);
    }
  }
}
