namespace PreferenciaProdutos {
    class Program {
        static void Main(string[] args) {
            int alcool = 0, gasolina = 0, diesel = 0, produto = 0;

            Console.WriteLine("Escolha um produto: 1.Álcool 2.Gasolina 3.Diesel 4.Fim");
            
            while(true) {
                bool numeroValidacao = int.TryParse(Console.ReadLine(),out produto);

                if(!numeroValidacao || produto <= 0) {
                    Console.WriteLine("\nProduto inválido! Escolha um produto: 1.Álcool 2.Gasolina 3.Diesel 4.Fim");                    
                }
                else if(produto == 1) {
                    alcool++;
                    Console.WriteLine("\nEscolha um produto: 1.Álcool 2.Gasolina 3.Diesel 4.Fim");                    
                }
                else if(produto == 2) {
                    gasolina++;
                    Console.WriteLine("\nEscolha um produto: 1.Álcool 2.Gasolina 3.Diesel 4.Fim");                   
                }
                else if(produto == 3) {
                    diesel++;
                    Console.WriteLine("\nEscolha um produto: 1.Álcool 2.Gasolina 3.Diesel 4.Fim");                    
                }
                else if(produto == 4) {
                    Console.WriteLine($"\nMUITO OBRIGADO! \nÁlcool: {alcool}\nGasolina: {gasolina}\nDiesel: {diesel}");
                    break;
                }
            }
        }
    }
}