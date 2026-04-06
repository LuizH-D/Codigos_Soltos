namespace Fatorial {
    class Program {
        static void Main(string[] args) {
            int valor; int resultado = 1;

            do {
                Console.Write("Escoha um número maior ou igual a zero: ");
            }
            while(!int.TryParse(Console.ReadLine(), out valor) || valor < 0);

            for(int i = 1;i <= valor;i++) {
                resultado *= i;              
            }

            Console.WriteLine($"O fatorial de {valor} é: {resultado}");
        }
    }
}