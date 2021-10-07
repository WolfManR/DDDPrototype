namespace DDDClient.Abstractions
{
    internal abstract record Analysis(int Id, string Description, decimal Price, Patient Patient) : IAnalysis, IPayInfo
    {
        public string Description { get; set; } = Description;
        public bool IsPaid { get; set; }
        public decimal Price { get; set; } = Price;
    }
}