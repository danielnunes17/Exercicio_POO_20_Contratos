using Exercicio_POO_20_Contratos.Entities;
using System.Security.Cryptography;

namespace Exercicio_POO_20_Contratos.Services
{
    public class ContractService
    {
        private IOnLinePaymentService _onLinePaymentService;
        public ContractService(IOnLinePaymentService onLinePaymentService)
        {
            _onLinePaymentService = onLinePaymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double basicQuota = contract.TotalValue / months;
            for (int i = 1; i <= months; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double upDateQuota = basicQuota + _onLinePaymentService.Interest(basicQuota, i);
                double fullQuota = upDateQuota + _onLinePaymentService.PaymentFee(upDateQuota);
                contract.AddInstalments(new Installment(date, fullQuota));
            }
        }
    }
}
