using System.Globalization;

namespace MediaSalarial {
    class Program {
        static void Main(string[] args) {
            Funcionario funcionario1, funcionario2; double media; bool salarioValido;

            // Entrada de dados do primeiro funcionário
            funcionario1 = new Funcionario();
            Console.WriteLine("Digite os dados da primeira pessoa:");

            // Nome do primeiro funcionário
            do {
                Console.Write("Nome: ");
                funcionario1.Nome = Console.ReadLine();

                if(string.IsNullOrWhiteSpace(funcionario1.Nome) || funcionario1.Nome.Any(char.IsDigit)) {
                    Console.WriteLine("\nO nome é obrigatório e não pode estar vazio e nem conter números!");
                }
            } while(string.IsNullOrWhiteSpace(funcionario1.Nome) || funcionario1.Nome.Any(char.IsDigit));

            // Salário do primeiro funcionário
            do {
                Console.Write("Salário: ");
                salarioValido = double.TryParse(Console.ReadLine(),CultureInfo.InvariantCulture,out funcionario1.Salario);

                if(!salarioValido || funcionario1.Salario <= 0) {
                    Console.WriteLine("\nDigite apenas um valor numérico acima de zero!");
                }
            } while(!salarioValido || funcionario1.Salario <= 0);

            // Entrada de dados do segundo funcionário
            funcionario2 = new Funcionario();
            Console.WriteLine("\nDigite os dados da Segunda pessoa:");

            // Nome do segundo funcionário
            do {
                Console.Write("Nome: ");
                funcionario2.Nome = Console.ReadLine();

                if(string.IsNullOrWhiteSpace(funcionario2.Nome) || funcionario2.Nome.Any(char.IsDigit)) {
                    Console.WriteLine("\nO nome é obrigatório e não pode estar vazio e nem conter números!");
                }
            } while(string.IsNullOrWhiteSpace(funcionario2.Nome) || funcionario2.Nome.Any(char.IsDigit));

            // Salário do segundo funcionário
            do {
                Console.Write("Salário: ");
                salarioValido = double.TryParse(Console.ReadLine(),CultureInfo.InvariantCulture,out funcionario2.Salario);

                if(!salarioValido || funcionario2.Salario <= 0) {
                    Console.WriteLine("\nDigite apenas um valor numérico acima de zero!");
                }
            } while(!salarioValido || funcionario2.Salario <= 0);

            media = (funcionario1.Salario + funcionario2.Salario) / 2;
            Console.Write($"Salário Médio: {media.ToString("F2",CultureInfo.InvariantCulture)}");
        }
    }
}