
using System.Net.Security;
using C_Examples.Examples;
using static C_Examples.Examples.EnumExample;

//textExample.Run();

//variableExample.Run();

//numberExample.Run();

//assignmentExample.Run();

//commentExample.Run();

//methodExample.Run();

//Car car = new Car();
//Console.WriteLine("Araç rengi:"+ car.color);

#region motocycle class
Motocycle Honda = new Motocycle();

Honda.color = "mavi";
Honda.gearType = "otomatik vites";
Honda.horsePower = 18;
Honda.year = 2023;
Honda.topSpeed = 117;
Honda.model = "pcx 125";

Console.WriteLine("Model: " + Honda.model);
Console.WriteLine("Renk: " + Honda.color);
Console.WriteLine("Beygir: " + Honda.horsePower);
Console.WriteLine("Son hız: " + Honda.topSpeed);
Console.WriteLine("Çıkış yılı: " + Honda.year);
Console.WriteLine("Vites tipi: " + Honda.gearType);
//Console.WriteLine("Aydınlatma: " + Honda.headLight); //Private olduğu için hata vericektir 
//Erişim belirleyicisi belirtilmezse class yapısında varsayılan olarak  private olur 

Motocycle.runEngine();

SuperMoto Ducati = new SuperMoto();
Console.WriteLine(Ducati.color);
Console.WriteLine(Ducati.model);

Ducati.horn();

#endregion


#region Car class 
Car Ford = new Car("white", "otomatik vites", 220, 2024, 259, "Mustang", "Ford");

Console.WriteLine("Renk: " + Ford.color); Console.WriteLine("Model: " + Honda.model);
Console.WriteLine("Beygir: " + Ford.horsePower);
Console.WriteLine("Son hız: " + Ford.topSpeed);
Console.WriteLine("Çıkış yılı: " + Ford.year);
Console.WriteLine("Vites tipi: " + Ford.gearType);

#endregion


#region personal class

Personal sDeveloper = new Personal();
sDeveloper.Name = "Alperen";

Console.WriteLine(sDeveloper.Name);

#endregion


#region Animal class 

Animal myAnimal = new Animal();
Animal myDog = new Dog();
Animal myCat = new Cat();

myAnimal.animalSound();
myDog.animalSound();
myCat.animalSound();

#endregion


#region games class 

Valorant reyna = new Valorant();

reyna.gameMusic();

#endregion


#region interface example 

RaceBicycle myRaceBicycle = new RaceBicycle();
myRaceBicycle.bicycleRide();

#endregion

#region Enum Example 

Level lowLevel = Level.Low;
Console.WriteLine("En düşük seviye: " + lowLevel);

switch (lowLevel)
{
    case Level.Low:
        Console.WriteLine("Düşük level");
        break;

    case Level.Medium:
        Console.WriteLine("Orta seviye");
        break;

    case Level.High:
        Console.WriteLine("Yüksek seviye");
        break;     
}

int firstMonth = (int)Months.January;
Console.WriteLine(firstMonth);

#endregion


Console.ReadKey();

