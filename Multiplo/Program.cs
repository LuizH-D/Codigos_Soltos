namespace Multiplo {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite dois números separados por espaço: ");
            string[] numeros = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int numero1 = int.Parse(numeros[0]);
            int numero2 = int.Parse(numeros[1]);

            if (numero2 == 0) {
                Console.WriteLine("Não é possível realizar divisão por zero");
            }
            else {
                Console.WriteLine(numero1 % numero2 == 0 ? "São múltiplos" : "Não são múltiplos");
            }
        }
    }
}