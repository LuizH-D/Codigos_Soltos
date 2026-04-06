using System.Globalization;

namespace Divisao {
    class Program {
        static void Main(string[] args) {
            double valor1, valor2, resultado = 0; int count;

            do {
                Console.Write("Digite quantos casos quer calcular: ");
            }
            while(!int.TryParse(Console.ReadLine(),out count) || count <= 0);

            for(int i = 1;i <= count;i++) {                
                    Console.Write("Digite 2 valores separados por espaço: ");
                    string[] valores = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                    valor1 = double.Parse(valores[0],CultureInfo.InvariantCulture);
                    valor2 = double.Parse(valores[1],CultureInfo.InvariantCulture);

                if(valor2 == 0){
                    Console.WriteLine("Divisão impossível");
                }
                else{
                    resultado = valor1 / valor2;
                    Console.WriteLine($"{resultado.ToString("F1",CultureInfo.InvariantCulture)}");
                }               
            }
        }
    }
}