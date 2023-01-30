using System;
using System.Collections.Generic;

class Payment
{
    public DateTime Date { get; set; }
    public decimal Amount { get; set; }
    public string Name { get; set; }

    public override string ToString()
    {
        return ${Date.ToString(yyyy-MM-dd)} - {Name} ${Amount};
    }
}

class Cost
{
    public DateTime Date { get; set; }
    public decimal Amount { get; set; }
    public string Name { get; set; }

    public override string ToString()
    {
        return ${Date.ToString(yyyy-MM-dd)} - {Name} ${Amount};
    }
}

class PaymentLog
{
    private ListPayment payments;

    public PaymentLog()
    {
        payments = new ListPayment();
    }

    public void AddPayment(Payment payment)
    {
        payments.Add(payment);
    }

    public ListPayment GetPayments()
    {
        return payments;
    }

    public void PrintPayments()
    {
        Console.WriteLine(Payments);
        foreach (Payment payment in payments)
        {
            Console.WriteLine(payment);
        }
        Console.WriteLine();
    }
}

class CostLog
{
    private ListCost costs;

    public CostLog()
    {
        costs = new ListCost();
    }

    public void AddCost(Cost cost)
    {
        costs.Add(cost);
    }

    public ListCost GetCosts()
    {
        return costs;
    }

    public void PrintCosts()
    {
        Console.WriteLine(Costs);
        foreach (Cost cost in costs)
        {
            Console.WriteLine(cost);
        }
        Console.WriteLine();
    }
}

class ProductStock
{
    public DateTime Date { get; set; }
    public string Name { get; set; }
    public decimal Stock { get; set; }

    public override string ToString()
    {
        return ${Date.ToString(yyyy-MM-dd)} - {Name} {Stock};
    }
}

class Program
{
    static ListProductStock CalculateStock(PaymentLog paymentLog, CostLog costLog)
    {
        DictionaryDateTime, decimal paymentDates = new DictionaryDateTime, decimal();
        foreach (Payment payment in paymentLog.GetPayments())
        {
            paymentDates[payment.Date] = payment.Amount;
        }

        DictionaryDateTime, decimal costDates = new DictionaryDateTime, decimal();
        foreach (Cost cost in costLog.GetCosts())
        {
            costDates[cost.Date] = cost.Amount;
        }

        HashSetDateTime allDates = new HashSetDateTime(paymentDates.Keys);
        allDates.UnionWith(costDates.Keys);

/*Contact me: linkedin.com/farukkara or farukkara100@protonmail.ch */