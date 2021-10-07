using System;

namespace DDDClient.Abstractions
{
    internal abstract record Analysis(int Id, string LaborType) : IAnalysis
    {
        public string Description { get; set; }
        public DateTime PaymentDate { get; private set; }
        public bool IsPaid { get; private set; }
        public decimal Price { get; set; }

        public (bool, decimal) Pay(decimal price)
        {
            if (Price > price) return (false, price);

            var change = price - Price;
            PaymentDate = DateTime.Now;
            return (IsPaid = true, change);
        }
    }
}