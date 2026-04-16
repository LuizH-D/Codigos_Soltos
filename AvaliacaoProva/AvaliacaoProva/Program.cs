using System.Globalization;

namespace AvaliacaoProva {
    class Program {
        static void Main(string[] args) {
            Aluno aluno = new Aluno();

            do {
                Console.Write("Digite o nome do aluno: ");
                aluno.Nome = Console.ReadLine();

                if(String.IsNullOrWhiteSpace(aluno.Nome) || aluno.Nome.Any(char.IsDigit)){
                    Console.WriteLine("\nO nome do aluno é obrigatório e não pode conter números!");
                }
            } while(String.IsNullOrWhiteSpace(aluno.Nome) || aluno.Nome.Any(char.IsDigit));

            Console.WriteLine("Digite as três notas do aluno: ");

            //Primeira nota
            do {                 
                aluno.Nota[0] = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                if(aluno.Nota[0] < 0.00 || aluno.Nota[0] > 30.00) {
                    Console.WriteLine("A primeira nota deve ser maior ou igual a zero e menor ou igual a 30.Digite novamente: ");
                }
            } while(aluno.Nota[0] < 0.00 || aluno.Nota[0] > 30.00);

            //Segunda e terceira notas
            for(int i = 1;i <= 2;i++) {
                do {
                    aluno.Nota[i] = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    if(aluno.Nota[i] < 0.00 || aluno.Nota[i] > 35.00) {
                        Console.WriteLine("A segunda e a terceira notas devem ser maiores ou iguais a zero e menores ou iguais a 35.Digite novamente:");
                    }
                } while(aluno.Nota[i] < 0.00 || aluno.Nota[i] > 35.00);
            }            

            Console.WriteLine(aluno);
        }                 
    }
}