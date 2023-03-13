using Exercicio_POO_20_Contratos.Entities;
using Exercicio_POO_20_Contratos.Services;
using System.Globalization;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter contract data: ");
        Console.Write("Number: ");
        int contractNumber = int.Parse(Console.ReadLine());
        Console.Write("Date (dd/MM/yyyy): ");
        DateTime contractDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
        Console.Write("Contract value: ");
        double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Enter number of installments: ");
        int numberctInstallments = int.Parse(Console.ReadLine());

        Contract myContract = new Contract(contractNumber, contractDate, contractValue);
        ContractService contractService = new ContractService(new PayPalService());
        contractService.ProcessContract(myContract, numberctInstallments);

        Console.WriteLine("Installments: ");
        foreach (Installment installment in myContract.Installments)
        {
            Console.WriteLine(installment);
        }
    }
}