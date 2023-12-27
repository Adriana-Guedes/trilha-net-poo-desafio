using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero:"54214569",modelo:"Modelo 1", imei: "3333333333333", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero:"8955",modelo:"Modelo 2", imei: "111111111111111", memoria: 128);
iphone.ReceberLigacao();
nokia.InstalarAplicativo("Telegram");
