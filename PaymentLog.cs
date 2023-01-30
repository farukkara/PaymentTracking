using System;
using System.Collections.Generic;

namespace PaymentTracking
{
    public class PaymentLog
    {
        private List<Payment> _payments;

        public PaymentLog()
        {
            _payments = new List<Payment>();
        }

        public void AddPayment(Payment payment)
        {
            _payments.Add(payment);
        }

        public void RemovePayment(Payment payment)
        {
            _payments.Remove(payment);
        }

        public List<Payment> GetPayments()
        {
            return _payments;
        }
    }
}

/*This class PaymentLog represents a collection of Payment objects. 
It has a private List member _payments to store the payments. 
It has three methods: AddPayment (which adds a Payment to the log), 
RemovePayment (which removes a Payment from the log), and GetPayments (which returns a List of all the Payments in the log).
Contact me: linkedin.com/farukkara or farukkara100@protonmail.ch */