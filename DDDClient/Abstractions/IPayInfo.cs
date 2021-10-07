namespace DDDClient.Abstractions
{
    internal interface IPayInfo
    {
        bool IsPaid { get; set; }
        decimal Price { get; set; }
    }
}