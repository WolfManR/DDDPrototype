using System;

namespace DDDClient.Abstractions
{
    internal interface IPayInfo
    {
        DateTime PaymentDate { get; }
        bool IsPaid { get; }
        decimal Price { get; }
    }
}