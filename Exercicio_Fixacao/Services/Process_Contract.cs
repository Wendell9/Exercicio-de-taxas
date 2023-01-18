using Entities;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    internal class Process_Contract
    {
        public Process_Contract()
        {
        }

        public void DefineInstallments(Contract contract,int months)
        {
            double installments;
            double amount;
            for (int i = 1; i <= months; i++)
            {
                installments = (contract.totalValue / months);
                IOnlinePaymentService Service = new PaypalService();
                double updateQuota = installments + Service.InterestFee(installments, i);
                double fullQuota = updateQuota + Service.PaymentFee(updateQuota);

                contract.Installments.Add(new Installment(contract.DateTime.AddMonths(i), fullQuota));
            }
        }
    }
}
