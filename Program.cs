using DesafioPOO.Models;

Nokia nokia = new Nokia(numero: "123456789", modelo: "Tijolao", imei: "1111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Iphone iphone = new Iphone(numero: "2468101214", modelo: "Iphone 12", imei: "2222222222", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");