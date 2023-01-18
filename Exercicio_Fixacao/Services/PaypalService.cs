using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    internal class PaypalService : IOnlinePaymentService
    {
        public PaypalService()
        {
        }

        public double PaymentFee(double amount)
        {
            return amount * 0.02;
        }
        public double InterestFee(double amount, int months)
        {
            return amount * months * 0.01;
        }
    }
}
