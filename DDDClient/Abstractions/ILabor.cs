namespace DDDClient.Abstractions
{
    internal interface ILabor : IPayInfo
    {
        int Id { get; }
        string Description { get; set; }
    }
}