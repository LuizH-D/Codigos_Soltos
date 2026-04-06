namespace QuadradoECubo {
    class Program {
        static void Main(string[] args) {
            int linhas;

            do {
                Console.Write("Digite quantas linhas você quer (maior que zero): ");
            }
            while(!int.TryParse(Console.ReadLine(),out linhas) || linhas <= 0);

            for(int i = 1;i <= linhas;i++) {
                Console.WriteLine($"{i} {Math.Pow(i, 2)} {Math.Pow(i, 3)}");
            }
        }
    }
}