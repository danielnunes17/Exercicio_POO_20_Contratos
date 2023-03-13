namespace Exercicio_POO_20_Contratos.Services
{
    public interface IOnLinePaymentService
    {
        public double PaymentFee(double amount);
        public double Interest(double amount, int months);
    }
}
