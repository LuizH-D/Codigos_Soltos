namespace NegativoOuPositivo {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero < 0) {
                Console.WriteLine("Negativo");
            }
            else {
                Console.WriteLine("Não Negativo");
            }
        }
    }
}