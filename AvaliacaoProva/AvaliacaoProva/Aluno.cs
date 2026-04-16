using System.Globalization;

namespace AvaliacaoProva {
    internal class Aluno {
        public string Nome;
        public double[] Nota = new double[3];

        private double NotaFinal() {           
            return Nota[0] + Nota[1] + Nota[2];
        }       

        public override string ToString() {
             if(NotaFinal() >= 60.00) {
                return "NOTA FINAL = "
                    + NotaFinal().ToString("F2",CultureInfo.InvariantCulture)
                    + "\nAPROVADO";
            }
            else {
                return "NOTA FINAL = "
                    + NotaFinal().ToString("F2",CultureInfo.InvariantCulture)
                    + "\nREPROVADO"
                    + "\nFALTARAM " + (60.00 - NotaFinal()).ToString("F2", CultureInfo.InvariantCulture) + " PONTOS";
            }
        }
    }
}
