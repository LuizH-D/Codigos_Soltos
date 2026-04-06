namespace NumerosImpares {
    class Program {
        static void Main(string[] args) {
            int numero;

            do {
                Console.Write("Escolha um número entre 1 e 1000: ");                
            } while(!int.TryParse(Console.ReadLine(), out numero) || numero < 1 || numero > 1000);

            for(int i = 1;i <= numero;i += 2) {
                Console.WriteLine(i);
            }
        }
    }
}