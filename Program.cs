using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Smartphone nokia = new Nokia("123456", "Modelo 1", "1111111", 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Telegram");

Smartphone iphone = new Iphone("654321", "Modelo 2", "222222", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");
