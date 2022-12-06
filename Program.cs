using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("------------------ Smartphone Nokia ------------------");
Smartphone nokia = new Nokia("119613387749", "tijolao", "JASIJ23", 32);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("whatsapp");

Console.WriteLine("\n");

Console.WriteLine("------------------ Smartphone Iphone ------------------");
Smartphone iphone = new Iphone("11961380749", "iphone 14 pro max", "HFHAOIS23", 126);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Candy Crush");