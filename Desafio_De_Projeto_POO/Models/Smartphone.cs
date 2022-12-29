using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_De_Projeto_POO.Models
{
    public abstract class Smartphone
{

        public string Numero { get; set; }
        private string IMEI { get; set; }
        private string Modelo { get; set; }
        private int Memoria { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama

        public Smartphone(string numero,string modelo,string imei,int memoria)
        {
            Numero = numero;
            IMEI=imei;
            Modelo=modelo;
            Memoria = memoria;
            
            // TODO: Passar os parâmetros do construtor para as propriedades
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);

        public void Calculadora(){
            int Opcao =0;
            System.Console.WriteLine("Você esta na calculadora o que deseja fazer ? ");
            System.Console.WriteLine("Digite 1 para Somar");
            System.Console.WriteLine("Digite 2 para Subtrair");
            System.Console.WriteLine("Digite 3 para Multiplicar");
            System.Console.WriteLine("Digite 4 para dividir");
            
            System.Console.WriteLine("Escolha sua opção:");
            int.TryParse(Console.ReadLine(), out Opcao);
            
            switch (Opcao)
            {
                case 1:
                System.Console.WriteLine("Digite um numero:");
                int.TryParse(Console.ReadLine(), out int num1);
                
                System.Console.WriteLine("Digite um numero:");
                int.TryParse(Console.ReadLine(), out int num2);

                int resultado= num1+num2;

                System.Console.WriteLine($"{num1}+{num2}={resultado}");
                break;
          
                case 2:
                System.Console.WriteLine("Digite um numero:");
                int.TryParse(Console.ReadLine(), out  num1);
                
                System.Console.WriteLine("Digite um numero:");
                int.TryParse(Console.ReadLine(), out  num2);

                 resultado= num1-num2;

                System.Console.WriteLine($"{num1}-{num2}={resultado}");
                break;

                case 3:
                System.Console.WriteLine("Digite um numero:");
                int.TryParse(Console.ReadLine(), out  num1);
                
                System.Console.WriteLine("Digite um numero:");
                int.TryParse(Console.ReadLine(), out  num2);

                 resultado= num1*num2;

                System.Console.WriteLine($"{num1}*{num2}={resultado}");
                break;

                case 4:
                System.Console.WriteLine("Digite um numero:");
                int.TryParse(Console.ReadLine(), out  num1);
                
                System.Console.WriteLine("Digite um numero:");
                int.TryParse(Console.ReadLine(), out  num2);

                 resultado= num1/num2;

                System.Console.WriteLine($"{num1}/{num2}={resultado}");
                break;

                default:
                System.Console.WriteLine("Opção invalida!");
                break;
            }


        }
    }
}
 