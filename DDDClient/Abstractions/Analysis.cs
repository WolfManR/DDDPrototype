namespace DDDClient.Abstractions
{
    internal abstract record Analysis(int Id, string LaborType) : IAnalysis
    {
        public string Description { get; set; }
        public bool IsPaid { get; set; }
        public decimal Price { get; set; }
    }
}