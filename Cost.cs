using System;

namespace PaymentTracking
{
    public class Cost
    {
        public int CostId { get; set; }
        public DateTime CostDate { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }

        public Cost(int costId, DateTime costDate, decimal amount, string description)
        {
            CostId = costId;
            CostDate = costDate;
            Amount = amount;
            Description = description;
        }
    }
}

/* This class Cost represents a single cost incurred by the business.
It has four properties: CostId (a unique identifier for the cost), 
CostDate (the date and time the cost was incurred), Amount (the amount of the cost), 
and Description (a description of what the cost was for). 
The class also has a constructor that takes in values for each of these properties, 
allowing you to create new Cost objects easily.
Contact me: linkedin.com/farukkara or farukkara100@protonmail.ch */