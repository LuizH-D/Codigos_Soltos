namespace NumerosNoIntervalo {
    class Program {
        static void Main(string[] args) {
            int numero, numcount, dentro = 0, fora = 0;

            do {
                Console.Write("Quantos números você quer digitar?: ");
            }
            while(!int.TryParse(Console.ReadLine(), out numcount) || numcount <= 0);

            for(int i = 1;i <= numcount;i++) {
                do {
                    Console.Write("Digite um número: ");
                } while(!int.TryParse(Console.ReadLine(),out numero));

                if(numero >= 10 && numero <= 20) {
                    dentro++;
                }
                else {
                    fora++;
                }
            }

            Console.WriteLine($"Dentro: {dentro}\nFora: {fora}");
        }
    }
}