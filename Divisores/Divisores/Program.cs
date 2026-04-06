namespace Divisores {
    class Program {
        static void Main(string[] args) {
            int numero;

            do {
                Console.Write("Digite um número (maior que zero) para obter seus divisores: ");
            }
            while(!int.TryParse(Console.ReadLine(),out numero) || numero <= 0);

            Console.WriteLine($"\nOs divisores são: ");

            for(int i = 1;i <= numero;i++) {                
                if(numero % i == 0) {
                    Console.WriteLine($"{i}");                   
                }                
            }
        }
    }
}