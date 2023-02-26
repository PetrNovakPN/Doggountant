using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doggountant.Data
{
    internal class MoneyStatsModel
    {
        public decimal totalValue { get; set; }

        public decimal incomeValue { get; set; }

        public decimal expenseValue { get; set; }


        public MoneyStatsModel()
        {
            totalValue = 0.00m;
            incomeValue = 0.00m;
            expenseValue = 0.00m;
        }
    }
}
