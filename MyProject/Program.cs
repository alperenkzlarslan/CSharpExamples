
using C_Examples.Examples;

//textExample.Run();

//variableExample.Run();

//numberExample.Run();

//assignmentExample.Run();

//commentExample.Run();

//methodExample.Run();

//Car car = new Car();
//Console.WriteLine("Araç rengi:"+ car.color);


Motorcycle Honda = new Motorcycle();
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
Motorcycle.runEngine();


Console.ReadKey();

