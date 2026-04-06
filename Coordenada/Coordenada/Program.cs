namespace Coordenada {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite duas coordenadas separadas por espaço: ");
            string[] coordenadas = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int coordx = int.Parse(coordenadas[0]);
            int coordy = int.Parse(coordenadas[1]);

            while(coordx != 0 && coordy != 0) {

                if(coordx > 0 && coordy > 0) {
                    Console.WriteLine("Primeiro");
                }
                else if(coordx < 0 && coordy > 0) {
                    Console.WriteLine("Segundo");
                }
                else if(coordx < 0 && coordy < 0) {
                    Console.WriteLine("Terceiro");
                }
                else {
                    Console.WriteLine("Quarto");
                }

                Console.Write("\nDigite duas coordenadas separadas por espaço: ");
                coordenadas = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                coordx = int.Parse(coordenadas[0]);
                coordy = int.Parse(coordenadas[1]);
            }

            Console.WriteLine("");
        }
    }
}