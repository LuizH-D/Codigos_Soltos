namespace Cotacao {
    internal static class ConversorMoeda {
        public static double Iof = 0.06;

        public static double ConversaoDolar(double cotacaoDolar,double valor) {
            return (valor + valor * Iof) * cotacaoDolar;
        }
    }
}
