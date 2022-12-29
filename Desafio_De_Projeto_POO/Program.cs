using Desafio_De_Projeto_POO.Models;
// TODO: Realizar os testes com as classes Nokia e Iphone

System.Console.WriteLine("Nokia");
Nokia N = new Nokia("81951451","Modelo 01", "1205596", 32);

N.Ligar();
N.InstalarAplicativo("Instagram");
N.ReceberLigacao();
N.Calculadora();


System.Console.WriteLine("Iphone");
Iphone iphone = new Iphone("0123","IPhone 8", "123546", 256);
iphone.Calculadora();
iphone.InstalarAplicativo("Telegram");
iphone.ReceberLigacao();
iphone.Ligar();