using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia (Parâmetros Corretos): ");
Smartphone nokia = new Nokia(numero: "84900000000", modelo: "Tijolão", imei: "000000000", memoria: 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\nSmartphone Iphone (Parâmetros Corretos): ");
Smartphone iphone = new Iphone(numero: "84900000000", modelo: "12", imei: "111111111", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");

Console.WriteLine("\nSmartphone Iphone (Memória com valor não permitido): ");
Smartphone iphoneMemoriaInvalida = new Iphone(numero: "84900000000", modelo: "12", imei: "111111111", memoria: 200);

Console.WriteLine("\nSmartphone Iphone (Número Inválido): ");
Smartphone iphoneNumeroInvalido = new Iphone(numero: "8490000000000", modelo: "12", imei: "111111111", memoria: 128);