using System;
using System.Collections.Generic;

namespace PaymentTracking
{
    public class CostLog
    {
        private List<Cost> _costs;

        public CostLog()
        {
            _costs = new List<Cost>();
        }

        public void AddCost(Cost cost)
        {
            _costs.Add(cost);
        }

        public void RemoveCost(Cost cost)
        {
            _costs.Remove(cost);
        }

        public List<Cost> GetCosts()
        {
            return _costs;
        }
    }
}

/*This class CostLog represents a collection of Cost objects. 
It has a private List member _costs to store the costs. 
It has three methods: AddCost (which adds a Cost to the log), 
RemoveCost (which removes a Cost from the log), and GetCosts (which returns a List of all the Costs in the log).
Contact me: linkedin.com/farukkara or farukkara100@protonmail.ch */