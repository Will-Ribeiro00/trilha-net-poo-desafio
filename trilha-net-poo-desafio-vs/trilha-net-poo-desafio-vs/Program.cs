using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia nokia = new(numero:"(11)99293-3372",chip:"Oi",imei:"111111",modelo:"G400",memoria:512);

Console.WriteLine("Smartphone Nokia:");
nokia.Ligar();
nokia.InstalarAplicativo("Telegram");
nokia.DesinstalarAplicativo("Twitter");

Console.WriteLine("\n");

Iphone iphone = new(numero: "(11)94572-9383",chip: "Tim", imei:"222222",modelo:"15 Pro-Max",memoria:256);
Console.WriteLine("Smartphone iPhone:");
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");
iphone.DesinstalarAplicativo("SnapChat");

Console.WriteLine("\n");

Motorola motorola = new(numero: "(11)963300-8174",chip:"Claro",  imei: "333333", modelo: "Edge 30 Ultra",128);
Console.WriteLine("Smartphone Motorola:");
motorola.Ligar();
motorola.InstalarAplicativo("LinkedIn");
motorola.DesinstalarAplicativo("Free Fire");

Console.WriteLine("\n");

Samsung samsung= new(numero:"(11)95759-3949",chip:"Vivo", imei:"444444", modelo:"S23 Pro",68);
Console.WriteLine("Smartphone Samsung:");
samsung.ReceberLigacao();
samsung.InstalarAplicativo("Facebook");
samsung.DesinstalarAplicativo("Duolingo");