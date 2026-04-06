namespace ParOuImpar {
    class Program {
        static void Main(string[] args) {
            int numero;

            do {
                Console.WriteLine("Digite um número: ");
            } while(!int.TryParse(Console.ReadLine(), out numero));

            if(numero % 2 == 0) {
                Console.WriteLine("Par");
            }
            else {
                Console.WriteLine("Impar");
            }
        }
    }
}