using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
// IMPLEMENTADO!!

System.Console.WriteLine("Modelo do Smartphone Iphone");
 Iphone apple = new Iphone(numero: "11980183527",modelo :"Apple", imei: "1111111111111", memoria :64);
apple.Ligar();
apple.ReceberLigacao();
apple.InstalarAplicativo("Linkedin");

System.Console.WriteLine("-------------------------------------------------");


System.Console.WriteLine("Modelo do Smartphone Nokia");
 Nokia nokia = new Nokia(numero: "11980183888",modelo :"Nokia", imei: "222222222222222", memoria :256);
apple.Ligar();
apple.ReceberLigacao();
apple.InstalarAplicativo("Facebook");

