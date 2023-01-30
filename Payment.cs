using System;

namespace PaymentTracking
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; }

        public Payment(int paymentId, DateTime paymentDate, decimal amount, string paymentMethod)
        {
            PaymentId = paymentId;
            PaymentDate = paymentDate;
            Amount = amount;
            PaymentMethod = paymentMethod;
        }
    }
}

/*
This class Payment represents a single payment made by 
a customer. It has four properties:
PaymentId (a unique identifier for the payment), 
PaymentDate (the date and time the payment was made),
Amount (the amount of the payment), and PaymentMethod 
(the method the payment was made, such as "credit card" or "cash"). 
The class also has a constructor that takes in values for each of these properties,
allowing you to create new Payment objects easily. - Contact me: linkedin.com/farukkara or farukkara100@protonmail.ch */