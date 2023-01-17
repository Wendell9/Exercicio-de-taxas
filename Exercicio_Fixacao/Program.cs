using Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services;
using System.Globalization;

namespace Exercicio_Fixacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number,months;
            DateTime date;
            double ContractV;

            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            number = int.Parse(Console.ReadLine());
            Console.Write("Date(dd/MM/yyyy): ");
            date = DateTime.Parse(Console.ReadLine());
            Console.Write("Contract value: ");
            ContractV = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Enter the number of installments: ");
            months = int.Parse(Console.ReadLine());

            Contract contract = new Contract(number, date, ContractV);
            Process_Contract process = new Process_Contract();
            process.DefineInstallments(contract, months);

            Console.WriteLine("Installments:");
            foreach (Installment item in contract.Installments)
            {
                Console.WriteLine($"{item.Date.ToShortDateString()} - {item.Amount.ToString("F2",CultureInfo.InvariantCulture)}");
            }
        }
    }
}
