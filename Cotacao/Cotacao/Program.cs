using System.Globalization;

namespace Cotacao {
    class Program {
        static void Main(string[] args) {
            double cotacaoDolar, valor;

            do {
                Console.Write("Qual é a cotação do dólar (entre com números maiores que zero)? ");
            } while(!double.TryParse(Console.ReadLine(),CultureInfo.InvariantCulture,out cotacaoDolar) || cotacaoDolar <= 0.00);

            do {
                Console.Write("Quantos dólares você vai comprar (entre com números maiores que zero)? ");
            } while(!double.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out valor) || valor <= 0.00);

            double conversao = ConversorMoeda.ConversaoDolar(cotacaoDolar, valor);

            Console.WriteLine($"Valor a ser pago = R${conversao.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}