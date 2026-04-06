using System.Globalization;

namespace MediaPonderada {
    class Program {
        static void Main(string[] args) {
            string[] valores;
            double valor1, valor2, valor3, resultado;
            int countnum;

            do {
                Console.Write("Quantos cálculos você quer realizar?: ");
            }
            while(!int.TryParse(Console.ReadLine(), out countnum) || countnum <= 0);            

            for(int i = 1;i <= countnum;i++) {
                Console.WriteLine("\nDigite 3 valores separados por espaço: ");
                valores = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                valor1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
                valor2 = double.Parse(valores[1], CultureInfo.InvariantCulture);
                valor3 = double.Parse(valores[2], CultureInfo.InvariantCulture);

                resultado = ((valor1 * 2) + (valor2 * 3) + (valor3 * 5)) / (2 + 3 + 5);

                Console.WriteLine($"{resultado.ToString("F1", CultureInfo.InvariantCulture)}");
            }           
        }
    }
}