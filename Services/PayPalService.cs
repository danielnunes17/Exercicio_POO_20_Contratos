namespace Exercicio_POO_20_Contratos.Services
{
    public class PayPalService : IOnLinePaymentService
    {
        private const double FeePercentage = 0.02;
        private const double MounthlyInterest = 0.01;
        public double Interest(double amount, int months)
        {
            return amount * MounthlyInterest * months;
        }

        public double PaymentFee(double amount)
        {
            return amount * FeePercentage;
        }
    }
}
